using Azihub.AppConsole.Base.Exceptions;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Azihub.SingleSignOn.Domain.Exceptions.Interceptors
{
    /// <summary>
    /// A base interceptor that handles all server-side exceptions.
    /// </summary>
    public class ServerExceptionsInterceptorBase : Interceptor
    {
        public ServerExceptionsInterceptorBase()
        {

        }

        /// <summary>
        /// Allows implementors to intercept exceptions, optionally re-exposing them as <see cref="RpcException"/>.
        /// </summary>
        /// <returns><c>true</c> if the exception should be re-exposed as an <see cref="RpcException"/>, <c>false</c> otherwise</returns>
        protected virtual bool OnException(Exception exception, out Status status)
        {
            status = default;
            return false;
        }

        /// <inheritdoc/>
        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
        {
            try
            {
                return await base.UnaryServerHandler(request, context, continuation).ConfigureAwait(false);
            }
            catch (Exception ex) when (OnException(ex, out var status))
            {
                throw new RpcException(status);
            }
        }
    }

    /// <summary>
    /// Indicates that a service or method should use simplified exception handling - which means that all server exceptions are treated as <see cref="RpcException"/>; this
    /// will expose the <see cref="Exception.Message"/> to the caller (and the type may be interpreted as a <see cref="StatusCode"/> when possible), which should only be
    /// done with caution as this may present security implications. Additional exception metadata (<see cref="Exception.Data"/>, <see cref="Exception.InnerException"/>,
    /// <see cref="Exception.StackTrace"/>, etc) is not propagated. The exception is still exposed at the client as an <see cref="RpcException"/>.
    /// </summary>
    public class SsoRpcExceptionsInterceptor : ServerExceptionsInterceptorBase
    {
        private SsoRpcExceptionsInterceptor() { }
        private static SsoRpcExceptionsInterceptor? _sInstance;

        /// <summary>
        /// Provides a shared instance of this interceptor
        /// </summary>
        public static SsoRpcExceptionsInterceptor Instance => _sInstance ??= new SsoRpcExceptionsInterceptor();

        private static bool ShouldWrap(Exception exception, out Status status)
        {
            var messages = "";
            var debugException = (((RpcException)exception).Status.DebugException);

            // Check DebugException in exception
            if ((IException)debugException != null)
            {
                var exceptionType = ((IException)(debugException)).TypeException;
                switch (exceptionType)
                {
                    case TypeException.BusinessLogic:

                        //Get errors property in exception
                        var result = ((BusinessLogicException)(debugException)).Errors;

                        // Add errors to businessErrors list
                        var businessErrors = result.Select(item => new RpcError(item.LocaleConst, item.Code, TypeException.BusinessLogic.ToString())).ToList();

                        // Serialize businessErrors
                        messages = Newtonsoft.Json.JsonConvert.SerializeObject(businessErrors);

                        break;
                    case TypeException.Security:

                        //Get DebugException in exception
                        var securityResult = (SecurityException)(debugException);

                        // Serialize securityError
                        messages = SerializeErrorMessage(securityResult.LocaleConst, securityResult.Code, TypeException.Security.ToString());

                        break;
                    case TypeException.ApplicationFailure:

                        //Get DebugException in exception
                        var applicationFailureResult = ((ApplicationFailureException)(debugException));

                        // Serialize applicationFailureError
                        messages = SerializeErrorMessage(applicationFailureResult.LocaleConst, applicationFailureResult.Code, TypeException.ApplicationFailure.ToString());

                        break;
                    case TypeException.Super:

                        //Get DebugException in exception
                        var superResult = ((SuperException)(debugException));

                        // Serialize superError
                        messages = SerializeErrorMessage(superResult.LocaleConst, superResult.Code, TypeException.Super.ToString());
                        break;

                    default:
                        break;
                }

            }

            // Initialize status
            status = new Status(
             StatusCode.Internal
             , messages, exception);

            return true;
        }

        /// <inheritdoc/>
        protected override bool OnException(Exception exception, out Status status)
            => ShouldWrap(exception, out status);

        private static string SerializeErrorMessage(string localeConst, int code, string typeException)
        {
            // Get superError
            var superError = new RpcError(localeConst, code, typeException);

            // Return serialize errorMessage
            return Newtonsoft.Json.JsonConvert.SerializeObject(superError);
        }
    }

    /// <summary>
    /// This class is used for deserialize RpcException.
    /// </summary>
    public class RpcError
    {
        public RpcError(string message, int code, string exceptionType)
        {
            LocaleConst = message;
            Code = code;
            ExceptionType = exceptionType;
        }

        public string LocaleConst { get; private set; }
        public int Code { get; private set; }
        public string ExceptionType { get; private set; }
    }

}

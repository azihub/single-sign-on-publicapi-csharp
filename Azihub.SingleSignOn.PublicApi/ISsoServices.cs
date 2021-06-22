using ProtoBuf.Grpc.Configuration;
using Azihub.SingleSignOn.PublicApi.Validations.EditEmail;
using Azihub.SingleSignOn.PublicApi.Validations.SendSms;
using Azihub.SingleSignOn.PublicApi.Validations.SignUp;
using Azihub.SingleSignOn.PublicApi.Validations.VerifyEmail;
using Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Azihub.SingleSignOn.PublicApi
{
    [ServiceContract(Name = "SsoServices")]

    public interface ISsoServices
    {
        [OperationContract]
        [SimpleRpcExceptions]
        Task<SignUpFormResponse> SignUp(SignUpFormRequest signUpFormRequest);

        [OperationContract]
        [SimpleRpcExceptions]
        Task<EditEmailResponse> EditEmail(EditEmailRequest editEmailRequest);

        [OperationContract]
        [SimpleRpcExceptions]
        Task<VerifyEmailResponse> VerifyEmail(VerifyEmailRequest verifyEmailRequest);

        [OperationContract]
        [SimpleRpcExceptions]
        Task<SendSmsResponse> SendSms(SendSmsRequest sendSmsRequest);

        [OperationContract]
        [SimpleRpcExceptions]
        Task<VerifyMobileOtpResponse> VerifyMobile(VerifyMobileOtpRequest verifyMobileOtpRequest);
    }
}
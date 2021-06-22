using ProtoBuf.Grpc.Configuration;
using Azihub.SingleSignOn.Domain.Validations.EditEmail;
using Azihub.SingleSignOn.Domain.Validations.SendSms;
using Azihub.SingleSignOn.Domain.Validations.SignUp;
using Azihub.SingleSignOn.Domain.Validations.VerifyEmail;
using Azihub.SingleSignOn.Domain.Validations.VerifyMobileOtp;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Azihub.SingleSignOn.Domain
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
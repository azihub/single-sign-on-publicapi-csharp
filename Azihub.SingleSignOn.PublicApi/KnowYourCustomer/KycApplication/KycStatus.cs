namespace Azihub.SingleSignOn.PublicApi.KnowYourCustomer.KycApplication
{
    public enum KycStatus
    {
        /// <summary>
        /// User submit and is waiting for approval
        /// </summary>
        PendingApproval,

        /// <summary>
        /// User submitted but decided to cancel and try a different type before decision
        /// </summary>
        Withdrawn,

        /// <summary>
        /// Bad Document, asked user to make a new application and submit again because document is unverifiable
        /// </summary>
        ReturnedToCustomer,

        /// <summary>
        /// User submitted fake document (belong to someone else or altered photos)
        /// </summary>
        Forged,

        /// <summary>
        /// Authenticity is correct but user is rejected service due AML or sanction laws
        /// </summary>
        Sanctioned,

        /// <summary>
        /// Valid KYC application is approved
        /// </summary>
        Approved
    }
}
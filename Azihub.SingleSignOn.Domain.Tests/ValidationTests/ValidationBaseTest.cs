using Azihub.AppConsole.Base.Exceptions;
using System.Collections.Generic;

namespace Azihub.SingleSignOn.Domain.Tests.ValidationTests
{
    public class ValidationBaseTest
    {
        protected List<BusinessLogicException> SignUpFormErrors;
        public ValidationBaseTest()
        {
            SignUpFormErrors = new List<BusinessLogicException>();
        }
    }
}

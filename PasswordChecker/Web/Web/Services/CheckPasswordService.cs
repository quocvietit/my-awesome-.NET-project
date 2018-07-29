using Web.Services.Interface;
using Web.Models;

namespace Web.Services
{
    public class CheckPasswordService : ICheckPasswordService
    {
        private ICheckTopPasswordService _checkTopPasswordService;
        private ICheckLengthPasswordService _checkLengthPasswordService;

        public CheckPasswordService(ICheckTopPasswordService checkTopPasswordService,
        ICheckLengthPasswordService checkLengthPasswordService)
        {
            _checkTopPasswordService = checkTopPasswordService;
            _checkLengthPasswordService = checkLengthPasswordService;
        }

        public string GetResultCheckTopPassword(string password)
        {
            return _checkTopPasswordService.CheckTopPasswords(password);
        }

        public string GetResultCheckLengthPassword(string password)
        {
            return _checkLengthPasswordService.CheckLengthPassword(password);
        }

        public string GetResultCheckComplexityPassword(string password)
        {

            return _checkLengthPasswordService.CheckLengthPassword(password);
        }
    }
}

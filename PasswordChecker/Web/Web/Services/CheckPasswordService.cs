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

        public MessageModel GetResultCheckTopPassword(string password)
        {
            return _checkTopPasswordService.CheckTopPasswords(password);
        }

        public MessageModel GetResultCheckLengthPassword(string password)
        {
            return _checkLengthPasswordService.CheckLengthPassword(password);
        }

    }
}

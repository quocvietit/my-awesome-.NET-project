using Web.Models;

namespace Web.Services.Interface
{
    public interface ICheckPasswordService
    {
        MessageModel GetResultCheckTopPassword(string password);
        MessageModel GetResultCheckLengthPassword(string password);
    }
}

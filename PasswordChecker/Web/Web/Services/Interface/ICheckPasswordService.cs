using Web.Models;

namespace Web.Services.Interface
{
    public interface ICheckPasswordService
    {
        string GetResultCheckTopPassword(string password);
        string GetResultCheckLengthPassword(string password);
    }
}

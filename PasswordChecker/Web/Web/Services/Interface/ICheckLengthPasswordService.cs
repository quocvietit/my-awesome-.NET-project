using Web.Models;

namespace Web.Services.Interface
{
    public interface ICheckLengthPasswordService
    {
        string CheckLengthPassword(string password);
        string GetMessage(int lengthPassword);
    }
}

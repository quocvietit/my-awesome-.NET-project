using Web.Models;

namespace Web.Services.Interface
{
    public interface ICheckLengthPasswordService
    {
        MessageModel CheckLengthPassword(string password);

        string GetMessage(int lengthPassword);
    }
}

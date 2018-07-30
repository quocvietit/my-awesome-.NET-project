using Web.Models;
using Web.Services.Interface;
using Web.Utils;

namespace Web.Services
{
    public class CheckLengthPasswordService : ICheckLengthPasswordService
    {
        public CheckLengthPasswordService()
        {
        }

        public string CheckLengthPassword(string password)
        {
            int lengthPassword = password.Length;
            string message = this.GetMessage(lengthPassword);

            return message;
        }

        public string GetMessage(int lengthPassword)
        {
            string message = "";
            if (lengthPassword <= Contants.Length.Number.VERY_SHORT)
            {
                message = Contants.Length.Title.VERY_SHORT;
            }
            else if (lengthPassword <= Contants.Length.Number.SHORT)
            {
                message = Contants.Length.Title.SHORT;
            }
            else if (lengthPassword <= Contants.Length.Number.MEDIUM)
            {
                message = Contants.Length.Title.MEDIUM;
            }
            else if (lengthPassword <= Contants.Length.Number.LONG)
            {
                message = Contants.Length.Title.LONG;
            }
            else
            {
                message = Contants.Length.Title.TOO_LONG;
            }

            return string.Format(Contants.Message.Result.LENGTH_PASSWORD, lengthPassword, message);
        }
    }
}

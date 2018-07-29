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
            if (lengthPassword <= Contants.Length.Number.VERY_SHORT)
            {
                return Contants.Length.Title.VERY_SHORT;
            }
            else if (lengthPassword <= Contants.Length.Number.SHORT)
            {
                return Contants.Length.Title.SHORT;
            }
            else if (lengthPassword <= Contants.Length.Number.MEDIUM)
            {
                return Contants.Length.Title.MEDIUM;
            }
            else if (lengthPassword <= Contants.Length.Number.LONG)
            {
                return Contants.Length.Title.LONG;
            }
            else
            {
                return Contants.Length.Title.TOO_LONG;
            }
        }
    }
}

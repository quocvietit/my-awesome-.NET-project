using Web.Models;
using Web.Services.Interface;
using Web.Utils;

namespace Web.Services
{
    public class CheckLengthPasswordService : ICheckLengthPasswordService
    {
        public MessageModel _messageModel;

        public CheckLengthPasswordService()
        {
            _messageModel = new MessageModel();
            _messageModel.Title = "Đánh giá độ dài mật khẩu: ";
            _messageModel.Message = "";
            _messageModel.Show = true;
        }

        public MessageModel CheckLengthPassword(string password)
        {
            int lengthPassword = password.Length;
            _messageModel.Message = this.GetMessage(lengthPassword);

            return _messageModel;
        }

        public string GetMessage(int lengthPassword)
        {
            if (lengthPassword <= Constants.Length.Number.VERY_SHORT)
            {
                return Constants.Length.Title.VERY_SHORT;
            }
            else if (lengthPassword <= Constants.Length.Number.SHORT)
            {
                return Constants.Length.Title.SHORT;
            }
            else if (lengthPassword <= Constants.Length.Number.MEDIUM)
            {
                return Constants.Length.Title.MEDIUM;
            }
            else if (lengthPassword <= Constants.Length.Number.LONG)
            {
                return Constants.Length.Title.LONG;
            }
            else
            {
                return Constants.Length.Title.TOO_LONG;
            }
        }
    }
}

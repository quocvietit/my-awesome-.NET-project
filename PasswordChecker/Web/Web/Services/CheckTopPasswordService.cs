using System;
using System.Collections.Generic;
using System.Linq;
using Web.Services.Interface;
using Web.Utils.Interface;
using Web.Models;

namespace Web.Services
{
    public class CheckTopPasswordService : ICheckTopPasswordService
    {
        public IReadFile _readFile;
        public IValidate _validate;

        public List<string> _passwords;
        public MessageModel _messageModel;

        public CheckTopPasswordService(IReadFile readFile, IValidate validate)
        {
            _readFile = readFile;
            _validate = validate;

            _passwords = this.GetTopPasswords();

            _messageModel = new MessageModel();
            _messageModel.Title = "Mật khẩu của bạn thường được sử dụng. Nó sẽ bị bẻ khoá gần như ngay lập tức";
            _messageModel.Message = "";
            _messageModel.Show = false;
        }

        public List<String> GetTopPasswords()
        {
            return _readFile.ReadTopPasswordFile().ToList();
        }

        public MessageModel CheckTopPasswords(string password)
        {
            bool isTopPassword = this.Check(password);
            if (isTopPassword)
            {
                int topNumber = this.GetTopNumber(password);

                _messageModel.Message = "Mật khẩu thuộc top " + topNumber + " được sử dụng hàng đầu trên thế giới!";
                _messageModel.Show = true;
            }
            else
            {
                _messageModel.Show = false;
            }
            return _messageModel;
        }

        public bool Check(string password)
        {
            if (_passwords.Contains(password))
            {
                return true;
            }
            return false;
        }

        public int GetTopNumber(string password)
        {
            int topNumber = 0;
            topNumber = _passwords.IndexOf(password);

            return _validate.ValidateTopLevel(topNumber);
        }
    }
}

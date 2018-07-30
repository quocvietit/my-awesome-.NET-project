using System;
using System.Collections.Generic;
using System.Linq;
using Web.Services.Interface;
using Web.Utils;
using Web.Utils.Interface;

namespace Web.Services
{
    public class CheckTopPasswordService : ICheckTopPasswordService
    {
        public IReadFile _readFile;
        public IValidate _validate;

        public List<string> _passwords;

        public CheckTopPasswordService(IReadFile readFile, IValidate validate)
        {
            _readFile = readFile;
            _validate = validate;

            _passwords = this.GetTopPasswords();
        }

        public List<String> GetTopPasswords()
        {
            return _readFile.ReadTopPasswordFile().ToList();
        }

        public string CheckTopPasswords(string password)
        {
            bool isTopPassword = this.Check(password);
            string message = null;

            if (isTopPassword)
            {
                int topNumber = this.GetTopNumber(password);
                message = String.Format(Contants.Message.Result.TOP_PASSWORD, topNumber);
            }
            return message;
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

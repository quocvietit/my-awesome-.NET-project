using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public class CheckTopPassword
    {
        public HashSet<String> GetTopPasswords()
        {
            HashSet<String> topPasswords = new HashSet<string>();
            topPasswords.Add("123456");
            return topPasswords;
        }

        public bool Check(string password)
        {
            HashSet<string> passwords = GetTopPasswords();
            if (passwords.Contains(password))
            {
                return true;
            }
            return false;
        }
    }
}

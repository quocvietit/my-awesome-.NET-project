using System;
using System.Collections.Generic;
using System.IO;
using Web.Utils.Interface;

namespace Web.Utils
{
    public class ReadFile : IReadFile
    {
        public ReadFile() { }

        public HashSet<string> ReadTopPasswordFile()
        {
            HashSet<string> passwords = new HashSet<string>();
            try
            {
                string xpath = ".\\..\\Web\\Resources\\TopPasswords.txt";
                using (StreamReader sr = new StreamReader(xpath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        passwords.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Read File Error");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            return passwords;
        }
    }
}

using Web.Models;
using Web.Services.Interface;
using Web.Utils;
using System.Text.RegularExpressions;
using System;

namespace Web.Services
{
    public class AnalysisPasswordService : IAnalysisPasswordService
    {
        public PasswordDetailModel _passwordDetailModel;

        public AnalysisPasswordService()
        {
            _passwordDetailModel = new PasswordDetailModel();
        }

        public string BruteForceSearchSpace()
        {
            TimeModel timeModel = new TimeModel();
            ulong space = 1;
            ulong time = 0;

            int len = _passwordDetailModel.Length;
            int spaceDepth = _passwordDetailModel.SpaceDeth;


            for (int i = 1; i <= len; i++)
            {
                space *= (ulong)spaceDepth;
                time = space / Contants.BILLON;
                timeModel.SetTime(time);
            }

             string message = timeModel.Year + "y - " + timeModel.Month + "m - " + timeModel.Day + "d - " + timeModel.Hour + "h - " + timeModel.Minute + "m - " + timeModel.Second + "s";

            return message;
        }

        public void AnalysisSpaceDethPassword(string password)
        {
            _passwordDetailModel.Password = password;
            _passwordDetailModel.Length = this.SearchSpaceLength(password);

            _passwordDetailModel.UpperCase = this.SearchSpaceDepth(_passwordDetailModel.Password, Contants.Alphabet.Regular.UPPER_CASE);
            _passwordDetailModel.LowerCase = this.SearchSpaceDepth(_passwordDetailModel.Password, Contants.Alphabet.Regular.LOWER_CASE);
            _passwordDetailModel.Digit = this.SearchSpaceDepth(_passwordDetailModel.Password, Contants.Alphabet.Regular.DIGIT);
            _passwordDetailModel.Symbol = this.SearchSpaceDepth(_passwordDetailModel.Password, Contants.Alphabet.Regular.SYMBOL);

            _passwordDetailModel.SetSpaceDeth();
        }

        public int SearchSpaceDepth(string text, string pattern)
        {
            Regex re = new Regex(pattern);
            MatchCollection result = re.Matches(text);
            return result.Count;
        }

        public int SearchSpaceLength(string password)
        {
            return password.Length;
        }
    }
}

using Web.Models;
using Web.Services.Interface;
using Web.Utils;
using System.Text.RegularExpressions;

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

            string message = string.Format(Contants.Message.Result.TIME, timeModel.GetTime());

            return message;
        }

        public string LevelPassword()
        {
            int choose = _passwordDetailModel.SpaceDeth;
            string message = Contants.Message.Level.VERY_WEAK;

            switch (choose)
            {
                case Contants.Alphabet.LevelSpace.ONE:
                    message = Contants.Message.Level.VERY_WEAK;
                    break;
                case Contants.Alphabet.LevelSpace.THREE:
                    message = Contants.Message.Level.WEAK;
                    break;
                case Contants.Alphabet.LevelSpace.FOUR:
                    message = Contants.Message.Level.VERY_WEAK;
                    break;
                case Contants.Alphabet.LevelSpace.FIVE:
                    message = Contants.Message.Level.WEAK;
                    break;
                case Contants.Alphabet.LevelSpace.SEVEN:
                    message = Contants.Message.Level.MEDIUM;
                    break;
                case Contants.Alphabet.LevelSpace.EIGHT:
                    message = Contants.Message.Level.VERY_WEAK;
                    break;
                case Contants.Alphabet.LevelSpace.NINE:
                    message = Contants.Message.Level.WEAK;
                    break;
                case Contants.Alphabet.LevelSpace.ELEVEN:
                    message = Contants.Message.Level.MEDIUM;
                    break;
                case Contants.Alphabet.LevelSpace.TWELVE:
                    message = Contants.Message.Level.WEAK;
                    break;
                case Contants.Alphabet.LevelSpace.FIFTEEN:
                    message = Contants.Message.Level.STRONG;
                    break;
                default:
                    break;
            }

            if (_passwordDetailModel.Length <= 6)
            {
                message = Contants.Message.Level.VERY_WEAK;
            }

            if (_passwordDetailModel.Length >= 10 && message.Equals(Contants.Message.Level.STRONG))
            {
                message = message = Contants.Message.Level.VERY_STRONG;
            }

            return message;
        }

        public string ComplexityPassword()
        {
            string complexity = "";
            bool check = false;
            if (_passwordDetailModel.UpperCase > 0)
            {
                if (check)
                {
                    complexity += " - ";
                }
                complexity += Contants.Message.Complexity.UPPER_CASE;
                check = true;
            }

            if (_passwordDetailModel.LowerCase > 0)
            {
                if (check)
                {
                    complexity += " - ";
                }
                complexity += Contants.Message.Complexity.LOWER_CASE;
                check = true;
            }

            if (_passwordDetailModel.Digit > 0)
            {
                if (check)
                {
                    complexity += " - ";
                }
                complexity += Contants.Message.Complexity.DIGIT;
                check = true;
            }

            if (_passwordDetailModel.Symbol > 0)
            {
                if (check)
                {
                    complexity += " - ";
                }
                complexity += Contants.Message.Complexity.SYMBOL;
                check = true;
            }

            string message = string.Format(Contants.Message.Result.COMPLEXITY, complexity);

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

        public RecommendModel CreateRecommend()
        {
            RecommendModel recommendModel = new RecommendModel();

            recommendModel.AllCase = _passwordDetailModel.UpperCase + _passwordDetailModel.LowerCase == 0 ? Contants.Message.Recommend.ALL_CASE : null;
            recommendModel.Digit = _passwordDetailModel.Digit == 0 ? Contants.Message.Recommend.DIGIT : null;
            recommendModel.UpperCase = _passwordDetailModel.UpperCase == 0 ? Contants.Message.Recommend.UPPER_CASE : null;
            recommendModel.LowerCase = _passwordDetailModel.LowerCase == 0 ? Contants.Message.Recommend.LOWER_CASE : null;
            recommendModel.Symbol = _passwordDetailModel.Symbol == 0 ? Contants.Message.Recommend.SYMBOL : null;
            recommendModel.Length = _passwordDetailModel.Length < Contants.Length.Number.SHORT ? Contants.Message.Recommend.LENGTH : null;

            if (_passwordDetailModel.Length <= Contants.Length.Number.SHORT ||
                _passwordDetailModel.UpperCase == 0 ||
                _passwordDetailModel.LowerCase == 0 ||
                _passwordDetailModel.Digit == 0 ||
                _passwordDetailModel.Symbol == 0)
            {
                recommendModel.Title = Contants.Message.Recommend.TITLE;
            }

            if (this.LevelPassword().Equals(Contants.Message.Level.VERY_STRONG))
            {
                recommendModel = new RecommendModel();
            }

            return recommendModel;
        }
    }
}

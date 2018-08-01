using Web.Services.Interface;
using Web.Models;
using Web.Utils;

namespace Web.Services
{
    public class CheckPasswordService : ICheckPasswordService
    {
        private ICheckTopPasswordService _checkTopPasswordService;
        private ICheckLengthPasswordService _checkLengthPasswordService;
        private IAnalysisPasswordService _analysisPasswordService;

        public CheckPasswordService(ICheckTopPasswordService checkTopPasswordService,
        ICheckLengthPasswordService checkLengthPasswordService,
        IAnalysisPasswordService analysisPasswordService)
        {
            _checkTopPasswordService = checkTopPasswordService;
            _checkLengthPasswordService = checkLengthPasswordService;
            _analysisPasswordService = analysisPasswordService;
        }

        public ResultModel GetResult(string password)
        {
            this.CreatePasswordModelToAnalysis(password);

            ResultModel result = new ResultModel();
            result.Level = _analysisPasswordService.LevelPassword();
            result.Message = this.GetResultCheckTopPassword(password);
            result.Length = this.GetResultCheckLengthPassword(password);
            result.Complexity = _analysisPasswordService.ComplexityPassword();
            result.Time = _analysisPasswordService.BruteForceSearchSpace();

            if(result.Message != null)
            {
                result.Level = Contants.Message.Level.VERY_WEAK;

            }

            result.LevelColor = this.GetLevelColor(result.Level);
            return result;
        }

        public RecommendModel GetRecommend()
        {
            return _analysisPasswordService.CreateRecommend();
        }

        public void CreatePasswordModelToAnalysis(string password)
        {
            _analysisPasswordService.AnalysisSpaceDethPassword(password);
        }

        public string GetResultCheckTopPassword(string password)
        {
            return _checkTopPasswordService.CheckTopPasswords(password);
        }

        public string GetResultCheckLengthPassword(string password)
        {
            return _checkLengthPasswordService.CheckLengthPassword(password);
        }

        public string GetLevelColor(string level)
        {
            if (level.Equals(Contants.Message.Level.VERY_WEAK))
            {
                return Contants.Message.Color.VERY_WEAK;
            }
            else if (level.Equals(Contants.Message.Level.WEAK))
            {
                return Contants.Message.Color.WEAK;
            }
            else if (level.Equals(Contants.Message.Level.MEDIUM))
            {
                return Contants.Message.Color.MEDIUM;
            }
            else if (level.Equals(Contants.Message.Level.STRONG))
            {
                return Contants.Message.Color.STRONG;
            }
            else
            {
                return Contants.Message.Color.VERY_STRONG;
            }
        }
    }
}

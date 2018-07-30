using Web.Models;

namespace Web.Services.Interface
{
    public interface ICheckPasswordService
    {
        ResultModel GetResult(string password);
        RecommendModel GetRecommend();
        void CreatePasswordModelToAnalysis(string password);
        string GetResultCheckTopPassword(string password);
        string GetResultCheckLengthPassword(string password);
        string GetLevelColor(string level);
    }
}

using Web.Models;

namespace Web.Services.Interface
{
    public interface IAnalysisPasswordService
    {
        string BruteForceSearchSpace();
        string LevelPassword();
        string ComplexityPassword();
        void AnalysisSpaceDethPassword(string password);
        int SearchSpaceDepth(string text, string pattern);
        int SearchSpaceLength(string password);
        RecommendModel CreateRecommend();
    }
}

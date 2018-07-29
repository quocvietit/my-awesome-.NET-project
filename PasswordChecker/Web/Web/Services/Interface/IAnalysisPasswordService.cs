using Web.Models;

namespace Web.Services.Interface
{
    public interface IAnalysisPasswordService
    {
        string BruteForceSearchSpace();
        void AnalysisSpaceDethPassword(string password);
        int SearchSpaceDepth(string text, string pattern);
        int SearchSpaceLength(string password);
    }
}

using Web.Models;

namespace Web.Services.Interface
{
    public interface IAnalysisPasswordService
    {
        MessageModel BruteForceSearchSpace(string password);
        int SearchSpaceDepth(string password);
        int SearchSpaceLength(string password);
    }
}

using Web.Models;
using Web.Services.Interface;
using System;

namespace Web.Services
{
    public class AnalysisPasswordService : IAnalysisPasswordService
    {
        public MessageModel _messageModel;

        public AnalysisPasswordService() {
            _messageModel = new MessageModel();
         }

        public MessageModel BruteForceSearchSpace(string password)
        {
            TimeModel timeModel = new TimeModel();

            int len = this.SearchSpaceLength(password);
            ulong time = 0;
            ulong tmp = 1;
            ulong spaceDepth = 26;

            for(int i=0; i<len; i++)
            {
                time = (ulong) Math.Pow(spaceDepth, tmp);
                timeModel.SetTime(time);
                tmp++;
            }

            _messageModel.Message = timeModel.Hour + "h" + timeModel.Minute + "p";

            return _messageModel;
        }

        public int SearchSpaceDepth(string password)
        {
            return 0;
        }

        public int SearchSpaceLength(string password)
        {
            return password.Length;
        }
    }
}

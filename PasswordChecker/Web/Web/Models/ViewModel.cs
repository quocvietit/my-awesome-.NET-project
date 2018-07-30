using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class ViewModel
    {
        public PasswordModel PasswordModel { get; set; }
        public ResultModel ResultModel { get; set; }
        public RecommendModel RecommendModel { get; set; }

        public ViewModel()
        {
            this.PasswordModel = new PasswordModel();
            this.ResultModel = new ResultModel();
            this.RecommendModel = new RecommendModel();
        }
    }
}

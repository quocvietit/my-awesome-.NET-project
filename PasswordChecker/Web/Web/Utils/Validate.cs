using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Utils.Interface;

namespace Web.Utils
{
    public class Validate: IValidate
    {
        public Validate() { }

        public int ValidateTopLevel(int topNumber)
        {
            return (topNumber / 5 + 1) * 5;
        }
    }
}

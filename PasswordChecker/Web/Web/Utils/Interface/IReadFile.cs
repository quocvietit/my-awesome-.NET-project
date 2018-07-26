using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Utils.Interface
{
    public interface IReadFile
    {
        HashSet<string> ReadTopPasswordFile();
    }
}

using System.Collections.Generic;

namespace Web.Utils.Interface
{
    public interface IReadFile
    {
        HashSet<string> ReadTopPasswordFile();
    }
}

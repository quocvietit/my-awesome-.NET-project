using Web.Utils.Interface;
using Web.Models;

namespace Web.Utils
{
    public class Validate : IValidate
    {
        public Validate() { }

        public int ValidateTopLevel(int topNumber)
        {
            return (topNumber / 5 + 1) * 5;
        }


    }
}

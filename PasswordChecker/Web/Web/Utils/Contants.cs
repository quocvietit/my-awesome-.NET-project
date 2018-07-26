using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Utils
{
    public static class Constants
    {
        public static class Length
        {
            public static class Number
            {
                public const int VERY_SHORT = 6;
                public const int SHORT = 8;
                public const int MEDIUM = 15;
                public const int LONG = 20;
                public const int TOO_LONG = 30;
            }

            public static class Title
            {
                public const string VERY_SHORT = "Quá ngắn!";
                public const string SHORT = "Ngắn!";
                public const string MEDIUM = "Trung bình!";
                public const string LONG = "Dài!";
                public const string TOO_LONG = "Quá dài!";
            }
           
        }

    }
}

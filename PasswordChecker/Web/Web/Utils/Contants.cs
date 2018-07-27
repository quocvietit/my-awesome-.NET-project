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

        public static class Date
        {
            public static class Second
            {
                public const int SECOND = 1;
                public const int MINUTE = 60;
                public const int HOUR = 3600;
                public const int DAY = 86400;
                public const int MONTH = 2592000;
                public const int YEAR = 31536000;
            }

        }

        public static class Alphabet
        {
            public static class SpaceDeth
            {
                public const int LOWER_CASE = 26;
                public const int UPPER_CASE = 26;
                public const int DIGIT = 10;
                public const int SYMBOL = 33;
            }

            public static class Level
            {
                public const int LOWER_CASE = 1;
                public const int UPPER_CASE = 2;
                public const int DIGIT = 4;
                public const int SYMBOL = 8;
            }

            public static class LevelNumber
            {
                public const int LOWER_CASE = 1;
                public const int UPPER_CASE = 2;
                public const int UPPER_CASE_AND_LOWER_CASE = 3;
                public const int DIGIT = 4;
                public const int DIGIT_AND_LOWER_CASE = 5;
                public const int DIGIT_AND_UPPER_CASE = 6;
                public const int DIGIT_AND_ALL_CASE = 7;
                public const int SYMBOL = 8;
                public const int SYMBOL_AND_LOWER_CASE = 9;
                public const int SYMBOL_AND_UPPER_CASE = 10;
                public const int SYMBOL_AND_ALL_CASE = 11;
                public const int SYMBOL_AND_DIGIT = 12;
                public const int SYMBOL_AND_DIGIT_AND_LOWER_CASE = 13;
                public const int SYMBOL_AND_DIGIT_AND_UPPER_CASE = 14;
                public const int SYMBOL_AND_DIGIT_AND_ALL_CASE = 15;
            }

            public static class LevelSpace
            {
                public const int ONE = 26;
                public const int TWO = 26;
                public const int THREE = 52;
                public const int FOUR = 10;
                public const int FIVE = 36;
                public const int SIX = 36;
                public const int SEVEN = 62;
                public const int EIGHT = 33;
                public const int NINE = 59;
                public const int TEN = 59;
                public const int ELEVEN = 85;
                public const int TWELVE = 43;
                public const int THIRTEEN = 59;
                public const int FOURTEEN = 59;
                public const int FIFTEEN = 95;
            }

        }
    }
}

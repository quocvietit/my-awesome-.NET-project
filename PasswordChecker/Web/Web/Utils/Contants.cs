namespace Web.Utils
{
    public static class Contants
    {
        public const ulong BILLON = 10000000000;

        public static class Title
        {
            public const string HOME = "Kiểm tra mật khẩu";
            public const string ABOUT = "Giới thiệu";
            public const string TERM = "Điều khoản";
            public const string CONTRACT = "Liên hệ";
        }

        public static class Message
        {
            public static class Result
            {
                public const string TOP_PASSWORD = "Mật khẩu thuộc top {0} được sử dụng hàng đầu trên thế giới!";
                public const string LENGTH_PASSWORD = "Độ dài: {0} ký tự - {1}";
                public const string COMPLEXITY = "Độ phức tạp: {0}";
                public const string TIME = "Thời gian bẻ khóa: {0}";
                public const string ERROR = "Có lỗi xảy ra. Vui lòng liên hệ admin để biết thêm chi tiết!";
            }

            public static class Recommend
            {
                public const string TITLE = "Gợi ý tạo mật khẩu an toàn hơn:";
                public const string DIGIT = "- Thêm chữ số vào mật khẩu.";
                public const string ALL_CASE = "- Thêm chữ vào mật khẩu.";
                public const string LOWER_CASE = "- Thay một vài chữ thường thành chữ hoa.";
                public const string UPPER_CASE = "- Thay một vài chữ hoa thành chữ thường.";
                public const string SYMBOL = "- Thêm ký tự đặc biệt như:@?\\()[]{}-|...";
                public const string LENGTH = "- Tăng độ dài mật khẩu.";
            }

            public static class Level
            {
                public const string VERY_WEAK = "RẤT YẾU";
                public const string WEAK = "YẾU";
                public const string MEDIUM = "TRUNG BÌNH";
                public const string STRONG = "MẠNH";
                public const string VERY_STRONG = "RẤT MẠNH";
            }

            public static class Color
            {
                public const string VERY_WEAK = "#FF0000" ;
                public const string WEAK = "#990000";
                public const string MEDIUM = "#00EE00";
                public const string STRONG = "#00AA00";
                public const string VERY_STRONG = "#008800";
            }

            public static class Complexity
            {
                public const string UPPER_CASE = "Chữ hoa";
                public const string LOWER_CASE = "Chữ thường";
                public const string DIGIT = "Số";
                public const string SYMBOL = "Các ký tự đặc biệt";
            }
        }
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

            public const int SECOND = 1;
            public const int MINUTE = 60;
            public const int HOUR = 60;
            public const int DAY = 24;
            public const int MONTH = 30;
            public const int YEAR = 12;

            public static class Message
            {
                public const string INSTANTLY = "Ngay lập tức (Nhỏ hơn 1 giây)!";
                public const string SECOND = "~ {0} giây.";
                public const string MINUTE = "~ {0} phút.";
                public const string HOUR = "~ {0} giờ.";
                public const string DAY = "~ {0} ngày.";
                public const string MONTH = "~ {0} tháng.";
                public const string YEAR = "~ {0:N0} năm.";
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

            public static class Regular
            {
                public const string UPPER_CASE = "[A-Z]";
                public const string LOWER_CASE = "[a-z]";
                public const string DIGIT = "[0-9]";
                public const string SYMBOL = "[!\"#$%&'()*+,-\\.\\/:;<=>?@[\\]^`{|}~_]";
            }
        }
    }
}

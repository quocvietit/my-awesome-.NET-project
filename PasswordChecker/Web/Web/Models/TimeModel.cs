using Web.Utils;

namespace Web.Models
{
    public class TimeModel
    {

        public ulong Year { get; set; }
        public ulong Month { get; set; }
        public ulong Day { get; set; }
        public ulong Hour { get; set; }
        public ulong Minute { get; set; }
        public ulong Second { get; set; }

        public TimeModel() { }

        public void SetTime(ulong second)
        {
            this.Year = second / Constants.Date.Second.YEAR;
            second = second % Constants.Date.Second.YEAR;

            this.Month = second / Constants.Date.Second.MONTH;
            second = second % Constants.Date.Second.MONTH;

            this.Day = second / Constants.Date.Second.DAY;
            second = second % Constants.Date.Second.DAY;

            this.Hour = second / Constants.Date.Second.HOUR;
            second = second % Constants.Date.Second.HOUR;

            this.Minute = second / Constants.Date.Second.MINUTE;
            second = second % Constants.Date.Second.MINUTE;

            this.Second = second / Constants.Date.Second.SECOND;
            second = second % Constants.Date.Second.SECOND;
        }
    }
}

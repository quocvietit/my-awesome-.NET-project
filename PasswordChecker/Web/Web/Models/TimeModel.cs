using System;
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

        public TimeModel() {
            this.Year = 0;
            this.Month = 0;
            this.Day = 0;
            this.Hour = 0;
            this.Minute = 0;
            this.Second = 0;
        }

        public void SetTime(ulong second)
        {
            ulong tmp = second + this.Second;
            this.Second = tmp % Contants.Date.MINUTE;

            tmp = tmp / Contants.Date.MINUTE + this.Minute;
            this.Minute = tmp % Contants.Date.HOUR;

            tmp = tmp / Contants.Date.HOUR + this.Hour;
            this.Hour = tmp % Contants.Date.DAY;

            tmp = tmp / Contants.Date.DAY + this.Day;
            this.Day = tmp % Contants.Date.MONTH;

            tmp = tmp / Contants.Date.MONTH + this.Month;
            this.Month = tmp % Contants.Date.YEAR;

            tmp = tmp / Contants.Date.YEAR + this.Year;
            this.Year += tmp;
        }
    }
}

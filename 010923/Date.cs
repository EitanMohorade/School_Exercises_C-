using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _010923
{
    public class Date
    {
        private int day;
        private int month;
        private int year;
        public int Day { get{return day;} set{day = value;} }
        public int Month { get{return month;} set{month = value;} }
        public int Year { get{return year;} set{year = value;} }

        public Date(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
            this.year = year;
        }
    }
}
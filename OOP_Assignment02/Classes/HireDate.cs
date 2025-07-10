using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_Assignment02.Classes
{
    #region Develop a Class to represent the Hiring Date Data: consisting of fields to hold the day, month and Years.

    internal class HireDate
    {
        private int day;
        private int month;
        private int year;
        DateTime CurrentYear = DateTime.Now;


        public HireDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
        public int Day
        {
            get
            {
                if (day >= 1 && day <= 31)
                {
                    return day;
                }
                return 0;
            }
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }
            }
        }
        public int Month
        {
            get
            {
                if (month >= 1 && month <= 12)
                {
                    return month;
                }
                return 0;
            }
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
            }
        }
        public int Year
        {
            get
            {
                if (year >= 1 && year <= int.Parse(CurrentYear.Year.ToString()))
                {
                    return year;
                }
                return 0000;
            }
            set
            {
                if (value >= 1 && value <= int.Parse(CurrentYear.Year.ToString()))
                {
                    year = value;
                }

            }
        }

        public override string ToString()
        {
            try
            {
                return $"{day:D2} {new DateTime(year, month, day):MMMM} {year}";
            }
            catch
            {
                return "Invalid Date";
            }
        }

    } 
    #endregion
}

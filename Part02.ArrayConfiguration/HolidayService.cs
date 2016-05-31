using System;
using System.Linq;

namespace Part02.ArrayConfiguration
{
    public class HolidayService
    {
        public DateTime[] Holidays { get; set; }

        public bool IsHoliday(DateTime date)
        {
            if (Holidays != null)
            {
                DateTime matchDate = date.Date;
                return Holidays.Any(test => test.Date.Equals(matchDate));
            }

            return false;
        }
    }
}

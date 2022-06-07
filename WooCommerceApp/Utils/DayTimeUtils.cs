using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooCommerceApp.Utils
{
    public static class DayTimeUtils
    {

        public static bool IsSunday(this DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Sunday;
        }
        public static bool IsSaturday(this DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday;
        }
    }
}

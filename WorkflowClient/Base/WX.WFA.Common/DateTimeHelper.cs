using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX.WFA.Common
{
    public static class DateTimeHelper
    {
      public static DateTime GetDateTime(decimal date, decimal time)
      {
        var dateInt = Convert.ToInt32(date);
        var timeInt = Convert.ToInt32(time);
        if (dateInt.ToString().Length != 8)
        {
          return new DateTime();
        }
        else if (timeInt.ToString().Length != 6)
        {
          new DateTime(dateInt / 10000, dateInt % 10000 / 100, dateInt % 100, 0, 0, 0);
        }

        return new DateTime(dateInt / 10000, dateInt % 10000 / 100, dateInt % 100, timeInt / 10000, timeInt % 10000 / 100, timeInt % 100);
      }
    }
}

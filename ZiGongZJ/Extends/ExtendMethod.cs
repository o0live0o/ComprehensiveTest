using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZiGongZJ.Extends
{
    public static class ExtendMethod
    {
        public static string ToCustomerDate(this string s, string type)
        {
            DateTime dateTime;
            if (DateTime.TryParse(s, out dateTime))
            {
                dateTime.ToString(type);
            }
            return s;
        }

        public static int ToInt(this string s)
        { 
            decimal d;
            if (null == s)
                return 0;
            if (decimal.TryParse(s, out d))
            {
                return Convert.ToInt32(d);
            }
            return 0;
        }

        public static string ChangePD(this string s)
        {
            if ("1".Equals(s))
            {
                s = "1";
            }
            else if ("2".Equals(s))
            {
                s = "2";
            }
            else if ("3".Equals(s))
            {
                s = "0";
            }
            else if ("10".Equals(s))
            {
                s = "7";
            }
            else if ("11".Equals(s))
            {
                s = "8";
            }
            return s;
        }
    }
}

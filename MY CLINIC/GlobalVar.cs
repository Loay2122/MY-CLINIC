using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_CLINIC
{
    internal class GlobalVar
    {
        public static bool b;
        public static string n="";
        public static System.DateTime moment = DateTime.Now;
        public static int year = moment.Year;
        public static int month = moment.Month;
        public static int day = moment.Day;
        public static int hour = int.Parse(moment.ToString("HH"));
        public static int minute = moment.Minute;
        public static int second = moment.Second;
    }
}

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
        public static int c = 1;
        public static System.DateTime moment = DateTime.Now;
        public static int year = moment.Year;
        public static int month = moment.Month;
        public static int day = moment.Day;
        public static int hour = int.Parse(moment.ToString("HH"));
        public static string Date= day.ToString()+"/"+month.ToString()+"/"+year.ToString();
        public static int Start = 0;
        public static int End = 0;
        public static string Generate_ID(string service)
        {
            string hol = "";
            hol = "" + c + "" + "" + day + "" + "" + month + "";
            string year1=year.ToString();
            year1= year1.Substring(2);
            c++;
            hol = hol + "" + year1 + "";
            hol = hol + DataBase.Get_ServID(service);
            return hol;
        }
        public static string Generate_Hours(int s,int e)
        {
            string fromto = "";
            int y = s + e;
            fromto = s.ToString()+":00-"+y.ToString()+":00";
            s = s + e;
            return fromto;
        }

    }
}

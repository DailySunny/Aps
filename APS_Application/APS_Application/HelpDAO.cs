using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_Application
{
    class HelpDAO
    {
        public static int week_next;
        public static int yearofnextweek;
        public static int week_now;
        public static int year;
        public static int week_last;
        public static void getYearandWeek()
        {
            //获取当年的年份
            year = DateTime.Now.Year;
            //获取该年第一个周日的日期
            DateTime dt = DateTime.Parse(year.ToString() + "/1/1");
            while (dt.DayOfWeek != DayOfWeek.Sunday)
            {
                dt = dt.AddDays(1);
            }
            Console.WriteLine(dt.ToString());
            //获取该年最后一周是第几周
            week_last = getWeek(year + "/12/31", dt.ToString());
            Console.WriteLine("最后一周：" + week_last);

            //先判断当前的日期是否是小于本年度第一个周日
            int day_now = DateTime.Now.DayOfYear;//获取当前日期是当年的第几天
            week_now = getWeek(DateTime.Now.ToString(), dt.ToString());//获取当前是第几周
            //int week_count=getWeek(year+"/12/31",dt.ToString());
            Console.WriteLine("本周是第" + week_now + "周");
            if (week_now == week_last)
            {
                week_next = 1;
                yearofnextweek = year + 1;
            }
            else
            {
                week_next = week_now + 1;
                yearofnextweek = year;
            }
            Console.WriteLine("week_now" + week_now);
            Console.WriteLine("week_last:" + week_next);
            Console.WriteLine("yearofnextyear" + yearofnextweek);

        }
        public static void getThisWeek(){
            //获取当年的年份
            year = DateTime.Now.Year;
            //获取该年第一个周日的日期
            DateTime dt = DateTime.Parse(year.ToString() + "/1/1");
            while (dt.DayOfWeek != DayOfWeek.Sunday)
            {
                dt = dt.AddDays(1);
            }
            Console.WriteLine(dt.ToString());
            //先判断当前的日期是否是小于本年度第一个周日
            int day_now = DateTime.Now.DayOfYear;//获取当前日期是当年的第几天
            week_now = getWeek(DateTime.Now.ToString(), dt.ToString());//获取当前是第几周
            Console.WriteLine("week_now" + week_now);
            Console.WriteLine("year:" + year);
        }
        public static int getWeek(string day, string firstDate)
        {

            int day_off = DateTime.Parse(day).DayOfYear - DateTime.Parse(firstDate).DayOfYear + 1;//和第一天相差多少天
            Console.WriteLine("和第一天相差" + day_off);
            int week = 0;
            if (day_off < 0)//比第一天还少
            {
                week = 0;
            }
            else
            {
                if (day_off == 0)//正好是第一天
                {
                    week = 1;
                }
                else
                {
                    if ((day_off % 7) == 0)
                    {
                        week = day_off / 7;
                    }
                    else
                    {
                        week = day_off / 7 + 1;
                    }
                    Console.WriteLine("week" + week);
                }
            }
            return week;
        }
    }
}

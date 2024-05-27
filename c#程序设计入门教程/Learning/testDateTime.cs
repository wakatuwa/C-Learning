using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class testDateTime
    {
        public void testDT()
        {
            DateTime dt1 = new DateTime(2024, 5, 25);
            DateTime dt2 = new DateTime(2024, 5, 25, 18, 30, 30);
            Console.WriteLine("dt1:" + dt1);
            Console.WriteLine("dt2:" + dt2);
            Console.ReadKey();
        }

        //timespan对象用于表示时间间隔
        public void testTimeSpan()
        {
            TimeSpan ts1 = new TimeSpan(1, 2, 3);
            Console.WriteLine("ts1的时间间隔为：" + ts1);
            TimeSpan ts2 = new TimeSpan(1, 2, 3, 4, 5);
            Console.WriteLine("ts2的时间间隔为：" + ts2);
            Console.ReadKey();
        }

        public void testDateTimeFunction()
        {
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(1, 0, 0);
            Console.WriteLine(dt);
            dt = dt.Add(ts);
            Console.WriteLine(dt);
            bool b = dt.Equals(DateTime.Now);


            string s  = dt.ToShortTimeString();
            Console.WriteLine(s);
            
        }
    }
}

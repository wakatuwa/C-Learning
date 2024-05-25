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
    }
}

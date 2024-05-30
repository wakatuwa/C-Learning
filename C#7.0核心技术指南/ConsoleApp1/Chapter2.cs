using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test2
    {
        public struct Point { public int x, y; }
        public void zhileixing()
        {
            Point p1 = new Point();
            p1.x = 7;
            Point p2 = p1;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

            p1.x = 9;
            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);
        }
        public class Pointz { public int x, y; }
        public void yinyongleixing()
        {
            Pointz p1 = new Pointz();
            p1.x = 7;
            Pointz p2 = p1;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

            p1.x = 9;
            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

        }
    }
}

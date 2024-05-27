using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class testRandom
    {
        //Random无参构造函数
        public void testRandom1()
        {
            Random rd = new Random();
            for(int i = 0; i < 10; i++)
            {
                int temp = rd.Next();
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }

        //Random有参构造函数
        public void testRandom2()
        {
            Random rd = new Random(10);
            for(int i=0; i<10; i++)
            {
                int temp = rd.Next();
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }

        public void testRandom3()
        {
            Random rd = new Random();
            int temp;
            temp = rd.Next();
            Console.WriteLine(temp);
            temp = rd.Next(10);
            Console.WriteLine(temp);
            temp = rd.Next(10, 20);
            Console.WriteLine(temp);
            double temp1 = rd.NextDouble();
            Console.WriteLine(temp1);
            Console.ReadKey(); 
        }
    }
}

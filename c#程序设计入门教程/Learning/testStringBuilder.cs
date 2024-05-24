using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class testStringBuilder
    {
        public void testSB()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("abcd");
            Console.WriteLine("追加字符串：" + sb.ToString());
            sb.Insert(3, "aaa");
            Console.WriteLine("插入字符：" + sb.ToString());
            sb.Remove(3, 3);
            Console.WriteLine("移除字符串: " + sb.ToString());
            sb.Replace("a", "b");
            Console.WriteLine("替换字符串：" + sb.ToString());
            Console.WriteLine("sb的长度是：" + sb.Length);
            Console.ReadKey();
        }
    }
}

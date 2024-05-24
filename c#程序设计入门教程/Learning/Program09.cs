using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Learning
{
    public class Program09
    {
        public void test09()
        {
            Console.WriteLine("请输入mp3文件名");
            string input = Console.ReadLine();//接受用户从控制台输入的字符串
            //EndsWith()方法的作用是判断当前字符串是否以指定字符串结尾
            if (input.EndsWith(".mp3"))
            {
                Console.WriteLine("文件格式正确");
            }
            else
            {
                Console.WriteLine("输入的文件不是MP3格式");
            }
            Console.WriteLine();
        }

        public void test10()
        {
            string str = "abbcdefefghefg";
            //查找第一个'e'字符的位置
            //IndexOf()方法用于返回指定字符或字符串在字符串中的索引
            int index = str.IndexOf('e');
            Console.WriteLine("找到e，索引为{0}", index);
            Console.ReadKey();
        }

        //Split()方法将专门用于分隔字符串
       public void test11()
        {
            string str = "I have a dream";
            //用空格来分隔字符串数组
            string[] strs = str.Split(' ');
            Console.WriteLine("一共有{0}个单词，分别是:", strs.Length);
            int index = 1;
            foreach(var item in strs)
            {
                Console.WriteLine("第{0}个单词是: {1}", index , item);
                index++;
            }
        }

        //Substring()方法的作用是对字符串进行截取，例如要获取文件的后缀名，可以使用Substring()方法
        public void test12()
        {
            string path = @"D:\itcast\chapter7\program12.cs";
            int index = path.IndexOf('.');
            string fileType = path.Substring(index + 1);
            Console.WriteLine("文件后缀名为：{0}", fileType);

            Console.ReadKey();
        }

        //ToCharArray()方法的作用是将字符串转换成一个字符串数组，
        public void test13()
        {
            string s = "abcdef";
            string s1 = ReverseString(s);
            Console.WriteLine(s1);
            Console.ReadKey();
        }
        //定义让字符串反转的方法
        public static string ReverseString(string str)
        {
            //将字符串转换成字符数组
            char[] chs = str.ToCharArray();
            for(int i = 0; i<chs.Length/2; i++)
            {
                char temp = chs[i];
                chs[i] = chs[chs.Length-1-i];
                chs[chs.Length - 1 - i] = temp;
             }
            return new string(chs);
        }

        //Trim()方法是去除字符串两端的空格，注意是两端
        public void test15()
        {
            string str = "  ab  cd  ";
            Console.WriteLine("|" + str + "|");
            str = str.Trim();
            Console.WriteLine("|" + str + "|");
            Console.ReadKey();
        }

    }
}

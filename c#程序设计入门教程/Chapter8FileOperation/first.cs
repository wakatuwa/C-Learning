using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chapter8FileOperation
{
    public class firstTest()
    {
        public void program01()
        {
            File.Create("Data.txt");
            Console.WriteLine("文件创建成功");
            if (File.Exists("Data.txt"))
            {
                Console.WriteLine("文件存在");
            }
            else
            {
                Console.WriteLine("文件不存在");
            }
            Console.ReadKey();
        }
        //FileInfo类
        public void program02()
        {
            FileInfo aFile = new FileInfo("Data.txt");
            aFile.Create();
            Console.WriteLine("文件创建成功");
            if(aFile.Exists)
            {
                Console.WriteLine("文件存在");
            }
            else
            {
                Console.WriteLine("文件不存在");
            }
            Console.WriteLine("文件当前目录为："+ aFile.Directory);
            Console.WriteLine("文件大小为：" + aFile.Length);
        }

        //Directory
        public void program03()
        {
            Directory.CreateDirectory(@"G:\itcast\chapter08\program03");
            if (Directory.Exists(@"G:\itcast\chapter08\program03"))
            {
                Console.WriteLine("文件存在");
            }
            else
            {
                Console.WriteLine("文件不存在");
            }
            //删除目录
            Directory.Delete(@"G:\itcast\chapter08\program03");
            Console.WriteLine("删除成功");
            if (Directory.Exists(@"G:\itcast\chapter08\program03"))
            {
                Console.WriteLine("文件存在");
            }
            else
            {
                Console.WriteLine("文件不存在");
            }
        }
        
        //DirectoryInfo
        public void program04()
        {
            string path = @"G:\itcast\chapter08\program04\bin\Debug\Test";

            DirectoryInfo di = new DirectoryInfo(path);
            di.Create();
            Console.WriteLine(di.Name);
            Console.WriteLine(di.Parent);
            Console.WriteLine(di.Root);
            string path1 = @"G:\itcast\chapter08\program04\bin\Debug";
            DirectoryInfo di1 = new DirectoryInfo(path1);

            FileInfo[] files1 = di1.GetFiles("*P*");
            foreach(var item in files1)
            {
                Console.WriteLine(item.Name);
            }
        }
        //FileStream
        public void program05()
        {
            byte[] byteData = new byte[1024];
            char[] charData = new char[1024];
            using(FileStream aFile = new FileStream("Data.txt", FileMode.Open))
            {
                aFile.Seek(0, SeekOrigin.Begin);
                aFile.Read(byteData, 0, 1024);
            }
            Decoder d = Encoding.Default.GetDecoder();
            d.GetChars(byteData, 0, byteData.Length, charData, 0);

            Console.WriteLine(charData);
            Console.ReadKey();
        }

        //
        public void program06()
        {
            byte[] byteData;
            char[] charData;
            try
            {
                using(FileStream aFile = new FileStream("Data.txt", FileMode.Create))
                {
                    charData = "Hello world by C#".ToCharArray(); 
                    byteData = new byte[charData.Length];
                    Encoder e = Encoding.Default.GetEncoder();
                    e.GetBytes(charData, 0, charData.Length, byteData, 0, true);
                    aFile.Seek(0, SeekOrigin.Begin );
                    aFile.Write(byteData, 0, byteData.Length);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("File Operation yi chang");
                Console.WriteLine(ex.ToString());
                return;

            }
        }

        //StreamWriter
        public void program08()
        {
            try
            {
                StreamWriter sw = new StreamWriter("Data.txt");
                sw.WriteLine("Change is Good!");
                sw.Close();
                Console.ReadKey();
            }
            catch(IOException ex)
            {
                Console.WriteLine("File Operation yi chang");
                Console.WriteLine(ex.ToString());
                return;
            }
        }

        //StreamWriter and StreamReader
        public void program11()
        {
            string temp;
            StreamWriter sw = new StreamWriter("Data.txt", true, Encoding.Default);
            sw.WriteLine("Today is Mat 29th");
            sw.Close();
            StreamReader sr = new StreamReader("Data.txt", Encoding.Default);
            while((temp = sr.ReadLine()) != null)
            {
                Console.WriteLine(temp);
            }
            sr.Close();
            sr.Dispose();
            sw.Dispose();
            Console.ReadKey();
        }

        public void porgram13()
        {
            int i;
            FileStream myStream1, myStream2;
            BufferedStream myBStream1, myBStream2;
            byte[] myByte = new byte[1024];

            Console.WriteLine("Before Read and Write");
            Print("Data2.txt");
            myStream1 = File.OpenRead("Data1.txt");
            myStream2 = File.OpenWrite("Data2.txt");
            myBStream1 = new BufferedStream(myStream1);
            myBStream2 = new BufferedStream(myStream2);

            i = myBStream1.Read(myByte, 0, 1024);
            while(i > 0)
            {
                myBStream2.Write(myByte, 0, i); 
                i = myStream1.Read(myByte, 0, 1024);
            }

            myBStream2.Flush();
            myStream1.Close();
            myStream2.Close();
            Console.WriteLine("After Read and Write");
            Print("Data2.txt");
            Console.ReadKey();
        }

        //output file 
        public static void Print(string path)
        {
            using(StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine("File{0}Content:{1}", path, content);
            }
        }

        //Serializable被弃用了，这里用jsonSerializer去进行序列化和反序列化
        public void program14()
        {
            Person person = new Person { Age = 30, Name = "John" };
            string jsonString = JsonSerializer.Serialize(person);
            File.WriteAllText("person.json", jsonString);

            string jsonString1 = File.ReadAllText("person.json");
            Person person1 = JsonSerializer.Deserialize<Person>(jsonString1);
            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
        }
        [Serializable]
        public class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
        }
    }
}

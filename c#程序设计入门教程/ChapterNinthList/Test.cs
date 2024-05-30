using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterNinthList
{
    public class Test
    {
        //ArrayList add element
        public void program01()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(134);
            arr1.AddRange(new ArrayList() { "zhangan", "lisi" });
            arr1.Insert(2, 'a');

            ErgoArr(arr1);

            Console.WriteLine("length: " + arr1.Count);
            Console.WriteLine("arr1的容量为:" + arr1.Capacity);

        }

        static void ErgoArr(ArrayList arr)
        {
            for(int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }

        //ArrayList delete element
        public void program02()
        {
            ArrayList arr1 = new ArrayList();

            arr1.AddRange(new ArrayList() { "zhangsan", "lisi", "wangwu" });
            ErgoArr(arr1);

            arr1.Remove("zhangsan");
            ErgoArr(arr1);

            arr1.RemoveAt(0);
            ErgoArr(arr1); ;

            arr1.Clear();
            Console.WriteLine("arrd1 length: " + arr1.Count);
        }

        // change ArrayList element
        public void program03()
        {
            ArrayList arr1 = new ArrayList(new ArrayList()
            {
                "zhangsan", "lisi", "wangwu"
            });
            Console.WriteLine("Before change");
            ErgoArr(arr1);
            arr1[0]= 1;
            arr1[1] = 2;
            arr1[2]= 3;
            Console.WriteLine();
            Console.WriteLine("After change");
            ErgoArr(arr1);
            Console.ReadKey();
        }

        //serach ArrayList element
        public void program04()
        {
            ArrayList arr1 = new ArrayList(new ArrayList() { 1, 2, 3, 1});
            ErgoArr(arr1);
            int index = arr1.IndexOf(1);
            Console.WriteLine("find the first one's index: " + index);
            int lastIndex = arr1.LastIndexOf(1);
            Console.WriteLine("find the last one's index: " + lastIndex);

            bool result = arr1.Contains(2);
            Console.WriteLine("if 2 in ArrayList: " + result);

            //sort 
            arr1.Sort();
            ErgoArr(arr1);
            
        }

        //hashtable
        public void program05()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "zhangsan");
            ht.Add(2, "lisi");
            ht.Add("BB", "wangwu");
            ErgoHash(ht);

            ht.Remove("BB");
            ErgoHash(ht);

            ht.Clear();
            Console.WriteLine("ht's length: " + ht.Count);
            Console.ReadKey();
        }
        static void ErgoHash(Hashtable ht)
        {
            foreach(object key in ht.Keys)
            {
                Console.Write(key + ":" + ht[key] + "\n");
            }
            Console.WriteLine();
        }

        public void program07()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "zhangsan");
            ht.Add(2, "lisi");
            ht.Add(3, "wangwu");

            foreach (var item in ht.Values)
            {
                Console.WriteLine("turn value: " + item);
            }

             Console.WriteLine();

            foreach(DictionaryEntry item in ht)
            {
                Console.Write(item.Key + ":" + item.Value + "\n");
            }
        }

        //List<T>
        public void program08()
        {
            List<string> list = new List<string>();

            list.Add("Apple");
            list.Add("Banana");
            list.Add("Orange");

            foreach (string item in list)
            {
                Console.WriteLine(item + "");
            }
            
        }

        //List<T> function
        public void program09()
        {
            List<int> list = new List<int>(new int[] { 1, 3, 5, 2, 4, 6 });
            ErgoList(list);

            int max = list.Max();
            Console.WriteLine("max value: " + max);

            int min = list.Min();
            Console.WriteLine("min value: " + min);

            int sum = list.Sum();
            Console.WriteLine("list sum: " + sum);


        }

        static void ErgoList(List<int> list)
        {
            foreach(int item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }

        //Dictionary<Tkey, TValue>
        public void program10()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1, "zhangsan");
            dic.Add(2, "lisi");
            dic.Add(3, "wangwu");

            foreach(int key in dic.Keys)
            {
                Console.WriteLine(key + ":" + dic[key]);
            }
            Console.WriteLine();
            dic.Remove(2);

            foreach(var kv in dic)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value);
            }
            Console.WriteLine();
        }

        //zi ding yi fan xing
        public void program11()
        {
            MyClass<string> myClass = new MyClass<string>();

            myClass.Add("zhangsan");
            Console.WriteLine("myclass's element: " + myClass.Get());
        }

        class MyClass<T>
        {
            T myElement;
            public void Add(T elem)
            {
                this.myElement = elem;
            }
            public T Get()
            {
                return this.myElement;
            }
        }
    }
}

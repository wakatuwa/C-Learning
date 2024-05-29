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
    }
}

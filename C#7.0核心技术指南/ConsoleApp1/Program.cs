namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(FeetToInches(30));
            //Console.WriteLine(FeetToInches(100));
            Test2 test2 = new Test2();
            //test2.zhileixing();
            test2.yinyongleixing();

        }
        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}

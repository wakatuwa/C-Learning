namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(30));
            Console.WriteLine(FeetToInches(100));
        }
        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}

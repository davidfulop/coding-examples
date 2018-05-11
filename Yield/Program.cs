using System;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in new MyEnumerable1())
            {
                System.Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

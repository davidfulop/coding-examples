using System;
using static System.Console;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicEnumerable();
            
            ReadLine();
        }

        private static void ClassicEnumerable()
        {
            WriteLine("--- ClassicEnumerable ---");            
            foreach (int i in new ClassicEnumerable())
            {
                WriteLine(i);
            }
        }
    }
}

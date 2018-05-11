using System;
using static System.Console;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicEnumerable();

            NakedEnumerable();
            
            ReadLine();
        }

        private static void NakedEnumerable()
        {
            WriteLine("--- NakedEnumerable ---");
            foreach (int i in new NakedEnumerable())
            {
                WriteLine(i);
            }
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

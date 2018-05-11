using System;
using static System.Console;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            // uncomment the method call(s) you want to test

            // ClassicEnumerable();

            // NakedEnumerable();

            // ClassicEnumerableWithYield();

            NumberGenerator();
            
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
        private static void NakedEnumerable()
        {
            WriteLine("--- NakedEnumerable ---");
            foreach (int i in new NakedEnumerable())
            {
                WriteLine(i);
            }
        }

        private static void ClassicEnumerableWithYield()
        {
            WriteLine("--- ClassicEnumerableWithYield ---");            
            foreach (int i in new ClassicEnumerableWithYield())
            {
                WriteLine(i);
            }
        }

        private static void NumberGenerator()
        {
            WriteLine("--- NumberGenerator ---");            
            foreach (int i in new NumberGenerator(49))
            {
                WriteLine(i);
            }
        }
    }
}

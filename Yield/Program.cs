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

            // NumberGenerator();

            CustomEnumerable();
            
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
        
        private static void CustomEnumerable()
        {
            WriteLine("--- CustomEnumerable ---");
            var list = new CustomEnumerable();
            var enumerator1 = list.GetEnumerator(0);
            while (enumerator1.MoveNext())
            {
                WriteLine(enumerator1.Current);
            }
            WriteLine(Environment.NewLine);
            var enumerator2 = list.GetEnumerator(4);
            while (enumerator2.MoveNext())
            {
                WriteLine(enumerator2.Current);
            }
        }
    }
}

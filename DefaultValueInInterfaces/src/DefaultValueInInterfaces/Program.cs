using System;
using System.Linq;
using System.Reflection;

namespace DefaultValueInInterfaces
{
    class Program
    {
        static void Main()
        {
            IStringReverser reverser = GetStringReverser();
            string reversed = reverser.Reverse();
            Console.WriteLine(reversed);
        }

        private static IStringReverser GetStringReverser()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            Type tsr = asm.GetType("DefaultValueInInterfaces.StringReverser");
            return Activator.CreateInstance(tsr) as IStringReverser;
        }
    }

    public interface IStringReverser
    {
        string Reverse(string s = "Picard");
    }

    public class StringReverser : IStringReverser
    {
        public string Reverse(string s = "Archer")
        {
            return new string(s.Reverse().ToArray());
        }
    }
}

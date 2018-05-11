using System;
using System.Collections;
using System.Collections.Generic;

namespace Yield
{
    class NumberGenerator : IEnumerable<int>
    {
        private int _max;

        public NumberGenerator(int max)
        {
            if (max >= 100) throw new ArgumentException(nameof(max) + " can't be bigger than 99.");
            _max = max;
        }

        Random _r = new Random();

        public IEnumerator<int> GetEnumerator()
        {
            while (true)
            {
                var num = _r.Next(0, 100);
                if (num > _max)
                {
                    System.Console.WriteLine($"Stopping, because {num} is bigger than {_max}.");
                    yield break;
                }
                yield return num;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
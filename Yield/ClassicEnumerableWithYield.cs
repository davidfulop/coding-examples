using System.Collections;
using System.Collections.Generic;

namespace Yield
{
    // classic enumerable with yield
    class ClassicEnumerableWithYield : IEnumerable<int>
    {
        private int[] _items = new int[] { 0, 1, 2, 3, 44, 55, 7 };

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _items.Length; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

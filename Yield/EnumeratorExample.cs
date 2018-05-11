using System.Collections;
using System.Collections.Generic;

namespace Yield
{
    class MyEnumerable1 : IEnumerable<int>
    {
        private int[] _items = new int[] { 0, 1, 2, 3, 44, 55, 7 };

        public IEnumerator<int> GetEnumerator()
        {
            return new MyEnumerable1Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class MyEnumerable1Enumerator : IEnumerator<int>
        {
            int _index = -1;
            MyEnumerable1 _subject;

            public MyEnumerable1Enumerator(MyEnumerable1 subject)
            {
                _subject = subject;
            }

            public int Current => _subject._items[_index];

            object IEnumerator.Current => Current;

            public void Dispose() 
            { }

            public bool MoveNext()
            {
                return ++_index < _subject._items.Length;
            }

            public void Reset()
            {
                _index = -1;
            }
        }
    }
}
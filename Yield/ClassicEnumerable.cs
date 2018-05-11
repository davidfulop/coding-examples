using System.Collections;
using System.Collections.Generic;

namespace Yield
{
    // classic enumerable
    class ClassicEnumerable : IEnumerable<int>
    {
        private int[] _items = new int[] { 0, 1, 2, 3, 44, 55, 7 };

        public IEnumerator<int> GetEnumerator()
        {
            return new ClassicEnumerableEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class ClassicEnumerableEnumerator : IEnumerator<int>
        {
            int _index = -1;
            ClassicEnumerable _subject;

            public ClassicEnumerableEnumerator(ClassicEnumerable subject)
            {
                _subject = subject;
            }

            public int Current
            {
                get { return _subject._items[_index]; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

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

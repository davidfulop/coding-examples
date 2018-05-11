using System;

namespace Yield
{
    // naked, custom enumerable and enumerator
    class CustomEnumerable
    {
        private int[] _items = { 0, 1, 2, 3, 44, 55, 7 };

        public CustomEnumerator GetEnumerator(int startIndex)
        {
            if (startIndex >= _items.Length) throw new ArgumentException("Nope.");
            return new CustomEnumerator(this, startIndex);
        }

        public class CustomEnumerator
        {
            private int _index = -1;
            private CustomEnumerable _subject;


            public CustomEnumerator(CustomEnumerable subject, int startIndex)
            {
                this._subject = subject;
                this._index = startIndex - 1;
            }

            public bool MoveNext()
            {
                return ++_index < _subject._items.Length;
            }

            public int Current
            {
                get { return _subject._items[_index]; }
            }
        }
    }
}

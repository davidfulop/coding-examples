namespace Yield
{
    // naked enumerable and enumerator - not implementing the canonical interfaces, just the bare minimum
    class NakedEnumerable
    {
        private int[] _items = { 0, 1, 2, 3, 44, 55, 7 };

        public NakedEnumerator GetEnumerator()
        {
            return new NakedEnumerator(this);
        }

        public class NakedEnumerator
        {
            private int _index = -1;
            private NakedEnumerable _subject;

            public NakedEnumerator(NakedEnumerable subject)
            {
                this._subject = subject;
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

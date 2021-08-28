using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class Photos : IEnumerator<Photo>, IEnumerable<Photo>
    {
        private readonly Collection<Photo> m_Photos;

        public int Index { get; private set; } = -1;

        public int Count => m_Photos.Count;

        public Photos(Collection<Photo> i_Photos)
        {
            m_Photos = new Collection<Photo>(i_Photos);
        }

        public Photo Current
        {
            get
            {
                try
                {
                    return m_Photos[Index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Add(Photo i_Photo)
        {
            m_Photos.Add(i_Photo);
        }

        public void Clear()
        {
            m_Photos.Clear();
            Reset();
        }

        public IEnumerator<Photo> GetEnumerator() => this;

        public bool MoveNext()
        {
            Index++;
            return (Index < m_Photos.Count);
        }

        public bool MovePrev()
        {
            Index--;
            return (Index >= 0);
        }

        public void Reset() => Index = -1;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        void IDisposable.Dispose()
        {
            // Dispose
        }
    }
}

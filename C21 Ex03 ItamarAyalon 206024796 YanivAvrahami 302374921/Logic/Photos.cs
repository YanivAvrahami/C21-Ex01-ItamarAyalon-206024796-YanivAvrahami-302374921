using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class Photos : IEnumerable<Photo>
    {
        private readonly Collection<Photo> m_Photos;

        public int Count => m_Photos.Count;

        public Photos()
        {
            m_Photos = new Collection<Photo>();
        }

        public Photos(Collection<Photo> i_Photos)
        {
            m_Photos = new Collection<Photo>(i_Photos);
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            foreach (Photo photo in m_Photos)
            {
                yield return photo;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public IEnumerator<Photo> GetEnumeratorFrom(int i_Index)
        {
            if (i_Index < 0 && i_Index >= m_Photos.Count)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = i_Index; i < m_Photos.Count; i++)
            {
                yield return m_Photos[i_Index];
            }
        }

        public void Add(Photo i_Photo)
        {
            m_Photos.Add(i_Photo);
        }

        public void Clear()
        {
            m_Photos.Clear();
        }
    }
}

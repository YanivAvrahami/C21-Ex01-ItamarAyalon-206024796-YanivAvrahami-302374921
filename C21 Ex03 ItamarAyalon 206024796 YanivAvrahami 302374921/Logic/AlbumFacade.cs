using FacebookWrapper.ObjectModel;
using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    public class AlbumsFacade
    {
        private readonly Photos r_Photos;
        private int m_CurrentPage;

        public Photos CurrentChunk { get; }

        public int MaxChunkSize { get; }

        public bool HasNextPage => (m_CurrentPage * MaxChunkSize) < r_Photos.Count;

        public bool HasPrevPage => ((m_CurrentPage - 1) * MaxChunkSize) >= MaxChunkSize;

        public AlbumsFacade(Album i_AlbumShown, int i_MaxChunkSize)
        {
            r_Photos = new Photos(FacebookUserFetcher.Instance.FetchPhotos(i_AlbumShown));
            m_CurrentPage = 0;
            CurrentChunk = new Photos();
            MaxChunkSize = i_MaxChunkSize;
            NextPage();
        }

        public void NextPage()
        {
            IEnumerator<Photo> enumerator = r_Photos.GetEnumeratorFrom(m_CurrentPage * MaxChunkSize);
            m_CurrentPage++;
            CurrentChunk.Clear();

            for (int i = 0; i < MaxChunkSize; i++)
            {
                if (!enumerator.MoveNext())
                {
                    break;
                }

                CurrentChunk.Add(enumerator.Current);
            }
        }

        public void PrevPage()
        {
            m_CurrentPage--;
            IEnumerator<Photo> enumerator = r_Photos.GetEnumeratorFrom((m_CurrentPage - 1) * MaxChunkSize);
            CurrentChunk.Clear();

            for (int i = 0; i < MaxChunkSize; i++)
            {
                if (!enumerator.MoveNext())
                {
                    break;
                }

                CurrentChunk.Add(enumerator.Current);
            }
        }
    }
}

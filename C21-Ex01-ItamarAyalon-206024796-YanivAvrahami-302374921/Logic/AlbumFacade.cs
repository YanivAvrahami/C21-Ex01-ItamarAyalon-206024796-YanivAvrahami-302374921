using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class AlbumsFacade
    {
        private readonly Photos r_Photos;

        public Photos CurrentChunk { get; }

        public int ChunkSize { get; private set; }

        public int MaxChunkSize { get; }

        public bool HasNextPage => r_Photos.Index < r_Photos.Count;

        public bool HasPrevPage => r_Photos.Index >= MaxChunkSize;

        public AlbumsFacade(Album i_AlbumShown, int i_MaxChunkSize)
        {
            r_Photos = new Photos(FacebookUserFetcher.Instance.FetchPhotos(i_AlbumShown));
            CurrentChunk = new Photos(null);
            MaxChunkSize = i_MaxChunkSize;
            NextPage();
        }

        public void PrevPage()
        {
            CurrentChunk.Clear();

            for (int i = 0; i < MaxChunkSize; i++)
            {
                CurrentChunk.Add(r_Photos.Current);

                if (!r_Photos.MovePrev())
                {
                    break;
                }
            }
        }

        public void NextPage()
        {
            CurrentChunk.Clear();

            for (int i = 0; i < MaxChunkSize; i++)
            {
                if (!r_Photos.MoveNext())
                {
                    break;
                }

                CurrentChunk.Add(r_Photos.Current);
            }
        }
    }
}

using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using System.Collections;
using System.Collections.ObjectModel;

namespace UI
{
    public partial class AlbumForm : Form
    {
        private AlbumsFacade m_AlbumsFacade;
        private Album m_AlbumShown;

        public Album AlbumShown
        {
            get => m_AlbumShown;
            set
            {
                m_AlbumShown = value;
                fetchPhotos();
            }
        }

        public AlbumForm()
        {
            InitializeComponent();

            m_AlbumShown = null;
        }

        private void fetchPhotos()
        {
            m_AlbumsFacade = new AlbumsFacade(FacebookUserFetcher.Instance.FetchPhotos(AlbumShown), 6);
            btnNextPage_Click(this, new EventArgs());
        }

        private void displayPhotos()
        {
            IEnumerator<Photo> enumerator = m_AlbumsFacade.CurrentChunk.GetEnumerator();

            foreach (Control control in groupBoxPhotos.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;

                    if (enumerator.MoveNext())
                    {
                        pictureBox.LoadAsync(enumerator.Current.PictureThumbURL);
                    }
                }
            }

            setButtons();
        }

        private void setButtons()
        {
            btnNextPage.Enabled = m_AlbumsFacade.HasNextPage();
            btnPrevPage.Enabled = m_AlbumsFacade.HasPrevPage();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            m_AlbumsFacade.NextPage();
            displayPhotos();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            m_AlbumsFacade.PrevPage();
            displayPhotos();
        }
    }

    public class AlbumsFacade
    {
        private Photos m_Photos;

        public Photos CurrentChunk { get; }
        public int ChunkSize { get; private set; }
        public int MaxChunkSize { get; }

        public AlbumsFacade(Collection<Photo> i_Photos, int i_MaxChunkSize)
        {
            m_Photos = new Photos(i_Photos);
            MaxChunkSize = i_MaxChunkSize;
            CurrentChunk = null;
        }

        public void PrevPage()
        {
            CurrentChunk.Clear();

            for (int i = 0; i < MaxChunkSize; i++)
            {
                CurrentChunk.Add(m_Photos.Current);

                if (!m_Photos.MovePrev())
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
                if (!m_Photos.MoveNext())
                {
                    break;
                }

                CurrentChunk.Add(m_Photos.Current);
            }
        }

        public bool HasNextPage()
        {
            return (m_Photos.Index < m_Photos.Count);
        }

        public bool HasPrevPage()
        {
            return (m_Photos.Index >= MaxChunkSize);
        }
    }

    //public interface IPhotoAlbum : IEnumerator<Photo>, IEnumerable<Photo>
    //{
    //    void Add(Photo i_Photo);

    //    void Clear();
    //}

    //public class PhotosObjectProxy : IPhotoAlbum
    //{

    //}

    public class Photos : IEnumerator<Photo>, IEnumerable<Photo>
    {
        private Collection<Photo> m_Photos;
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

        public void Dispose() { }

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


        //private class PhotoEnumerator : IEnumerator<Photo>
        //{
        //    private List<Photo> m_Photos;
        //    private int m_Index = -1;

        //    public Photo Current
        //    {
        //        get
        //        {
        //            try
        //            {
        //                return m_Photos[index];
        //            }
        //            catch (IndexOutOfRangeException)
        //            {
        //                throw new InvalidOperationException();
        //            }
        //        }
        //    }

        //    object IEnumerator.Current => Current;

        //    public PhotoEnumerator(List<Photo> i_Photos)
        //    {
        //        m_Photos = i_Photos;
        //    }

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        index++;
        //        return (index < m_Photos.Count);
        //    }

        //    public void Reset()
        //    {
        //        index = -1;
        //    }
        //}
    }
}

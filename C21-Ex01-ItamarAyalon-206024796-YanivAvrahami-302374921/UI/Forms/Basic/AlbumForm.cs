using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;

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
        }

        private void fetchPhotos()
        {
            m_AlbumsFacade = new AlbumsFacade(AlbumShown, 6);
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
}

using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class albumForm : Form
    {
        private int m_CurrentPhotoIdx;
        private List<Photo> m_Photos;
        private Album m_AlbumShown;
        private int m_Displayed;

        public Album AlbumShown
        {
            get => m_AlbumShown;
            set
            {
                m_AlbumShown = value;
                fetchPhotos();
            }
        }

        public albumForm()
        {
            InitializeComponent();

            m_AlbumShown = null;
            m_Photos = new List<Photo>();
            m_CurrentPhotoIdx = 0;
            m_Displayed = 0;
        }

        private void fetchPhotos()
        {
            m_Photos = FacebookUserFetcher.sr_Instance.FetchPhotos(AlbumShown);

            displayPhotos();
        }

        private void displayPhotos()
        {
            m_Displayed = 0;
            foreach (Control control in groupBoxPhotos.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image = null;
                    }

                    if (m_CurrentPhotoIdx < m_Photos.Count)
                    {
                        pictureBox.LoadAsync(m_Photos[m_CurrentPhotoIdx].PictureThumbURL);
                        m_CurrentPhotoIdx++;
                        m_Displayed++;
                    }
                }
            }

            setButtons();
        }

        private void setButtons()
        {
            if (m_CurrentPhotoIdx < m_Photos.Count)
            {
                btnNextPage.Enabled = true;
            }
            else
            {
                btnNextPage.Enabled = false;
            }

            if (m_CurrentPhotoIdx > groupBoxPhotos.Controls.Count)
            {
                btnPrevPage.Enabled = true;
            }
            else
            {
                btnPrevPage.Enabled = false;
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            displayPhotos();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            m_CurrentPhotoIdx -= groupBoxPhotos.Controls.Count + m_Displayed;

            if (m_CurrentPhotoIdx < 0)
            {
                m_CurrentPhotoIdx = 0;
            }

            displayPhotos();
        }
    }
}

using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class albumsForm : Form
    {
        private List<Album> m_Albums;

        public albumsForm()
        {
            InitializeComponent();

            m_Albums = new List<Album>();
        }

        private void btnFetchAlbums_Click(object sender, EventArgs e)
        {
            m_Albums = FacebookUserFetcher.Instance.FetchAlbums();

            listBoxAlbums.Items.Clear();
            for (int i = 0; i < m_Albums.Count; i++)
            {
                listBoxAlbums.Items.Add(m_Albums[i].Name);
            }

            labelAlbumsCounted.Text = m_Albums.Count.ToString();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlbums.SelectedIndex == -1)
            {
                btnOpenAlbum.Enabled = false;
                return;
            }

            Album chosen = m_Albums[listBoxAlbums.SelectedIndex];

            labelName.Text = chosen.Name;
            labelCreateDate.Text = chosen.CreatedTime.Value.ToString("dd/MM/yy HH:mm");
            labelPhotos.Text = chosen.Photos.Count.ToString();
            labelPrivacy.Text = chosen.PrivcaySettings.ToString();

            pictureBoxCover.LoadAsync(chosen.PictureAlbumURL);

            btnOpenAlbum.Enabled = chosen.Count > 0;
        }

        private void btnOpenAlbum_Click(object sender, EventArgs e)
        {
            albumForm album = new albumForm();
            album.AlbumShown = m_Albums[listBoxAlbums.SelectedIndex];
            album.ShowDialog();
        }
    }
}

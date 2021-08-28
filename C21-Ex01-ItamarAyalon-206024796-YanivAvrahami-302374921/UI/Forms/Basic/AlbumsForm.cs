using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using System.Threading;

namespace UI
{
    public partial class AlbumsForm : Form
    {
        private List<Album> m_Albums;
        private FormFactory m_FormFactory;

        public AlbumsForm(FormFactory i_FormFactory)
        {
            InitializeComponent();

            m_Albums = new List<Album>();
            m_FormFactory = i_FormFactory;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            new Thread(fetchAlbumsOnLoad).Start();
        }

        private void fetchAlbumsOnLoad()
        {
            m_Albums = FacebookUserFetcher.Instance.FetchAlbums();

            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));
            for (int i = 0; i < m_Albums.Count; i++)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(m_Albums[i].Name)));
                //listBoxAlbums.Items.Add(m_Albums[i].Name);
            }

            labelAlbumsCounted.Invoke(new Action(() => labelAlbumsCounted.Text = m_Albums.Count.ToString()));
        }

        private void btnFetchAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchAlbumsOnLoad).Start();
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
            AlbumForm album = (AlbumForm)m_FormFactory.Create(typeof(AlbumForm));
            album.AlbumShown = m_Albums[listBoxAlbums.SelectedIndex];
            album.ShowDialog();
        }
    }
}

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUI.Forms
{
    public partial class AlbumsForm : Form
    {
        private List<Album> m_Albums;

        public AlbumsForm()
        {
            InitializeComponent();

            m_Albums = new List<Album>();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_Albums = FacebookUserFetcher.sr_Instance.FetchAlbums();

            listBoxAlbums.Items.Clear();
            for (int i = 0; i < m_Albums.Count; i++)
            {
                listBoxAlbums.Items.Add(m_Albums[i].Name);
            }

            labelEventsCounted.Text = m_Albums.Count.ToString();
        }
    }
}

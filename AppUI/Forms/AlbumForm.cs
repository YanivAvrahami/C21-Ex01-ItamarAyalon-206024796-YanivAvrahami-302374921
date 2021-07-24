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
    public partial class AlbumForm : Form
    {
        private List<Photo> m_Photos;

        public AlbumForm()
        {
            InitializeComponent();

            m_Photos = FacebookUserFetcher.sr_Instance.FetchPhotos();


        }


    }
}

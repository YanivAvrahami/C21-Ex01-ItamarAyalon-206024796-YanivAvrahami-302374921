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

namespace AppUI
{
    public partial class LikeRated : Form
    {
        private List<Photo> m_Photos;

        public LikeRated()
        {
            InitializeComponent();

            m_Photos = new List<Photo>();
        }

        private void btnFetchInfo_Click(object sender, EventArgs e)
        {
            List<Album> albums = FacebookUserFetcher.sr_Instance.FetchAlbums();
            m_Photos = new List<Photo>();

            foreach (Album album in albums)
            {
                m_Photos.AddRange(FacebookUserFetcher.sr_Instance.FetchPhotos(album));
            }

            extractInfo();
        }

        private void extractInfo()
        {
            if (m_Photos.Count == 0)
            {
                MessageBox.Show("Could not found any images :(");
                return;
            }

            Photo mostLiked = m_Photos[0];
            Photo leastLiked = m_Photos[0];
            Photo mostComments = m_Photos[0];
            Photo leastComments = m_Photos[0];
            int totalLikes = 0;
            int totalComments = 0;

            foreach (Photo currentPhoto in m_Photos)
            {
                totalLikes += currentPhoto.LikedBy.Count;
                totalComments += currentPhoto.Comments.Count;

                if (mostLiked.LikedBy.Count < currentPhoto.LikedBy.Count)
                {
                    mostLiked = currentPhoto;
                }

                if (leastLiked.LikedBy.Count > currentPhoto.LikedBy.Count)
                {
                    leastLiked = currentPhoto;
                }

                if (mostComments.Comments.Count < currentPhoto.Comments.Count)
                {
                    mostComments = currentPhoto;
                }

                if (leastComments.Comments.Count > currentPhoto.Comments.Count)
                {
                    leastComments = currentPhoto;
                }
            }

            displayPictures(mostLiked, leastLiked, mostComments, leastComments);

            labelTotalPhotos.Text = m_Photos.Count.ToString();
            labelAvgLikes.Text = (totalLikes / (float)m_Photos.Count).ToString();
            labelAvgComments.Text = (totalComments / (float)m_Photos.Count).ToString();
        }

        private void displayPictures(Photo i_MostLiked, Photo i_LeastLiked, Photo i_MostComments, Photo i_LeastComments)
        {
            labelMostLiked.Text = i_MostLiked.CreatedTime?.ToString("dd/MM/yyyy");
            pictureBoxMostLiked.Image = i_MostLiked.ImageNormal;

            labelLeastLiked.Text = i_LeastLiked.CreatedTime?.ToString("dd/MM/yyyy");
            pictureBoxLeastLiked.Image = i_LeastLiked.ImageNormal;

            labelMostComments.Text = i_MostComments.CreatedTime?.ToString("dd/MM/yyyy");
            pictureBoxMostComments.Image = i_MostComments.ImageNormal;

            labelLeastComments.Text = i_LeastComments.CreatedTime?.ToString("dd/MM/yyyy");
            pictureBoxLeastComments.Image = i_LeastComments.ImageNormal;
        }
    }
}

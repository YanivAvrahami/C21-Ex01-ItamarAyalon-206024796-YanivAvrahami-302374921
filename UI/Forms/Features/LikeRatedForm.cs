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
using Logic;

namespace UI
{
    public partial class likeRatedForm : Form
    {
        private List<Photo> m_Photos;

        public likeRatedForm()
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
            int total = 0;

            foreach (Photo currentPhoto in m_Photos)
            {
                if (!isDateInRange(currentPhoto.CreatedTime))
                {
                    continue;
                }

                totalLikes += currentPhoto.LikedBy.Count;
                totalComments += currentPhoto.Comments.Count;
                total++;

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

            labelTotalPhotos.Text = total.ToString();
            labelAvgLikes.Text = (totalLikes / (float)total).ToString();
            labelAvgComments.Text = (totalComments / (float)total).ToString();
        }

        private bool isDateInRange(DateTime? i_PhotoCreatedTime)
        {
            if (!i_PhotoCreatedTime.HasValue)
            {
                return false;
            }

            if (dateTimePickerStart.Checked &&
                i_PhotoCreatedTime < dateTimePickerStart.Value)
            {
                return false;
            }

            if (dateTimePickerEnd.Checked &&
                i_PhotoCreatedTime > dateTimePickerEnd.Value)
            {
                return false;
            }

            return true;
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

using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppUI
{
    public partial class PostCounter : Form
    {
        private List<string> months = new List<string>(12);
        private int[] postCountByMonth = new int[12];

        public PostCounter()
        {
            InitializeComponent();

            months.Add("Jan");
            months.Add("Feb");
            months.Add("Mar");
            months.Add("Apr");
            months.Add("May");
            months.Add("Jun");
            months.Add("Jul");
            months.Add("Aug");
            months.Add("Sep");
            months.Add("Oct");
            months.Add("Nov");
            months.Add("Dec");
        }

        private void btnLoadMostLikedPosts_Click(object sender, EventArgs e)
        {
            postCountByMonth = getPostsNumInEachMonth();

            for (int i = 0; i < 12; i++)
            {
                chartPostsCounter.Series["Posts"].Points.AddXY(months[i], postCountByMonth[i]);
            }
        }

        private int[] getPostsNumInEachMonth() 
        {
            int[] counter = new int[12];

            foreach (Post post in FacebookUserFetcher.sr_Instance.FetchPosts())
            {
                counter[post.CreatedTime.Value.Month - 1]++;
            }

            return counter;
        }
    }
}

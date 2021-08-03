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
    public partial class PostCounter : Form
    {
        private string[] months =
            {"Jan", "Feb", "Mar", "Apr",
            "May", "Jun", "Jul", "Aug",
            "Sep", "Oct", "Nov", "Dec"};

        public PostCounter()
        {
            InitializeComponent();
        }

        private void btnLoadMostLikedPosts_Click(object sender, EventArgs e)
        {
            chartPostsCounter.Series["Posts"].Points.AddXY(months[0], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[1], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[2], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[3], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[4], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[5], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[6], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[7], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[8], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[9], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[10], 33);
            chartPostsCounter.Series["Posts"].Points.AddXY(months[11], 33);
        }
    }
}

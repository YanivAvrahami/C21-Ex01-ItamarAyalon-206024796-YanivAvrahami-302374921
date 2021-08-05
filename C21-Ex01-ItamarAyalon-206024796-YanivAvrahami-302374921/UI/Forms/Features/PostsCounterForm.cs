using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Collections.ObjectModel;
using Logic;

namespace UI
{
    public partial class postsCounterForm : Form
    {
        private readonly int k_NumOfMonthInYear = 12;

        private List<Post> UserPosts { get; set; }

        private List<string> MonthStrings { get; set; }

        private List<int> Years { get; set; }

        private List<int> Months { get; set; }

        private int[] MonthCounters { get; set; }
        
        private bool IsYearOnlyChecked { get; set; }

        private int SelectedYear { get; set; }

        private int SelectedMonth { get; set; }

        public postsCounterForm()
        {
            InitializeComponent();

            UserPosts = new List<Post>();
            MonthStrings = new List<string>();
            Years = new List<int>();
            MonthCounters = new int[12];
            initializeMonthStrings();

            initializeBindings();
        }

        private void initializeBindings()
        {
            yearComboBox.DataSource = Years;
            monthComboBox.DataSource = Months;
        }

        private void FormPostCounter_Load(object sender, EventArgs e)
        {
            UserPosts = FacebookUserFetcher.sr_Instance.FetchPosts();
            Years = UserPosts.Select(post => post.CreatedTime.Value.Year).Distinct().ToList();
            yearComboBox.DataSource = null;
            yearComboBox.DataSource = Years;
        }

        private void updateChartButton_Click(object sender, EventArgs e)
        {
            MonthCounters = new int[k_NumOfMonthInYear];
            List<Post> allPostsInSelectedYear = UserPosts.Where(post => post.CreatedTime.Value.Year == SelectedYear).ToList();

            if (IsYearOnlyChecked)
            {
                for (int i = 0; i < k_NumOfMonthInYear; i++)
                {
                    MonthCounters[i] = allPostsInSelectedYear.Where(post => post.CreatedTime.Value.Month == i).ToList().Count;
                }
            }
            else
            {
                MonthCounters[SelectedMonth] = allPostsInSelectedYear.Where(post => post.CreatedTime.Value.Month == SelectedMonth).ToList().Count;
            }

            postsChart.Series["Posts"].Points.DataBindXY(MonthStrings, MonthCounters);
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedYear = (int)yearComboBox.SelectedItem;
            Months = UserPosts.Where(post => post.CreatedTime.Value.Year == SelectedYear)
                .Select(post => post.CreatedTime.Value.Month)
                .Distinct()
                .ToList();
            monthComboBox.DataSource = Months;
        }

        private void monthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMonth = (int)monthComboBox.SelectedItem;
        }

        private void yearOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsYearOnlyChecked = yearOnlyCheckBox.Checked;
            monthComboBox.Enabled = !IsYearOnlyChecked;
        }

        private void initializeMonthStrings()
        {
            MonthStrings.Add("Jan");
            MonthStrings.Add("Feb");
            MonthStrings.Add("Mar");
            MonthStrings.Add("Apr");
            MonthStrings.Add("May");
            MonthStrings.Add("Jun");
            MonthStrings.Add("Jul");
            MonthStrings.Add("Aug");
            MonthStrings.Add("Sep");
            MonthStrings.Add("Oct");
            MonthStrings.Add("Nov");
            MonthStrings.Add("Dec");
        }
    }
}

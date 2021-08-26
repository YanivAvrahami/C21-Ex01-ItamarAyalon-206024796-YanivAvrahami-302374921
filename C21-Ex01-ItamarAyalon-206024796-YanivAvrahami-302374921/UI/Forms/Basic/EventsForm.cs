using System;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class EventsForm : Form
    {
        public eventsForm()
        {
            InitializeComponent();

            bindComponents();

            comboBoxEventType.Items.AddRange(Enum.GetNames(typeof(eEventType)));
            comboBoxEventType.SelectedIndex = 0;
        }

        private void bindComponents()
        {
            Binding countEventsBinding = new Binding("Text", eventBindingSource, "");
            countEventsBinding.Format += countEventsBinding_Format;
            Binding imageBinding = new Binding("Image", eventBindingSource, "Cover");
            imageBinding.Format += imageBinding_Format;

            pictureBoxCover.DataBindings.Add(imageBinding);
            labelEventsCounted.DataBindings.Add(countEventsBinding);
        }

        private void countEventsBinding_Format(object sender, ConvertEventArgs e)
        {
            Binding theSender = sender as Binding;
            if (theSender.DataSource is BindingSource bSource)
            {
                e.Value = bSource.Count.ToString();
            }
        }

        private void imageBinding_Format(object sender, ConvertEventArgs e)
        {
            Binding theSender = sender as Binding;
            if (theSender.DataSource is BindingSource bSource)
            {
                if (bSource.Current is Event theEvent)
                {
                    pictureBoxCover.LoadAsync(theEvent.Cover.SourceURL);
                }
            }
        }

        private void btnFetchEvents_Click(object sender, EventArgs e)
        {
            eEventType eventsType = (eEventType)Enum.Parse(typeof(eEventType), comboBoxEventType.SelectedItem.ToString());

            eventBindingSource.DataSource = FacebookUserFetcher.Instance.FetchEvents(eventsType);
        }
    }
}

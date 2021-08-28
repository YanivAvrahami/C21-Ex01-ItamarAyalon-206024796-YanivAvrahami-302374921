using System;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UI
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();

            bindComponents();

            comboBoxEventType.Items.AddRange(Enum.GetNames(typeof(eEventType)));
            comboBoxEventType.SelectedIndex = 0;
            comboBoxEventType.SelectedIndexChanged += comboBoxEventType_SelectedIndexChanged;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            new Thread(fetchEventsOnLoad).Start();
        }

        private void fetchEventsOnLoad()
        {
            comboBoxEventType.Invoke(new Action(() =>
            {
                eEventType eventsType = (eEventType)Enum.Parse(typeof(eEventType), comboBoxEventType.SelectedItem.ToString());
                eventBindingSource.DataSource = FacebookUserFetcher.Instance.FetchEvents(eventsType);
            }));
        }

        private void bindComponents()
        {
            Binding countEventsBinding = new Binding("Text", eventBindingSource, string.Empty);
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
            new Thread(fetchEventsOnLoad).Start();
        }

        private void comboBoxEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
           new Thread(fetchEventsOnLoad).Start();
        }
    }
}

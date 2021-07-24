using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppUI
{
    public partial class EventsForm : Form
    {
        private List<Event> m_Events = new List<Event>();

        public EventsForm()
        {
            InitializeComponent();

            comboBoxEventType.Items.AddRange(Enum.GetNames(typeof(eEventType)));
            comboBoxEventType.SelectedIndex = 0;
        }

        private void btnFetchEvents_Click(object sender, System.EventArgs e)
        {
            eEventType eventsType = (eEventType)Enum.Parse(typeof(eEventType), comboBoxEventType.SelectedItem.ToString());

            m_Events = FacebookUserFetcher.sr_Instance.FetchEvents(eventsType);

            string[] eventsTitle = new string[m_Events.Count];
            for (int i = 0; i < m_Events.Count; i++)
            {
                eventsTitle[i] = m_Events[i].Name;
            }

            listBoxEvents.Items.Clear();
            listBoxEvents.Items.AddRange(eventsTitle);
            labelEventsCounted.Text = eventsTitle.Length.ToString();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event chosen = m_Events[listBoxEvents.SelectedIndex];

            labelEventName.Text = chosen.Name;
            labelEventLocation.Text = chosen.Place.Name;
            labelEventInterested.Text = chosen.InterestedCount.ToString();
            labelEventPrivacy.Text = chosen.Privacy.ToString();
            textBoxEventDesc.Text = chosen.Description;
            pictureBoxCover.LoadAsync(chosen.Cover.SourceURL);
            labelEventStartDate.Text = chosen.StartTime.Value.ToString("dd/MM/yy HH:mm");

            if (chosen.EndTime.HasValue)
            {
                labelEventEndDate.Text = chosen.EndTime.Value.ToString("dd/MM/yy HH:mm");
            } else
            {
                labelEventStartDate.Text = "-";
            }
        }
    }
}

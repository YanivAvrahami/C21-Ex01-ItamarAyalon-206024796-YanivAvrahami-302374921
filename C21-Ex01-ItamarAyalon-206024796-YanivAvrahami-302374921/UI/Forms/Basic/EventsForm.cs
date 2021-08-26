using System;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class EventsForm : Form
    {
        private List<Event> m_Events;

        public EventsForm()
        {
            InitializeComponent();

            m_Events = new List<Event>();

            comboBoxEventType.Items.AddRange(Enum.GetNames(typeof(eEventType)));
            comboBoxEventType.SelectedIndex = 0;
        }

        private void btnFetchEvents_Click(object sender, EventArgs e)
        {
            eEventType eventsType = (eEventType)Enum.Parse(typeof(eEventType), comboBoxEventType.SelectedItem.ToString());

            m_Events = FacebookUserFetcher.Instance.FetchEvents(eventsType);

            listBoxEvents.Items.Clear();
            for (int i = 0; i < m_Events.Count; i++)
            {
                listBoxEvents.Items.Add(m_Events[i].Name);
            }

            labelEventsCounted.Text = m_Events.Count.ToString();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEvents.SelectedIndex == -1)
            {
                return;
            }

            Event chosen = m_Events[listBoxEvents.SelectedIndex];

            labelEventName.Text = chosen.Name;

            labelEventLocation.Text = chosen.Place?.Name;
            labelEventInterested.Text = chosen.InterestedCount.ToString();
            labelEventPrivacy.Text = chosen.Privacy.ToString();
            textBoxEventDesc.Text = chosen.Description;
            labelEventStartDate.Text = chosen.StartTime.Value.ToString("dd/MM/yy HH:mm");

            if (chosen.Cover != null)
            {
                pictureBoxCover.LoadAsync(chosen.Cover.SourceURL);
            }

            if (chosen.EndTime.HasValue)
            {
                labelEventEndDate.Text = chosen.EndTime.Value.ToString("dd/MM/yy HH:mm");
            }
            else
            {
                labelEventEndDate.Text = "-";
            }
        }
    }
}

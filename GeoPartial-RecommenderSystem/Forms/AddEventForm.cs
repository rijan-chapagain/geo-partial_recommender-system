using GeoPartial_RecommenderSystem.Events.EventLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoPartial_RecommenderSystem.Forms
{
    public partial class AddEventForm : Form
    {
        private int mouseX;
        private int mouseY;
        EventLogSchema.EventTypes eventTypes;
        public AddEventForm()
        {
            InitializeComponent();
        }

        public AddEventForm(int mouseY, int mouseX)
        {
            InitializeComponent();
            this.mouseX = mouseX;
            this.mouseY = mouseY;
        }

        private void locationLabel_Click(object sender, EventArgs e)
        {

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            Event addNewEvent;
            //perhaps a better way to do this??
            try
            {
                addNewEvent = EventLogSchema.AddEvent(eventTypes);
                switch (eventTypes)
                {
                    case EventLogSchema.EventTypes.Twitter:
                        addNewEvent.EventProps["Text"] = mainGroupBox.Controls.Find("text", true).Single().Text;
                        mainGroupBox.Controls.Find("text", true).Single().Text = "";
                        addNewEvent.Location = LatLong;
                        break;
                    case EventLogSchema.EventTypes.Facebook:

                        addNewEvent.EventProps["Text"] = mainGroupBox.Controls.Find("text", true).Single().Text;
                        addNewEvent.Location = LatLong;
                        mainGroupBox.Controls.Find("text", true).Single().Text = "";
                        break;
                    case EventLogSchema.EventTypes.Photo:

                        addNewEvent.EventProps["Filepath"] = mainGroupBox.Controls.Find("imageLabel", true).Single().Text;
                        mainGroupBox.Controls.Find("imageLabel", true).Single().Text = "";
                        addNewEvent.Location = LatLong;
                        break;
                    case EventLogSchema.EventTypes.Video:

                        addNewEvent.EventProps["Filepath"] = mainGroupBox.Controls.Find("videoLabel", true).Single().Text;
                        mainGroupBox.Controls.Find("videoLabel", true).Single().Text = "";
                        addNewEvent.Location = LatLong;
                        break;
                    case EventLogSchema.EventTypes.TrackLog:

                        addNewEvent.EventProps["Filepath"] = mainGroupBox.Controls.Find("tracklogLabel", true).Single().Text;
                        mainGroupBox.Controls.Find("tracklogLabel", true).Single().Text = "";
                        addNewEvent.Location = XMLTracklogLoader.GetStartCordinatesOfTrack(addNewEvent.EventProps["Filepath"].ToString());
                        break;
                    default:
                        return;

                }

                addNewEvent.Datetimestamp = DateTime.ParseExact(mainGroupBox.Controls.Find("datePicker", true).Single().Text, customDateFormat, CultureInfo.InvariantCulture);
                eventHelper.AddEvent(addNewEvent);
                this.DialogResult = DialogResult.OK;
            }
            catch (ExecutionEngineException)
            {
                MessageBox.Show("An error occured while creating event. Check if the fields are correct");
            }
            this.Close();
        }

        private void mainControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void eventTypeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AddEventForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void rbFacebook_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbTweet_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbPhoto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbTracklog_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

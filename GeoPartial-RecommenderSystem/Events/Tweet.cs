namespace GeoPartial_RecommenderSystem.Events
{
    internal class Tweet : IEvent
    {
        private string eventID;
        private string text;
        private int latitude;
        private int longitude;
        private string datetimestamp;

        public Tweet(string eventID, string text, int latitude, int longitude, string datetimestamp)
        {
            this.eventID = eventID;
            this.text = text;
            this.latitude = latitude;
            this.longitude = longitude;
            this.datetimestamp = datetimestamp;
        }

        public string EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public int Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public int Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public string Datetimestamp
        {
            get { return datetimestamp; }
            set { datetimestamp = value; }
        }

        public override string ToString()
        {
            return eventID + " " + text + " " + latitude + " " + longitude + " " + datetimestamp;
        }
    }
}
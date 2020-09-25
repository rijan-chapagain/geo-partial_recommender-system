using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace GeoPartial_RecommenderSystem
{
    public class Event
    {
        public Event()
        {
            EventProps = new Dictionary<string, object>();
        }

        interface IEvent
        {
            string EventID { get; set; }
        }
            private String id;

        // Adds event props
        public Dictionary<string, object> EventProps { get; private set; }

/*         public LatLong Location { get => location; set => location = value; }
*/        public DateTime Datetimestamp { get => datetimestamp; set => datetimestamp = value; }
        public string ID { get => id; set => id = value; }
/*        public HashSet<string> Links { get => links; set => links = value; }
*/      /*  string IEvent.EventID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private HashSet<string> links = new HashSet<string>();
        private LatLong location;*/
        private DateTime datetimestamp = new DateTime();
        /*        public abstract void Render();
                public abstract XElement ToXElement(XNamespace ns);
                public abstract Panel CreatePanel();
                public abstract bool IsValid();*/

        /*        public abstract string  EventID(); 
        */

        class Tweet : IEvent
        {
            private string eventID;
            private string text;
            private int lat;
            private int longi;
            private string datetimestamp;

            public Tweet(string eventID, string text, int lat, int longi, string datetimestamp)
            {
                this.eventID = eventID;
                this.text = text;
                this.lat = lat;
                this.longi = longi;
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
            public int Lat
            {
                get { return lat; }
                set { lat = value; }
            }
            public int Longi
            {
                get { return longi; }
                set { longi = value; }
            }
            public string Datetimestamp
            {
                get { return datetimestamp; }
                set { datetimestamp = value; }
            }

            public override string ToString()
            {
                return eventID + " " + text + " " + lat + " " + longi + " " + datetimestamp;
            }
        }

    }

    
}

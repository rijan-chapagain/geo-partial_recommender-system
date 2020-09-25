using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace GeoPartial_RecommenderSystem.Events.EventLog
{
    public abstract class Event : IEvents
    {
        public Event()
        {
           
        }
        private String id;

        public Dictionary<string, Tweet> TweetDict { get => tweetDict; set => tweetDict = value; }
        public Dictionary<string, Facebook> FacebookDict { get => facebookDict; set => facebookDict = value; }
        public Dictionary<string, Photo> PhotoDict { get => photoDict; set => photoDict = value; }
        public Dictionary<string, Video> VideoDict { get => videoDict; set => videoDict = value; }
        public Dictionary<string, Tracklog> TracklogDict { get => tracklogDict; set => tracklogDict = value; }

        /*        public Dictionary<string, object> { get; private set; }
        */
        public LatLong Location { get => location; set => location = value; }
        public DateTime Datetimestamp { get => datetimestamp; set => datetimestamp = value; }
        public string ID { get => id; set => id = value; }
        public HashSet<string> Links { get => links; set => links = value; }

        private HashSet<string> links = new HashSet<string>();
        private LatLong location;
        private DateTime datetimestamp = new DateTime();
        public abstract void Render();
        public abstract XElement ToXElement(XNamespace ns);
        public abstract Panel CreatePanel();
        public abstract bool IsValid();
    }
}

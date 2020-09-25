using GeoPartial_RecommenderSystem.Events.EventLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GeoPartial_RecommenderSystem.Events
{
    class ParseEvents
    {
        Event events = new Event();

        Dictionary<string, Tweet> tweetDict = new Dictionary<string, Tweet>();
        Dictionary<string, Facebook> facebookDict = new Dictionary<string, Facebook>();
        Dictionary<string, Photo> photoDict = new Dictionary<string, Photo>();
      /*  Dictionary<string, Video> videoDict = new Dictionary<string, Video>();
        Dictionary<string, Tracklog> tracklogDict = new Dictionary<string, Tracklog>();
*/
        public Dictionary<string, Tweet> TweetDict { get => tweetDict; set => tweetDict = value; }
        public Dictionary<string, Facebook> FacebookDict { get => facebookDict; set => facebookDict = value; }
        public Dictionary<string, Photo> PhotoDict { get => photoDict; set => photoDict = value; }
/*        public Dictionary<string, Video> VideoDict { get => videoDict; set => videoDict = value; }
        public Dictionary<string, Tracklog> TracklogDict { get => tracklogDict; set => tracklogDict = value; }
*/

        public void LoadData()
        {
            // Load the XML file from our project directory containing the Events
            // Specify the xml file path
            var filename = "..\\..\\Resources\\Lifelog-events.xml";

            // Define XML namespace
            XNamespace lle = "http://www.xyz.org/lifelogevents";
            
            XElement eventLog = XElement.Load(filename);
            IEnumerable<XElement> xElements = eventLog.Elements();

            Console.WriteLine("load data********************");
            Debug.WriteLine("Data loaded from SOAP:   ", xElements);

            String[] eventTypes = {"tweet", "facebook-status-update", "photo", "video", "tracklog" };

            // Adds each element to corresponding objects
            foreach(var incomingEvents in xElements.Descendants(lle + "Event"))
            {
                // if event is twitter type then 
                foreach (var incomingEventsType in incomingEvents.Descendants(lle + eventTypes[1))
                {
                    var latitude = 999;
                    var longitude = 999;

                    foreach(var incomingLocationEvent in incomingEvents.Descendants(lle + "location"))
                    {
                        latitude = Int16.Parse(incomingLocationEvent.Element(lle + "lat").Value);
                        longitude = Int16.Parse(incomingLocationEvent.Element(lle + "long").Value);
                    }

                    // Require tweet so creating tweet class.
                
                    Tweet tweetEv = new Tweet(incomingEvents.Element(lle + "eventid").Value, incomingEventsType.Element(lle + "text").Value, latitude, longitude, incomingEventsType.Element(lle + "datetimestamp").Value);

                    TweetDict.Add(incomingEvents.Element(lle + "eventid").Value, tweetEv);
                }

                // if event is twitter type then 
                foreach (var incomingEventsType in incomingEvents.Descendants(lle + "facebook-status-update"))
                {
                    var latitude = 999;
                    var longitude = 999;

                    foreach (var incomingLocationEvent in incomingEvents.Descendants(lle + "location"))
                    {
                        latitude = Int16.Parse(incomingLocationEvent.Element(lle + "lat").Value);
                        longitude = Int16.Parse(incomingLocationEvent.Element(lle + "long").Value);
                    }

                    // Require tweet so creating tweet class.

                    Tweet tweetEv = new Tweet(incomingEvents.Element(lle + "eventid").Value, incomingEventsType.Element(lle + "text").Value, latitude, longitude, incomingEventsType.Element(lle + "datetimestamp").Value);

                    TweetDict.Add(incomingEvents.Element(lle + "eventid").Value, tweetEv);
                }


            }

        }

    }
}

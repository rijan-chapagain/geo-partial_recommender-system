using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace GeoPartial_RecommenderSystem.Events.EventLog
{
    public static class EventLogSchema
    {
        public enum EventTypes
        {
            Empty,
            Facebook,
            Photo,
            TrackLog,
            Twitter,
            Video
        }

        public static Event AddEvent(EventTypes e)
        {
            switch (e)
            {
                case EventTypes.Facebook:
                    return new FacebookEvent();
                case EventTypes.Twitter:
                    return new TwitterEvent();
                case EventTypes.Photo:
                    return new PhotoEvent();
                case EventTypes.Video:
                    return new VideoEvent();
                case EventTypes.TrackLog:
                    return new TrackEvent();
                default:
                    return new EmptyEvent();
            }
        }

    }
}

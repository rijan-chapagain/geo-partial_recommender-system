using System.Text;

namespace GeoPartial_RecommenderSystem.Events.EventLog
{
    public class LatLong
    {
        public LatLong(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        private double latitude;
        private double longitude;

        public override string ToString()
        {
            StringBuilder location = new StringBuilder();
            location.Append(this.Latitude);
            location.Append(", ");
            location.Append(this.Longitude);
            return location.ToString();
        }

        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
    }
}
}
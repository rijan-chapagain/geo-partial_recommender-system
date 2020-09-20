namespace GeoPartial_RecommenderSystem
{
    using GMap.NET;
    using GMap.NET.MapProviders;
    using GMap.NET.WindowsForms;
    using GMap.NET.WindowsForms.Markers;
    using System;
    using System.Windows.Forms;
    class Utilities
    {
        private double latitude = Convert.ToDouble(-31.953512);
        private double longitude = Convert.ToDouble(115.857048);

        public GMapOverlay Marker()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude),
            GMarkerGoogleType.green);
            markersOverlay.Markers.Add(marker);
            return markersOverlay;
        }
    }
}

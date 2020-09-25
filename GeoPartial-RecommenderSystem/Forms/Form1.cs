namespace GeoPartial_RecommenderSystem
{
    using GeoPartial_RecommenderSystem.Forms;
    using GMap.NET;
    using GMap.NET.MapProviders;
    using GMap.NET.WindowsForms;
    using GMap.NET.WindowsForms.Markers;
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        Utilities util = new Utilities();
        public Form1()
        {
            InitializeComponent();

            // handle drag on map
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;

            double latitude = Convert.ToDouble(-31.953512);
            double longitude = Convert.ToDouble(115.857048);
            map.Position = new PointLatLng(latitude, longitude);

            map.Overlays.Add(util.Marker());
        }

        private void Map_Load(object sender, EventArgs e)
        {
/*            MessageBox.Show(string.Format("X: {0} Y: {1}", X, Y));
*/        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            var mouseX = e.X;
            var mouseY = e.Y;
            mouseX = mouseX - 15;
            mouseY = mouseY - 37;
            Form form = new AddEventForm(mouseX, mouseY);
            form.Show();
        }

    }
}

namespace GeoPartial_RecommenderSystem
{
    using GMap.NET;
    using GMap.NET.MapProviders;
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // handle drag on map
            map.DragButton = MouseButtons.Left;


            map.MapProvider = GMapProviders.GoogleMap;
            double latitude = Convert.ToDouble(-31.953512);
            double longitude = Convert.ToDouble(115.857048);

            map.Position = new PointLatLng(latitude, longitude);
            // adjust Zoom level
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 12;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            /*double latitude = Convert.ToDouble(textLat.Text);
            double longitude = Convert.ToDouble(textLong.Text);*/
        }

        private int X;
        private int Y;

        private void Map_Load_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("X: {0} Y: {1}", X, Y));
        }

        private void Map_Load_MouseUp(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }

        private void Map_Load(object sender, EventArgs e)
        {
        }

        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void eventName_Click(object sender, EventArgs e)
        {

        }
    }
}

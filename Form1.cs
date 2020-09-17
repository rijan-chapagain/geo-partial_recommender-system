namespace GeoPartial_RecommenderSystem
{
    using GMap.NET;
    using GMap.NET.MapProviders;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Form1" />.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The btnSearch_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // handle drag on map
            map.DragButton = MouseButtons.Left;



            map.MapProvider = GMapProviders.GoogleMap;
            double latitude = Convert.ToDouble(-32.3473927848437);
            double longitude = Convert.ToDouble(115.811621855803);
           /* double latitude = Convert.ToDouble(textLat.Text);
            double longitude = Convert.ToDouble(textLong.Text);*/

            map.Position = new PointLatLng(latitude, longitude);
            // adjust Zoom level
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 10;
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
            // map Init
            // this.map.Click += new System.EventHandler(this.map_Load);

            // get coordinates on click in map 

        }

        private void Splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}

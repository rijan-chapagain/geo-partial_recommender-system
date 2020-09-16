using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoPartial_RecommenderSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.BingMap;
            double latitude = Convert.ToDouble(textLat.Text);
            double longitude = Convert.ToDouble(textLong.Text);

            map.Position = new PointLatLng(latitude, longitude);
            map.MinZoom = 0;
            map.MaxZoom = 18;
            map.Zoom = 3;
        }
    }
}

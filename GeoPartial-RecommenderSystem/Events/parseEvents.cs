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

        public static void LoadData()
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

        }

    }
}

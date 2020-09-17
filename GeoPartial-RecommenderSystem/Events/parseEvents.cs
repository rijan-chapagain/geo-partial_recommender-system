using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeoPartial_RecommenderSystem.Events
{
    class ParseEvents
    {

        public void LoadData()
        {
            // Load the XML file from our project directory containing the Events
            var filename = "Lifelog-events.xml";
            var currentDirectory = Directory.GetCurrentDirectory();
            var purchaseOrderFilepath = Path.Combine(currentDirectory, filename);

            XElement purchaseOrder = XElement.Load(purchaseOrderFilepath);

            IEnumerable<string> partNos = from item in purchaseOrder.Descendants("Item")
                                          select (string)item.Attribute("PartNumber");
            Console.WriteLine(partNos);
        }
       
    }
}

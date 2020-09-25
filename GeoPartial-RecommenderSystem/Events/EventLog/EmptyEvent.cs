using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace GeoPartial_RecommenderSystem.Events.EventLog
{
    class EmptyEvent : Event
    {
        public override Panel CreatePanel()
        {
            throw new NotImplementedException();
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }

        public override XElement ToXElement(XNamespace ns)
        {
            throw new NotImplementedException();
        }
    }
}

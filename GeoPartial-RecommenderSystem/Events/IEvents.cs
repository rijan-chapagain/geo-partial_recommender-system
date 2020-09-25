
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace GeoPartial_RecommenderSystem.Events
{
    interface IEvents
    {    
        XElement ToXElement(XNamespace ns);
        void Render();
        Panel CreatePanel();
    }
}

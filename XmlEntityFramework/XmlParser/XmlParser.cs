using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlEntityFramework.XmlParser
{
    class XmlParser
    {
        public void ParseFromString(string xmlData)
        {
            XDocument doc = XDocument.Parse(xmlData); //or XDocument.Load(path)
            string jsonText = JsonConvert.SerializeXNode(doc);
            dynamic dyn = JsonConvert.DeserializeObject<ExpandoObject>(jsonText);
        }

        public void ParseFromFile(string path)
        {

        }
    }
}

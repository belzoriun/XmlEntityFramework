using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlEntityFramework.XmlParser
{
    class XmlParser
    {
        public dynamic Parse(string xmlData)
        {
            XDocument doc = XDocument.Parse(xmlData); //or XDocument.Load(path)
            string jsonText = JsonConvert.SerializeXNode(doc);
            return JsonConvert.DeserializeObject<ExpandoObject>(jsonText);
        }
    }
}

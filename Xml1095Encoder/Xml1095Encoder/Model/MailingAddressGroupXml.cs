using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class MailingAddressGroupXml
    {
        private UsAddressGroupXml _usAddressGroupXml; 

        [XmlElement(ElementName = "UsAddressGrp")]
        public UsAddressGroupXml UsAddressGroupXml
        {
            get { return _usAddressGroupXml; }
            set { _usAddressGroupXml = value; }
        }

        private MailingAddressGroupXml() { }

        public MailingAddressGroupXml(UsAddressGroupXml usAddressGroupXml)
        {
            _usAddressGroupXml = usAddressGroupXml;
        }
    }
}

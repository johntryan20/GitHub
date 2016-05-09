using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class BusinessNameXml
    {
        string _businessNameLine1Txt;
        string _businessNameLine2Txt;

        [XmlElement(ElementName = "BusinessNameLine1Txt")]
        public string businessNameLine1Txt
        {
            get { return _businessNameLine1Txt; }
            set { _businessNameLine1Txt = value; }
        }

        [XmlElement(ElementName = "BusinessNameLine2Txt")]
        public string businessNameLine2Txt
        {
            get { return _businessNameLine2Txt; }
            set { _businessNameLine2Txt = value; }
        }

        private BusinessNameXml() {}

        public BusinessNameXml(string businessNameLine1Txt, string businessNameLine2Txt) 
        {
            _businessNameLine1Txt = businessNameLine1Txt;
            _businessNameLine2Txt = businessNameLine2Txt;
        }    
    
    }
}

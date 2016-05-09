using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class UsAddressGroupXml
    {
        string _addressLine1Txt;
        string _addressLine2Txt;
        string _cityNm;
        string _usStateCode;
        string _usZipCode;
        string _usZipCodeExtensionCode; 

        [XmlElement(ElementName = "AddressLine1Txt", Order = 1)]
        public string addressLine1Txt
        {
            get { return _addressLine1Txt; }
            set { _addressLine1Txt = value; }
        }

        [XmlElement(ElementName = "AddressLine2Txt", Order = 2)]
        public string addressLine2Txt
        {
            get { return _addressLine2Txt; }
            set { _addressLine2Txt = value; }
        }

        [XmlElement(ElementName = "CityNm", Order = 3, Namespace = "urn:us:gov:treasury:irs:common")]
        public string cityNm
        {
            get { return _cityNm; }
            set { _cityNm = value; }
        }

        [XmlElement(ElementName = "USStateCd", Order = 4)]
        public string usStateCode
        {
            get { return _usStateCode; }
            set { _usStateCode = value; }
        }

        [XmlElement(ElementName = "USZIPCd", Order = 5, Namespace = "urn:us:gov:treasury:irs:common")]
        public string usZipCode
        {
            get { return _usZipCode; }
            set { _usZipCode = value; }
        }

        [XmlElement(ElementName = "USZIPExtensionCd", Order = 6, Namespace = "urn:us:gov:treasury:irs:common")]
        public string usZipCodeExtensionCode
        {
            get { return _usZipCodeExtensionCode; }
            set { _usZipCodeExtensionCode = value; }
        }

        private UsAddressGroupXml() { }

        public UsAddressGroupXml(string addressLine1Txt, string addressLine2Txt, string cityNm, string usStateCode, string usZipCode, string usZipCodeExtensionCode)
        {
            _addressLine1Txt = addressLine1Txt;
            _addressLine2Txt = addressLine2Txt;
            _cityNm = cityNm;
            _usStateCode = usStateCode;
            _usZipCode = usZipCode;
            _usZipCodeExtensionCode = usZipCodeExtensionCode;
        }
    }
}

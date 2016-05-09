using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class SponsoringEmployerInfoGroupXml
    {
        BusinessNameXml _businessName;
        string _businessNameControlTxt;
        string _tinRequestTypeCd;
        string _employerIdentificationNumber;
        string _contactPhoneNumber;
        MailingAddressGroupXml _mailingAddressGroup;

        [XmlElement(ElementName = "BusinessName", Order = 1)]
        public BusinessNameXml BusinessName
        {
            get { return _businessName; }
            set { _businessName = value; }
        }

        [XmlElement(ElementName = "BusinessNameControlTxt", Order = 2)]
        public string BusinessNameControlTxt
        {
            get { return _businessNameControlTxt; }
            set { _businessNameControlTxt = value; }
        }

        [XmlElement(ElementName = "TINRequestTypeCd", Order = 3, Namespace = "urn:us:gov:treasury:irs:common")]
        public string TaxIdentificationRequestTypeCode
        {
            get { return _tinRequestTypeCd; }
            set { _tinRequestTypeCd = value; }
        }

        [XmlElement(ElementName = "EIN", Order = 4, Namespace = "urn:us:gov:treasury:irs:common")]
        public string EmployerIndentificationNumber
        {
            get { return _employerIdentificationNumber; }
            set { _employerIdentificationNumber = value; }
        }

        [XmlElement(ElementName = "ContactPhoneNum", Order = 5)]
        public string ContactPhoneNumber
        {
            get { return _contactPhoneNumber; }
            set { _contactPhoneNumber = value; }
        }

        [XmlElement(ElementName = "MailingAddressGrp", Order = 6)]
        public MailingAddressGroupXml MailingAddressGroup
        {
            get { return _mailingAddressGroup; }
            set { _mailingAddressGroup = value; }
        }

        private SponsoringEmployerInfoGroupXml() { }

        public SponsoringEmployerInfoGroupXml(BusinessNameXml businessName, string businessNameControlTxt, string tinRequestTypeCd
                                             , string employerIdentificationNumber, string contactPhoneNumber, MailingAddressGroupXml mailingAddressGroup)
        {
            _businessName = businessName;
            _businessNameControlTxt = businessNameControlTxt;
            _tinRequestTypeCd = tinRequestTypeCd;
            _employerIdentificationNumber = employerIdentificationNumber;
            _contactPhoneNumber = contactPhoneNumber;
            _mailingAddressGroup = mailingAddressGroup;
        }
    }
}

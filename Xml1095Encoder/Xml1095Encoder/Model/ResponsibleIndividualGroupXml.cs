using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class ResponsibleIndividualGroupXml
    {
        ResponsibleIndividualNameXml _responsibleIndividualName;
        string _personNameControlTxt;
        string _tinRequestTypeCd;
        string _socialSecurityNumber;
        string _birthDt;
        string _policyOriginCd;
        string _shopIdentificationNum;
        MailingAddressGroupXml _mailingAddress;

        [XmlElement(ElementName = "ResponsibleIndividualName", Order = 1)]
        public ResponsibleIndividualNameXml ResponsibleIndividualName
        {
            get { return _responsibleIndividualName; }
            set { _responsibleIndividualName = value; }
        }

        [XmlElement(ElementName = "PersonNameControlTxt", Order = 2)]
        public string personNameControlTxt
        {
            get { return _personNameControlTxt; }
            set { _personNameControlTxt = value; }
        }

        [XmlElement(ElementName = "TINReqwuestTypeCd", Order = 3, Namespace = "urn:us:gov:treasury:irs:common")]
        public string tinRequestTypeCd
        {
            get { return _tinRequestTypeCd; }
            set { _tinRequestTypeCd = value; }
        }

        [XmlElement(ElementName = "SSN", Order = 4, Namespace = "urn:us:gov:treasury:irs:common")]
        public string socialSecurityNumber
        {
            get { return _socialSecurityNumber; }
            set { _socialSecurityNumber = value; }
        }

        [XmlElement(ElementName = "BirthDt", Order = 5, Namespace = "urn:us:gov:treasury:irs:common")]
        public string dateOfBirth
        {
            get { return _birthDt; }
            set { _birthDt = value; }
        }

        [XmlElement(ElementName = "MailingAddressGrp", Order = 6)]
        public MailingAddressGroupXml MailingAddressGroup
        {
            get { return _mailingAddress; }
            set { _mailingAddress = value; }
        }

        [XmlElement(ElementName = "PolicyOriginCd", Order = 7)]
        public string policyOriginCd
        {
            get { return _policyOriginCd; }
            set { _policyOriginCd = value; }
        }
        
        [XmlElement(ElementName = "SHOPIdentificationNum", Order = 8, Namespace = "urn:us:gov:treasury:irs:common")]
        public string shopIdentificationNum
        {
            get { return _shopIdentificationNum; }
            set { _shopIdentificationNum = value; }
        }

/*
        [XmlArrayItem(ElementName = "CorrectedRecordPayeeName")]
        public List<ResponsibleIndividualNameXml> ResponsibleIndividualName { get; set; }
*/
        private ResponsibleIndividualGroupXml() {}

        public ResponsibleIndividualGroupXml(ResponsibleIndividualNameXml reponsibleIndividualName, string personNameControlTxt, string tinRequestTypeCd, string socialSecurityNumber, string birthDt, MailingAddressGroupXml mailingAddress
                                             ,string policyOriginCd, string shopIdentificationNum) 
        {
            _responsibleIndividualName = reponsibleIndividualName;
            _personNameControlTxt = personNameControlTxt;
            _tinRequestTypeCd = tinRequestTypeCd;
            _socialSecurityNumber = socialSecurityNumber;
            _birthDt = birthDt;
            _mailingAddress = mailingAddress;
            _policyOriginCd = policyOriginCd;
            _shopIdentificationNum = shopIdentificationNum;

        }    


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class CoveredIndividualGroupXml
    {

        CoveredIndividualNameXml _coveredIndividualNameXml;
        string _personNameControlTxt;
        string _tinRequestTypeCd;
        string _socialSecurityNumber;
        string _birthDt;
        string _coveredIndividualGroupInd;
        CoveredIndividualMonthlyIndGroupXml _coveredIndividualMonthlyIndGroupXml;

        [XmlElement(ElementName = "CoveredIndividualName", Order = 1)]
        public CoveredIndividualNameXml CoveredIndividualName
        {
            get { return _coveredIndividualNameXml; }
            set { _coveredIndividualNameXml = value; }
        }

        [XmlElement(ElementName = "PersonNameControlTxt", Order = 2)]
        public string PersonNameControlTxt
        {
            get { return _personNameControlTxt; }
            set { _personNameControlTxt = value; }
        }

        [XmlElement(ElementName = "TINRequestTypeCode", Order = 3, Namespace = "urn:us:gov:treasury:irs:common")]
        public string TaxIdentificationNumberTypeCode
        {
            get { return _tinRequestTypeCd; }
            set { _tinRequestTypeCd = value; }
        }

        [XmlElement(ElementName = "SSN", Order = 4, Namespace = "urn:us:gov:treasury:irs:common")]
        public string SocialSecurityNumber
        {
            get { return _socialSecurityNumber; }
            set { _socialSecurityNumber = value; }
        }

        [XmlElement(ElementName = "BirthDt", Order = 5, Namespace = "urn:us:gov:treasury:irs:common")]
        public string DateOfBirth
        {
            get { return _birthDt; }
            set { _birthDt = value; }
        }

        [XmlElement(ElementName = "CoveredIndividualAnnualInd", Order = 6)]
        public string CoveredIndividualAnnualInd
        {
            get { return _coveredIndividualGroupInd; }
            set { _coveredIndividualGroupInd = value; }
        }

        [XmlElement(ElementName = "CoveredIndividualMonthlyIndGrp", Order = 7)]
        public CoveredIndividualMonthlyIndGroupXml CoveredIndividualMonthlyIndGroup
        {
            get { return _coveredIndividualMonthlyIndGroupXml; }
            set { _coveredIndividualMonthlyIndGroupXml = value; }
        }

        private CoveredIndividualGroupXml(){}

        public CoveredIndividualGroupXml(CoveredIndividualNameXml coveredIndividualNameXml, string personNameControlTxt, string tinRequestTypeCode, string ssn, string birthDt, string coveredIndividualAnnualInd
                                        ,CoveredIndividualMonthlyIndGroupXml coveredIndividualMonthlyIndGroupXml) 
        {
            _coveredIndividualNameXml = coveredIndividualNameXml;
            _personNameControlTxt = personNameControlTxt;
            _tinRequestTypeCd = tinRequestTypeCode;
            _socialSecurityNumber = ssn;
            _birthDt = birthDt;
            _coveredIndividualGroupInd = coveredIndividualAnnualInd;
            _coveredIndividualMonthlyIndGroupXml = coveredIndividualMonthlyIndGroupXml;
        }    

    }
}

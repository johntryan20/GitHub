using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    [XmlType(TypeName = "Form1095BUpstreamDetail" ,Namespace = "irs")]
    
    [Serializable]
    public class Form1095Xml
    {
        [XmlAttribute(AttributeName = "lineNum")]
        public string lineNum {get; set;}

        [XmlAttribute(AttributeName = "recordType")]
        public string recordType { get; set; }

        [XmlElement(ElementName = "RecordId", Order = 1)]
        public string recordId { get; set; }

        [XmlElement(ElementName = "TestScenarioId", Order = 2)]
        public string testScenarioId { get; set; }

        [XmlElement(ElementName = "CorrectedInd", Order = 3)]
        public string correctedInd { get; set; }

        [XmlElement(ElementName = "CorrectedRecordInfoGrp", Order = 4)]
        public List<CorrectedRecordInfoGroupXml> correctedRecord = new List<CorrectedRecordInfoGroupXml>();

        [XmlElement(ElementName = "TaxYr", Order = 5, Namespace = "urn:us:gov:treasury:irs:common")]
        public string taxYear { get; set; }

        [XmlElement(ElementName = "ResponsibleIndividualGrp", Order = 6)]
        public List<ResponsibleIndividualGroupXml> responsibleIndividualGroup = new List<ResponsibleIndividualGroupXml>();

        [XmlElement(ElementName = "SponsoringEmployerInfoGrp", Order = 7)]
        public List<SponsoringEmployerInfoGroupXml> sponsoringEmployerInfoGroup = new List<SponsoringEmployerInfoGroupXml>();

        [XmlElement(ElementName = "IssuerInfoGrp", Order = 8)]
        public List<IssuerInfoGroupXml> issuerInfoGroup = new List<IssuerInfoGroupXml>();

        [XmlElement(ElementName = "CoveredIndividualGrp", Order = 9)]
        public List<CoveredIndividualGroupXml> coveredIndividualGroup = new List<CoveredIndividualGroupXml>();

    }


}

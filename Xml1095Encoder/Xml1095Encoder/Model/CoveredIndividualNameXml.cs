using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class CoveredIndividualNameXml
    {
        string _personFirstNm; 
        string _personLastNm; 
        string _personMiddleNm; 
        string _suffixNm; 

        [XmlElement(ElementName = "PersonFirstNm")]
        public string PersonFirstName
        {
            get { return _personFirstNm; }
            set { _personFirstNm = value; }
        }

        [XmlElement(ElementName = "PersonMiddleNm")]
        public string PersonMiddleName
        {
            get { return _personMiddleNm; }
            set { _personMiddleNm = value; }
        }

        [XmlElement(ElementName = "PersonLastNm")]
        public string PersonLastName
        {
            get { return _personMiddleNm; }
            set { _personMiddleNm = value; }
        }

        [XmlElement(ElementName = "SuffixNm")]
        public string SuffixName
        {
            get { return _suffixNm; }
            set { _suffixNm = value; }
        }

        private CoveredIndividualNameXml() { }

        public CoveredIndividualNameXml(string personFirstNm, string PersonMiddleNm, string PersonLastNm, string PersonSuffixNm)
        {
            _personFirstNm = personFirstNm;
            _personMiddleNm  = PersonMiddleNm;
            _personLastNm = PersonLastNm;
            _suffixNm = PersonSuffixNm;
        }

    }
}

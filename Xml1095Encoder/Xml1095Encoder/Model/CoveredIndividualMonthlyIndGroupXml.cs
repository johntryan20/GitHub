using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class CoveredIndividualMonthlyIndGroupXml
    {
        string _januaryIndicator; 
        string _februaryIndicator; 
        string _marchIndicator; 
        string _aprilIndicator; 
        string _mayIndicator; 
        string _juneIndicator; 
        string _julyIndicator; 
        string _augustIndicator; 
        string _septemberIndicator; 
        string _octoberIndicator; 
        string _novemberIndicator; 
        string _decemberIndicator; 

        [XmlElement(ElementName = "JanuaryInd")]
        public string JanuaryIndicator
        {
            get { return _januaryIndicator; }
            set { _januaryIndicator = value; }
        }

        [XmlElement(ElementName = "FebruaryInd")]
        public string FebruaryIndicator
        {
            get { return _februaryIndicator; }
            set { _februaryIndicator = value; }
        }

        [XmlElement(ElementName = "MarchInd")]
        public string MarchIndicator
        {
            get { return _marchIndicator; }
            set { _marchIndicator = value; }
        }

        [XmlElement(ElementName = "AprilInd")]
        public string AprilIndicator
        {
            get { return _aprilIndicator; }
            set { _aprilIndicator = value; }
        }

        [XmlElement(ElementName = "MayInd")]
        public string MayIndicator
        {
            get { return _mayIndicator; }
            set { _mayIndicator = value; }
        }

        [XmlElement(ElementName = "JuneInd")]
        public string JuneIndicator
        {
            get { return _juneIndicator; }
            set { _juneIndicator = value; }
        }

        [XmlElement(ElementName = "JulyInd")]
        public string JulyIndicator
        {
            get { return _julyIndicator; }
            set { _julyIndicator = value; }
        }

        [XmlElement(ElementName = "AugustInd")]
        public string AugustIndicator
        {
            get { return _augustIndicator; }
            set { _augustIndicator = value; }
        }

        [XmlElement(ElementName = "SeptemberInd")]
        public string SeptemberIndicator
        {
            get { return _septemberIndicator; }
            set { _septemberIndicator = value; }
        }

        [XmlElement(ElementName = "OctoberInd")]
        public string OctoberIndicator
        {
            get { return _octoberIndicator; }
            set { _octoberIndicator = value; }
        }

        [XmlElement(ElementName = "NovemberInd")]
        public string NovemberIndicator
        {
            get { return _novemberIndicator; }
            set { _novemberIndicator = value; }
        }

        [XmlElement(ElementName = "DecemberInd")]
        public string DecemberIndicator
        {
            get { return _decemberIndicator; }
            set { _decemberIndicator = value; }
        }

        private CoveredIndividualMonthlyIndGroupXml() { }

        public CoveredIndividualMonthlyIndGroupXml(string januaryIndicator, string februaryIndicator, string marchIndicator, string aprilIndicator, string mayIndicator,
                                                   string juneIndicator, string julyIndicator, string augustIndicator, string septemberIndicator, string octoberIndicator,
                                                   string novemberIndicator, string decemberIndicator)
        {
            _januaryIndicator = januaryIndicator;
            _februaryIndicator = februaryIndicator;
            _marchIndicator = marchIndicator;
            _aprilIndicator = aprilIndicator;
            _mayIndicator = mayIndicator;
            _juneIndicator = juneIndicator;
            _julyIndicator = julyIndicator;
            _augustIndicator = augustIndicator;
            _septemberIndicator = septemberIndicator;
            _octoberIndicator = octoberIndicator;
            _novemberIndicator = novemberIndicator;
            _decemberIndicator = decemberIndicator;
        }
    }
}

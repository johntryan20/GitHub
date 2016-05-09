using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class CorrectedRecordInfoGroupXml
    {
        string _correctedUniqueRecordId;
        CorrectedRecordPayeeNameXml _correctedRecordPayeeName;
        string _correctedRecordPayeeTin; 

        [XmlElement(ElementName = "CorrectedUniqueRecordId", Order = 1)]
        public string CorrectedUniqueRecordId
        {
            get { return _correctedUniqueRecordId; }
            set { _correctedUniqueRecordId = value; }
        }

        [XmlElement(ElementName = "CorrectedRecordPayeeName", Order = 2)]
        public CorrectedRecordPayeeNameXml CorrectedRecordPayeeName
        {
            get { return _correctedRecordPayeeName; }
            set { _correctedRecordPayeeName = value; }
        }

        [XmlElement(ElementName = "CorrectedRecordPayeeTin", Order = 3)]
        public string CorrectedRecordPayeeTin
        {
            get { return _correctedRecordPayeeTin; }
            set { _correctedRecordPayeeTin = value; }
        }

        private CorrectedRecordInfoGroupXml() { }

        public CorrectedRecordInfoGroupXml(string correctedUniqueRecordId, CorrectedRecordPayeeNameXml correctedRecordPayeeName, string corrrectedRecordPayeeTin)
        {
            _correctedUniqueRecordId = correctedUniqueRecordId;
            _correctedRecordPayeeName = correctedRecordPayeeName;
            _correctedRecordPayeeTin = corrrectedRecordPayeeTin;
        }


    }
}

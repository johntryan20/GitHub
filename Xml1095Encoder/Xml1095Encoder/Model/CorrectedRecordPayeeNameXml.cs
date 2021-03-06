﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    public class CorrectedRecordPayeeNameXml
    {
        string _firstName; 
        string _middleName;
        string _lastName;

        [XmlElement(ElementName = "PersonFirstNm")]
        public string personFirstName { 
                                        get {return _firstName; } 
                                        set {_firstName = value; }
                                      }

        [XmlElement(ElementName = "PersonMiddleNm")]
        public string personMiddleName { 
                                         get {return _middleName; } 
                                         set {_middleName = value; }
                                       }

        [XmlElement(ElementName = "PersonLastNm")]
         public string personLastName { 
                                          get {return _lastName; } 
                                          set {_lastName = value; }
                                      }

        private CorrectedRecordPayeeNameXml() {}

        public CorrectedRecordPayeeNameXml(string firstName, string middleName, string lastName) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _middleName = middleName;
        }    
    }
}

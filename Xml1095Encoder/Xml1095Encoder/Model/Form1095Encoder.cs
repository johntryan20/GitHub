using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Xml1095Encoder.Model
{
    class Form1095Encoder
    {
        /// <summary>
        /// Returns 1095 data
        /// </summary>
        /// <returns></returns>
        public DataTable GetData()
        {
            DataTable data1095 = new DataTable();
            return data1095;
        }

        /// <summary>
        /// Write Results to XML File
        /// </summary>
        public void WriteFile()
        {
            // Step 1: Build 1095 Object
            Form1095Xml xml = new Form1095Xml();
            xml.lineNum = "0";
            xml.recordType = "String";

            xml.recordId = "1";
            xml.testScenarioId = "2";
            xml.correctedInd = "1";
            xml.taxYear = "2015";

            XmlSerializerNamespaces myNamespaces = new XmlSerializerNamespaces();
            myNamespaces.Add("irs", "urn:us:gov:treasury:irs:common");
            
            // Add Responsible Individual Info 
            xml.responsibleIndividualGroup.Add(new ResponsibleIndividualGroupXml(new ResponsibleIndividualNameXml("John","T","Ryan","")
                                              ,"John Ryan"
                                              ,"INDIVIDUAL_TIN"
                                              ,"111-11-1111"
                                              ,"09/07/1981"
                                              ,new MailingAddressGroupXml(new UsAddressGroupXml("123 Fake St.","","Denver","CO","80002","1234"))
                                              ,"a"
                                              ,"123")                                              
                                              );

            // Add Covered Individual Group Info 
            xml.coveredIndividualGroup.Add(new CoveredIndividualGroupXml(new CoveredIndividualNameXml("John","Thomas","Ryan","")
                                                                        ,"John T. Ryan"
                                                                        ,"TIN"
                                                                        ,"999-99-9999"
                                                                        ,"09/09/1909"
                                                                        ,"1"
                                                                        ,new CoveredIndividualMonthlyIndGroupXml("1","1","1","1","1","1","1","1","1","1","1","1"))
                                          );

            // Add Corrected Record Info
            xml.correctedRecord.Add(new CorrectedRecordInfoGroupXml("correctedUniqueRecordId"
                                                                   ,new CorrectedRecordPayeeNameXml("John","T","Ryan")
                                                                   ,"corrrectedRecordPayeeTin")
                                   );
        

            // Add Sponsering Employer Group Info 
            xml.sponsoringEmployerInfoGroup.Add(new SponsoringEmployerInfoGroupXml(new BusinessNameXml("MyBusiness","Business2")
                                               ,"businessControlText"
                                               ,"tinRequestTypeCd"
                                               ,"111111111111"
                                               ,"303-123-1234"
                                               ,new MailingAddressGroupXml(new UsAddressGroupXml("123 Fake St.","Ste. 123","Denver","CO","12343","1234"))));

            // Add Issuer Info Group
            xml.issuerInfoGroup.Add(new IssuerInfoGroupXml(new BusinessNameXml("businessNameLine1","businessNameLine2")
                                   ,"businessNameControlTxt"
                                   ,"tinRequestTypeCd"
                                   ,"employerIdentificationNumber"
                                   ,"contactPhoneNumber"
                                   ,new MailingAddressGroupXml(new UsAddressGroupXml("addressLine1"
                                                                                    ,"addressLine2"
                                                                                    ,"cityNm"
                                                                                    ,"usStateCd"
                                                                                    ,"usZipCode"
                                                                                    ,"usZipCodeExtensionCode")))
                                   );

            // Step 2: Write Xml Serialized Object To File
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(xml.GetType());

            // Test Code 
            using (XmlWriter xmlWriter = XmlWriter.Create("JohnR.xml"))
            {

                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("HI");

                xmlWriter.WriteStartElement("Employee");

                xmlWriter.WriteElementString("ID", "1234");   // <-- These are new
                xmlWriter.WriteElementString("FirstName", "John");
                xmlWriter.WriteElementString("LastName", "Ryan");
                xmlWriter.WriteElementString("Salary", "$0.00");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }            
            // End of Test Code

            //xmlDoc.DocumentElement.WriteTo(xmlWriter); 

            // Creates a stream whose backing store is memory. 
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, xml);
                xmlStream.Position = 0;
                //Loads the XML document from the specified string.
                xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmlDoc.Load(xmlStream);
/*
 * TODO: Prefix Code (i.e. <irs:taxYear>2015</taxYear>
                var node = xmlDoc.CreateElement("irs",xml.taxYear.ToString(),"irs" );
                XmlElement taxYearElement = xmlDoc.DocumentElement;
                taxYearElement.Prefix = "irs";
*/
                // TODO: Fix this so we can specify file location
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
                System.IO.FileStream file = System.IO.File.Create(path);

                xmlSerializer.Serialize(file, xml, myNamespaces);
                file.Close();            
            }
        }
    }
}

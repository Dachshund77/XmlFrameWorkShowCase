using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlFrameWorkShowCase.InterfaceApproache
{
    public abstract class XmlStream
    {
        protected string OutPath { get; set; }
        protected XmlReaderSettings xmlReaderSettings { get; set; } //Case to be amde to mkae them public
        protected XmlWriterSettings xmlWriterSettings { get; set; }

        public XmlStream()
        {
            //Default Writer settings
            this.xmlWriterSettings = new XmlWriterSettings();  

            //Default Reader settings
            this.xmlReaderSettings = new XmlReaderSettings();
            this.xmlReaderSettings.XmlResolver = new XmlUrlResolver();
            this.xmlReaderSettings.IgnoreWhitespace = true;
        }

        public XmlStream(string outPath)
            :this()
        {
            this.OutPath = OutPath;
        }

        public XmlStream(string outPath, string externalDTD)
        {

        }

        protected IEnumerable<IXmlStreamable> ReadXml()
        {
            //Init values 

            //Read

            //Return
        }

        protected bool WriteXml(IEnumerable<IXmlStreamable> xmlStreamables)
        {
            //Init values 

            //Read

            //Return
        }


    }

}

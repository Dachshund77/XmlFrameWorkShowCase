using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlFrameWorkShowCase.InterfaceApproache
{
    public interface IXmlStreamable
    {

        bool ReadXml();

        XElement WriteXml();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlFrameWorkShowCase.InterfaceApproache
{
    public class GenericXmlStream<T> : XmlStream where T : IXmlStreamable, new()
    {
        public GenericXmlStream(String outPutPath)
        {
            //Base should define a base behaviour
            
        }
    }
}

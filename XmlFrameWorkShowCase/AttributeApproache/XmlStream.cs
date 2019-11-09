using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XmlFrameWorkShowCase
{
    public class XmlStream
    {


        public void read()
        {


        }

        public void Write(object obj)
        {
            //We need Default root

            //Check for XmlObject tag
            //If present the Xml Element should be called differently else default name
            string name = obj.GetType().Name;
            Console.WriteLine("Obj name is {0}", name);

            //Check properties
            //if Either attribute or Element is present add corresponding 
            //If list we call deeper

            //Check the Fields
            //if Either attribute or Element is present add corresponding 
            //If list we call deeper

            obj.GetType().getPro

            PropertyInfo[] info = obj.GetType().GetProperties();
            foreach (PropertyInfo item in info)
            {
                Attribute test = item.GetCustomAttribute(typeof(Xml));
                Console.WriteLine("Atribute was {0}", test?.ToString());
                Console.WriteLine("Value was {0}", item.GetValue(obj).ToString());

            }

          

            
        }

        private Dictionary<PropertyInfo, Xml> GetXmlProperties(Object obj)
        {

        }

        private Dictionary<FieldInfo, Xml> GetXmlFields(Object obj)
        {

        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlFrameWorkShowCase
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWritable testWritable = new TestWritable();

            XmlStream xmlStream = new XmlStream();

            xmlStream.Write(testWritable);



            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}

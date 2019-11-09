using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlFrameWorkShowCase
{
    class TestWritable
    {
        [Xml]
        private int fieldInt1 = 5;

        private int fieldInt2 = 7;

        private int? nullTest = null;

        private string fieldString3 = "this is field 3";

        private string fieldString4 = "This is field 4";

        [Xml]
        public int PropertyInt1 { get; set; } 

        public int PropertyInt2 { get; set; }

        //not geeter?
        
        public string PropertString { get; set; }

        public TestWritable()
        {
            this.PropertyInt1 = 4124;
            this.PropertyInt2 = 4212;
            this.PropertString = "A propery String";
        }
    }
}

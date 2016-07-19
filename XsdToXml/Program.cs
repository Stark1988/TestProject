using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XsdToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new MyClass { Field1 = "Kavin", Field2 = "Shah" };
            var serializer = new XmlSerializer(typeof(MyClass));
            using (var stream = new StreamWriter("g:\\test.xml"))
            {
                serializer.Serialize(stream, data);
            }


           
        }
    }
}

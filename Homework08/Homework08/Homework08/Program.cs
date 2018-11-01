using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Homework08
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = XDocument.Load("C:\temp\readfile.xml").
                XPathSelectElements("//response").Count();

            Console.WriteLine(count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Homework08
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument readfile = new XmlDocument();
            readfile.Load("readfile.xml");

            //int  count = readfile.SelectNodes("survey/question/response").Count;
            int countN = readfile.SelectNodes("survey/question[1]/response[. = \"N\"]").Count;
            int countY = readfile.SelectNodes("survey/question[1]/response[. = \"Y\"]").Count;

            int countN2 = readfile.SelectNodes("survey/question[2]/response[. = \"N\"]").Count;
            int countY2 = readfile.SelectNodes("survey/question[2]/response[. = \"Y\"]").Count;

            Console.WriteLine("Question 1: Yes="+ countY + "  No=" + countN);
            Console.WriteLine("Question 2: Yes=" + countY2 + "  No=" + countN2);
        }
    }
}

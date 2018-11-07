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

            Console.WriteLine("Enter xml File: ");
            string path = Console.ReadLine().ToString();
            //string path = @"H:\Data202\Data202\Homework08\Homework08\Homework08\bin\Debug\readfile.xml";

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;

            XmlReader xmlIn = XmlReader.Create(path, settings);

            int countN = readfile.SelectNodes("survey /question[0]/response[. = \"N\"]").Count;
            int countY = readfile.SelectNodes("survey/question[0]/response[. = \"Y\"]").Count;
            int count = 1;
            while (xmlIn.Read())
            {
                if (xmlIn.NodeType == XmlNodeType.Element &&
                    xmlIn.Name == "question")
                {
                    countN = readfile.SelectNodes("survey/question["+count+"]/response[. = \"N\"]").Count;
                    countY = readfile.SelectNodes("survey/question["+count+"]/ response[. = \"Y\"]").Count;
                    
                    Console.WriteLine("Question "+ count+ ":" + 
                        "Yes=" + countY + "  No=" + countN);
                    count++;
                }
   
            }

            //option 2
            //int countN = readfile.SelectNodes("survey/question[1]/response[. = \"N\"]").Count;
            //int countY = readfile.SelectNodes("survey/question[1]/response[. = \"Y\"]").Count;

            // int countN2 = readfile.SelectNodes("survey/question[2]/response[. = \"N\"]").Count;
            //int countY2 = readfile.SelectNodes("survey/question[2]/response[. = \"Y\"]").Count;

            //Console.WriteLine("Question 1: Yes=" + countY + "  No=" + countN);

            //Console.WriteLine("Question 2: Yes=" + countY2 + "  No=" + countN2);
            

        }
    }
}

            
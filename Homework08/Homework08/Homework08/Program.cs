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
            //read the input file form user
            Console.WriteLine("Enter xml File: ");
            string path = Console.ReadLine().ToString();

            //loads user input file as a xml document
            XmlDocument readfile = new XmlDocument();
            readfile.Load(path);

            //??
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;

            //creates path to for the xmlreader
            XmlReader xmlIn = XmlReader.Create(path, settings);

            // Select nodes starting at index question 0 and get count of Y and N
            int countN = readfile.SelectNodes("survey /question[0]/response[. = \"N\"]").Count;
            int countY = readfile.SelectNodes("survey/question[0]/response[. = \"Y\"]").Count;

            // initiate count to go to the next question response
            int count = 1;

            // while xmlIn is reading the file
            while (xmlIn.Read())
            {
                // if loop if the name is question and th xmlin is a nodetype of element
                if (xmlIn.NodeType == XmlNodeType.Element &&
                    xmlIn.Name == "question")
                {
                    //select the nodes of the Y and N at question index count && count the file
                    countN = readfile.SelectNodes("survey/question["+count+"]/response[. = \"N\"]").Count;
                    countY = readfile.SelectNodes("survey/question["+count+"]/ response[. = \"Y\"]").Count;
                    // write out the result
                    Console.WriteLine("Question "+ count+ ":" + 
                        "Yes=" + countY + "  No=" + countN);
                    // incrememnt count of the index to move on to the next question responses
                    count++;
                }
   
            }

            /*
            option 2
            int countN = readfile.SelectNodes("survey/question[1]/response[. = \"N\"]").Count;
            int countY = readfile.SelectNodes("survey/question[1]/response[. = \"Y\"]").Count;

            int countN2 = readfile.SelectNodes("survey/question[2]/response[. = \"N\"]").Count;
            int countY2 = readfile.SelectNodes("survey/question[2]/response[. = \"Y\"]").Count;

            Console.WriteLine("Question 1: Yes=" + countY + "  No=" + countN);

            Console.WriteLine("Question 2: Yes=" + countY2 + "  No=" + countN2);
            */
        }
    }
}

            
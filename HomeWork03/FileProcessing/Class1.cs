using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using log4net;
using System.Diagnostics;

namespace FileProcessing
{
    public class ProcessTxt
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
               (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public StringBuilder tStr = new StringBuilder(); // string builder for appending to the the txt file
        public Dictionary<string, int> tDict = new Dictionary<string, int>(); // creates a dict for the coutn and the unique word

        public void doString(string InFile, string OFile)
        {

            File.WriteAllText(OFile, ""); // clears out the ofolder text file so it does not pile up

            StreamWriter sr = new StreamWriter(new FileStream(OFile,
                    FileMode.Append, FileAccess.Write)); // creates a file for word count
            string readF = File.ReadAllText(InFile); // read in the user input file and text

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string demoS = readF;
            string[] words = demoS.Split(delimiterChars,
                            StringSplitOptions.RemoveEmptyEntries);

            foreach (string x in words) // loops through the input file
            {
                if (tDict.ContainsKey(x))
                    tDict[x] = tDict[x] + 1;
                else
                    tDict[x] = 1; // increase count 1
            }

            foreach (KeyValuePair<string, int> entry in tDict) // Concats the coutn and unique word
            {
                tStr.Append("Word: " + entry.Key.ToString() + ", " + entry.Value.ToString() + Environment.NewLine);
            }

            sr.WriteLine(tStr);
            sr.Close();
            sr.Dispose();
        }
        public string GettStr()
        {
            return tStr.ToString();
        }

        public string GettDict()
        {
            return tDict.ToString();
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_without
{
    
    class fileAverage
    {
        List<string> listIn = new List<string>();

       public int readInFile(string fileName)
        {
            int totalLines=0;
            try {
                string readLine;
                StreamReader fR = new StreamReader(fileName);
                while (!fR.EndOfStream)
                {
                    readLine = fR.ReadLine();
                    listIn.Add(readLine);
                }
            }
            catch(Exception tE)
            {
                throw tE;
            }
            totalLines = listIn.Count();
            return totalLines;
        }

       public void processWithSerial()
        {
            if (listIn.Count() == 0)
            {
                Exception general = new Exception("No items to process");
                throw general;
            }

            foreach(string tS in listIn)
            {
                baseProcess(tS);
            }
        }

       public void processWithParallel()
        {
            Parallel.ForEach(listIn, curline => baseProcess(curline));
        }

       public long baseProcess(string evaluate)
        {
            long average = 0;
            string[] sTemp = evaluate.Split(',');
            for (int i = 0; i < sTemp.Length; i++)
            {
                average += Int64.Parse(sTemp[i]);

            }
            return average /= sTemp.Length;
        }
    }
}

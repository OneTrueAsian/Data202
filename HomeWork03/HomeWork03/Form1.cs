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
using System.Windows.Forms;
using System.Diagnostics;

//example at https://stackoverflow.com/questions/9805281/writing-logs-to-file
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string oFolder;
        public string iFolder;


        public Form1()
        {
            InitializeComponent();
        }

        // Write To File
        private void button2_Click(object sender, EventArgs e)
        {

            StreamWriter sr =
                new StreamWriter(new FileStream(@"C:\temp\Demo.txt",
            FileMode.Append,
            FileAccess.Write)); 
            //sr.WriteLine(textBox1.Text);
            sr.Close();
            sr.Dispose();

            MessageBox.Show("Message Sent");
            Process.Start(@"C:\temp\Demo.txt"); // Opens the File

            //Time Stamp
            Console.WriteLine("Starting");
            log.Info("Read Input!");
            MessageBox.Show("Write to file Logged");
        }

        // Select the input file
        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            iFolder = folderBrowserDialog1.SelectedPath;

            string[] files = Directory.GetFiles(iFolder); // Add files within file path to array

            
            int i; // Index of last file path "\" character
            string f; // File name

            foreach (string fname in files)
            {
                i = fname.LastIndexOf('\\') + 1;
                f = fname.Substring(i);
                if (f.EndsWith(".txt")) { comboBox1.Items.Add(f); }
            }
        }

        // Select the output file
        private void button1_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            oFolder = folderBrowserDialog1.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e){}

        // Word Count
        private void button5_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\temp\FileThis.txt");
            
            StreamWriter sr = new StreamWriter(new FileStream(@"C:\temp\FileThis.txt",
                    FileMode.Append,FileAccess.Write)); // creates a file for word count
            string readF = File.ReadAllText(@"C:\temp\Demo.txt");

            Dictionary<string, int> tDict = new Dictionary<string, int>();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string demoS = readF;
            string[] words = demoS.Split(delimiterChars,
                            StringSplitOptions.RemoveEmptyEntries);

            foreach (string x in words)
            {
                if (tDict.ContainsKey(x))
                    tDict[x] = tDict[x] + 1;
                else
                    tDict[x] = 1;
            }


            StringBuilder tStr = new StringBuilder();

            foreach (KeyValuePair<string, int> entry in tDict)
            {
                tStr.Append("Word: " + entry.Key.ToString() + "," + entry.Value.ToString() + Environment.NewLine);
            }

            MessageBox.Show("Got:" + Environment.NewLine +tStr);

            sr.WriteLine(tStr);
            sr.Close();
            sr.Dispose();
            File.Delete(@"C:\temp\Demo.txt");
            Process.Start(@"C:\temp\FileThis.txt");

            // Time Stamp
            Console.WriteLine("Starting");
            log.Info("counted Word!");
            MessageBox.Show("Read from file logged");
            //File.Delete(@"C:\temp\FileThis.txt");
            //File.Create(@"C:\temp\FileThis.txt").Close();
        }

        // List the files
        /*private void button3_Click(object sender, EventArgs e)
        {
            //string folder = textBox2.Text;
            try
            {
                string[] files = Directory.GetFiles(folder);
                foreach (string fname in files)
                {
                    listBox2.Items.Add(fname);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message, "Problem", MessageBoxButtons.OK);
            }
        }*/


    }
}

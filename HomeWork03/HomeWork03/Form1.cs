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
using FileProcessing;

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

            string if1 = iFolder + "\\" + comboBox1.SelectedItem;
            string of1 = oFolder + "\\FileThis.txt";
            ProcessTxt a = new ProcessTxt();
            a.doString(if1, of1);
            MessageBox.Show("Got:" + Environment.NewLine + a.GettStr().ToString());
            Process.Start(of1);
            log.Info("done");
            MessageBox.Show("Read from file logged");
            Console.WriteLine("Starting");
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

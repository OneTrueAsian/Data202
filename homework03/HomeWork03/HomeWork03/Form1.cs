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
                if (f.EndsWith(".txt")) {
                    comboBox1.Items.Add(f);
                    if (comboBox1  == null)
                    {
                        throw new System.ArgumentNullException("Please Select A File");
                    }
            
                }
            }
        }

        // Select the output file
        private void button1_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            oFolder = folderBrowserDialog1.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void button5_Click(object sender, EventArgs e)
        {
            
            string if1 = iFolder;
            string of1 = oFolder + "FileThis.txt";

            if1 = iFolder + "\\" + comboBox1.SelectedItem;
            of1 = oFolder + "\\FileThis.txt";

            ProcessTxt a = new ProcessTxt();
            a.doString(if1, of1);

            Cursor.Current = Cursors.WaitCursor;
            System.Threading.Thread.Sleep(2000);
            Cursor.Current = Cursors.Default;

            Process.Start(of1);
            log.Info("done");
            MessageBox.Show("Read from file logged");
        }

    }
}

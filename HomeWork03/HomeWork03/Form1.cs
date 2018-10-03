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
        public Form1()
        {
            InitializeComponent();
        }

        // Time Stamp
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starting");
            log.Info("Got it!");
            MessageBox.Show("Message Logged");
        }

        // Write To File
        private void button2_Click(object sender, EventArgs e)
        {

            StreamWriter sr =
                new StreamWriter(new FileStream(@"C:\temp\Demo.txt",
            FileMode.Append,
            FileAccess.Write)); 
            sr.WriteLine(textBox1.Text);
            sr.Close();
            sr.Dispose();

            MessageBox.Show("Message Sent");
            Process.Start(@"C:\temp\Demo.txt"); // Opens the File

            //Time Stamp
            Console.WriteLine("Starting");
            log.Info("Read Input!");
            MessageBox.Show("Write to file Logged");
        }

        // Select the file
        private void button4_Click(object sender, EventArgs e)
        {
            string fName;
            folderBrowserDialog1.ShowDialog();
            fName = folderBrowserDialog1.SelectedPath;
            textBox2.Text = fName;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        // Word Count
        private void button5_Click(object sender, EventArgs e)
        {
            
            string if1 = @"C:\temp\Demo.txt";
            string of1 = @"C:\temp\FileThis.txt";
            ProcessTxt a = new ProcessTxt();
            a.doString(if1, of1);
            MessageBox.Show("Got:" + Environment.NewLine + a.GettStr().ToString());
            Process.Start(of1);
            log.Info("done");
            MessageBox.Show("Read from file logged");
            Console.WriteLine("Starting");
        }

        // List the files
        private void button3_Click(object sender, EventArgs e)
        {
            string folder = textBox2.Text;
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
        }

        
    }
}

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

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starting");
            log.Info("Got it!");
            MessageBox.Show("Message Logged");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sr =
                new StreamWriter(new FileStream(@"C:\Temp\Demo.txt",
                        FileMode.Append,
                        FileAccess.Write));
            sr.WriteLine(textBox1.Text);
            sr.Close();
            sr.Dispose();
            MessageBox.Show("Done");
        }

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

        private void button5_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> tDict = new Dictionary<string, int>();

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            // string demoS = "Yonkers my Yonkers.";
            string demoS = textBox1.Text;
            string[] words = demoS.Split(delimiterChars,
                            StringSplitOptions.RemoveEmptyEntries);
            string[] foo = { "hi", "bye", "here" };

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
                tStr.Append("\nWord: " + entry.Key.ToString() + "," + entry.Value.ToString());
            }

            MessageBox.Show("Got:" + tStr);
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

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

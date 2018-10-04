using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace with_without
{
    public partial class FormParallelDemo : Form
    {
        public FormParallelDemo()
        {
            InitializeComponent();
        }
        Stopwatch masterSW;

        private void label2_Click(object sender, EventArgs e)
        {
            openFileData.ShowDialog();
            textBoxFilePath.Text = openFileData.FileName;
        }

        private void buttonProcessData_Click(object sender, EventArgs e)
        {
            int frequency = (int)numericUpDownTimes.Value;

            resetLabels();

            if (textBoxFilePath.Text.Length == 0 || !File.Exists(textBoxFilePath.Text))
            {
                MessageBox.Show("Enter a valid file name.");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            fileAverage tObject = new fileAverage();
            masterSW = Stopwatch.StartNew();
            labelLineCount.Text = "Total Lines to Process: " + tObject.readInFile(textBoxFilePath.Text) + " lines" ;
            masterSW.Stop();


            labelOpenTime.Text = "Time to Open File: " + masterSW.ElapsedMilliseconds + "ms";

            

            masterSW = Stopwatch.StartNew();
            for (int i = 0; i < frequency; i++)
                tObject.processWithSerial();
            masterSW.Stop();
            labelProcessTimeSingle.Text = "Time to Process With Single CPU: " + masterSW.ElapsedMilliseconds + "ms";

            masterSW = Stopwatch.StartNew();
            for (int k = 0; k < frequency; k++)
                tObject.processWithParallel();
            masterSW.Stop();
            labelProcessTimeParallel.Text = "Time to Process With Multiple CPUs: " + masterSW.ElapsedMilliseconds + "ms";

            Cursor.Current = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetLabels();
        }

        private void resetLabels()
        {
            labelProcessTimeParallel.Text = "Time to Process With Multiple CPUs: ";
            labelProcessTimeSingle.Text = "Time to Process With Single CPU: ";
            labelOpenTime.Text = "Time to Open File: ";
            labelLineCount.Text = "Total Lines to Process: ";

        }
    }
}

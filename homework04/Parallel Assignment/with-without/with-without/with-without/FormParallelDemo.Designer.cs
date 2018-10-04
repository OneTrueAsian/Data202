namespace with_without
{
    partial class FormParallelDemo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileData = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOpenTime = new System.Windows.Forms.Label();
            this.labelProcessTimeSingle = new System.Windows.Forms.Label();
            this.labelLineCount = new System.Windows.Forms.Label();
            this.labelProcessTimeParallel = new System.Windows.Forms.Label();
            this.buttonProcessData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownTimes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileData
            // 
            this.openFileData.FileName = "openFileDialog1";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(122, 56);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(333, 30);
            this.textBoxFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelOpenTime
            // 
            this.labelOpenTime.AutoSize = true;
            this.labelOpenTime.Location = new System.Drawing.Point(30, 215);
            this.labelOpenTime.Name = "labelOpenTime";
            this.labelOpenTime.Size = new System.Drawing.Size(173, 25);
            this.labelOpenTime.TabIndex = 4;
            this.labelOpenTime.Text = "Time to Open File:";
            // 
            // labelProcessTimeSingle
            // 
            this.labelProcessTimeSingle.AutoSize = true;
            this.labelProcessTimeSingle.Location = new System.Drawing.Point(30, 291);
            this.labelProcessTimeSingle.Name = "labelProcessTimeSingle";
            this.labelProcessTimeSingle.Size = new System.Drawing.Size(311, 25);
            this.labelProcessTimeSingle.TabIndex = 5;
            this.labelProcessTimeSingle.Text = "Time to Process With Single CPU:";
            // 
            // labelLineCount
            // 
            this.labelLineCount.AutoSize = true;
            this.labelLineCount.Location = new System.Drawing.Point(30, 255);
            this.labelLineCount.Name = "labelLineCount";
            this.labelLineCount.Size = new System.Drawing.Size(211, 25);
            this.labelLineCount.TabIndex = 6;
            this.labelLineCount.Text = "Total Lines to Process:";
            // 
            // labelProcessTimeParallel
            // 
            this.labelProcessTimeParallel.AutoSize = true;
            this.labelProcessTimeParallel.Location = new System.Drawing.Point(30, 332);
            this.labelProcessTimeParallel.Name = "labelProcessTimeParallel";
            this.labelProcessTimeParallel.Size = new System.Drawing.Size(323, 25);
            this.labelProcessTimeParallel.TabIndex = 7;
            this.labelProcessTimeParallel.Text = "Time to Process With Multiple CPU:";
            // 
            // buttonProcessData
            // 
            this.buttonProcessData.Location = new System.Drawing.Point(122, 148);
            this.buttonProcessData.Name = "buttonProcessData";
            this.buttonProcessData.Size = new System.Drawing.Size(333, 37);
            this.buttonProcessData.TabIndex = 8;
            this.buttonProcessData.Text = "Process Data";
            this.buttonProcessData.UseVisualStyleBackColor = true;
            this.buttonProcessData.Click += new System.EventHandler(this.buttonProcessData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownTimes
            // 
            this.numericUpDownTimes.Location = new System.Drawing.Point(388, 107);
            this.numericUpDownTimes.Name = "numericUpDownTimes";
            this.numericUpDownTimes.Size = new System.Drawing.Size(67, 30);
            this.numericUpDownTimes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number of Times to Process:";
            // 
            // FormParallelDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownTimes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonProcessData);
            this.Controls.Add(this.labelProcessTimeParallel);
            this.Controls.Add(this.labelLineCount);
            this.Controls.Add(this.labelProcessTimeSingle);
            this.Controls.Add(this.labelOpenTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilePath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormParallelDemo";
            this.Text = "Parallel Demonstration";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileData;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelOpenTime;
        private System.Windows.Forms.Label labelProcessTimeSingle;
        private System.Windows.Forms.Label labelLineCount;
        private System.Windows.Forms.Label labelProcessTimeParallel;
        private System.Windows.Forms.Button buttonProcessData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownTimes;
        private System.Windows.Forms.Label label3;
    }
}


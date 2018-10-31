namespace hwkForm1
{
    partial class Form1
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
            this.Time = new System.Windows.Forms.TextBox();
            this.IRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PaymentM = new System.Windows.Forms.Label();
            this.AccuI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcPayment = new System.Windows.Forms.Button();
            this.Amount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(289, 72);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(159, 22);
            this.Time.TabIndex = 1;
            // 
            // IRate
            // 
            this.IRate.Location = new System.Drawing.Point(289, 122);
            this.IRate.Name = "IRate";
            this.IRate.Size = new System.Drawing.Size(159, 22);
            this.IRate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loan Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Monthly Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Accumulated Interest";
            // 
            // PaymentM
            // 
            this.PaymentM.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PaymentM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaymentM.Location = new System.Drawing.Point(286, 213);
            this.PaymentM.Name = "PaymentM";
            this.PaymentM.Size = new System.Drawing.Size(162, 35);
            this.PaymentM.TabIndex = 8;
            // 
            // AccuI
            // 
            this.AccuI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccuI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccuI.Location = new System.Drawing.Point(286, 287);
            this.AccuI.Name = "AccuI";
            this.AccuI.Size = new System.Drawing.Size(162, 36);
            this.AccuI.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Loan Amount";
            // 
            // CalcPayment
            // 
            this.CalcPayment.Location = new System.Drawing.Point(209, 358);
            this.CalcPayment.Name = "CalcPayment";
            this.CalcPayment.Size = new System.Drawing.Size(119, 34);
            this.CalcPayment.TabIndex = 11;
            this.CalcPayment.Text = "Calculate";
            this.CalcPayment.UseVisualStyleBackColor = true;
            this.CalcPayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(286, 12);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(162, 22);
            this.Amount.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 395);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.CalcPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccuI);
            this.Controls.Add(this.PaymentM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IRate);
            this.Controls.Add(this.Time);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox IRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PaymentM;
        private System.Windows.Forms.Label AccuI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcPayment;
        private System.Windows.Forms.TextBox Amount;
    }
}


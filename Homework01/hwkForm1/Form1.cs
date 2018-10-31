using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwkForm1
{
    public partial class Form1 : Form
    {
        double AmountReq, Rate, MPayment, TotalI;
        int Years;

        string iMpayment, iTotalI;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmountReq = Convert.ToDouble(Amount.Text);
            Rate = Convert.ToDouble(IRate.Text);
            Rate = Rate / 100;
            Years = Convert.ToInt32(Time.Text);
            MPayment = (Rate * AmountReq) / (12 * (1 - Math.Pow(1 + (Rate / 12), (Years * 12) * -1)));

            iMpayment = Convert.ToString(MPayment);
            iMpayment = String.Format("{0:C}", MPayment);
            PaymentM.Text = iMpayment;

            TotalI = (MPayment * (Years * 12)) - AmountReq;
            iTotalI = string.Format("{0:C}", TotalI);
            AccuI.Text = iTotalI;
        }
    }
}

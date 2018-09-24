using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanClass
{
    public class ClassLoan
    {
        public string ssn, name, Choice;
        public double AmountReq, downPayment, Payment, Rate, Time, Totali;

        public void getInput(string issn, string iname, string ichoice, double iloan, double idwnpay, double itime, double irate)
        {
            ssn = iname;
            name = iname;
            AmountReq = iloan;
            downPayment = idwnpay;
            Time = itime;
            Rate = irate;
            Choice = ichoice;
        }

        public double Calculate()
        {
            if (downPayment < (AmountReq * .10))
            {
                Rate += 1;
            }
            if (Choice == "H")
            {
                Rate += 1;
            } else if (Choice == "B")
            {
                Rate += .5;
            } else if(Choice == "A")
            {
                Rate += 3.5;
            } else if(Choice == "E")
            {
                Rate += 2.5;
            } else if (Choice == "R")
            {
                Rate += 0;
            }
            AmountReq = AmountReq - downPayment;
            Rate = Rate / 100;
            Payment = (Rate * AmountReq) / (12 * (1 - Math.Pow(1 + (Rate / 12), (Time * 12) * -1)));
            return Payment = Math.Round(Payment, 2);
        }

        public void setAccumI()
        {
            Totali = (Payment * (Time * 12)) - AmountReq;
            Totali = Math.Round(Payment, 2);
        }
        public double getTotali()
        {
            return Totali;
        }
    }
}

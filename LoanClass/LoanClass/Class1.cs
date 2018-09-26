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
            /// <summary>
            /// To initialize the inputs
            /// </summary>

            ssn = issn;
            name = iname;
            AmountReq = iloan;
            downPayment = idwnpay;
            Time = itime;
            Rate = irate;
            Choice = ichoice;
        }

        public double Calculate()
        {
            /// <summary>
            /// To calculate the monthly payment and total interest rate
            /// </summary>
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

            Totali = Math.Round(((Payment * (Time * 12)) - AmountReq), 2);

            return Payment = Math.Round(Payment, 2);
        }
        public string getName()
        {
            /// <summary>
            /// To access the name
            /// </summary>
            return name;
        }
        public string getSSN()
        {
            /// <summary>
            /// To access the ssn
            /// </summary>
            return ssn;
        }
        public string getChoice()
        {
            /// <summary>
            /// To access the choice
            /// </summary>
            return Choice;
        }
        public double getTotali()
        { 
            /// <summary>
           /// To access the Totali
           /// </summary>
            return Totali;
        }
        public double getLoan()
        {
            /// <summary>
            /// To access the AmountReq
            /// </summary>
            return AmountReq;
        }
        public double getDownPayment()
        {
            /// <summary>
            /// To access the downPayment
            /// </summary>
            return downPayment;
        }
        public double getRate()
        {
            /// <summary>
            /// To access the Rate
            /// </summary>
            return Rate;
        }
        public double getTime()
        {
            /// <summary>
            /// To access the Time
            /// </summary>
            return Time;
        }
    }
}

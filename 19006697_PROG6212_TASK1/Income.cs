using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19006697
{
    class Income
    {

        //VARIABLES
        private double monthlyIncome;
        private double tax;


        //CONSTRUCTOR
        public Income(double monthlyIncome, double tax)
        {
            this.monthlyIncome = monthlyIncome;
            this.tax = tax;
        }


        //GET METHODS
        public double getMonthlyIncome()
        {
            return monthlyIncome;
        }

        public double getTax()
        {
            return tax;
        }

        public string DisplayIncome()
        {
            string sDisplay = "";
            sDisplay = "GROSS MONTHLY INCOME:" + Convert.ToString(monthlyIncome) + "\t" + "TAX:" + Convert.ToString(tax);
            return sDisplay;
        }
    }

}

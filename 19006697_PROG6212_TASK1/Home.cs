using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19006697
{
    class Home
    {

        //VARIABLES
        private double rentalAmount;
        private double purchaseHome;
        private double depositHome;
        private double interestHome;
        private int noOfMonths;


        //CONSTRUCTOR
        public Home(double rentalAmount, double purchaseHome, double depositHome, double interestHome, int noOfMonths)
        {
            this.rentalAmount = rentalAmount;
            this.purchaseHome = purchaseHome;
            this.depositHome = depositHome;
            this.interestHome = interestHome;
            this.noOfMonths = noOfMonths;
        }


        //GET METHODS
        public double getRentalAmount()
        {
            return rentalAmount;
        }

        public double getPurchaseHome()
        {
            return purchaseHome;
        }

        public double getDepositHome()
        {
            return depositHome;
        }

        public double getInterestHome()
        {
            return interestHome;
        }

        public int getNoOfMonths()
        {
            return noOfMonths;
        }

        public string DisplayHome()
        {
            string sDisplay = "";
            sDisplay =  "\t" + "PURCHASE PRICE"
            + Convert.ToString(purchaseHome) + "\t" + "TOTAL DEPOSIT:"
            + Convert.ToString(depositHome) + "\t" + "INTEREST:" + Convert.ToString(interestHome)
            + "\t" + "NO OF MONTHS:" + Convert.ToString(noOfMonths);
            return sDisplay;
        }
    }
}

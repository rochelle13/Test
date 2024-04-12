using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19006697
{
    class Vehicle
    {
        //VARIABLES
        private string model;
        private double purchaseVehicle;
        private double depositVehicle;
        private double interestVehicle;
        private double insurance;


        //CONSTRUCTOR
        public Vehicle(string model, double purchaseVehicle, double depositVehicle, double interestVehicle, double insurance)
        {
            this.model = model;
            this.purchaseVehicle = purchaseVehicle;
            this.depositVehicle = depositVehicle;
            this.interestVehicle = interestVehicle;
            this.insurance = insurance;
        }


        //GET METHODS
        public string getModel()
        {
            return model;
        }

        public double getPurchaseVehicle()
        {
            return purchaseVehicle;
        }

        public double getDepositVehicle()
        {
            return depositVehicle;
        }

        public double getInterestVehicle()
        {
            return interestVehicle;
        }

        public double getInsurance()
        {
            return insurance;
        }

        public string DisplayVehicle()
        {
            string sDisplay = "";
            sDisplay = "MODEL AND MAKE:" + model + "\t" + "PURCHASE PRICE" 
            + Convert.ToString(purchaseVehicle) + "\t" + "TOTAL DEPOSIT:" 
            + Convert.ToString(depositVehicle) + "\t" + "INTEREST:" + Convert.ToString(interestVehicle)
            + "\t" + "INSURANCE:" + Convert.ToString(insurance);
            return sDisplay;
        }
    }

}

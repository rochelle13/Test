using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19006697
{
    class Expenditures
    {
        //VARIABLES
        private double groceries;
        private double waterAndLights;
        private double travel;
        private double cellphone;
        private double otherExpenses;

        //CONSTRUCTOR
        public Expenditures(double groceries, double waterAndLights, double travel, double cellphone, double otherExpenses)
        {
            this.groceries = groceries;
            this.waterAndLights = waterAndLights;
            this.travel = travel;
            this.cellphone = cellphone;
            this.otherExpenses = otherExpenses;
        }

        //GET METHODS
        public double getGroceries()
        {
            return groceries;
        }
        
        public double getWaterAndLights()
        {
            return waterAndLights;
        }

        public double getTravel()
        {
            return travel;
        }

        public double getCellphone()
        {
            return cellphone;
        }

        public double getOtherExpenses()
        {
            return otherExpenses;
        }

        public string DisplayVehicle()
        {
            string sDisplay = "";
            sDisplay = "\t" + "GROCERIES:"
            + Convert.ToString(groceries) + "\t" + "WATER AND LIGHTS:"
            + Convert.ToString(waterAndLights) + "\t" + "TRAVEL COST:" + Convert.ToString(travel)
            + "\t" + "CELLPHONE & TELLPHONE:" + Convert.ToString(cellphone)
            + "\t" + "OTHER EXPENSES:" + Convert.ToString(otherExpenses);
            return sDisplay;
        }
    }
}

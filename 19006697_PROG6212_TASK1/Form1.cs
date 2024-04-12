using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19006697
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //VARIABLES
        private double monthlyIncome = 0 ;
        private double tax = 0;

        private double groceries = 0;
        private double waterAndLights = 0;
        private double travel = 0;
        private double cellphone = 0;
        private double otherExpenses = 0;

        private string model =  " ";
        private double purchaseVehicle = 0;
        private double depositVehicle = 0;
        private double interestVehicle = 0;
        private double insurance = 0;

        private double rentalAmount = 0;
        private double purchaseHome = 0;
        private double depositHome = 0;
        private double interestHome = 0;
        private int noOfMonths = 0;

        private double homeLoan = 0;
        private double vehicleCost = 0;
        private double availableMoney = 0;
        private double expenditures = 0;

        private string displayVehicle = "";
        private string displayHome = "";
        private string loanApproval = " ";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlVehicle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlIncome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMonthlyCost_Click(object sender, EventArgs e)//CALCULATES MONTHLY COST OF A VEHICLE
        {
            if (chkYes.Checked == true)//CHECKS IF USER WANTS TO BUY A VEHICLE
            {
                vehicleCost= 0;
                //SETS VARIABLES TO VALUES IN TEXT BOXES
                model = txtModel.Text;
                purchaseVehicle = Convert.ToDouble(txtPurchaseVehicle.Text);
                depositVehicle = Convert.ToDouble(txtDepositVehicle.Text);
                interestVehicle = Convert.ToDouble(txtIntVehicle.Text) / 100;
                insurance = Convert.ToDouble(txtInsurance.Text);

                //CALCULATES MONTHLY VEHICLE COST
                vehicleCost = ((purchaseVehicle + insurance + (purchaseVehicle * interestVehicle)) - (depositVehicle))/60;

                //STORES ALL INFOMATION ABOUT VEHICLE IN A STRING 
                displayVehicle ="\n"+ "VEHICLE " +"\n" + "MODEL AND MAKE: " + model + "\n" + "PURCHASE PRICE: R"
                + Convert.ToString(purchaseVehicle) + "\n" + "TOTAL DEPOSIT: R"
                + Convert.ToString(depositVehicle) + "\n" + "INTEREST:" + Convert.ToString(interestVehicle) + "%"
                + "\n" + "INSURANCE: R" + Convert.ToString(insurance) + "\n" + "TOTAL MONTHLY COST: R" + Convert.ToString(vehicleCost);
            }
            if (chkNo.Checked == true)//RUNS IF USERS DOES NOT WANT A VEHICLE
            {
                vehicleCost = 0;
                displayVehicle = "\n" + "VEHICLE " + "\n" + "USER DID NOT PURCHASE VEHICLE";// SHOWS MESSAGE
            }
        }

        private void btnMonthlyMoney_Click(object sender, EventArgs e)
        {
            //SETS VARIABLES TO VALUES IN TEXTBOXES
            monthlyIncome = Convert.ToDouble(txtIncome.Text);
            tax = Convert.ToDouble(txtTax.Text);
            groceries = Convert.ToDouble(txtGroceries.Text);
            waterAndLights = Convert.ToDouble(txtGroceries.Text);
            travel = Convert.ToDouble(txtTravel.Text);
            cellphone = Convert.ToDouble(txtCell.Text);
            otherExpenses = Convert.ToDouble(txtExpenses.Text);

            expenditures = (groceries + waterAndLights + travel + cellphone + otherExpenses);//SUM OF EXPENDITURES

            //CALCULATES MONEY AVAILABLE AT THE END OF THE MONTH
            availableMoney = monthlyIncome - (expenditures + vehicleCost + homeLoan + rentalAmount+ tax);

            //STORES ALL VALUES IN A STRING
             string display = "GROSS MONTHLY INCOME:" + Convert.ToString(monthlyIncome) + "\n" + "TAX:" + Convert.ToString(tax)+ "\n" + "GROCERIES:"
            + Convert.ToString(groceries) + "\n" + "WATER AND LIGHTS:"
            + Convert.ToString(waterAndLights) + "\n" + "TRAVEL COST:" + Convert.ToString(travel)
            + "\n" + "CELLPHONE & TELLPHONE:" + Convert.ToString(cellphone)
            + "\n" + "OTHER EXPENSES:" + Convert.ToString(otherExpenses) + "\n" + displayVehicle + "\n" + displayHome 
            + "\n" + "MONTHLY COST:" + Convert.ToString(expenditures + vehicleCost + homeLoan + rentalAmount + tax)
            + "\n" + "MONTHLY AVAILABLE MONEY:" + Convert.ToString(availableMoney);

            rtbOutput.Text = display;//DISPLAYS STRING



        }

        private void btnHomeLoan_Click(object sender, EventArgs e)
        {
            if (chkRent.Checked == true)//CHECKS IF USER WANTS TO RENT A HOUSE
            {
                homeLoan = 0;
                rentalAmount = Convert.ToDouble(txtRent.Text);//GETS RENTAL VALUE

                //STORES RENTAL VALUE IN A STRING WITH MESSAGE
                displayHome = "\n" + "RENTAL AMOUNT: R" + Convert.ToString(rentalAmount);
                rtbOutput.Text = displayHome;//DISPLAYS STRING
            }
            if (chkBuy.Checked == true)//CHECKS IF USER WANTS TO BUY A HOUSE
            {
                rentalAmount = 0;
                //GETS VALUES FROM TEXTBOXES
                purchaseHome = Convert.ToDouble(txtPurchaseHome.Text);
                depositHome = Convert.ToDouble(txtDepositHome.Text);
                interestHome = (Convert.ToDouble(txtIntHome.Text)/100);
                noOfMonths = Convert.ToInt32(txtMonths.Text);

                //CALCULATES HOME LOAN
                homeLoan = ((purchaseHome + (interestHome * purchaseHome)) - depositHome) / noOfMonths;

                //IF HOME LOAN IS GREATER THAN1/3 OF MONTHLY INCOME AN APPROPRIATE MESSAGE IS DISPLAYED
                if (homeLoan > (1/3 * monthlyIncome))
                {
                    loanApproval = "HOME LOAN APPROVAL IS UNLIKELY";
                }
                else
                {
                    loanApproval = "HOME LOAN IS APPROVED";

                }

                //STORES ALL VALUES IN A STRING 
                 displayHome = "\n" + "HOME"+"\n" + "PURCHASE PRICE"
                 + Convert.ToString(purchaseHome) + "\n" + "TOTAL DEPOSIT:"
                 + Convert.ToString(depositHome) + "\n" + "INTEREST:" + Convert.ToString(interestHome)
                 + "\n" + "NO OF MONTHS:" + Convert.ToString(noOfMonths) + "\n" + "MONTHLY HOME LOAN REPAYMENT:"
                 + Convert.ToString(homeLoan) + "\n" + loanApproval;
                rtbOutput.Text = displayHome;//DISPLAYS STRING



            }
        }

    }
}

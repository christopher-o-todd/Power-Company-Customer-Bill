using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAssignment1
{
    
    public partial class kWLabelInd : Form
    {
        List<Customer> customers = new List<Customer>(); // empty list
        decimal totalCustomers = 0; // total customer value
        decimal totalCustomersR = 0;
        decimal totalCustomersC = 0;
        decimal totalCustomersI = 0;
        public kWLabelInd()
        {
            InitializeComponent();
        }

        // calculates total charge value
        private decimal CalculateTotal()
        {
            decimal total = 0;


            foreach (Customer c in customers)
                total += c.SumCharges();

            return total;
        }
        private decimal CalculateTotalR()
        {
            decimal totalR = 0;

            foreach (Customer c in customers)
                    totalR += c.SumResidential();
            return totalR;         
        }

        private decimal CalculateTotalC()
        {
            decimal totalC = 0;

            foreach (Customer c in customers)
                totalC += c.SumCommercial();
            return totalC;
        }

        private decimal CalculateTotalI()
        {
            decimal totalI = 0;

            foreach (Customer c in customers)
                totalI += c.SumIndustrial();
            return totalI;
        }
        // add a new customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get data (skipping validation)
            int account;
            string name;
            string custType;
            decimal charge;

            account = Convert.ToInt32(txtAccount.Text);
            name = txtCustomerName.Text;
            custType = CustomerTextBox.Text;
            charge = Convert.ToDecimal(txtCharge.Text);

            // create new customer and add to the list
            Customer newCust = new Customer(account, name, custType, charge);
            customers.Add(newCust);
            // adjust total inventory
            totalCustomers += newCust.SumCharges();
            totalCustomersR += newCust.SumResidential();
            totalCustomersC += newCust.SumCommercial();
            totalCustomersI += newCust.SumIndustrial();

            // display list in the list box, and count and inventory 
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            var custType = CustomerTextBox.Text;
            listCustomers.Items.Clear(); // start with empty list box
            foreach (Customer c in customers)
                listCustomers.Items.Add(c); // calls ToString()
            lblCount2.Text = customers.Count.ToString();
            lblSum2.Text = totalCustomers.ToString("c");
            lblR2.Text = totalCustomersR.ToString("c");
            lblC2.Text = totalCustomersC.ToString("c");
            lblI2.Text = totalCustomersI.ToString("c");
        }

        // just before form closes, save data

        private void kWLabelInd_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerDB.SaveCustomers(customers);
        }

        // delete selected customer 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listCustomers.SelectedIndex; // index of the selected item
            if (index < 0) // no selection
            {
                MessageBox.Show("Please select Customer to delete");
            }
            else // user selected a customer to delete
            {
                Customer cust = customers[index]; // selected customer
                DialogResult answer =
                    MessageBox.Show("Are you sure you want to delete " + cust.Name + "?",
                    "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    // delete selected product
                    customers.RemoveAt(index); // remove from the list
                    totalCustomers = CalculateTotal(); // recalculate total charges
                    totalCustomersR = CalculateTotalR();
                    totalCustomersC = CalculateTotalC();
                    totalCustomersI = CalculateTotalI();
                    DisplayCustomers();
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (Conversions.Validator.IsPresent(kWTextBox) &&
                Conversions.Validator.IsInteger(kWTextBox) &&
                Conversions.Validator.IsNonNegativeInteger(kWTextBox) &&
                Conversions.Validator.IsPresent(kWOffTxtBox) &&
                Conversions.Validator.IsInteger(kWOffTxtBox) &&
                Conversions.Validator.IsNonNegativeInteger(kWOffTxtBox)
                )
            {
                string customerType = CustomerTextBox.Text; //customer type input
                int kWHours = Convert.ToInt32(kWTextBox.Text); //kWh amount input
                int kWOffHours = Convert.ToInt32(kWOffTxtBox.Text); //kwh for Off Peak Hours input
                CustomerMethod(customerType, kWHours, kWOffHours); //method to calculate charge
            }
        }

        private double CustomerMethod(string customerType, int kWHours, int kWOffHours)
        {
            double charge = 0; //initial value of charge
            
            //residential calculation:

            if (customerType == "R" || customerType == "r")
            {
                charge = (6 + (0.052 * kWHours));
                string resMessage = "The Residential bill is " + charge.ToString("c");
                chargeLabel.Text = resMessage;
                txtCharge.Text = charge.ToString();
            }

            //commercial calculation:

            else if (customerType == "C" || customerType == "c")
            {
                if (kWHours <= 1000)
                {
                    charge = 60;
                }
                else
                {
                    charge = 60 + (kWHours - 1000) * 0.045;
                }
                string resMessage = "The Commercial bill is " + charge.ToString("c");
                chargeLabel.Text = resMessage;
                txtCharge.Text = charge.ToString();
            }

            //industrial calculation:

            else if (customerType == "I" || customerType == "i")
            {
                if (kWHours <= 1000 && kWOffHours <= 1000)
                {
                    charge = 76 + 40;
                }
                else if (kWHours <= 1000 && kWOffHours > 1000)
                {
                    charge = 76 + 40 + (kWOffHours - 1000) * 0.028;
                }
                else if (kWHours > 1000 && kWOffHours <= 1000)
                {
                    charge = 76 + 40 + (kWHours - 1000) * 0.065;
                }
                else
                {
                    charge = 76 + 40 + (kWHours - 1000) * 0.065 + (kWOffHours - 1000) * 0.028;
                }
                string resMessage = "The Industrial bill is " + charge.ToString("c");
                chargeLabel.Text = resMessage;
                txtCharge.Text = charge.ToString();
            }
            return charge;
        }

        //Clear button resets all fields and focuses on the customer text box
        private void btnClear_Click(object sender, EventArgs e)
        {
            CustomerTextBox.Text = "";
            kWTextBox.Text = "";
            chargeLabel.Text = "";
            kWOffTxtBox.Text = "";
            txtAccount.Text = "";
            txtCustomerName.Text = "";
            txtCharge.Text = "";

            kWOffTxtBox.Visible = false;
            kWOffLabel.Visible = false;
            peakHoursLabel.Visible = false;
            CustomerTextBox.Focus();

        }

        //Exit button exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //Hides the off peak hours box and label if Residential or Commercial customer is chosen, when the kWText box is chosen
        private void kWTextBox_Enter(object sender, EventArgs e)
        {
            string customerType = CustomerTextBox.Text;
            if (customerType == "R" || customerType == "C")
            {
                kWOffTxtBox.Text = "0"; //required because form won't complete with null value
                peakHoursLabel.Visible = false;
                kWOffTxtBox.Visible = false;
                kWOffLabel.Visible = false;
            }
            else if (customerType == "I")
            {
                kWOffTxtBox.Visible = true;
                kWOffLabel.Visible = true;
                peakHoursLabel.Visible = true;
            }
        }

        // read and display data
        //As the form loads, hide the peak hour label, box and hint. Residential is set to default customer.

        private void kWLabelInd_Load(object sender, EventArgs e)

        {
            customers = CustomerDB.GetCustomers();
            totalCustomers = CalculateTotal();
            totalCustomersR = CalculateTotalR();
            totalCustomersC = CalculateTotalC();
            totalCustomersI = CalculateTotalI();
            DisplayCustomers();
            CustomerTextBox.Text = "R";
            peakHoursLabel.Visible = false;
            kWOffTxtBox.Visible = false;
            kWOffLabel.Visible = false;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerFormProject
{
    public partial class frmCustomers : Form
    {
        private List<Customer> customers = new List<Customer>();

        public frmCustomers()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            customers = DataHandler.LoadData();

            lstbCustomers.Items.Clear();
            //Loop to load and format that occurs when form is opened
            foreach (Customer customer in customers)
            {
                string fullName = $"{customer.FirstName} {customer.LastName}";

                int numberOfPurchases = customer.Purchases.Count;

                double maxPurchase = customer.Purchases.Count > 0 ? customer.Purchases.Max(p => p.Price) : 0;

                double totalPurchaseAmount = customer.Purchases.Sum(p => p.Price * p.Quantity);

                string formattedData = $"{fullName, -25}\t{numberOfPurchases, -10}\t{maxPurchase.ToString("C"), -15}\t{totalPurchaseAmount.ToString("C")}";

                lstbCustomers.Items.Add(formattedData);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Show Add Customer form
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            addCustomerForm.ShowDialog();

            if (!string.IsNullOrEmpty(addCustomerForm.FirstName))
            {
                //Create a new customer and add it to the list
                Customer newCustomer = new Customer
                {
                    FirstName = addCustomerForm.FirstName,
                    LastName = addCustomerForm.LastName
                };
                customers.Add(newCustomer);

                lstbCustomers.Items.Add($"{newCustomer.FirstName} {newCustomer.LastName}");

                DataHandler.SaveData(customers);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SaveAndExit();
        }

        private void SaveAndExit()
        {
            DataHandler.SaveData(customers);
            this.Close();
        }

        private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save data when the form is closing
            SaveAndExit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Check if a customer is selected
            if (lstbCustomers.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Remove selected customer from the list
                    customers.RemoveAt(lstbCustomers.SelectedIndex);
                    lstbCustomers.Items.RemoveAt(lstbCustomers.SelectedIndex);

                    //Save the updated data
                    DataHandler.SaveData(customers);
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Error");
            }
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {

        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            //Check if a customer is selected
            if (lstbCustomers.SelectedItem != null)
            {
                //Get the selected customer
                Customer selectedCustomer = customers[lstbCustomers.SelectedIndex];

                // Pass the list of purchases associated with the selected customer
                frmPurchases purchasesForm = new frmPurchases(selectedCustomer.Purchases);
                purchasesForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a customer to view purchases.", "Error");
            }
        }
    }
}

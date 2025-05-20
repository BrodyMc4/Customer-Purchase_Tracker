using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerFormProject
{
    public partial class frmPurchases : Form
    {
        private List<Purchase> purchases;

        public frmPurchases(List<Purchase> purchases)
        {
            InitializeComponent();
            this.purchases = purchases ?? new List<Purchase>();
            LoadPurchases();
            CalculatePurchaseStats();
        }

        private void btnAddPurch_Click(object sender, EventArgs e)
        {
            //Open the frmAddPurchase form
            frmAddPurchase addPurchaseForm = new frmAddPurchase();
            addPurchaseForm.PurchaseSaved += AddPurchaseForm_PurchaseSaved;
            addPurchaseForm.ShowDialog();
            CalculatePurchaseStats();
        }

        private void LoadPurchases()
        {
            lstbPurchases.Items.Clear();
            foreach (Purchase purchase in purchases)
            {
                string formattedPurchase = $"{purchase.ProductName,-20} {purchase.Price,20:C} {purchase.Quantity,8} {purchase.Total,10:C}";
                lstbPurchases.Items.Add(formattedPurchase);
            }
        }

        private void CalculatePurchaseStats()
        {
            if (purchases.Count > 0)
            {
                double minPrice = purchases.Min(p => p.Price);
                double maxPrice = purchases.Max(p => p.Price);
                double totalPrice = purchases.Sum(p => p.Price * p.Quantity);

                //Display the calculated statistics
                txtMinPurch.Text = minPrice.ToString("C");
                txtMaxPurch.Text = maxPrice.ToString("C");
                txtOverallTotal.Text = totalPrice.ToString("C");
            }
            else
            {
                //If there are no purchases, display default values or leave the textboxes empty
                txtMinPurch.Text = "N/A";
                txtMaxPurch.Text = "N/A";
                txtOverallTotal.Text = "N/A";
            }
        }

        private void UpdatePurchasesList()
        {
            lstbPurchases.Items.Clear();
            foreach (Purchase purchase in purchases)
            {
                string formattedPurchase = $"{purchase.ProductName,-20} {purchase.Price,20:C} {purchase.Quantity,8} {purchase.Total,10:C}";
                lstbPurchases.Items.Add(formattedPurchase);
            }
        }

        private void AddPurchaseForm_PurchaseSaved(object sender, PurchaseEventArgs e)
        {
            //Add the new purchase to the list and update the UI
            purchases.Add(e.Purchase);
            UpdatePurchasesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPurchases_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstbPurchases.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this purchase?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Remove the selected purchase from the list
                    int selectedIndex = lstbPurchases.SelectedIndex;
                    purchases.RemoveAt(selectedIndex);
                    lstbPurchases.Items.RemoveAt(selectedIndex);

                    // Update the purchase statistics
                    CalculatePurchaseStats();
                }
            }
            else
            {
                MessageBox.Show("Please select a purchase to delete.", "Error");
            }
        }
    }
}

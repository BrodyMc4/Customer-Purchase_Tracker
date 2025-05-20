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
    public partial class frmAddPurchase : Form
    {
        public frmAddPurchase()
        {
            InitializeComponent();
        }

        public event EventHandler<PurchaseEventArgs> PurchaseSaved;

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string productName = txtName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);

                //Create a new Purchase object
                Purchase newPurchase = new Purchase(productName, price, quantity)
                {
                    ProductName = productName,
                    Price = price,
                    Quantity = quantity
                };

                //Raise the PurchaseSaved event with the new purchase
                PurchaseSaved?.Invoke(this, new PurchaseEventArgs(newPurchase));

                //Close the form
                this.Close();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            double price;
            if (!double.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Price must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Quantity must be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddPurchase_Load(object sender, EventArgs e)
        {

        }
    }
}

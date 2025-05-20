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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                FirstName = txtFirstName.Text;
                LastName = txtLastName.Text;
                Email = txtEmail.Text;

                this.Close();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}

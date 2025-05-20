namespace CustomerFormProject
{
    partial class frmPurchases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbPurchases = new System.Windows.Forms.ListBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.btnAddPurch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinPurch = new System.Windows.Forms.TextBox();
            this.txtMaxPurch = new System.Windows.Forms.TextBox();
            this.txtOverallTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstbPurchases
            // 
            this.lstbPurchases.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbPurchases.FormattingEnabled = true;
            this.lstbPurchases.ItemHeight = 16;
            this.lstbPurchases.Location = new System.Drawing.Point(12, 68);
            this.lstbPurchases.Name = "lstbPurchases";
            this.lstbPurchases.Size = new System.Drawing.Size(421, 260);
            this.lstbPurchases.TabIndex = 0;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(8, 15);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(170, 16);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Purchases for Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "List Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Qty.";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(352, 50);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(35, 15);
            this.Total.TabIndex = 5;
            this.Total.Text = "Total";
            // 
            // btnAddPurch
            // 
            this.btnAddPurch.Location = new System.Drawing.Point(439, 68);
            this.btnAddPurch.Name = "btnAddPurch";
            this.btnAddPurch.Size = new System.Drawing.Size(102, 29);
            this.btnAddPurch.TabIndex = 6;
            this.btnAddPurch.Text = "Add Purchase";
            this.btnAddPurch.UseVisualStyleBackColor = true;
            this.btnAddPurch.Click += new System.EventHandler(this.btnAddPurch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(439, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(439, 303);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min Purchase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Max Purchase";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(339, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Overall Total";
            // 
            // txtMinPurch
            // 
            this.txtMinPurch.Location = new System.Drawing.Point(15, 368);
            this.txtMinPurch.Name = "txtMinPurch";
            this.txtMinPurch.ReadOnly = true;
            this.txtMinPurch.Size = new System.Drawing.Size(100, 20);
            this.txtMinPurch.TabIndex = 12;
            // 
            // txtMaxPurch
            // 
            this.txtMaxPurch.Location = new System.Drawing.Point(127, 368);
            this.txtMaxPurch.Name = "txtMaxPurch";
            this.txtMaxPurch.ReadOnly = true;
            this.txtMaxPurch.Size = new System.Drawing.Size(100, 20);
            this.txtMaxPurch.TabIndex = 13;
            // 
            // txtOverallTotal
            // 
            this.txtOverallTotal.Location = new System.Drawing.Point(333, 368);
            this.txtOverallTotal.Name = "txtOverallTotal";
            this.txtOverallTotal.ReadOnly = true;
            this.txtOverallTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOverallTotal.TabIndex = 14;
            // 
            // frmPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 405);
            this.Controls.Add(this.txtOverallTotal);
            this.Controls.Add(this.txtMaxPurch);
            this.Controls.Add(this.txtMinPurch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddPurch);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lstbPurchases);
            this.Name = "frmPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbPurchases;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button btnAddPurch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinPurch;
        private System.Windows.Forms.TextBox txtMaxPurch;
        private System.Windows.Forms.TextBox txtOverallTotal;
    }
}
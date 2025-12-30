namespace BakeryShopManagementSystem
{
    partial class Admin
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
            this.btnexitadmin = new System.Windows.Forms.Button();
            this.adminleftpanel = new System.Windows.Forms.Panel();
            this.todashboard = new System.Windows.Forms.Button();
            this.tocategory = new System.Windows.Forms.Button();
            this.toproduct = new System.Windows.Forms.Button();
            this.tocustomer = new System.Windows.Forms.Button();
            this.lblshopname = new System.Windows.Forms.Label();
            this.tabControlmain = new System.Windows.Forms.TabControl();
            this.Customer = new System.Windows.Forms.TabPage();
            this.Product = new System.Windows.Forms.TabPage();
            this.Category = new System.Windows.Forms.TabPage();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.lbladmincustomer = new System.Windows.Forms.Label();
            this.lbladminproduct = new System.Windows.Forms.Label();
            this.lbladmincategory = new System.Windows.Forms.Label();
            this.lbldashboard = new System.Windows.Forms.Label();
            this.adminleftpanel.SuspendLayout();
            this.tabControlmain.SuspendLayout();
            this.Customer.SuspendLayout();
            this.Product.SuspendLayout();
            this.Category.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexitadmin
            // 
            this.btnexitadmin.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnexitadmin.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitadmin.ForeColor = System.Drawing.Color.LightCoral;
            this.btnexitadmin.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnexitadmin.Location = new System.Drawing.Point(64, 479);
            this.btnexitadmin.Name = "btnexitadmin";
            this.btnexitadmin.Size = new System.Drawing.Size(71, 25);
            this.btnexitadmin.TabIndex = 0;
            this.btnexitadmin.Text = "Logout";
            this.btnexitadmin.UseVisualStyleBackColor = false;
            this.btnexitadmin.Click += new System.EventHandler(this.btnexitadmin_Click);
            // 
            // adminleftpanel
            // 
            this.adminleftpanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.adminleftpanel.Controls.Add(this.lblshopname);
            this.adminleftpanel.Controls.Add(this.todashboard);
            this.adminleftpanel.Controls.Add(this.btnexitadmin);
            this.adminleftpanel.Controls.Add(this.tocategory);
            this.adminleftpanel.Controls.Add(this.toproduct);
            this.adminleftpanel.Controls.Add(this.tocustomer);
            this.adminleftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminleftpanel.Location = new System.Drawing.Point(0, 0);
            this.adminleftpanel.Name = "adminleftpanel";
            this.adminleftpanel.Size = new System.Drawing.Size(185, 507);
            this.adminleftpanel.TabIndex = 1;
            // 
            // todashboard
            // 
            this.todashboard.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.todashboard.Location = new System.Drawing.Point(46, 371);
            this.todashboard.Name = "todashboard";
            this.todashboard.Size = new System.Drawing.Size(105, 49);
            this.todashboard.TabIndex = 3;
            this.todashboard.Text = "Dashboard";
            this.todashboard.UseVisualStyleBackColor = false;
            this.todashboard.Click += new System.EventHandler(this.todashboard_Click);
            // 
            // tocategory
            // 
            this.tocategory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tocategory.Location = new System.Drawing.Point(46, 275);
            this.tocategory.Name = "tocategory";
            this.tocategory.Size = new System.Drawing.Size(105, 49);
            this.tocategory.TabIndex = 2;
            this.tocategory.Text = "Category";
            this.tocategory.UseVisualStyleBackColor = false;
            this.tocategory.Click += new System.EventHandler(this.tocategory_Click);
            // 
            // toproduct
            // 
            this.toproduct.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toproduct.Location = new System.Drawing.Point(46, 188);
            this.toproduct.Name = "toproduct";
            this.toproduct.Size = new System.Drawing.Size(105, 49);
            this.toproduct.TabIndex = 1;
            this.toproduct.Text = "Product";
            this.toproduct.UseVisualStyleBackColor = false;
            this.toproduct.Click += new System.EventHandler(this.toproduct_Click);
            // 
            // tocustomer
            // 
            this.tocustomer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tocustomer.Location = new System.Drawing.Point(46, 93);
            this.tocustomer.Name = "tocustomer";
            this.tocustomer.Size = new System.Drawing.Size(105, 49);
            this.tocustomer.TabIndex = 0;
            this.tocustomer.Text = "Customer";
            this.tocustomer.UseVisualStyleBackColor = false;
            this.tocustomer.Click += new System.EventHandler(this.tocustomer_Click);
            // 
            // lblshopname
            // 
            this.lblshopname.AutoSize = true;
            this.lblshopname.BackColor = System.Drawing.Color.Transparent;
            this.lblshopname.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshopname.ForeColor = System.Drawing.Color.Honeydew;
            this.lblshopname.Location = new System.Drawing.Point(26, 12);
            this.lblshopname.Name = "lblshopname";
            this.lblshopname.Size = new System.Drawing.Size(144, 27);
            this.lblshopname.TabIndex = 4;
            this.lblshopname.Text = "Cake n\' Bake";
            // 
            // tabControlmain
            // 
            this.tabControlmain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlmain.Controls.Add(this.Customer);
            this.tabControlmain.Controls.Add(this.Product);
            this.tabControlmain.Controls.Add(this.Category);
            this.tabControlmain.Controls.Add(this.Dashboard);
            this.tabControlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlmain.Location = new System.Drawing.Point(185, 0);
            this.tabControlmain.Name = "tabControlmain";
            this.tabControlmain.SelectedIndex = 0;
            this.tabControlmain.Size = new System.Drawing.Size(757, 507);
            this.tabControlmain.TabIndex = 2;
            // 
            // Customer
            // 
            this.Customer.BackColor = System.Drawing.Color.Teal;
            this.Customer.Controls.Add(this.lbladmincustomer);
            this.Customer.Location = new System.Drawing.Point(4, 4);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(749, 480);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.Teal;
            this.Product.Controls.Add(this.lbladminproduct);
            this.Product.Location = new System.Drawing.Point(4, 4);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(749, 480);
            this.Product.TabIndex = 1;
            this.Product.Text = "Product";
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.Teal;
            this.Category.Controls.Add(this.lbladmincategory);
            this.Category.Location = new System.Drawing.Point(4, 4);
            this.Category.Name = "Category";
            this.Category.Padding = new System.Windows.Forms.Padding(3);
            this.Category.Size = new System.Drawing.Size(749, 480);
            this.Category.TabIndex = 2;
            this.Category.Text = "Category";
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.Teal;
            this.Dashboard.Controls.Add(this.lbldashboard);
            this.Dashboard.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Dashboard.Location = new System.Drawing.Point(4, 4);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.Dashboard.Size = new System.Drawing.Size(749, 480);
            this.Dashboard.TabIndex = 3;
            this.Dashboard.Text = "Dashboard";
            // 
            // lbladmincustomer
            // 
            this.lbladmincustomer.AutoSize = true;
            this.lbladmincustomer.BackColor = System.Drawing.Color.Transparent;
            this.lbladmincustomer.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmincustomer.Location = new System.Drawing.Point(230, 8);
            this.lbladmincustomer.Name = "lbladmincustomer";
            this.lbladmincustomer.Size = new System.Drawing.Size(174, 27);
            this.lbladmincustomer.TabIndex = 0;
            this.lbladmincustomer.Text = "Customer Panel";
            // 
            // lbladminproduct
            // 
            this.lbladminproduct.AutoSize = true;
            this.lbladminproduct.BackColor = System.Drawing.Color.Transparent;
            this.lbladminproduct.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminproduct.Location = new System.Drawing.Point(239, 8);
            this.lbladminproduct.Name = "lbladminproduct";
            this.lbladminproduct.Size = new System.Drawing.Size(157, 27);
            this.lbladminproduct.TabIndex = 1;
            this.lbladminproduct.Text = "Product Panel";
            // 
            // lbladmincategory
            // 
            this.lbladmincategory.AutoSize = true;
            this.lbladmincategory.BackColor = System.Drawing.Color.Transparent;
            this.lbladmincategory.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmincategory.Location = new System.Drawing.Point(218, 8);
            this.lbladmincategory.Name = "lbladmincategory";
            this.lbladmincategory.Size = new System.Drawing.Size(166, 27);
            this.lbladmincategory.TabIndex = 1;
            this.lbladmincategory.Text = "Category Panel";
            // 
            // lbldashboard
            // 
            this.lbldashboard.AutoSize = true;
            this.lbldashboard.BackColor = System.Drawing.Color.Transparent;
            this.lbldashboard.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldashboard.Location = new System.Drawing.Point(210, 8);
            this.lbldashboard.Name = "lbldashboard";
            this.lbldashboard.Size = new System.Drawing.Size(186, 27);
            this.lbldashboard.TabIndex = 2;
            this.lbldashboard.Text = "Dashboard Panel";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(942, 507);
            this.Controls.Add(this.tabControlmain);
            this.Controls.Add(this.adminleftpanel);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.adminleftpanel.ResumeLayout(false);
            this.adminleftpanel.PerformLayout();
            this.tabControlmain.ResumeLayout(false);
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            this.Category.ResumeLayout(false);
            this.Category.PerformLayout();
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexitadmin;
        private System.Windows.Forms.Panel adminleftpanel;
        private System.Windows.Forms.Button tocustomer;
        private System.Windows.Forms.Button todashboard;
        private System.Windows.Forms.Button tocategory;
        private System.Windows.Forms.Button toproduct;
        private System.Windows.Forms.Label lblshopname;
        private System.Windows.Forms.TabControl tabControlmain;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Category;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.Label lbladmincustomer;
        private System.Windows.Forms.Label lbladminproduct;
        private System.Windows.Forms.Label lbladmincategory;
        private System.Windows.Forms.Label lbldashboard;
    }
}
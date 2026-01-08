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
            this.lblshopname = new System.Windows.Forms.Label();
            this.todashboard = new System.Windows.Forms.Button();
            this.tocategory = new System.Windows.Forms.Button();
            this.toproduct = new System.Windows.Forms.Button();
            this.tousers = new System.Windows.Forms.Button();
            this.tabControlmain = new System.Windows.Forms.TabControl();
            this.User = new System.Windows.Forms.TabPage();
            this.btnadmdltuser = new System.Windows.Forms.Button();
            this.btnadminpendinguser = new System.Windows.Forms.Button();
            this.btnadminupdateuser = new System.Windows.Forms.Button();
            this.btnadminviewuser = new System.Windows.Forms.Button();
            this.dgvadminusers = new System.Windows.Forms.DataGridView();
            this.lbladminuser = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.TabPage();
            this.btnadminsertproduct = new System.Windows.Forms.Button();
            this.btnadmdltproduct = new System.Windows.Forms.Button();
            this.lblproductprice = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.txtproductprice = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.lblproductid = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.btnadmupdateproduct = new System.Windows.Forms.Button();
            this.dgvadminproduct = new System.Windows.Forms.DataGridView();
            this.btnadmviewproduct = new System.Windows.Forms.Button();
            this.lbladminproduct = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.TabPage();
            this.lbladmincategory = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.TabPage();
            this.lbldashboard = new System.Windows.Forms.Label();
            this.panelpending = new System.Windows.Forms.Panel();
            this.dgvpanelpending = new System.Windows.Forms.DataGridView();
            this.btnapproveuser = new System.Windows.Forms.Button();
            this.btndeclineuser = new System.Windows.Forms.Button();
            this.adminleftpanel.SuspendLayout();
            this.tabControlmain.SuspendLayout();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminusers)).BeginInit();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminproduct)).BeginInit();
            this.Category.SuspendLayout();
            this.Dashboard.SuspendLayout();
            this.panelpending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpanelpending)).BeginInit();
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
            this.adminleftpanel.Controls.Add(this.tousers);
            this.adminleftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminleftpanel.Location = new System.Drawing.Point(0, 0);
            this.adminleftpanel.Name = "adminleftpanel";
            this.adminleftpanel.Size = new System.Drawing.Size(185, 507);
            this.adminleftpanel.TabIndex = 1;
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
            // tousers
            // 
            this.tousers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tousers.Location = new System.Drawing.Point(46, 93);
            this.tousers.Name = "tousers";
            this.tousers.Size = new System.Drawing.Size(105, 49);
            this.tousers.TabIndex = 0;
            this.tousers.Text = "Users";
            this.tousers.UseVisualStyleBackColor = false;
            this.tousers.Click += new System.EventHandler(this.tousers_Click);
            // 
            // tabControlmain
            // 
            this.tabControlmain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlmain.Controls.Add(this.User);
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
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Teal;
            this.User.Controls.Add(this.panelpending);
            this.User.Controls.Add(this.btnadmdltuser);
            this.User.Controls.Add(this.btnadminpendinguser);
            this.User.Controls.Add(this.btnadminupdateuser);
            this.User.Controls.Add(this.btnadminviewuser);
            this.User.Controls.Add(this.dgvadminusers);
            this.User.Controls.Add(this.lbladminuser);
            this.User.Location = new System.Drawing.Point(4, 4);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(3);
            this.User.Size = new System.Drawing.Size(749, 480);
            this.User.TabIndex = 0;
            this.User.Text = "Users";
            // 
            // btnadmdltuser
            // 
            this.btnadmdltuser.Location = new System.Drawing.Point(305, 440);
            this.btnadmdltuser.Name = "btnadmdltuser";
            this.btnadmdltuser.Size = new System.Drawing.Size(75, 23);
            this.btnadmdltuser.TabIndex = 12;
            this.btnadmdltuser.Text = "delete";
            this.btnadmdltuser.UseVisualStyleBackColor = true;
            // 
            // btnadminpendinguser
            // 
            this.btnadminpendinguser.Location = new System.Drawing.Point(212, 440);
            this.btnadminpendinguser.Name = "btnadminpendinguser";
            this.btnadminpendinguser.Size = new System.Drawing.Size(75, 23);
            this.btnadminpendinguser.TabIndex = 7;
            this.btnadminpendinguser.Text = "Pending";
            this.btnadminpendinguser.UseVisualStyleBackColor = true;
            this.btnadminpendinguser.Click += new System.EventHandler(this.btnadminpendinguser_Click);
            // 
            // btnadminupdateuser
            // 
            this.btnadminupdateuser.Location = new System.Drawing.Point(114, 440);
            this.btnadminupdateuser.Name = "btnadminupdateuser";
            this.btnadminupdateuser.Size = new System.Drawing.Size(75, 23);
            this.btnadminupdateuser.TabIndex = 6;
            this.btnadminupdateuser.Text = "Update";
            this.btnadminupdateuser.UseVisualStyleBackColor = true;
            // 
            // btnadminviewuser
            // 
            this.btnadminviewuser.Location = new System.Drawing.Point(6, 440);
            this.btnadminviewuser.Name = "btnadminviewuser";
            this.btnadminviewuser.Size = new System.Drawing.Size(78, 23);
            this.btnadminviewuser.TabIndex = 5;
            this.btnadminviewuser.Text = "Load";
            this.btnadminviewuser.UseVisualStyleBackColor = true;
            this.btnadminviewuser.Click += new System.EventHandler(this.btnadminviewuser_Click);
            // 
            // dgvadminusers
            // 
            this.dgvadminusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadminusers.Location = new System.Drawing.Point(0, 48);
            this.dgvadminusers.Name = "dgvadminusers";
            this.dgvadminusers.ReadOnly = true;
            this.dgvadminusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvadminusers.Size = new System.Drawing.Size(529, 368);
            this.dgvadminusers.TabIndex = 4;
            this.dgvadminusers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvadminusers_CellClick);
            // 
            // lbladminuser
            // 
            this.lbladminuser.AutoSize = true;
            this.lbladminuser.BackColor = System.Drawing.Color.Transparent;
            this.lbladminuser.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminuser.Location = new System.Drawing.Point(257, 8);
            this.lbladminuser.Name = "lbladminuser";
            this.lbladminuser.Size = new System.Drawing.Size(123, 27);
            this.lbladminuser.TabIndex = 0;
            this.lbladminuser.Text = "User Panel";
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.Teal;
            this.Product.Controls.Add(this.btnadminsertproduct);
            this.Product.Controls.Add(this.btnadmdltproduct);
            this.Product.Controls.Add(this.lblproductprice);
            this.Product.Controls.Add(this.lblproductname);
            this.Product.Controls.Add(this.txtproductprice);
            this.Product.Controls.Add(this.txtproductname);
            this.Product.Controls.Add(this.lblproductid);
            this.Product.Controls.Add(this.txtproductid);
            this.Product.Controls.Add(this.btnadmupdateproduct);
            this.Product.Controls.Add(this.dgvadminproduct);
            this.Product.Controls.Add(this.btnadmviewproduct);
            this.Product.Controls.Add(this.lbladminproduct);
            this.Product.Location = new System.Drawing.Point(4, 4);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(3);
            this.Product.Size = new System.Drawing.Size(749, 480);
            this.Product.TabIndex = 1;
            this.Product.Text = "Product";
            // 
            // btnadminsertproduct
            // 
            this.btnadminsertproduct.Location = new System.Drawing.Point(116, 430);
            this.btnadminsertproduct.Name = "btnadminsertproduct";
            this.btnadminsertproduct.Size = new System.Drawing.Size(75, 23);
            this.btnadminsertproduct.TabIndex = 12;
            this.btnadminsertproduct.Text = "insert";
            this.btnadminsertproduct.UseVisualStyleBackColor = true;
            this.btnadminsertproduct.Click += new System.EventHandler(this.btnadminsertproduct_Click);
            // 
            // btnadmdltproduct
            // 
            this.btnadmdltproduct.Location = new System.Drawing.Point(324, 430);
            this.btnadmdltproduct.Name = "btnadmdltproduct";
            this.btnadmdltproduct.Size = new System.Drawing.Size(75, 23);
            this.btnadmdltproduct.TabIndex = 11;
            this.btnadmdltproduct.Text = "delete";
            this.btnadmdltproduct.UseVisualStyleBackColor = true;
            this.btnadmdltproduct.Click += new System.EventHandler(this.btnadmdltproduct_Click);
            // 
            // lblproductprice
            // 
            this.lblproductprice.AutoSize = true;
            this.lblproductprice.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductprice.Location = new System.Drawing.Point(544, 187);
            this.lblproductprice.Name = "lblproductprice";
            this.lblproductprice.Size = new System.Drawing.Size(41, 17);
            this.lblproductprice.TabIndex = 10;
            this.lblproductprice.Text = "Price";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(544, 147);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(46, 17);
            this.lblproductname.TabIndex = 9;
            this.lblproductname.Text = "Name";
            // 
            // txtproductprice
            // 
            this.txtproductprice.Location = new System.Drawing.Point(617, 184);
            this.txtproductprice.Name = "txtproductprice";
            this.txtproductprice.Size = new System.Drawing.Size(100, 25);
            this.txtproductprice.TabIndex = 8;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(617, 144);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(100, 25);
            this.txtproductname.TabIndex = 7;
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.Location = new System.Drawing.Point(541, 106);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(74, 17);
            this.lblproductid.TabIndex = 6;
            this.lblproductid.Text = "Product Id";
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(617, 103);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(100, 25);
            this.txtproductid.TabIndex = 5;
            // 
            // btnadmupdateproduct
            // 
            this.btnadmupdateproduct.Location = new System.Drawing.Point(219, 430);
            this.btnadmupdateproduct.Name = "btnadmupdateproduct";
            this.btnadmupdateproduct.Size = new System.Drawing.Size(75, 23);
            this.btnadmupdateproduct.TabIndex = 4;
            this.btnadmupdateproduct.Text = "update";
            this.btnadmupdateproduct.UseVisualStyleBackColor = true;
            this.btnadmupdateproduct.Click += new System.EventHandler(this.btnadminupdate_Click);
            // 
            // dgvadminproduct
            // 
            this.dgvadminproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadminproduct.Location = new System.Drawing.Point(0, 38);
            this.dgvadminproduct.Name = "dgvadminproduct";
            this.dgvadminproduct.ReadOnly = true;
            this.dgvadminproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvadminproduct.Size = new System.Drawing.Size(529, 368);
            this.dgvadminproduct.TabIndex = 3;
            this.dgvadminproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvadminproduct_CellClick);
            // 
            // btnadmviewproduct
            // 
            this.btnadmviewproduct.Location = new System.Drawing.Point(8, 430);
            this.btnadmviewproduct.Name = "btnadmviewproduct";
            this.btnadmviewproduct.Size = new System.Drawing.Size(78, 23);
            this.btnadmviewproduct.TabIndex = 2;
            this.btnadmviewproduct.Text = "Load";
            this.btnadmviewproduct.UseVisualStyleBackColor = true;
            this.btnadmviewproduct.Click += new System.EventHandler(this.btnadminview_Click);
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
            // panelpending
            // 
            this.panelpending.Controls.Add(this.btndeclineuser);
            this.panelpending.Controls.Add(this.btnapproveuser);
            this.panelpending.Controls.Add(this.dgvpanelpending);
            this.panelpending.Location = new System.Drawing.Point(526, 48);
            this.panelpending.Name = "panelpending";
            this.panelpending.Size = new System.Drawing.Size(200, 368);
            this.panelpending.TabIndex = 13;
            // 
            // dgvpanelpending
            // 
            this.dgvpanelpending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpanelpending.Location = new System.Drawing.Point(0, 0);
            this.dgvpanelpending.Name = "dgvpanelpending";
            this.dgvpanelpending.ReadOnly = true;
            this.dgvpanelpending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpanelpending.Size = new System.Drawing.Size(200, 272);
            this.dgvpanelpending.TabIndex = 0;
            this.dgvpanelpending.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpanelpending_CellClick);
            // 
            // btnapproveuser
            // 
            this.btnapproveuser.ForeColor = System.Drawing.Color.Green;
            this.btnapproveuser.Location = new System.Drawing.Point(112, 287);
            this.btnapproveuser.Name = "btnapproveuser";
            this.btnapproveuser.Size = new System.Drawing.Size(75, 23);
            this.btnapproveuser.TabIndex = 8;
            this.btnapproveuser.Text = "Approve";
            this.btnapproveuser.UseVisualStyleBackColor = true;
            this.btnapproveuser.Click += new System.EventHandler(this.btnapproveuser_Click);
            // 
            // btndeclineuser
            // 
            this.btndeclineuser.ForeColor = System.Drawing.Color.Tomato;
            this.btndeclineuser.Location = new System.Drawing.Point(13, 287);
            this.btndeclineuser.Name = "btndeclineuser";
            this.btndeclineuser.Size = new System.Drawing.Size(75, 23);
            this.btndeclineuser.TabIndex = 9;
            this.btndeclineuser.Text = "Decline";
            this.btndeclineuser.UseVisualStyleBackColor = true;
            this.btndeclineuser.Click += new System.EventHandler(this.btndeclineuser_Click);
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
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminusers)).EndInit();
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminproduct)).EndInit();
            this.Category.ResumeLayout(false);
            this.Category.PerformLayout();
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            this.panelpending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpanelpending)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexitadmin;
        private System.Windows.Forms.Panel adminleftpanel;
        private System.Windows.Forms.Button tousers;
        private System.Windows.Forms.Button todashboard;
        private System.Windows.Forms.Button tocategory;
        private System.Windows.Forms.Button toproduct;
        private System.Windows.Forms.Label lblshopname;
        private System.Windows.Forms.TabControl tabControlmain;
        private System.Windows.Forms.TabPage User;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Category;
        private System.Windows.Forms.TabPage Dashboard;
        private System.Windows.Forms.Label lbladminuser;
        private System.Windows.Forms.Label lbladminproduct;
        private System.Windows.Forms.Label lbladmincategory;
        private System.Windows.Forms.Label lbldashboard;
        private System.Windows.Forms.DataGridView dgvadminproduct;
        private System.Windows.Forms.Button btnadmviewproduct;
        private System.Windows.Forms.Button btnadmupdateproduct;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.TextBox txtproductprice;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Label lblproductprice;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.DataGridView dgvadminusers;
        private System.Windows.Forms.Button btnadmdltproduct;
        private System.Windows.Forms.Button btnadminviewuser;
        private System.Windows.Forms.Button btnadminupdateuser;
        private System.Windows.Forms.Button btnadminpendinguser;
        private System.Windows.Forms.Button btnadminsertproduct;
        private System.Windows.Forms.Button btnadmdltuser;
        private System.Windows.Forms.Panel panelpending;
        private System.Windows.Forms.DataGridView dgvpanelpending;
        private System.Windows.Forms.Button btndeclineuser;
        private System.Windows.Forms.Button btnapproveuser;
    }
}
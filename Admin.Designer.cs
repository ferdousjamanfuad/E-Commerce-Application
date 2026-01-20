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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.adminleftpanel = new System.Windows.Forms.Panel();
            this.adminprofile = new System.Windows.Forms.PictureBox();
            this.btnlogoutadmin = new System.Windows.Forms.Button();
            this.toSales = new System.Windows.Forms.Button();
            this.toinventory = new System.Windows.Forms.Button();
            this.toproduct = new System.Windows.Forms.Button();
            this.tousers = new System.Windows.Forms.Button();
            this.tabControlmain = new System.Windows.Forms.TabControl();
            this.User = new System.Windows.Forms.TabPage();
            this.userpaneladmin = new System.Windows.Forms.Panel();
            this.lbladminuser = new System.Windows.Forms.Label();
            this.btnadmdltuser = new System.Windows.Forms.Button();
            this.btnadminpendinguser = new System.Windows.Forms.Button();
            this.btnadminviewuser = new System.Windows.Forms.Button();
            this.btnadminupdateuser = new System.Windows.Forms.Button();
            this.dgvadminusers = new System.Windows.Forms.DataGridView();
            this.panelpending = new System.Windows.Forms.Panel();
            this.lblpanelpending = new System.Windows.Forms.Label();
            this.btnexitpending = new System.Windows.Forms.Button();
            this.btndeclineuser = new System.Windows.Forms.Button();
            this.btnapproveuser = new System.Windows.Forms.Button();
            this.dgvpanelpending = new System.Windows.Forms.DataGridView();
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
            this.Inventory = new System.Windows.Forms.TabPage();
            this.btngotoinventory = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.TabPage();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSales = new System.Windows.Forms.Label();
            this.adminleftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminprofile)).BeginInit();
            this.tabControlmain.SuspendLayout();
            this.User.SuspendLayout();
            this.userpaneladmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminusers)).BeginInit();
            this.panelpending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpanelpending)).BeginInit();
            this.Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminproduct)).BeginInit();
            this.Inventory.SuspendLayout();
            this.Sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // adminleftpanel
            // 
            this.adminleftpanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.adminleftpanel.Controls.Add(this.adminprofile);
            this.adminleftpanel.Controls.Add(this.btnlogoutadmin);
            this.adminleftpanel.Controls.Add(this.toSales);
            this.adminleftpanel.Controls.Add(this.toinventory);
            this.adminleftpanel.Controls.Add(this.toproduct);
            this.adminleftpanel.Controls.Add(this.tousers);
            this.adminleftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminleftpanel.Location = new System.Drawing.Point(0, 0);
            this.adminleftpanel.Name = "adminleftpanel";
            this.adminleftpanel.Size = new System.Drawing.Size(185, 507);
            this.adminleftpanel.TabIndex = 1;
            // 
            // adminprofile
            // 
            this.adminprofile.Image = ((System.Drawing.Image)(resources.GetObject("adminprofile.Image")));
            this.adminprofile.Location = new System.Drawing.Point(46, 18);
            this.adminprofile.Name = "adminprofile";
            this.adminprofile.Size = new System.Drawing.Size(100, 50);
            this.adminprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminprofile.TabIndex = 6;
            this.adminprofile.TabStop = false;
            this.adminprofile.Click += new System.EventHandler(this.adminprofile_Click);
            // 
            // btnlogoutadmin
            // 
            this.btnlogoutadmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnlogoutadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogoutadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoutadmin.FlatAppearance.BorderSize = 0;
            this.btnlogoutadmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnlogoutadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogoutadmin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogoutadmin.Image")));
            this.btnlogoutadmin.Location = new System.Drawing.Point(46, 436);
            this.btnlogoutadmin.Name = "btnlogoutadmin";
            this.btnlogoutadmin.Size = new System.Drawing.Size(105, 59);
            this.btnlogoutadmin.TabIndex = 5;
            this.btnlogoutadmin.UseVisualStyleBackColor = false;
            this.btnlogoutadmin.Click += new System.EventHandler(this.btnlogoutadmin_Click);
            // 
            // toSales
            // 
            this.toSales.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toSales.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSales.Location = new System.Drawing.Point(46, 371);
            this.toSales.Name = "toSales";
            this.toSales.Size = new System.Drawing.Size(105, 49);
            this.toSales.TabIndex = 3;
            this.toSales.Text = "$ales";
            this.toSales.UseVisualStyleBackColor = false;
            this.toSales.Click += new System.EventHandler(this.todashboard_Click);
            // 
            // toinventory
            // 
            this.toinventory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toinventory.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toinventory.Location = new System.Drawing.Point(46, 275);
            this.toinventory.Name = "toinventory";
            this.toinventory.Size = new System.Drawing.Size(105, 49);
            this.toinventory.TabIndex = 2;
            this.toinventory.Text = "Inventory";
            this.toinventory.UseVisualStyleBackColor = false;
            this.toinventory.Click += new System.EventHandler(this.toinventory_Click);
            // 
            // toproduct
            // 
            this.toproduct.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toproduct.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tousers.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabControlmain.Controls.Add(this.Inventory);
            this.tabControlmain.Controls.Add(this.Sales);
            this.tabControlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlmain.Location = new System.Drawing.Point(185, 0);
            this.tabControlmain.Name = "tabControlmain";
            this.tabControlmain.SelectedIndex = 0;
            this.tabControlmain.Size = new System.Drawing.Size(757, 507);
            this.tabControlmain.TabIndex = 2;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Controls.Add(this.userpaneladmin);
            this.User.Controls.Add(this.panelpending);
            this.User.Location = new System.Drawing.Point(4, 4);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(3);
            this.User.Size = new System.Drawing.Size(749, 480);
            this.User.TabIndex = 0;
            this.User.Text = "Users";
            // 
            // userpaneladmin
            // 
            this.userpaneladmin.BackColor = System.Drawing.Color.IndianRed;
            this.userpaneladmin.Controls.Add(this.lbladminuser);
            this.userpaneladmin.Controls.Add(this.btnadmdltuser);
            this.userpaneladmin.Controls.Add(this.btnadminpendinguser);
            this.userpaneladmin.Controls.Add(this.btnadminviewuser);
            this.userpaneladmin.Controls.Add(this.btnadminupdateuser);
            this.userpaneladmin.Controls.Add(this.dgvadminusers);
            this.userpaneladmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userpaneladmin.Location = new System.Drawing.Point(3, 3);
            this.userpaneladmin.Name = "userpaneladmin";
            this.userpaneladmin.Size = new System.Drawing.Size(743, 474);
            this.userpaneladmin.TabIndex = 13;
            // 
            // lbladminuser
            // 
            this.lbladminuser.AutoSize = true;
            this.lbladminuser.BackColor = System.Drawing.Color.Transparent;
            this.lbladminuser.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladminuser.Location = new System.Drawing.Point(307, 14);
            this.lbladminuser.Name = "lbladminuser";
            this.lbladminuser.Size = new System.Drawing.Size(123, 27);
            this.lbladminuser.TabIndex = 0;
            this.lbladminuser.Text = "User Panel";
            // 
            // btnadmdltuser
            // 
            this.btnadmdltuser.Location = new System.Drawing.Point(521, 429);
            this.btnadmdltuser.Name = "btnadmdltuser";
            this.btnadmdltuser.Size = new System.Drawing.Size(75, 23);
            this.btnadmdltuser.TabIndex = 12;
            this.btnadmdltuser.Text = "delete";
            this.btnadmdltuser.UseVisualStyleBackColor = true;
            this.btnadmdltuser.Click += new System.EventHandler(this.btnadmdltuser_Click);
            // 
            // btnadminpendinguser
            // 
            this.btnadminpendinguser.Location = new System.Drawing.Point(401, 429);
            this.btnadminpendinguser.Name = "btnadminpendinguser";
            this.btnadminpendinguser.Size = new System.Drawing.Size(75, 23);
            this.btnadminpendinguser.TabIndex = 7;
            this.btnadminpendinguser.Text = "Pending";
            this.btnadminpendinguser.UseVisualStyleBackColor = true;
            this.btnadminpendinguser.Click += new System.EventHandler(this.btnadminpendinguser_Click);
            // 
            // btnadminviewuser
            // 
            this.btnadminviewuser.BackColor = System.Drawing.Color.Transparent;
            this.btnadminviewuser.Location = new System.Drawing.Point(146, 429);
            this.btnadminviewuser.Name = "btnadminviewuser";
            this.btnadminviewuser.Size = new System.Drawing.Size(78, 23);
            this.btnadminviewuser.TabIndex = 5;
            this.btnadminviewuser.Text = "Load";
            this.btnadminviewuser.UseVisualStyleBackColor = false;
            this.btnadminviewuser.Click += new System.EventHandler(this.btnadminviewuser_Click);
            // 
            // btnadminupdateuser
            // 
            this.btnadminupdateuser.Location = new System.Drawing.Point(274, 429);
            this.btnadminupdateuser.Name = "btnadminupdateuser";
            this.btnadminupdateuser.Size = new System.Drawing.Size(75, 23);
            this.btnadminupdateuser.TabIndex = 6;
            this.btnadminupdateuser.Text = "Update";
            this.btnadminupdateuser.UseVisualStyleBackColor = true;
            this.btnadminupdateuser.Click += new System.EventHandler(this.btnadminupdateuser_Click);
            // 
            // dgvadminusers
            // 
            this.dgvadminusers.AllowUserToAddRows = false;
            this.dgvadminusers.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvadminusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadminusers.GridColor = System.Drawing.Color.LightGreen;
            this.dgvadminusers.Location = new System.Drawing.Point(48, 54);
            this.dgvadminusers.MultiSelect = false;
            this.dgvadminusers.Name = "dgvadminusers";
            this.dgvadminusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvadminusers.Size = new System.Drawing.Size(656, 359);
            this.dgvadminusers.TabIndex = 4;
            // 
            // panelpending
            // 
            this.panelpending.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelpending.Controls.Add(this.lblpanelpending);
            this.panelpending.Controls.Add(this.btnexitpending);
            this.panelpending.Controls.Add(this.btndeclineuser);
            this.panelpending.Controls.Add(this.btnapproveuser);
            this.panelpending.Controls.Add(this.dgvpanelpending);
            this.panelpending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelpending.Location = new System.Drawing.Point(3, 3);
            this.panelpending.Name = "panelpending";
            this.panelpending.Size = new System.Drawing.Size(743, 474);
            this.panelpending.TabIndex = 13;
            // 
            // lblpanelpending
            // 
            this.lblpanelpending.AutoSize = true;
            this.lblpanelpending.BackColor = System.Drawing.Color.Transparent;
            this.lblpanelpending.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpanelpending.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblpanelpending.Location = new System.Drawing.Point(244, 22);
            this.lblpanelpending.Name = "lblpanelpending";
            this.lblpanelpending.Size = new System.Drawing.Size(208, 35);
            this.lblpanelpending.TabIndex = 11;
            this.lblpanelpending.Text = "Pending Users";
            // 
            // btnexitpending
            // 
            this.btnexitpending.ForeColor = System.Drawing.Color.Blue;
            this.btnexitpending.Location = new System.Drawing.Point(653, 310);
            this.btnexitpending.Name = "btnexitpending";
            this.btnexitpending.Size = new System.Drawing.Size(75, 60);
            this.btnexitpending.TabIndex = 10;
            this.btnexitpending.Text = "Exit";
            this.btnexitpending.UseVisualStyleBackColor = true;
            this.btnexitpending.Click += new System.EventHandler(this.btnexitpending_Click);
            // 
            // btndeclineuser
            // 
            this.btndeclineuser.ForeColor = System.Drawing.Color.Tomato;
            this.btndeclineuser.Location = new System.Drawing.Point(653, 216);
            this.btndeclineuser.Name = "btndeclineuser";
            this.btndeclineuser.Size = new System.Drawing.Size(75, 60);
            this.btndeclineuser.TabIndex = 9;
            this.btndeclineuser.Text = "Decline";
            this.btndeclineuser.UseVisualStyleBackColor = true;
            this.btndeclineuser.Click += new System.EventHandler(this.btndeclineuser_Click);
            // 
            // btnapproveuser
            // 
            this.btnapproveuser.ForeColor = System.Drawing.Color.Green;
            this.btnapproveuser.Location = new System.Drawing.Point(653, 112);
            this.btnapproveuser.Name = "btnapproveuser";
            this.btnapproveuser.Size = new System.Drawing.Size(75, 61);
            this.btnapproveuser.TabIndex = 8;
            this.btnapproveuser.Text = "Approve";
            this.btnapproveuser.UseVisualStyleBackColor = true;
            this.btnapproveuser.Click += new System.EventHandler(this.btnapproveuser_Click);
            // 
            // dgvpanelpending
            // 
            this.dgvpanelpending.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvpanelpending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpanelpending.Location = new System.Drawing.Point(38, 97);
            this.dgvpanelpending.Name = "dgvpanelpending";
            this.dgvpanelpending.ReadOnly = true;
            this.dgvpanelpending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpanelpending.Size = new System.Drawing.Size(594, 292);
            this.dgvpanelpending.TabIndex = 0;
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
            this.btnadminsertproduct.Location = new System.Drawing.Point(143, 430);
            this.btnadminsertproduct.Name = "btnadminsertproduct";
            this.btnadminsertproduct.Size = new System.Drawing.Size(97, 23);
            this.btnadminsertproduct.TabIndex = 12;
            this.btnadminsertproduct.Text = "insert";
            this.btnadminsertproduct.UseVisualStyleBackColor = true;
            this.btnadminsertproduct.Click += new System.EventHandler(this.btnadminsertproduct_Click);
            // 
            // btnadmdltproduct
            // 
            this.btnadmdltproduct.Location = new System.Drawing.Point(388, 430);
            this.btnadmdltproduct.Name = "btnadmdltproduct";
            this.btnadmdltproduct.Size = new System.Drawing.Size(92, 23);
            this.btnadmdltproduct.TabIndex = 11;
            this.btnadmdltproduct.Text = "delete";
            this.btnadmdltproduct.UseVisualStyleBackColor = true;
            this.btnadmdltproduct.Click += new System.EventHandler(this.btnadmdltproduct_Click);
            // 
            // lblproductprice
            // 
            this.lblproductprice.AutoSize = true;
            this.lblproductprice.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductprice.Location = new System.Drawing.Point(545, 211);
            this.lblproductprice.Name = "lblproductprice";
            this.lblproductprice.Size = new System.Drawing.Size(41, 17);
            this.lblproductprice.TabIndex = 10;
            this.lblproductprice.Text = "Price";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(545, 161);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(46, 17);
            this.lblproductname.TabIndex = 9;
            this.lblproductname.Text = "Name";
            // 
            // txtproductprice
            // 
            this.txtproductprice.Location = new System.Drawing.Point(618, 208);
            this.txtproductprice.Name = "txtproductprice";
            this.txtproductprice.Size = new System.Drawing.Size(100, 25);
            this.txtproductprice.TabIndex = 8;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(618, 158);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(100, 25);
            this.txtproductname.TabIndex = 7;
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.Location = new System.Drawing.Point(541, 110);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(74, 17);
            this.lblproductid.TabIndex = 6;
            this.lblproductid.Text = "Product Id";
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(618, 107);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.ReadOnly = true;
            this.txtproductid.Size = new System.Drawing.Size(100, 25);
            this.txtproductid.TabIndex = 5;
            // 
            // btnadmupdateproduct
            // 
            this.btnadmupdateproduct.Location = new System.Drawing.Point(262, 430);
            this.btnadmupdateproduct.Name = "btnadmupdateproduct";
            this.btnadmupdateproduct.Size = new System.Drawing.Size(99, 23);
            this.btnadmupdateproduct.TabIndex = 4;
            this.btnadmupdateproduct.Text = "update";
            this.btnadmupdateproduct.UseVisualStyleBackColor = true;
            this.btnadmupdateproduct.Click += new System.EventHandler(this.btnadminupdate_Click);
            // 
            // dgvadminproduct
            // 
            this.dgvadminproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadminproduct.Location = new System.Drawing.Point(3, 44);
            this.dgvadminproduct.MultiSelect = false;
            this.dgvadminproduct.Name = "dgvadminproduct";
            this.dgvadminproduct.ReadOnly = true;
            this.dgvadminproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvadminproduct.Size = new System.Drawing.Size(526, 368);
            this.dgvadminproduct.TabIndex = 3;
            this.dgvadminproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvadminproduct_CellClick);
            // 
            // btnadmviewproduct
            // 
            this.btnadmviewproduct.Location = new System.Drawing.Point(22, 430);
            this.btnadmviewproduct.Name = "btnadmviewproduct";
            this.btnadmviewproduct.Size = new System.Drawing.Size(93, 23);
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
            // Inventory
            // 
            this.Inventory.BackColor = System.Drawing.Color.Teal;
            this.Inventory.Controls.Add(this.btngotoinventory);
            this.Inventory.Location = new System.Drawing.Point(4, 4);
            this.Inventory.Name = "Inventory";
            this.Inventory.Padding = new System.Windows.Forms.Padding(3);
            this.Inventory.Size = new System.Drawing.Size(749, 480);
            this.Inventory.TabIndex = 2;
            this.Inventory.Text = "Inventory";
            // 
            // btngotoinventory
            // 
            this.btngotoinventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btngotoinventory.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngotoinventory.ForeColor = System.Drawing.Color.Firebrick;
            this.btngotoinventory.Location = new System.Drawing.Point(3, 3);
            this.btngotoinventory.Name = "btngotoinventory";
            this.btngotoinventory.Size = new System.Drawing.Size(743, 474);
            this.btngotoinventory.TabIndex = 2;
            this.btngotoinventory.Text = "Move to Inventory";
            this.btngotoinventory.UseVisualStyleBackColor = true;
            this.btngotoinventory.Click += new System.EventHandler(this.btngotoinventory_Click);
            // 
            // Sales
            // 
            this.Sales.BackColor = System.Drawing.Color.Teal;
            this.Sales.Controls.Add(this.chartSales);
            this.Sales.Controls.Add(this.lblSales);
            this.Sales.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Sales.Location = new System.Drawing.Point(4, 4);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(3);
            this.Sales.Size = new System.Drawing.Size(749, 480);
            this.Sales.TabIndex = 3;
            this.Sales.Text = "Dashboard";
            // 
            // chartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSales.Legends.Add(legend1);
            this.chartSales.Location = new System.Drawing.Point(31, 68);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(683, 382);
            this.chartSales.TabIndex = 3;
            this.chartSales.Text = "chart1";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.BackColor = System.Drawing.Color.Transparent;
            this.lblSales.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(311, 10);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(152, 27);
            this.lblSales.TabIndex = 2;
            this.lblSales.Text = "Total Sales($)";
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
            this.Load += new System.EventHandler(this.Admin_Load);
            this.adminleftpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminprofile)).EndInit();
            this.tabControlmain.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.userpaneladmin.ResumeLayout(false);
            this.userpaneladmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminusers)).EndInit();
            this.panelpending.ResumeLayout(false);
            this.panelpending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpanelpending)).EndInit();
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadminproduct)).EndInit();
            this.Inventory.ResumeLayout(false);
            this.Sales.ResumeLayout(false);
            this.Sales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel adminleftpanel;
        private System.Windows.Forms.Button tousers;
        private System.Windows.Forms.Button toSales;
        private System.Windows.Forms.Button toinventory;
        private System.Windows.Forms.Button toproduct;
        private System.Windows.Forms.TabControl tabControlmain;
        private System.Windows.Forms.TabPage User;
        private System.Windows.Forms.TabPage Product;
        private System.Windows.Forms.TabPage Inventory;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.Label lbladminuser;
        private System.Windows.Forms.Label lbladminproduct;
        private System.Windows.Forms.Label lblSales;
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
        private System.Windows.Forms.Button btnexitpending;
        private System.Windows.Forms.Label lblpanelpending;
        private System.Windows.Forms.Panel userpaneladmin;
        private System.Windows.Forms.Button btngotoinventory;
        private System.Windows.Forms.Button btnlogoutadmin;
        private System.Windows.Forms.PictureBox adminprofile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
    }
}
namespace BakeryShopManagementSystem
{
    partial class ProductionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionManager));
            this.btnpmstock = new System.Windows.Forms.Button();
            this.btnexitpm = new System.Windows.Forms.Button();
            this.dgvpm = new System.Windows.Forms.DataGridView();
            this.btnpmloadproduct = new System.Windows.Forms.Button();
            this.panelpmleft = new System.Windows.Forms.Panel();
            this.btnpmnewproduct = new System.Windows.Forms.Button();
            this.cmbpmproductname = new System.Windows.Forms.ComboBox();
            this.lblpmproductquan = new System.Windows.Forms.Label();
            this.txtpmproductquan = new System.Windows.Forms.TextBox();
            this.lblpmproductname = new System.Windows.Forms.Label();
            this.lblpmproductprice = new System.Windows.Forms.Label();
            this.txtpmproductprice = new System.Windows.Forms.TextBox();
            this.dgvpminv = new System.Windows.Forms.DataGridView();
            this.btnpmrefreshinv = new System.Windows.Forms.Button();
            this.pnlpminv = new System.Windows.Forms.Panel();
            this.btnpmdone = new System.Windows.Forms.Button();
            this.btnpmdeduct = new System.Windows.Forms.Button();
            this.txtUsedInventoryQty = new System.Windows.Forms.TextBox();
            this.cmbpminv_item = new System.Windows.Forms.ComboBox();
            this.pmprofile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpm)).BeginInit();
            this.panelpmleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpminv)).BeginInit();
            this.pnlpminv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnpmstock
            // 
            this.btnpmstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmstock.Location = new System.Drawing.Point(47, 401);
            this.btnpmstock.Margin = new System.Windows.Forms.Padding(4);
            this.btnpmstock.Name = "btnpmstock";
            this.btnpmstock.Size = new System.Drawing.Size(147, 57);
            this.btnpmstock.TabIndex = 16;
            this.btnpmstock.Text = "Stock";
            this.btnpmstock.UseVisualStyleBackColor = true;
            this.btnpmstock.Click += new System.EventHandler(this.btnpmstock_Click);
            // 
            // btnexitpm
            // 
            this.btnexitpm.BackColor = System.Drawing.Color.AliceBlue;
            this.btnexitpm.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitpm.Location = new System.Drawing.Point(-1, 601);
            this.btnexitpm.Margin = new System.Windows.Forms.Padding(4);
            this.btnexitpm.Name = "btnexitpm";
            this.btnexitpm.Size = new System.Drawing.Size(264, 37);
            this.btnexitpm.TabIndex = 2;
            this.btnexitpm.Text = "Logout";
            this.btnexitpm.UseVisualStyleBackColor = false;
            this.btnexitpm.Click += new System.EventHandler(this.btnexitpm_Click_1);
            // 
            // dgvpm
            // 
            this.dgvpm.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpm.Location = new System.Drawing.Point(261, 15);
            this.dgvpm.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpm.MultiSelect = false;
            this.dgvpm.Name = "dgvpm";
            this.dgvpm.ReadOnly = true;
            this.dgvpm.RowHeadersWidth = 82;
            this.dgvpm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpm.Size = new System.Drawing.Size(571, 348);
            this.dgvpm.TabIndex = 31;
            // 
            // btnpmloadproduct
            // 
            this.btnpmloadproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmloadproduct.Location = new System.Drawing.Point(47, 133);
            this.btnpmloadproduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnpmloadproduct.Name = "btnpmloadproduct";
            this.btnpmloadproduct.Size = new System.Drawing.Size(147, 71);
            this.btnpmloadproduct.TabIndex = 13;
            this.btnpmloadproduct.Text = "Load";
            this.btnpmloadproduct.UseVisualStyleBackColor = true;
            this.btnpmloadproduct.Click += new System.EventHandler(this.btnpmloadproduct_Click);
            // 
            // panelpmleft
            // 
            this.panelpmleft.BackColor = System.Drawing.Color.Azure;
            this.panelpmleft.Controls.Add(this.pmprofile);
            this.panelpmleft.Controls.Add(this.btnpmnewproduct);
            this.panelpmleft.Controls.Add(this.btnpmstock);
            this.panelpmleft.Controls.Add(this.btnexitpm);
            this.panelpmleft.Controls.Add(this.btnpmloadproduct);
            this.panelpmleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelpmleft.Location = new System.Drawing.Point(0, 0);
            this.panelpmleft.Margin = new System.Windows.Forms.Padding(4);
            this.panelpmleft.Name = "panelpmleft";
            this.panelpmleft.Size = new System.Drawing.Size(263, 639);
            this.panelpmleft.TabIndex = 32;
            // 
            // btnpmnewproduct
            // 
            this.btnpmnewproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmnewproduct.Location = new System.Drawing.Point(47, 281);
            this.btnpmnewproduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnpmnewproduct.Name = "btnpmnewproduct";
            this.btnpmnewproduct.Size = new System.Drawing.Size(147, 62);
            this.btnpmnewproduct.TabIndex = 31;
            this.btnpmnewproduct.Text = "New";
            this.btnpmnewproduct.UseVisualStyleBackColor = true;
            this.btnpmnewproduct.Click += new System.EventHandler(this.btnpmnewproduct_Click);
            // 
            // cmbpmproductname
            // 
            this.cmbpmproductname.FormattingEnabled = true;
            this.cmbpmproductname.Location = new System.Drawing.Point(351, 431);
            this.cmbpmproductname.Margin = new System.Windows.Forms.Padding(4);
            this.cmbpmproductname.Name = "cmbpmproductname";
            this.cmbpmproductname.Size = new System.Drawing.Size(132, 24);
            this.cmbpmproductname.TabIndex = 36;
            // 
            // lblpmproductquan
            // 
            this.lblpmproductquan.AutoSize = true;
            this.lblpmproductquan.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmproductquan.Location = new System.Drawing.Point(124, 450);
            this.lblpmproductquan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpmproductquan.Name = "lblpmproductquan";
            this.lblpmproductquan.Size = new System.Drawing.Size(146, 22);
            this.lblpmproductquan.TabIndex = 35;
            this.lblpmproductquan.Text = "product quantity";
            // 
            // txtpmproductquan
            // 
            this.txtpmproductquan.Location = new System.Drawing.Point(136, 486);
            this.txtpmproductquan.Margin = new System.Windows.Forms.Padding(4);
            this.txtpmproductquan.Name = "txtpmproductquan";
            this.txtpmproductquan.Size = new System.Drawing.Size(128, 22);
            this.txtpmproductquan.TabIndex = 34;
            // 
            // lblpmproductname
            // 
            this.lblpmproductname.AutoSize = true;
            this.lblpmproductname.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmproductname.Location = new System.Drawing.Point(353, 396);
            this.lblpmproductname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpmproductname.Name = "lblpmproductname";
            this.lblpmproductname.Size = new System.Drawing.Size(124, 22);
            this.lblpmproductname.TabIndex = 33;
            this.lblpmproductname.Text = "product name";
            // 
            // lblpmproductprice
            // 
            this.lblpmproductprice.AutoSize = true;
            this.lblpmproductprice.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmproductprice.Location = new System.Drawing.Point(587, 396);
            this.lblpmproductprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpmproductprice.Name = "lblpmproductprice";
            this.lblpmproductprice.Size = new System.Drawing.Size(119, 22);
            this.lblpmproductprice.TabIndex = 37;
            this.lblpmproductprice.Text = "product price";
            // 
            // txtpmproductprice
            // 
            this.txtpmproductprice.Location = new System.Drawing.Point(591, 432);
            this.txtpmproductprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtpmproductprice.Name = "txtpmproductprice";
            this.txtpmproductprice.Size = new System.Drawing.Size(128, 22);
            this.txtpmproductprice.TabIndex = 38;
            this.txtpmproductprice.Text = "0";
            // 
            // dgvpminv
            // 
            this.dgvpminv.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvpminv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpminv.Location = new System.Drawing.Point(0, 4);
            this.dgvpminv.Margin = new System.Windows.Forms.Padding(4);
            this.dgvpminv.MultiSelect = false;
            this.dgvpminv.Name = "dgvpminv";
            this.dgvpminv.ReadOnly = true;
            this.dgvpminv.RowHeadersWidth = 82;
            this.dgvpminv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpminv.Size = new System.Drawing.Size(388, 279);
            this.dgvpminv.TabIndex = 39;
            // 
            // btnpmrefreshinv
            // 
            this.btnpmrefreshinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmrefreshinv.Location = new System.Drawing.Point(152, 539);
            this.btnpmrefreshinv.Margin = new System.Windows.Forms.Padding(4);
            this.btnpmrefreshinv.Name = "btnpmrefreshinv";
            this.btnpmrefreshinv.Size = new System.Drawing.Size(100, 42);
            this.btnpmrefreshinv.TabIndex = 40;
            this.btnpmrefreshinv.Text = "refresh";
            this.btnpmrefreshinv.UseVisualStyleBackColor = true;
            this.btnpmrefreshinv.Click += new System.EventHandler(this.btnpmrefreshinv_Click);
            // 
            // pnlpminv
            // 
            this.pnlpminv.Controls.Add(this.btnpmdone);
            this.pnlpminv.Controls.Add(this.btnpmdeduct);
            this.pnlpminv.Controls.Add(this.txtUsedInventoryQty);
            this.pnlpminv.Controls.Add(this.cmbpminv_item);
            this.pnlpminv.Controls.Add(this.dgvpminv);
            this.pnlpminv.Controls.Add(this.btnpmrefreshinv);
            this.pnlpminv.Controls.Add(this.lblpmproductquan);
            this.pnlpminv.Controls.Add(this.txtpmproductquan);
            this.pnlpminv.Location = new System.Drawing.Point(840, 15);
            this.pnlpminv.Margin = new System.Windows.Forms.Padding(4);
            this.pnlpminv.Name = "pnlpminv";
            this.pnlpminv.Size = new System.Drawing.Size(392, 609);
            this.pnlpminv.TabIndex = 41;
            // 
            // btnpmdone
            // 
            this.btnpmdone.BackColor = System.Drawing.Color.LawnGreen;
            this.btnpmdone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmdone.Location = new System.Drawing.Point(248, 382);
            this.btnpmdone.Margin = new System.Windows.Forms.Padding(4);
            this.btnpmdone.Name = "btnpmdone";
            this.btnpmdone.Size = new System.Drawing.Size(100, 42);
            this.btnpmdone.TabIndex = 44;
            this.btnpmdone.Text = "Done";
            this.btnpmdone.UseVisualStyleBackColor = false;
            this.btnpmdone.Click += new System.EventHandler(this.btnpmdone_Click);
            // 
            // btnpmdeduct
            // 
            this.btnpmdeduct.BackColor = System.Drawing.Color.Crimson;
            this.btnpmdeduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmdeduct.Location = new System.Drawing.Point(43, 382);
            this.btnpmdeduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnpmdeduct.Name = "btnpmdeduct";
            this.btnpmdeduct.Size = new System.Drawing.Size(100, 42);
            this.btnpmdeduct.TabIndex = 43;
            this.btnpmdeduct.Text = "Deduct";
            this.btnpmdeduct.UseVisualStyleBackColor = false;
            this.btnpmdeduct.Click += new System.EventHandler(this.btnpmdeduct_Click);
            // 
            // txtUsedInventoryQty
            // 
            this.txtUsedInventoryQty.Location = new System.Drawing.Point(219, 324);
            this.txtUsedInventoryQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsedInventoryQty.Name = "txtUsedInventoryQty";
            this.txtUsedInventoryQty.Size = new System.Drawing.Size(128, 22);
            this.txtUsedInventoryQty.TabIndex = 42;
            // 
            // cmbpminv_item
            // 
            this.cmbpminv_item.FormattingEnabled = true;
            this.cmbpminv_item.Location = new System.Drawing.Point(28, 324);
            this.cmbpminv_item.Margin = new System.Windows.Forms.Padding(4);
            this.cmbpminv_item.Name = "cmbpminv_item";
            this.cmbpminv_item.Size = new System.Drawing.Size(132, 24);
            this.cmbpminv_item.TabIndex = 42;
            // 
            // pmprofile
            // 
            this.pmprofile.Image = ((System.Drawing.Image)(resources.GetObject("pmprofile.Image")));
            this.pmprofile.Location = new System.Drawing.Point(71, 31);
            this.pmprofile.Name = "pmprofile";
            this.pmprofile.Size = new System.Drawing.Size(100, 50);
            this.pmprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pmprofile.TabIndex = 32;
            this.pmprofile.TabStop = false;
            this.pmprofile.Click += new System.EventHandler(this.pmprofile_Click);
            // 
            // ProductionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1233, 639);
            this.Controls.Add(this.pnlpminv);
            this.Controls.Add(this.txtpmproductprice);
            this.Controls.Add(this.lblpmproductprice);
            this.Controls.Add(this.dgvpm);
            this.Controls.Add(this.panelpmleft);
            this.Controls.Add(this.cmbpmproductname);
            this.Controls.Add(this.lblpmproductname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionManager";
            this.Load += new System.EventHandler(this.ProductionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpm)).EndInit();
            this.panelpmleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpminv)).EndInit();
            this.pnlpminv.ResumeLayout(false);
            this.pnlpminv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pmprofile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpmstock;
        private System.Windows.Forms.Button btnexitpm;
        private System.Windows.Forms.DataGridView dgvpm;
        private System.Windows.Forms.Button btnpmloadproduct;
        private System.Windows.Forms.Panel panelpmleft;
        private System.Windows.Forms.Button btnpmnewproduct;
        private System.Windows.Forms.ComboBox cmbpmproductname;
        private System.Windows.Forms.Label lblpmproductquan;
        private System.Windows.Forms.TextBox txtpmproductquan;
        private System.Windows.Forms.Label lblpmproductname;
        private System.Windows.Forms.Label lblpmproductprice;
        private System.Windows.Forms.TextBox txtpmproductprice;
        private System.Windows.Forms.DataGridView dgvpminv;
        private System.Windows.Forms.Button btnpmrefreshinv;
        private System.Windows.Forms.Panel pnlpminv;
        private System.Windows.Forms.ComboBox cmbpminv_item;
        private System.Windows.Forms.TextBox txtUsedInventoryQty;
        private System.Windows.Forms.Button btnpmdone;
        private System.Windows.Forms.Button btnpmdeduct;
        private System.Windows.Forms.PictureBox pmprofile;
    }
}
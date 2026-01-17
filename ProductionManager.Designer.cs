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
            ((System.ComponentModel.ISupportInitialize)(this.dgvpm)).BeginInit();
            this.panelpmleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpmstock
            // 
            this.btnpmstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmstock.Location = new System.Drawing.Point(43, 275);
            this.btnpmstock.Name = "btnpmstock";
            this.btnpmstock.Size = new System.Drawing.Size(110, 46);
            this.btnpmstock.TabIndex = 16;
            this.btnpmstock.Text = "Stock";
            this.btnpmstock.UseVisualStyleBackColor = true;
            this.btnpmstock.Click += new System.EventHandler(this.btnpmstock_Click);
            // 
            // btnexitpm
            // 
            this.btnexitpm.BackColor = System.Drawing.Color.AliceBlue;
            this.btnexitpm.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitpm.Location = new System.Drawing.Point(-1, 488);
            this.btnexitpm.Name = "btnexitpm";
            this.btnexitpm.Size = new System.Drawing.Size(198, 30);
            this.btnexitpm.TabIndex = 2;
            this.btnexitpm.Text = "Logout";
            this.btnexitpm.UseVisualStyleBackColor = false;
            this.btnexitpm.Click += new System.EventHandler(this.btnexitpm_Click_1);
            // 
            // dgvpm
            // 
            this.dgvpm.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpm.Location = new System.Drawing.Point(296, 26);
            this.dgvpm.MultiSelect = false;
            this.dgvpm.Name = "dgvpm";
            this.dgvpm.ReadOnly = true;
            this.dgvpm.RowHeadersWidth = 82;
            this.dgvpm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpm.Size = new System.Drawing.Size(558, 377);
            this.dgvpm.TabIndex = 31;
            // 
            // btnpmloadproduct
            // 
            this.btnpmloadproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmloadproduct.Location = new System.Drawing.Point(43, 98);
            this.btnpmloadproduct.Name = "btnpmloadproduct";
            this.btnpmloadproduct.Size = new System.Drawing.Size(110, 58);
            this.btnpmloadproduct.TabIndex = 13;
            this.btnpmloadproduct.Text = "Load";
            this.btnpmloadproduct.UseVisualStyleBackColor = true;
            this.btnpmloadproduct.Click += new System.EventHandler(this.btnpmloadproduct_Click);
            // 
            // panelpmleft
            // 
            this.panelpmleft.BackColor = System.Drawing.Color.Azure;
            this.panelpmleft.Controls.Add(this.btnpmnewproduct);
            this.panelpmleft.Controls.Add(this.btnpmstock);
            this.panelpmleft.Controls.Add(this.btnexitpm);
            this.panelpmleft.Controls.Add(this.btnpmloadproduct);
            this.panelpmleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelpmleft.Location = new System.Drawing.Point(0, 0);
            this.panelpmleft.Name = "panelpmleft";
            this.panelpmleft.Size = new System.Drawing.Size(197, 519);
            this.panelpmleft.TabIndex = 32;
            // 
            // btnpmnewproduct
            // 
            this.btnpmnewproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpmnewproduct.Location = new System.Drawing.Point(43, 194);
            this.btnpmnewproduct.Name = "btnpmnewproduct";
            this.btnpmnewproduct.Size = new System.Drawing.Size(110, 50);
            this.btnpmnewproduct.TabIndex = 31;
            this.btnpmnewproduct.Text = "New";
            this.btnpmnewproduct.UseVisualStyleBackColor = true;
            this.btnpmnewproduct.Click += new System.EventHandler(this.btnpmnewproduct_Click);
            // 
            // cmbpmproductname
            // 
            this.cmbpmproductname.FormattingEnabled = true;
            this.cmbpmproductname.Location = new System.Drawing.Point(330, 450);
            this.cmbpmproductname.Name = "cmbpmproductname";
            this.cmbpmproductname.Size = new System.Drawing.Size(100, 21);
            this.cmbpmproductname.TabIndex = 36;
            // 
            // lblpmproductquan
            // 
            this.lblpmproductquan.AutoSize = true;
            this.lblpmproductquan.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmproductquan.Location = new System.Drawing.Point(506, 421);
            this.lblpmproductquan.Name = "lblpmproductquan";
            this.lblpmproductquan.Size = new System.Drawing.Size(114, 17);
            this.lblpmproductquan.TabIndex = 35;
            this.lblpmproductquan.Text = "product quantity";
            // 
            // txtpmproductquan
            // 
            this.txtpmproductquan.Location = new System.Drawing.Point(515, 450);
            this.txtpmproductquan.Name = "txtpmproductquan";
            this.txtpmproductquan.Size = new System.Drawing.Size(97, 20);
            this.txtpmproductquan.TabIndex = 34;
            // 
            // lblpmproductname
            // 
            this.lblpmproductname.AutoSize = true;
            this.lblpmproductname.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmproductname.Location = new System.Drawing.Point(332, 422);
            this.lblpmproductname.Name = "lblpmproductname";
            this.lblpmproductname.Size = new System.Drawing.Size(97, 17);
            this.lblpmproductname.TabIndex = 33;
            this.lblpmproductname.Text = "product name";
            // 
            // lblpmproductprice
            // 
            this.lblpmproductprice.AutoSize = true;
            this.lblpmproductprice.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpmproductprice.Location = new System.Drawing.Point(673, 421);
            this.lblpmproductprice.Name = "lblpmproductprice";
            this.lblpmproductprice.Size = new System.Drawing.Size(93, 17);
            this.lblpmproductprice.TabIndex = 37;
            this.lblpmproductprice.Text = "product price";
            // 
            // txtpmproductprice
            // 
            this.txtpmproductprice.Location = new System.Drawing.Point(676, 450);
            this.txtpmproductprice.Name = "txtpmproductprice";
            this.txtpmproductprice.Size = new System.Drawing.Size(97, 20);
            this.txtpmproductprice.TabIndex = 38;
            // 
            // ProductionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(925, 519);
            this.Controls.Add(this.txtpmproductprice);
            this.Controls.Add(this.lblpmproductprice);
            this.Controls.Add(this.dgvpm);
            this.Controls.Add(this.panelpmleft);
            this.Controls.Add(this.cmbpmproductname);
            this.Controls.Add(this.lblpmproductquan);
            this.Controls.Add(this.txtpmproductquan);
            this.Controls.Add(this.lblpmproductname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionManager";
            this.Load += new System.EventHandler(this.ProductionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpm)).EndInit();
            this.panelpmleft.ResumeLayout(false);
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
    }
}
namespace BakeryShopManagementSystem
{
    partial class InventoryManager
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
            this.btnexitim = new System.Windows.Forms.Button();
            this.btnInvbuyproduct = new System.Windows.Forms.Button();
            this.btnInvremove = new System.Windows.Forms.Button();
            this.dgvInventoryitem = new System.Windows.Forms.DataGridView();
            this.btnviewinventory = new System.Windows.Forms.Button();
            this.btnbacktoadmin = new System.Windows.Forms.Button();
            this.panelInvleft = new System.Windows.Forms.Panel();
            this.lblInvitemname = new System.Windows.Forms.Label();
            this.lblInvitemquan = new System.Windows.Forms.Label();
            this.txtInvitemquan = new System.Windows.Forms.TextBox();
            this.cmbInvitemname = new System.Windows.Forms.ComboBox();
            this.cmbInvunit = new System.Windows.Forms.ComboBox();
            this.lblInvunit = new System.Windows.Forms.Label();
            this.btnInvadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryitem)).BeginInit();
            this.panelInvleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexitim
            // 
            this.btnexitim.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnexitim.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitim.Location = new System.Drawing.Point(-1, 480);
            this.btnexitim.Name = "btnexitim";
            this.btnexitim.Size = new System.Drawing.Size(198, 30);
            this.btnexitim.TabIndex = 2;
            this.btnexitim.Text = "Logout";
            this.btnexitim.UseVisualStyleBackColor = false;
            this.btnexitim.Click += new System.EventHandler(this.btnexitim_Click);
            // 
            // btnInvbuyproduct
            // 
            this.btnInvbuyproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvbuyproduct.Location = new System.Drawing.Point(43, 360);
            this.btnInvbuyproduct.Name = "btnInvbuyproduct";
            this.btnInvbuyproduct.Size = new System.Drawing.Size(110, 50);
            this.btnInvbuyproduct.TabIndex = 17;
            this.btnInvbuyproduct.Text = "Buy";
            this.btnInvbuyproduct.UseVisualStyleBackColor = true;
            this.btnInvbuyproduct.Click += new System.EventHandler(this.btnInvbuyproduct_Click);
            // 
            // btnInvremove
            // 
            this.btnInvremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvremove.Location = new System.Drawing.Point(43, 275);
            this.btnInvremove.Name = "btnInvremove";
            this.btnInvremove.Size = new System.Drawing.Size(110, 46);
            this.btnInvremove.TabIndex = 16;
            this.btnInvremove.Text = "Remove";
            this.btnInvremove.UseVisualStyleBackColor = true;
            this.btnInvremove.Click += new System.EventHandler(this.btnInvremove_Click);
            // 
            // dgvInventoryitem
            // 
            this.dgvInventoryitem.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvInventoryitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryitem.Location = new System.Drawing.Point(227, 26);
            this.dgvInventoryitem.MultiSelect = false;
            this.dgvInventoryitem.Name = "dgvInventoryitem";
            this.dgvInventoryitem.ReadOnly = true;
            this.dgvInventoryitem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventoryitem.Size = new System.Drawing.Size(558, 377);
            this.dgvInventoryitem.TabIndex = 14;
            // 
            // btnviewinventory
            // 
            this.btnviewinventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewinventory.Location = new System.Drawing.Point(43, 98);
            this.btnviewinventory.Name = "btnviewinventory";
            this.btnviewinventory.Size = new System.Drawing.Size(110, 58);
            this.btnviewinventory.TabIndex = 13;
            this.btnviewinventory.Text = "View";
            this.btnviewinventory.UseVisualStyleBackColor = true;
            this.btnviewinventory.Click += new System.EventHandler(this.btnviewinventory_Click);
            // 
            // btnbacktoadmin
            // 
            this.btnbacktoadmin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnbacktoadmin.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacktoadmin.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnbacktoadmin.Location = new System.Drawing.Point(-1, 0);
            this.btnbacktoadmin.Name = "btnbacktoadmin";
            this.btnbacktoadmin.Size = new System.Drawing.Size(198, 33);
            this.btnbacktoadmin.TabIndex = 18;
            this.btnbacktoadmin.Text = "Back";
            this.btnbacktoadmin.UseVisualStyleBackColor = false;
            this.btnbacktoadmin.Click += new System.EventHandler(this.btnbacktoadmin_Click);
            // 
            // panelInvleft
            // 
            this.panelInvleft.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelInvleft.Controls.Add(this.btnInvadd);
            this.panelInvleft.Controls.Add(this.btnbacktoadmin);
            this.panelInvleft.Controls.Add(this.btnInvremove);
            this.panelInvleft.Controls.Add(this.btnInvbuyproduct);
            this.panelInvleft.Controls.Add(this.btnexitim);
            this.panelInvleft.Controls.Add(this.btnviewinventory);
            this.panelInvleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInvleft.Location = new System.Drawing.Point(0, 0);
            this.panelInvleft.Name = "panelInvleft";
            this.panelInvleft.Size = new System.Drawing.Size(197, 509);
            this.panelInvleft.TabIndex = 19;
            // 
            // lblInvitemname
            // 
            this.lblInvitemname.AutoSize = true;
            this.lblInvitemname.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvitemname.Location = new System.Drawing.Point(257, 422);
            this.lblInvitemname.Name = "lblInvitemname";
            this.lblInvitemname.Size = new System.Drawing.Size(77, 17);
            this.lblInvitemname.TabIndex = 24;
            this.lblInvitemname.Text = "Item name";
            // 
            // lblInvitemquan
            // 
            this.lblInvitemquan.AutoSize = true;
            this.lblInvitemquan.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvitemquan.Location = new System.Drawing.Point(422, 421);
            this.lblInvitemquan.Name = "lblInvitemquan";
            this.lblInvitemquan.Size = new System.Drawing.Size(94, 17);
            this.lblInvitemquan.TabIndex = 27;
            this.lblInvitemquan.Text = "Item quantity";
            // 
            // txtInvitemquan
            // 
            this.txtInvitemquan.Location = new System.Drawing.Point(419, 450);
            this.txtInvitemquan.Name = "txtInvitemquan";
            this.txtInvitemquan.Size = new System.Drawing.Size(97, 20);
            this.txtInvitemquan.TabIndex = 26;
            // 
            // cmbInvitemname
            // 
            this.cmbInvitemname.FormattingEnabled = true;
            this.cmbInvitemname.Location = new System.Drawing.Point(248, 450);
            this.cmbInvitemname.Name = "cmbInvitemname";
            this.cmbInvitemname.Size = new System.Drawing.Size(100, 21);
            this.cmbInvitemname.TabIndex = 28;
            // 
            // cmbInvunit
            // 
            this.cmbInvunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvunit.FormattingEnabled = true;
            this.cmbInvunit.Items.AddRange(new object[] {
            "kg",
            "liters",
            "pieces"});
            this.cmbInvunit.Location = new System.Drawing.Point(589, 450);
            this.cmbInvunit.Name = "cmbInvunit";
            this.cmbInvunit.Size = new System.Drawing.Size(70, 21);
            this.cmbInvunit.TabIndex = 29;
            // 
            // lblInvunit
            // 
            this.lblInvunit.AutoSize = true;
            this.lblInvunit.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvunit.Location = new System.Drawing.Point(602, 423);
            this.lblInvunit.Name = "lblInvunit";
            this.lblInvunit.Size = new System.Drawing.Size(33, 17);
            this.lblInvunit.TabIndex = 30;
            this.lblInvunit.Text = "unit";
            // 
            // btnInvadd
            // 
            this.btnInvadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvadd.Location = new System.Drawing.Point(43, 194);
            this.btnInvadd.Name = "btnInvadd";
            this.btnInvadd.Size = new System.Drawing.Size(110, 50);
            this.btnInvadd.TabIndex = 31;
            this.btnInvadd.Text = "Add";
            this.btnInvadd.UseVisualStyleBackColor = true;
            this.btnInvadd.Click += new System.EventHandler(this.btnInvadd_Click);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(939, 509);
            this.Controls.Add(this.lblInvunit);
            this.Controls.Add(this.cmbInvunit);
            this.Controls.Add(this.cmbInvitemname);
            this.Controls.Add(this.lblInvitemquan);
            this.Controls.Add(this.txtInvitemquan);
            this.Controls.Add(this.lblInvitemname);
            this.Controls.Add(this.panelInvleft);
            this.Controls.Add(this.dgvInventoryitem);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManager";
            this.Load += new System.EventHandler(this.InventoryManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryitem)).EndInit();
            this.panelInvleft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexitim;
        private System.Windows.Forms.Button btnInvbuyproduct;
        private System.Windows.Forms.Button btnInvremove;
        private System.Windows.Forms.DataGridView dgvInventoryitem;
        private System.Windows.Forms.Button btnviewinventory;
        private System.Windows.Forms.Button btnbacktoadmin;
        private System.Windows.Forms.Panel panelInvleft;
        private System.Windows.Forms.Label lblInvitemname;
        private System.Windows.Forms.Label lblInvitemquan;
        private System.Windows.Forms.TextBox txtInvitemquan;
        private System.Windows.Forms.ComboBox cmbInvitemname;
        private System.Windows.Forms.ComboBox cmbInvunit;
        private System.Windows.Forms.Label lblInvunit;
        private System.Windows.Forms.Button btnInvadd;
    }
}
namespace BakeryShopManagementSystem
{
    partial class Cashier_Show_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_Show_Product));
            this.btnback = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgv_Cashier_Product = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cashier_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.Control;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnback.Location = new System.Drawing.Point(12, 11);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(51, 48);
            this.btnback.TabIndex = 15;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShow.BackgroundImage")));
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(367, 368);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(241, 39);
            this.btnShow.TabIndex = 14;
            this.btnShow.Text = "Available Products";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgv_Cashier_Product
            // 
            this.dgv_Cashier_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cashier_Product.Location = new System.Drawing.Point(105, 33);
            this.dgv_Cashier_Product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Cashier_Product.Name = "dgv_Cashier_Product";
            this.dgv_Cashier_Product.RowHeadersWidth = 51;
            this.dgv_Cashier_Product.RowTemplate.Height = 24;
            this.dgv_Cashier_Product.Size = new System.Drawing.Size(756, 322);
            this.dgv_Cashier_Product.TabIndex = 13;
            // 
            // Cashier_Show_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 460);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgv_Cashier_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier_Show_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier_Show_Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cashier_Product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgv_Cashier_Product;
    }
}
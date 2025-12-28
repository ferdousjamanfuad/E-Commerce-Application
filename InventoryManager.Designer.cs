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
            this.SuspendLayout();
            // 
            // btnexitim
            // 
            this.btnexitim.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnexitim.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitim.Location = new System.Drawing.Point(899, -1);
            this.btnexitim.Name = "btnexitim";
            this.btnexitim.Size = new System.Drawing.Size(41, 24);
            this.btnexitim.TabIndex = 2;
            this.btnexitim.Text = "Exit";
            this.btnexitim.UseVisualStyleBackColor = false;
            this.btnexitim.Click += new System.EventHandler(this.btnexitim_Click);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(939, 509);
            this.Controls.Add(this.btnexitim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexitim;
    }
}
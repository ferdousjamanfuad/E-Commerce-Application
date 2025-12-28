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
            this.btnexitpm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexitpm
            // 
            this.btnexitpm.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnexitpm.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitpm.Location = new System.Drawing.Point(895, 0);
            this.btnexitpm.Name = "btnexitpm";
            this.btnexitpm.Size = new System.Drawing.Size(41, 22);
            this.btnexitpm.TabIndex = 1;
            this.btnexitpm.Text = "Exit";
            this.btnexitpm.UseVisualStyleBackColor = false;
            this.btnexitpm.Click += new System.EventHandler(this.btnexitpm_Click);
            // 
            // ProductionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(937, 508);
            this.Controls.Add(this.btnexitpm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductionManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexitpm;
    }
}
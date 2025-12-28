namespace BakeryShopManagementSystem
{
    partial class Cashier
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
            this.btnexitemployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexitemployee
            // 
            this.btnexitemployee.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnexitemployee.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitemployee.Location = new System.Drawing.Point(895, 0);
            this.btnexitemployee.Name = "btnexitemployee";
            this.btnexitemployee.Size = new System.Drawing.Size(46, 23);
            this.btnexitemployee.TabIndex = 1;
            this.btnexitemployee.Text = "Exit";
            this.btnexitemployee.UseVisualStyleBackColor = false;
            this.btnexitemployee.Click += new System.EventHandler(this.btnexitemployee_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(942, 508);
            this.Controls.Add(this.btnexitemployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexitemployee;
    }
}
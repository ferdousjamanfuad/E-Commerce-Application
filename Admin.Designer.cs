namespace E_Commerce_Application
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
            this.SuspendLayout();
            // 
            // btnexitadmin
            // 
            this.btnexitadmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnexitadmin.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitadmin.Location = new System.Drawing.Point(749, 1);
            this.btnexitadmin.Name = "btnexitadmin";
            this.btnexitadmin.Size = new System.Drawing.Size(81, 31);
            this.btnexitadmin.TabIndex = 0;
            this.btnexitadmin.Text = "Exit";
            this.btnexitadmin.UseVisualStyleBackColor = false;
            this.btnexitadmin.Click += new System.EventHandler(this.btnexitadmin_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 569);
            this.Controls.Add(this.btnexitadmin);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexitadmin;
    }
}
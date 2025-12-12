namespace E_Commerce_Application
{
    partial class Registration
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
            this.btnexitreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexitreg
            // 
            this.btnexitreg.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnexitreg.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitreg.Location = new System.Drawing.Point(304, 1);
            this.btnexitreg.Name = "btnexitreg";
            this.btnexitreg.Size = new System.Drawing.Size(81, 31);
            this.btnexitreg.TabIndex = 3;
            this.btnexitreg.Text = "Exit";
            this.btnexitreg.UseVisualStyleBackColor = false;
            this.btnexitreg.Click += new System.EventHandler(this.btnexitreg_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 479);
            this.Controls.Add(this.btnexitreg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexitreg;
    }
}
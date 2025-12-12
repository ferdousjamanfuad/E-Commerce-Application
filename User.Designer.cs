namespace E_Commerce_Application
{
    partial class User
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
            this.btnexituser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexituser
            // 
            this.btnexituser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnexituser.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexituser.Location = new System.Drawing.Point(746, 1);
            this.btnexituser.Name = "btnexituser";
            this.btnexituser.Size = new System.Drawing.Size(81, 31);
            this.btnexituser.TabIndex = 2;
            this.btnexituser.Text = "Exit";
            this.btnexituser.UseVisualStyleBackColor = false;
            this.btnexituser.Click += new System.EventHandler(this.btnexituser_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 528);
            this.Controls.Add(this.btnexituser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexituser;
    }
}
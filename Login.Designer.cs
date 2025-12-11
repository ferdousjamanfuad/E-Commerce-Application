namespace E_Commerce_Application
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblurname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txturname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblstore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblerrorurname = new System.Windows.Forms.Label();
            this.lblerrorpass = new System.Windows.Forms.Label();
            this.btnclr = new System.Windows.Forms.Button();
            this.btnlgn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblurname
            // 
            this.lblurname.AutoSize = true;
            this.lblurname.BackColor = System.Drawing.Color.Transparent;
            this.lblurname.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurname.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblurname.Location = new System.Drawing.Point(32, 224);
            this.lblurname.Name = "lblurname";
            this.lblurname.Size = new System.Drawing.Size(101, 25);
            this.lblurname.TabIndex = 0;
            this.lblurname.Text = "username";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblpass.Location = new System.Drawing.Point(33, 276);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(100, 25);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "password";
            // 
            // txturname
            // 
            this.txturname.Location = new System.Drawing.Point(139, 224);
            this.txturname.Name = "txturname";
            this.txturname.Size = new System.Drawing.Size(227, 20);
            this.txturname.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(139, 281);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(227, 20);
            this.txtpass.TabIndex = 3;
            // 
            // lblstore
            // 
            this.lblstore.AutoSize = true;
            this.lblstore.BackColor = System.Drawing.Color.Transparent;
            this.lblstore.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstore.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblstore.Location = new System.Drawing.Point(9, 6);
            this.lblstore.Name = "lblstore";
            this.lblstore.Size = new System.Drawing.Size(132, 28);
            this.lblstore.TabIndex = 4;
            this.lblstore.Text = "NEOSTORE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnlgn);
            this.panel1.Controls.Add(this.btnclr);
            this.panel1.Controls.Add(this.lblerrorpass);
            this.panel1.Controls.Add(this.lblerrorurname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txturname);
            this.panel1.Controls.Add(this.lblurname);
            this.panel1.Controls.Add(this.lblpass);
            this.panel1.Location = new System.Drawing.Point(41, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 435);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblerrorurname
            // 
            this.lblerrorurname.AutoSize = true;
            this.lblerrorurname.BackColor = System.Drawing.Color.Transparent;
            this.lblerrorurname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorurname.ForeColor = System.Drawing.Color.Red;
            this.lblerrorurname.Location = new System.Drawing.Point(176, 248);
            this.lblerrorurname.Name = "lblerrorurname";
            this.lblerrorurname.Size = new System.Drawing.Size(150, 15);
            this.lblerrorurname.TabIndex = 5;
            this.lblerrorurname.Text = "*** please enter username ";
            // 
            // lblerrorpass
            // 
            this.lblerrorpass.AutoSize = true;
            this.lblerrorpass.BackColor = System.Drawing.Color.Transparent;
            this.lblerrorpass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerrorpass.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpass.Location = new System.Drawing.Point(176, 305);
            this.lblerrorpass.Name = "lblerrorpass";
            this.lblerrorpass.Size = new System.Drawing.Size(149, 15);
            this.lblerrorpass.TabIndex = 6;
            this.lblerrorpass.Text = "*** please enter password ";
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.Location = new System.Drawing.Point(139, 346);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 23);
            this.btnclr.TabIndex = 7;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            // 
            // btnlgn
            // 
            this.btnlgn.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlgn.Location = new System.Drawing.Point(291, 346);
            this.btnlgn.Name = "btnlgn";
            this.btnlgn.Size = new System.Drawing.Size(75, 23);
            this.btnlgn.TabIndex = 8;
            this.btnlgn.Text = "Login";
            this.btnlgn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblstore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblurname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txturname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblstore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblerrorurname;
        private System.Windows.Forms.Label lblerrorpass;
        private System.Windows.Forms.Button btnlgn;
        private System.Windows.Forms.Button btnclr;
    }
}
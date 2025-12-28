namespace BakeryShopManagementSystem
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
            this.lblregurname = new System.Windows.Forms.Label();
            this.lblregpass = new System.Windows.Forms.Label();
            this.btncreateacc = new System.Windows.Forms.Button();
            this.txtregurname = new System.Windows.Forms.TextBox();
            this.txtregpass = new System.Windows.Forms.TextBox();
            this.lblregrole = new System.Windows.Forms.Label();
            this.cmbregrole = new System.Windows.Forms.ComboBox();
            this.lblreggender = new System.Windows.Forms.Label();
            this.rbreggenderM = new System.Windows.Forms.RadioButton();
            this.rbreggenderF = new System.Windows.Forms.RadioButton();
            this.lblregdob = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblregaddress = new System.Windows.Forms.Label();
            this.txtregaddress = new System.Windows.Forms.RichTextBox();
            this.lblregemail = new System.Windows.Forms.Label();
            this.txtregemail = new System.Windows.Forms.TextBox();
            this.lblregerrorurname = new System.Windows.Forms.Label();
            this.lblregerrorpass = new System.Windows.Forms.Label();
            this.lblregerroremail = new System.Windows.Forms.Label();
            this.lblregerrorgender = new System.Windows.Forms.Label();
            this.lblregerrorrole = new System.Windows.Forms.Label();
            this.lblregerroraddress = new System.Windows.Forms.Label();
            this.btnregclr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexitreg
            // 
            this.btnexitreg.BackColor = System.Drawing.Color.Beige;
            this.btnexitreg.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexitreg.ForeColor = System.Drawing.Color.Crimson;
            this.btnexitreg.Location = new System.Drawing.Point(361, 1);
            this.btnexitreg.Name = "btnexitreg";
            this.btnexitreg.Size = new System.Drawing.Size(25, 22);
            this.btnexitreg.TabIndex = 3;
            this.btnexitreg.Text = "X";
            this.btnexitreg.UseVisualStyleBackColor = false;
            this.btnexitreg.Click += new System.EventHandler(this.btnexitreg_Click);
            // 
            // lblregurname
            // 
            this.lblregurname.AutoSize = true;
            this.lblregurname.BackColor = System.Drawing.Color.Transparent;
            this.lblregurname.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregurname.ForeColor = System.Drawing.Color.DarkGray;
            this.lblregurname.Location = new System.Drawing.Point(7, 70);
            this.lblregurname.Name = "lblregurname";
            this.lblregurname.Size = new System.Drawing.Size(91, 22);
            this.lblregurname.TabIndex = 4;
            this.lblregurname.Text = "username";
            // 
            // lblregpass
            // 
            this.lblregpass.AutoSize = true;
            this.lblregpass.BackColor = System.Drawing.Color.Transparent;
            this.lblregpass.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregpass.ForeColor = System.Drawing.Color.DarkGray;
            this.lblregpass.Location = new System.Drawing.Point(7, 158);
            this.lblregpass.Name = "lblregpass";
            this.lblregpass.Size = new System.Drawing.Size(90, 22);
            this.lblregpass.TabIndex = 5;
            this.lblregpass.Text = "password";
            // 
            // btncreateacc
            // 
            this.btncreateacc.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreateacc.Location = new System.Drawing.Point(272, 444);
            this.btncreateacc.Name = "btncreateacc";
            this.btncreateacc.Size = new System.Drawing.Size(75, 23);
            this.btncreateacc.TabIndex = 9;
            this.btncreateacc.Text = "Create";
            this.btncreateacc.UseVisualStyleBackColor = true;
            this.btncreateacc.Click += new System.EventHandler(this.btncreateacc_Click);
            // 
            // txtregurname
            // 
            this.txtregurname.Location = new System.Drawing.Point(120, 74);
            this.txtregurname.Name = "txtregurname";
            this.txtregurname.Size = new System.Drawing.Size(227, 20);
            this.txtregurname.TabIndex = 10;
            // 
            // txtregpass
            // 
            this.txtregpass.Location = new System.Drawing.Point(120, 162);
            this.txtregpass.Name = "txtregpass";
            this.txtregpass.PasswordChar = '*';
            this.txtregpass.Size = new System.Drawing.Size(227, 20);
            this.txtregpass.TabIndex = 11;
            // 
            // lblregrole
            // 
            this.lblregrole.AutoSize = true;
            this.lblregrole.BackColor = System.Drawing.Color.Transparent;
            this.lblregrole.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregrole.ForeColor = System.Drawing.Color.DarkGray;
            this.lblregrole.Location = new System.Drawing.Point(7, 294);
            this.lblregrole.Name = "lblregrole";
            this.lblregrole.Size = new System.Drawing.Size(46, 22);
            this.lblregrole.TabIndex = 12;
            this.lblregrole.Text = "Role";
            // 
            // cmbregrole
            // 
            this.cmbregrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbregrole.FormattingEnabled = true;
            this.cmbregrole.Items.AddRange(new object[] {
            "Cashier",
            "Production Manager",
            "Inventory Manager"});
            this.cmbregrole.Location = new System.Drawing.Point(120, 295);
            this.cmbregrole.Name = "cmbregrole";
            this.cmbregrole.Size = new System.Drawing.Size(121, 21);
            this.cmbregrole.TabIndex = 13;
            // 
            // lblreggender
            // 
            this.lblreggender.AutoSize = true;
            this.lblreggender.BackColor = System.Drawing.Color.Transparent;
            this.lblreggender.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreggender.ForeColor = System.Drawing.Color.DarkGray;
            this.lblreggender.Location = new System.Drawing.Point(7, 249);
            this.lblreggender.Name = "lblreggender";
            this.lblreggender.Size = new System.Drawing.Size(70, 22);
            this.lblreggender.TabIndex = 14;
            this.lblreggender.Text = "Gender";
            // 
            // rbreggenderM
            // 
            this.rbreggenderM.AutoSize = true;
            this.rbreggenderM.Location = new System.Drawing.Point(125, 254);
            this.rbreggenderM.Name = "rbreggenderM";
            this.rbreggenderM.Size = new System.Drawing.Size(48, 17);
            this.rbreggenderM.TabIndex = 15;
            this.rbreggenderM.TabStop = true;
            this.rbreggenderM.Text = "Male";
            this.rbreggenderM.UseVisualStyleBackColor = true;
            // 
            // rbreggenderF
            // 
            this.rbreggenderF.AutoSize = true;
            this.rbreggenderF.Location = new System.Drawing.Point(205, 254);
            this.rbreggenderF.Name = "rbreggenderF";
            this.rbreggenderF.Size = new System.Drawing.Size(59, 17);
            this.rbreggenderF.TabIndex = 16;
            this.rbreggenderF.TabStop = true;
            this.rbreggenderF.Text = "Female";
            this.rbreggenderF.UseVisualStyleBackColor = true;
            // 
            // lblregdob
            // 
            this.lblregdob.AutoSize = true;
            this.lblregdob.BackColor = System.Drawing.Color.Transparent;
            this.lblregdob.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregdob.ForeColor = System.Drawing.Color.DarkGray;
            this.lblregdob.Location = new System.Drawing.Point(7, 205);
            this.lblregdob.Name = "lblregdob";
            this.lblregdob.Size = new System.Drawing.Size(112, 22);
            this.lblregdob.TabIndex = 17;
            this.lblregdob.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // lblregaddress
            // 
            this.lblregaddress.AutoSize = true;
            this.lblregaddress.BackColor = System.Drawing.Color.Transparent;
            this.lblregaddress.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregaddress.ForeColor = System.Drawing.Color.DarkGray;
            this.lblregaddress.Location = new System.Drawing.Point(7, 344);
            this.lblregaddress.Name = "lblregaddress";
            this.lblregaddress.Size = new System.Drawing.Size(77, 22);
            this.lblregaddress.TabIndex = 19;
            this.lblregaddress.Text = "Address";
            // 
            // txtregaddress
            // 
            this.txtregaddress.Location = new System.Drawing.Point(120, 341);
            this.txtregaddress.Name = "txtregaddress";
            this.txtregaddress.Size = new System.Drawing.Size(227, 67);
            this.txtregaddress.TabIndex = 20;
            this.txtregaddress.Text = "";
            // 
            // lblregemail
            // 
            this.lblregemail.AutoSize = true;
            this.lblregemail.BackColor = System.Drawing.Color.Transparent;
            this.lblregemail.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregemail.ForeColor = System.Drawing.Color.DarkGray;
            this.lblregemail.Location = new System.Drawing.Point(7, 116);
            this.lblregemail.Name = "lblregemail";
            this.lblregemail.Size = new System.Drawing.Size(56, 22);
            this.lblregemail.TabIndex = 21;
            this.lblregemail.Text = "Email";
            // 
            // txtregemail
            // 
            this.txtregemail.Location = new System.Drawing.Point(120, 120);
            this.txtregemail.Name = "txtregemail";
            this.txtregemail.Size = new System.Drawing.Size(227, 20);
            this.txtregemail.TabIndex = 22;
            // 
            // lblregerrorurname
            // 
            this.lblregerrorurname.AutoSize = true;
            this.lblregerrorurname.BackColor = System.Drawing.Color.Transparent;
            this.lblregerrorurname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregerrorurname.ForeColor = System.Drawing.Color.Red;
            this.lblregerrorurname.Location = new System.Drawing.Point(153, 95);
            this.lblregerrorurname.Name = "lblregerrorurname";
            this.lblregerrorurname.Size = new System.Drawing.Size(150, 15);
            this.lblregerrorurname.TabIndex = 23;
            this.lblregerrorurname.Text = "*** please enter username ";
            // 
            // lblregerrorpass
            // 
            this.lblregerrorpass.AutoSize = true;
            this.lblregerrorpass.BackColor = System.Drawing.Color.Transparent;
            this.lblregerrorpass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregerrorpass.ForeColor = System.Drawing.Color.Red;
            this.lblregerrorpass.Location = new System.Drawing.Point(154, 185);
            this.lblregerrorpass.Name = "lblregerrorpass";
            this.lblregerrorpass.Size = new System.Drawing.Size(149, 15);
            this.lblregerrorpass.TabIndex = 24;
            this.lblregerrorpass.Text = "*** please enter password ";
            // 
            // lblregerroremail
            // 
            this.lblregerroremail.AutoSize = true;
            this.lblregerroremail.BackColor = System.Drawing.Color.Transparent;
            this.lblregerroremail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregerroremail.ForeColor = System.Drawing.Color.Red;
            this.lblregerroremail.Location = new System.Drawing.Point(153, 143);
            this.lblregerroremail.Name = "lblregerroremail";
            this.lblregerroremail.Size = new System.Drawing.Size(150, 15);
            this.lblregerroremail.TabIndex = 25;
            this.lblregerroremail.Text = "*** please enter username ";
            // 
            // lblregerrorgender
            // 
            this.lblregerrorgender.AutoSize = true;
            this.lblregerrorgender.BackColor = System.Drawing.Color.Transparent;
            this.lblregerrorgender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregerrorgender.ForeColor = System.Drawing.Color.Red;
            this.lblregerrorgender.Location = new System.Drawing.Point(260, 256);
            this.lblregerrorgender.Name = "lblregerrorgender";
            this.lblregerrorgender.Size = new System.Drawing.Size(91, 15);
            this.lblregerrorgender.TabIndex = 26;
            this.lblregerrorgender.Text = "**select gender ";
            // 
            // lblregerrorrole
            // 
            this.lblregerrorrole.AutoSize = true;
            this.lblregerrorrole.BackColor = System.Drawing.Color.Transparent;
            this.lblregerrorrole.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregerrorrole.ForeColor = System.Drawing.Color.Red;
            this.lblregerrorrole.Location = new System.Drawing.Point(142, 319);
            this.lblregerrorrole.Name = "lblregerrorrole";
            this.lblregerrorrole.Size = new System.Drawing.Size(74, 15);
            this.lblregerrorrole.TabIndex = 27;
            this.lblregerrorrole.Text = "**select role ";
            // 
            // lblregerroraddress
            // 
            this.lblregerroraddress.AutoSize = true;
            this.lblregerroraddress.BackColor = System.Drawing.Color.Transparent;
            this.lblregerroraddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregerroraddress.ForeColor = System.Drawing.Color.Red;
            this.lblregerroraddress.Location = new System.Drawing.Point(142, 413);
            this.lblregerroraddress.Name = "lblregerroraddress";
            this.lblregerroraddress.Size = new System.Drawing.Size(134, 15);
            this.lblregerroraddress.TabIndex = 28;
            this.lblregerroraddress.Text = "***please input address";
            // 
            // btnregclr
            // 
            this.btnregclr.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregclr.Location = new System.Drawing.Point(120, 444);
            this.btnregclr.Name = "btnregclr";
            this.btnregclr.Size = new System.Drawing.Size(75, 23);
            this.btnregclr.TabIndex = 29;
            this.btnregclr.Text = "Clear";
            this.btnregclr.UseVisualStyleBackColor = true;
            this.btnregclr.Click += new System.EventHandler(this.btnregclr_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(388, 479);
            this.Controls.Add(this.btnregclr);
            this.Controls.Add(this.lblregerroraddress);
            this.Controls.Add(this.lblregerrorrole);
            this.Controls.Add(this.lblregerrorgender);
            this.Controls.Add(this.lblregerroremail);
            this.Controls.Add(this.lblregerrorpass);
            this.Controls.Add(this.lblregerrorurname);
            this.Controls.Add(this.txtregemail);
            this.Controls.Add(this.lblregemail);
            this.Controls.Add(this.txtregaddress);
            this.Controls.Add(this.lblregaddress);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblregdob);
            this.Controls.Add(this.rbreggenderF);
            this.Controls.Add(this.rbreggenderM);
            this.Controls.Add(this.lblreggender);
            this.Controls.Add(this.cmbregrole);
            this.Controls.Add(this.lblregrole);
            this.Controls.Add(this.txtregpass);
            this.Controls.Add(this.txtregurname);
            this.Controls.Add(this.btncreateacc);
            this.Controls.Add(this.lblregpass);
            this.Controls.Add(this.lblregurname);
            this.Controls.Add(this.btnexitreg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexitreg;
        private System.Windows.Forms.Label lblregurname;
        private System.Windows.Forms.Label lblregpass;
        private System.Windows.Forms.Button btncreateacc;
        private System.Windows.Forms.TextBox txtregurname;
        private System.Windows.Forms.TextBox txtregpass;
        private System.Windows.Forms.Label lblregrole;
        private System.Windows.Forms.ComboBox cmbregrole;
        private System.Windows.Forms.Label lblreggender;
        private System.Windows.Forms.RadioButton rbreggenderM;
        private System.Windows.Forms.RadioButton rbreggenderF;
        private System.Windows.Forms.Label lblregdob;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblregaddress;
        private System.Windows.Forms.RichTextBox txtregaddress;
        private System.Windows.Forms.Label lblregemail;
        private System.Windows.Forms.TextBox txtregemail;
        private System.Windows.Forms.Label lblregerrorurname;
        private System.Windows.Forms.Label lblregerrorpass;
        private System.Windows.Forms.Label lblregerroremail;
        private System.Windows.Forms.Label lblregerrorgender;
        private System.Windows.Forms.Label lblregerrorrole;
        private System.Windows.Forms.Label lblregerroraddress;
        private System.Windows.Forms.Button btnregclr;
    }
}
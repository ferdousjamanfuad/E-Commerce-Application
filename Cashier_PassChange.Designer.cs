namespace BakeryShopManagementSystem
{
    partial class Cashier_PassChange
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_PassChange));
            this.btnRetunr_Cash_Profile = new System.Windows.Forms.Button();
            this.btnEye = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.lblNew_pass = new System.Windows.Forms.Label();
            this.lblConfirm_pass = new System.Windows.Forms.Label();
            this.lblOld_pass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetunr_Cash_Profile
            // 
            this.btnRetunr_Cash_Profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRetunr_Cash_Profile.FlatAppearance.BorderSize = 0;
            this.btnRetunr_Cash_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetunr_Cash_Profile.Image = ((System.Drawing.Image)(resources.GetObject("btnRetunr_Cash_Profile.Image")));
            this.btnRetunr_Cash_Profile.Location = new System.Drawing.Point(651, 18);
            this.btnRetunr_Cash_Profile.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetunr_Cash_Profile.Name = "btnRetunr_Cash_Profile";
            this.btnRetunr_Cash_Profile.Size = new System.Drawing.Size(33, 31);
            this.btnRetunr_Cash_Profile.TabIndex = 1;
            this.btnRetunr_Cash_Profile.UseVisualStyleBackColor = true;
            this.btnRetunr_Cash_Profile.Click += new System.EventHandler(this.btnRetunr_Cash_Profile_Click);
            // 
            // btnEye
            // 
            this.btnEye.BackColor = System.Drawing.Color.Transparent;
            this.btnEye.FlatAppearance.BorderSize = 0;
            this.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEye.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEye.Image = ((System.Drawing.Image)(resources.GetObject("btnEye.Image")));
            this.btnEye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEye.Location = new System.Drawing.Point(281, 217);
            this.btnEye.Name = "btnEye";
            this.btnEye.Size = new System.Drawing.Size(153, 29);
            this.btnEye.TabIndex = 18;
            this.btnEye.Text = "Show Password";
            this.btnEye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEye.UseMnemonic = false;
            this.btnEye.UseVisualStyleBackColor = false;
            this.btnEye.Click += new System.EventHandler(this.btnEye_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
            this.btnChangePass.Location = new System.Drawing.Point(170, 249);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(105, 45);
            this.btnChangePass.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnChangePass, "Confirm Password Change");
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // lblNew_pass
            // 
            this.lblNew_pass.AutoSize = true;
            this.lblNew_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew_pass.Location = new System.Drawing.Point(144, 156);
            this.lblNew_pass.Name = "lblNew_pass";
            this.lblNew_pass.Size = new System.Drawing.Size(131, 18);
            this.lblNew_pass.TabIndex = 16;
            this.lblNew_pass.Text = "New Password :";
            // 
            // lblConfirm_pass
            // 
            this.lblConfirm_pass.AutoSize = true;
            this.lblConfirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm_pass.Location = new System.Drawing.Point(79, 193);
            this.lblConfirm_pass.Name = "lblConfirm_pass";
            this.lblConfirm_pass.Size = new System.Drawing.Size(196, 18);
            this.lblConfirm_pass.TabIndex = 15;
            this.lblConfirm_pass.Text = "Confirm New Password :";
            // 
            // lblOld_pass
            // 
            this.lblOld_pass.AutoSize = true;
            this.lblOld_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOld_pass.Location = new System.Drawing.Point(151, 119);
            this.lblOld_pass.Name = "lblOld_pass";
            this.lblOld_pass.Size = new System.Drawing.Size(124, 18);
            this.lblOld_pass.TabIndex = 14;
            this.lblOld_pass.Text = "Old Password :";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(299, 189);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(134, 22);
            this.txtConfirmPass.TabIndex = 13;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(299, 155);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(134, 22);
            this.txtNewPass.TabIndex = 12;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(299, 115);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(134, 22);
            this.txtOldPass.TabIndex = 11;
            this.txtOldPass.UseSystemPasswordChar = true;
            this.txtOldPass.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(120, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Change Current user Password !";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnRetunr_Cash_Profile);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 70);
            this.panel1.TabIndex = 19;
            // 
            // Cashier_PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 309);
            this.Controls.Add(this.btnEye);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.lblNew_pass);
            this.Controls.Add(this.lblConfirm_pass);
            this.Controls.Add(this.lblOld_pass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier_PassChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier_PassChange";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetunr_Cash_Profile;
        private System.Windows.Forms.Button btnEye;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label lblNew_pass;
        private System.Windows.Forms.Label lblConfirm_pass;
        private System.Windows.Forms.Label lblOld_pass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
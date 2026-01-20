namespace BakeryShopManagementSystem
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.lblprofilerole = new System.Windows.Forms.Label();
            this.lblprofileuserid = new System.Windows.Forms.Label();
            this.lblprofilename = new System.Windows.Forms.Label();
            this.lblprofilejoiningdate = new System.Windows.Forms.Label();
            this.btnbackadmindashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprofilerole
            // 
            this.lblprofilerole.AutoSize = true;
            this.lblprofilerole.Cursor = System.Windows.Forms.Cursors.No;
            this.lblprofilerole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofilerole.Location = new System.Drawing.Point(103, 221);
            this.lblprofilerole.Name = "lblprofilerole";
            this.lblprofilerole.Size = new System.Drawing.Size(91, 31);
            this.lblprofilerole.TabIndex = 7;
            this.lblprofilerole.Text = "Role :";
            // 
            // lblprofileuserid
            // 
            this.lblprofileuserid.AutoSize = true;
            this.lblprofileuserid.Cursor = System.Windows.Forms.Cursors.No;
            this.lblprofileuserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofileuserid.Location = new System.Drawing.Point(103, 165);
            this.lblprofileuserid.Name = "lblprofileuserid";
            this.lblprofileuserid.Size = new System.Drawing.Size(118, 31);
            this.lblprofileuserid.TabIndex = 6;
            this.lblprofileuserid.Text = "UserId :";
            // 
            // lblprofilename
            // 
            this.lblprofilename.AutoSize = true;
            this.lblprofilename.Cursor = System.Windows.Forms.Cursors.No;
            this.lblprofilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofilename.Location = new System.Drawing.Point(94, 108);
            this.lblprofilename.Name = "lblprofilename";
            this.lblprofilename.Size = new System.Drawing.Size(115, 31);
            this.lblprofilename.TabIndex = 5;
            this.lblprofilename.Text = " Name :";
            // 
            // lblprofilejoiningdate
            // 
            this.lblprofilejoiningdate.AutoSize = true;
            this.lblprofilejoiningdate.Cursor = System.Windows.Forms.Cursors.No;
            this.lblprofilejoiningdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofilejoiningdate.Location = new System.Drawing.Point(94, 278);
            this.lblprofilejoiningdate.Name = "lblprofilejoiningdate";
            this.lblprofilejoiningdate.Size = new System.Drawing.Size(124, 31);
            this.lblprofilejoiningdate.TabIndex = 8;
            this.lblprofilejoiningdate.Text = "Joining :";
            // 
            // btnbackadmindashboard
            // 
            this.btnbackadmindashboard.BackColor = System.Drawing.Color.BurlyWood;
            this.btnbackadmindashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbackadmindashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbackadmindashboard.FlatAppearance.BorderSize = 0;
            this.btnbackadmindashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnbackadmindashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbackadmindashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnbackadmindashboard.Image")));
            this.btnbackadmindashboard.Location = new System.Drawing.Point(413, 0);
            this.btnbackadmindashboard.Name = "btnbackadmindashboard";
            this.btnbackadmindashboard.Size = new System.Drawing.Size(49, 42);
            this.btnbackadmindashboard.TabIndex = 9;
            this.btnbackadmindashboard.UseVisualStyleBackColor = false;
            this.btnbackadmindashboard.Click += new System.EventHandler(this.btnbackadmindashboard_Click);
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(461, 397);
            this.Controls.Add(this.btnbackadmindashboard);
            this.Controls.Add(this.lblprofilejoiningdate);
            this.Controls.Add(this.lblprofilerole);
            this.Controls.Add(this.lblprofileuserid);
            this.Controls.Add(this.lblprofilename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblprofilerole;
        private System.Windows.Forms.Label lblprofileuserid;
        private System.Windows.Forms.Label lblprofilename;
        private System.Windows.Forms.Label lblprofilejoiningdate;
        private System.Windows.Forms.Button btnbackadmindashboard;
    }
}
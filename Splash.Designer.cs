namespace E_Commerce_Application
{
    partial class splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblstore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblload = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar.ForeColor = System.Drawing.Color.Green;
            this.progressBar.Location = new System.Drawing.Point(12, 368);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(669, 10);
            this.progressBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblstore
            // 
            this.lblstore.AutoSize = true;
            this.lblstore.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstore.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblstore.Location = new System.Drawing.Point(278, 9);
            this.lblstore.Name = "lblstore";
            this.lblstore.Size = new System.Drawing.Size(105, 22);
            this.lblstore.TabIndex = 2;
            this.lblstore.Text = "NEOSTORE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblload
            // 
            this.lblload.AutoSize = true;
            this.lblload.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblload.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblload.Location = new System.Drawing.Point(12, 347);
            this.lblload.Name = "lblload";
            this.lblload.Size = new System.Drawing.Size(74, 19);
            this.lblload.TabIndex = 3;
            this.lblload.Text = "Loading...";
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 389);
            this.Controls.Add(this.lblload);
            this.Controls.Add(this.lblstore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Screen";
            this.Load += new System.EventHandler(this.splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblstore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblload;
    }
}


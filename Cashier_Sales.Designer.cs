namespace BakeryShopManagementSystem
{
    partial class Cashier_Sales
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_Sales));
            this.Pnl_CashierChartLoad = new System.Windows.Forms.Panel();
            this.chartCashier_Sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_CashierChartLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCashier_Sales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_CashierChartLoad
            // 
            this.Pnl_CashierChartLoad.Controls.Add(this.chartCashier_Sales);
            this.Pnl_CashierChartLoad.Location = new System.Drawing.Point(37, 95);
            this.Pnl_CashierChartLoad.Name = "Pnl_CashierChartLoad";
            this.Pnl_CashierChartLoad.Size = new System.Drawing.Size(837, 357);
            this.Pnl_CashierChartLoad.TabIndex = 0;
            this.Pnl_CashierChartLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_CashierChartLoad_Paint);
            // 
            // chartCashier_Sales
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCashier_Sales.ChartAreas.Add(chartArea1);
            this.chartCashier_Sales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartCashier_Sales.Legends.Add(legend1);
            this.chartCashier_Sales.Location = new System.Drawing.Point(0, 0);
            this.chartCashier_Sales.Name = "chartCashier_Sales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCashier_Sales.Series.Add(series1);
            this.chartCashier_Sales.Size = new System.Drawing.Size(837, 357);
            this.chartCashier_Sales.TabIndex = 0;
            this.chartCashier_Sales.Text = "chart1";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.Color.Coral;
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnback.Location = new System.Drawing.Point(25, 20);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(51, 48);
            this.btnback.TabIndex = 16;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(260, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 59);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Cashier Sales";
            // 
            // Cashier_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(906, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.Pnl_CashierChartLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier_Sales";
            this.Pnl_CashierChartLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCashier_Sales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_CashierChartLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCashier_Sales;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_Sales));
            this.Pnl_CashierChartLoad = new System.Windows.Forms.Panel();
            this.chartCashier_Sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnback = new System.Windows.Forms.Button();
            this.Pnl_CashierChartLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCashier_Sales)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_CashierChartLoad
            // 
            this.Pnl_CashierChartLoad.Controls.Add(this.chartCashier_Sales);
            this.Pnl_CashierChartLoad.Location = new System.Drawing.Point(82, 54);
            this.Pnl_CashierChartLoad.Name = "Pnl_CashierChartLoad";
            this.Pnl_CashierChartLoad.Size = new System.Drawing.Size(710, 347);
            this.Pnl_CashierChartLoad.TabIndex = 0;
            // 
            // chartCashier_Sales
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCashier_Sales.ChartAreas.Add(chartArea2);
            this.chartCashier_Sales.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartCashier_Sales.Legends.Add(legend2);
            this.chartCashier_Sales.Location = new System.Drawing.Point(0, 0);
            this.chartCashier_Sales.Name = "chartCashier_Sales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCashier_Sales.Series.Add(series2);
            this.chartCashier_Sales.Size = new System.Drawing.Size(710, 347);
            this.chartCashier_Sales.TabIndex = 0;
            this.chartCashier_Sales.Text = "chart1";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.ForeColor = System.Drawing.Color.Coral;
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnback.Location = new System.Drawing.Point(12, 11);
            this.btnback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(51, 48);
            this.btnback.TabIndex = 16;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Cashier_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(859, 474);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.Pnl_CashierChartLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cashier_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier_Sales";
            this.Pnl_CashierChartLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCashier_Sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_CashierChartLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCashier_Sales;
        private System.Windows.Forms.Button btnback;
    }
}
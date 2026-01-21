using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakeryShopManagementSystem
{
    public partial class Cashier_Sales : Form
    {
        public Cashier_Sales()
        {
            InitializeComponent();
        }

        private void ShowDailySalesChart()
        {
            int cashierId = Session.UserId;

            string sql = "SELECT CONVERT(DATE, order_date) AS SaleDate, SUM(total_amount) AS TotalSales " +
             "FROM orders " +
             "WHERE cashier_id = " + cashierId + " " +
             "GROUP BY CONVERT(DATE, order_date) " +
             "ORDER BY SaleDate";


            DataTable dt = DatabaseHelper.GetData(sql);

            chartCashier_Sales.Series.Clear();
            chartCashier_Sales.Series.Add("Sales");
            chartCashier_Sales.Series["Sales"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                chartCashier_Sales.Series["Sales"].Points.AddXY(
                   Convert.ToDateTime(row["SaleDate"]).ToString("dd-MM-yyyy"),
                    Convert.ToDecimal(row["TotalSales"])
                );
            }
            chartCashier_Sales.ChartAreas[0].AxisX.Title = "Date";
            chartCashier_Sales.ChartAreas[0].AxisY.Title = "Total Sales";
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Cashier c=new Cashier();
            c.Show();
            this.Close();
        }
        private void Pnl_CashierChartLoad_Paint(object sender, PaintEventArgs e)
        {
            ShowDailySalesChart();
        }
    }
}

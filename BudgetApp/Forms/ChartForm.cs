﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetApp
{
    public partial class ChartForm : Form
    {
        //database connection string
        private readonly string connectionString = "Data Source=localhost;Initial Catalog=expenses;Integrated Security=True";
       
        public ChartForm()
        {
            InitializeComponent();
        }

        //on load, fill out all charts
        private void ChartForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expensesDataSet.expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.expensesDataSet.expenses);
            FillPieChart();
            FillMonthlySpendingChart();
        }

        //request data of total spending for each category and fill pie chart with it
        public void FillPieChart()
        {
            //connect to database
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                //SQL query to get table that shows the sum of amounts for every expense under each category
                string categorySumQuery = "SELECT expCategory, " +
                    "SUM(expAmount) AS catTotal " +
                    "FROM [dbo].expenses " +
                    "GROUP BY expCategory";

                //fill datatable from sql server using above query
                SqlDataAdapter adapter = new SqlDataAdapter(categorySumQuery, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //clears autogenerated series--needed to avoid crash
                pieChart.Series.Clear();

                //build series with information from table from database
                Series series = new Series("ExpenseByCategory");
                series.Points.DataBind(dt.AsEnumerable(), "expCategory", "catTotal", "");
                series.ChartType=SeriesChartType.Pie;

                //formatting
                series.IsValueShownAsLabel=true;
                series.LabelFormat = "$0.00";

                //add series to chart
                pieChart.Series.Add(series);
            }
        }

        //Request monthly spending data for the last year from database and fill bar chart
        public void FillMonthlySpendingChart()
        {
            //calculate starting date of range
            DateTime oneYearAgo = DateTime.Now.AddYears(-1);

            //SQL query to calculate monthly spending for last year
            string monthlySpendingQuery = "SELECT YEAR(expDate) AS expYear," +
                " MONTH(expDate) AS expMonth, " +
                "FORMAT(expDate, 'MMM') AS monthName, " +
                "SUM(expAmount) AS totalAmount " +
                "FROM [dbo].expenses" +
                " WHERE expDate >= DATEADD(year, -1, GETDATE()) " +
                "GROUP BY YEAR(expDate), MONTH(expDate), FORMAT(expDate, 'MMM') " +
                "ORDER BY YEAR(expDate), MONTH(expDate)";

            //connect to database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                //get data from SQL server
                SqlCommand cmd = new SqlCommand(monthlySpendingQuery, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //clears any autogenerated series--needed to avoid crash
                monthlySpendingChart.Series.Clear();

                //set up series & add to chart
                Series series = new Series("SpendingByMonth");
                series.Points.DataBind(dt.AsEnumerable(), "monthName", "totalAmount", "");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel=true;
                monthlySpendingChart.Series.Add(series);

                //hide legend
                series.IsVisibleInLegend = false;

                //currency formatting for y axis
                monthlySpendingChart.ChartAreas[0].AxisY.LabelStyle.Format = "$#,0";
            }
        }

        //when back button is clicked, close the window
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

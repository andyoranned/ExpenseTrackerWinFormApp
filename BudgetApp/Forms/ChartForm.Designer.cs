namespace BudgetApp
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesDataSet = new BudgetApp.expensesDataSet();
            this.expensesTableAdapter = new BudgetApp.expensesDataSetTableAdapters.expensesTableAdapter();
            this.pieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePie = new System.Windows.Forms.TabPage();
            this.tabPageMonthlySpending = new System.Windows.Forms.TabPage();
            this.monthlySpendingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPagePie.SuspendLayout();
            this.tabPageMonthlySpending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthlySpendingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "expenses";
            this.expensesBindingSource.DataSource = this.expensesDataSet;
            // 
            // expensesDataSet
            // 
            this.expensesDataSet.DataSetName = "expensesDataSet";
            this.expensesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // pieChart
            // 
            chartArea3.Name = "ChartArea1";
            this.pieChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pieChart.Legends.Add(legend3);
            this.pieChart.Location = new System.Drawing.Point(6, 5);
            this.pieChart.Name = "pieChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieChart.Series.Add(series3);
            this.pieChart.Size = new System.Drawing.Size(591, 327);
            this.pieChart.TabIndex = 0;
            this.pieChart.Text = "chart1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePie);
            this.tabControl.Controls.Add(this.tabPageMonthlySpending);
            this.tabControl.Location = new System.Drawing.Point(12, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(608, 371);
            this.tabControl.TabIndex = 1;
            // 
            // tabPagePie
            // 
            this.tabPagePie.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePie.Controls.Add(this.pieChart);
            this.tabPagePie.Location = new System.Drawing.Point(4, 29);
            this.tabPagePie.Name = "tabPagePie";
            this.tabPagePie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePie.Size = new System.Drawing.Size(600, 338);
            this.tabPagePie.TabIndex = 0;
            this.tabPagePie.Text = "Spending By Category";
            // 
            // tabPageMonthlySpending
            // 
            this.tabPageMonthlySpending.Controls.Add(this.monthlySpendingChart);
            this.tabPageMonthlySpending.Location = new System.Drawing.Point(4, 29);
            this.tabPageMonthlySpending.Name = "tabPageMonthlySpending";
            this.tabPageMonthlySpending.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMonthlySpending.Size = new System.Drawing.Size(600, 338);
            this.tabPageMonthlySpending.TabIndex = 1;
            this.tabPageMonthlySpending.Text = "Spending By Month";
            this.tabPageMonthlySpending.UseVisualStyleBackColor = true;
            // 
            // monthlySpendingChart
            // 
            chartArea4.Name = "ChartArea1";
            this.monthlySpendingChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.monthlySpendingChart.Legends.Add(legend4);
            this.monthlySpendingChart.Location = new System.Drawing.Point(6, 9);
            this.monthlySpendingChart.Name = "monthlySpendingChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.monthlySpendingChart.Series.Add(series4);
            this.monthlySpendingChart.Size = new System.Drawing.Size(594, 300);
            this.monthlySpendingChart.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Image = global::BudgetApp.Properties.Resources.OIP;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 3;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPagePie.ResumeLayout(false);
            this.tabPageMonthlySpending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthlySpendingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private expensesDataSet expensesDataSet;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private expensesDataSetTableAdapters.expensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChart;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePie;
        private System.Windows.Forms.TabPage tabPageMonthlySpending;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlySpendingChart;
        private System.Windows.Forms.Button backButton;
    }
}
namespace BudgetApp
{
    partial class HomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.expDataGridView = new System.Windows.Forms.DataGridView();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesDataSet = new BudgetApp.expensesDataSet();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.expensesTableAdapter = new BudgetApp.expensesDataSetTableAdapters.expensesTableAdapter();
            this.chartButton = new System.Windows.Forms.Button();
            this.selectGroupBox = new System.Windows.Forms.GroupBox();
            this.expIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.expDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataSet)).BeginInit();
            this.selectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // expDataGridView
            // 
            this.expDataGridView.AllowUserToAddRows = false;
            this.expDataGridView.AllowUserToDeleteRows = false;
            this.expDataGridView.AutoGenerateColumns = false;
            this.expDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expIDDataGridViewTextBoxColumn,
            this.expNameDataGridViewTextBoxColumn,
            this.expAmountDataGridViewTextBoxColumn,
            this.expDateDataGridViewTextBoxColumn,
            this.expCategoryDataGridViewTextBoxColumn});
            this.expDataGridView.DataSource = this.expensesBindingSource;
            this.expDataGridView.Location = new System.Drawing.Point(6, 60);
            this.expDataGridView.Name = "expDataGridView";
            this.expDataGridView.ReadOnly = true;
            this.expDataGridView.RowHeadersWidth = 62;
            this.expDataGridView.RowTemplate.Height = 28;
            this.expDataGridView.Size = new System.Drawing.Size(761, 186);
            this.expDataGridView.TabIndex = 0;
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
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(12, 12);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(90, 30);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "New...";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(120, 16);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(90, 30);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit...";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(216, 16);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // chartButton
            // 
            this.chartButton.Location = new System.Drawing.Point(674, 271);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(90, 30);
            this.chartButton.TabIndex = 4;
            this.chartButton.Text = "Chart...";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // selectGroupBox
            // 
            this.selectGroupBox.Controls.Add(this.editButton);
            this.selectGroupBox.Controls.Add(this.deleteButton);
            this.selectGroupBox.Location = new System.Drawing.Point(342, 255);
            this.selectGroupBox.Name = "selectGroupBox";
            this.selectGroupBox.Size = new System.Drawing.Size(312, 59);
            this.selectGroupBox.TabIndex = 5;
            this.selectGroupBox.TabStop = false;
            this.selectGroupBox.Text = "Select Row to";
            // 
            // expIDDataGridViewTextBoxColumn
            // 
            this.expIDDataGridViewTextBoxColumn.DataPropertyName = "expID";
            this.expIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.expIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expIDDataGridViewTextBoxColumn.Name = "expIDDataGridViewTextBoxColumn";
            this.expIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.expIDDataGridViewTextBoxColumn.Width = 40;
            // 
            // expNameDataGridViewTextBoxColumn
            // 
            this.expNameDataGridViewTextBoxColumn.DataPropertyName = "expName";
            this.expNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.expNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expNameDataGridViewTextBoxColumn.Name = "expNameDataGridViewTextBoxColumn";
            this.expNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expAmountDataGridViewTextBoxColumn
            // 
            this.expAmountDataGridViewTextBoxColumn.DataPropertyName = "expAmount";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.expAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.expAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.expAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expAmountDataGridViewTextBoxColumn.Name = "expAmountDataGridViewTextBoxColumn";
            this.expAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expDateDataGridViewTextBoxColumn
            // 
            this.expDateDataGridViewTextBoxColumn.DataPropertyName = "expDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.expDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.expDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.expDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expDateDataGridViewTextBoxColumn.Name = "expDateDataGridViewTextBoxColumn";
            this.expDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expCategoryDataGridViewTextBoxColumn
            // 
            this.expCategoryDataGridViewTextBoxColumn.DataPropertyName = "expCategory";
            this.expCategoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.expCategoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.expCategoryDataGridViewTextBoxColumn.Name = "expCategoryDataGridViewTextBoxColumn";
            this.expCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 324);
            this.Controls.Add(this.selectGroupBox);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.expDataGridView);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.HomeForm_Activated);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataSet)).EndInit();
            this.selectGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private expensesDataSet expensesDataSet;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private expensesDataSetTableAdapters.expensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.DataGridView expDataGridView;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.GroupBox selectGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn expIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expCategoryDataGridViewTextBoxColumn;
    }
}


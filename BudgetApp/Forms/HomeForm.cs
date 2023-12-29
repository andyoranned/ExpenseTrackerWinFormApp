using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetApp;

namespace BudgetApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
            //get access to expense methods
            Expense exp = new Expense();

            //check for the existance of txt file that tracks amount of expenses made
            if (File.Exists(Path.Combine(exp.DOC_PATH, exp.FILE_NAME)))
            {
                int idCount = 0;

                //Save number recorded in txt file
                using (StreamReader sr = new StreamReader(Path.Combine(exp.DOC_PATH, exp.FILE_NAME)))
                {
                    idCount = int.Parse(sr.ReadLine());
                }

                //update Amount to the value from file
                Expense.Count = idCount;
            }

            // TODO: This line of code loads data into the 'expensesDataSet.expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.expensesDataSet.expenses);

        }

        //when the new button is clicked, the inputform shows
        private void newButton_Click(object sender, EventArgs e)
        {
            InputForm newForm = new InputForm(true);

            //set this form as the owner of the input form
            newForm.Owner = this;
            newForm.Show(this);
        }

        // get the id from table when row is selected
        public int getIdFromDGV()
        {
            DataGridViewRow selectedRow = expDataGridView.SelectedRows[0];
            int expID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            return expID;
        }

        //delete the expense from the row that's highlighted in the datagridview
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //is a row selected?
            if (expDataGridView.SelectedRows.Count > 0)
            {
                //get the id that user selected
                int expID = getIdFromDGV();
                this.expensesTableAdapter.DeleteExpense(expID);
                this.HomeForm_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please select whole row.");
            }
        }

        //when user clicks the editbutton, open InputForm populated with selected data
        private void editButton_Click(object sender, EventArgs e)
        {
            //is a row selected?
            if (expDataGridView.SelectedRows.Count > 0)
            {
                //yes, collect data from it
                DataGridViewRow selectedRow = expDataGridView.SelectedRows[0];
                string selectID= selectedRow.Cells[0].Value.ToString();
                string selectName = selectedRow.Cells[1].Value.ToString();
                DateTime selectDate = Convert.ToDateTime(selectedRow.Cells[3].Value);
                string selectAmount = selectedRow.Cells[2].Value.ToString();
                string selectCategory = selectedRow.Cells[4].Value.ToString();

                //create expense object to hold data
                Expense exp = new Expense(selectID, selectName, selectAmount, selectCategory, selectDate);
                
                //create new instance of input form populated with data
                InputForm updateForm = new InputForm(exp);
                updateForm.Show();
            }
            else
            {
                MessageBox.Show("Please select whole row.");
            }
        }

        //open the chart form when the chart button is clicked
        private void chartButton_Click(object sender, EventArgs e)
        {
            ChartForm chartForm = new ChartForm();
            chartForm.Show(this);
        }

        //whenever user returns to homeform, reload. This ensures datagridview is up-to-date
        private void HomeForm_Activated(object sender, EventArgs e)
        {
            this.HomeForm_Load(sender, e);
        }
    }
}

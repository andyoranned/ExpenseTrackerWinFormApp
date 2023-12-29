using BudgetApp.expensesDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;

namespace BudgetApp
{
    public partial class InputForm : Form
    {
        
        public bool IsNew {  get; set; }        //identifies if this is a new expense or an update

        //constructor used when putting in a new expense, hides ID information
        public InputForm(bool isNew)
        {
            InitializeComponent();
            IsNew = isNew;
            this.idLabel.Visible = false;
            this.idTextBox.Visible = false;
        }

        //for updating existing expense, shows ID information
        public InputForm(Expense exp)
        {
            InitializeComponent();
            //identifies this instance as an update
            IsNew = false;

            //make ID info visible
            idLabel.Visible = true;
            idTextBox.Visible = true;

            //populate the form with information from Expense
            idTextBox.Text = exp.Id.ToString();
            nameTextBox.Text = exp.Name;
            amountTextBox.Text = exp.Amount.ToString();
            categoryComboBox.Text = exp.Category;
            dateTimePicker.Value = exp.Date;
        }

        //clear all input when button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.nameTextBox.Text = string.Empty;
            this.amountTextBox.Text = string.Empty;
            this.categoryComboBox.SelectedItem = null;
            this.dateTimePicker.Value = DateTime.Now;
        }

        //when user clicks save button the information from the form is recorded in the database
        private void saveButton_Click(object sender, EventArgs e)
        {
            bool success = false;

            //is the form filled out?
            try
            {
                if (!String.IsNullOrEmpty(this.nameTextBox.Text) && !String.IsNullOrEmpty(this.amountTextBox.Text) && !String.IsNullOrEmpty(this.categoryComboBox.SelectedItem.ToString()))
                {
                    //New expense?
                    if (IsNew)
                    {
                        //make expense that generates new id
                        Expense exp = new Expense(this.nameTextBox.Text, this.amountTextBox.Text, this.categoryComboBox.SelectedItem.ToString(), this.dateTimePicker.Value);
                        this.expensesTableAdapter.InsertExpense(exp.Id, exp.Name, exp.Amount, exp.Date, exp.Category);
                        success = true;
                    }
                    else //Updating old expense
                    {
                        //make expense with id provided
                        Expense exp = new Expense(this.idTextBox.Text, this.nameTextBox.Text, this.amountTextBox.Text, this.categoryComboBox.SelectedItem.ToString(), this.dateTimePicker.Value);
                        this.expensesTableAdapter.UpdateExpense(exp.Name, exp.Amount, exp.Category, exp.Date, exp.Id);

                        success = true; 
                    }
                }//end outter if
            }
            catch 
            {
                success = false;
            }

            //did the update work?
            if (success)
            {

                //yes, close window after notifying user
                MessageBox.Show("Successfully recorded.");
                this.Close();
            }
            else
            {
                //no, notify user
                MessageBox.Show("Failed to record.");
            }
        }

        //when the back button is clicked, closes this window
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //validates that Name is in correct form
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            
            if (nameTextBox.Text == "")
            {
                errorProviderName.SetError(nameTextBox, "Please enter a name.");
               
            }
            else
            {
                errorProviderName.SetError(nameTextBox, "");
            }
        }

        //validates amount is a number and positive
        private void amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (amountTextBox.Text == "")
            {
                errorProviderAmount.SetError(amountTextBox, "Please enter an amount.");
            }
            else
            {
                errorProviderAmount.SetError(amountTextBox, "");
                try
                {
                    double temp = double.Parse(amountTextBox.Text);
                    errorProviderAmount.SetError(amountTextBox, "");
                    if (temp < 0)
                    {
                        errorProviderAmount.SetError(amountTextBox, "Please enter a positive number.");
                    }
                    else
                    {
                        errorProviderAmount.SetError(amountTextBox, "");
                    }
                }
                catch
                {
                    errorProviderAmount.SetError(amountTextBox, "Please enter a number.");
                }
            }


        }

        //validate combobox is selected
        private void categoryComboBox_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(categoryComboBox.Text))
            {
                errorProviderCategory.SetError(categoryComboBox, "Please select a category.");
            }
            else
            {
                errorProviderCategory.SetError(categoryComboBox, "");
            }
        }

        //not even sure if this is necessary. lol but I don't want to break anything this late in the game, so there it stays.
        //Agile prinicple of working code before anything else in practice right here! 
        private void InputForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'expensesDataSet.expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.expensesDataSet.expenses);
        }
    }
}

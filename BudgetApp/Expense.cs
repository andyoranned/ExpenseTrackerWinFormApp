using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    public class Expense
    { 
        //keeps track of how many expenses have ever been made to ensure unique ID
        public static int Count { get; set; }

        //each variable matches with a column in expense database
        public int Id { get; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }

        //Path & filename for txt file that saves Count long-term
        public readonly string DOC_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public readonly string FILE_NAME = "expenseTotalCount.txt";

        //empty constructor used to gain access to methods without adding data
        public Expense()
        {
           
        }

        //initialize fields and convert values to proper type, used when adding a new expense
        public Expense(string name, string amount, string category, DateTime date)
        {
            //If it's not the first, increment. Otherwise, initialize.
            if (Count >= 1)
                Count++;
            else
                Count = 1;

            //every time Count is increased, update and save txt file tracking it
            saveIdCount();

            this.Id = Count;
            this.Name = name;
            this.Amount = Convert.ToDouble(amount);
            this.Category = category;
            this.Date = date;
        }

        //use this constructor when you want to hold info of existing expense
        public Expense(string id, string name, string amount, string category, DateTime date)
        {
            this.Id = Convert.ToInt32(id);

            this.Name = name;
            this.Amount = Convert.ToDouble(amount);
            this.Category = category;
            this.Date = date;
        }

        //Save a text file that keeps track of how many expenses have ever been made
        public void saveIdCount()
        {
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(DOC_PATH, FILE_NAME)))
            {
                outputFile.WriteLine(Count.ToString());
                
            }//end of using = file closed
        }
    }
}

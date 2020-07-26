using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Budget
{
    public partial class BudgetForm : Form
    {

        private Database db;

        public BudgetForm()
        {
            InitializeComponent();
        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {

            db = new Database();

            fetchSums();
            fetchIncome();
            fetchExpenses();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (description.Text == "")
            {
                MessageBox.Show("Please enter the description", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt32(amount.Value) == 0)
            {
                MessageBox.Show("Please enter amount", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (debitcredit.SelectedIndex == -1)
            {
                MessageBox.Show("Please select debit or credit", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string desc = description.Text.ToString();
            int amt = Convert.ToInt32(amount.Value);
            int category = debitcredit.SelectedIndex;
            DateTime now = DateTime.Now;
            int day = now.Day;
            string month = getMonth(now.Month);
            int year = now.Year;



            db.insertRecord(desc, amt, category, day, month, year);

            description.Text = "";
            amount.Value = 0;

            fetchSums();
            fetchIncome();
            fetchExpenses();
            
        }

        private void fetchIncome()
        {
            incomeview.Items.Clear();
            List<DebitCredit> dataListIncome = db.retrieveRecords("credit");

            foreach (DebitCredit dc in dataListIncome)
            {
                ListViewItem item = new ListViewItem(dc.description);
                item.SubItems.Add(dc.amount.ToString());
                incomeview.Items.Add(item);
            }
        }

        private void fetchExpenses()
        {
            expensesview.Items.Clear();
            List<DebitCredit> dataListExpenses = db.retrieveRecords("debit");

            foreach (DebitCredit dc in dataListExpenses)
            {
                ListViewItem item = new ListViewItem(dc.description);
                item.SubItems.Add(dc.amount.ToString());
                expensesview.Items.Add(item);
            }
        }

        private void fetchSums()
        {

            Dictionary<string, int> sums = db.retrieveAmountCurrentMonth();

            budget.Text = sums["total"].ToString();
            credit.Text = "+ " + sums["income"].ToString();
            debit.Text = "- " + sums["expense"].ToString();
        }

        public static string getMonth(int numericMonth)
        {
            if(numericMonth == 1)
            {
                return "Jan";
            }
            else if(numericMonth == 2)
            {
                return "Feb";
            }
            else if(numericMonth == 3)
            {
                return "Mar";
            }
            else if(numericMonth == 4)
            {
                return "Apr";
            }
            else if(numericMonth == 5)
            {
                return "May";
            }
            else if(numericMonth == 6)
            {
                return "Jun";
            }
            else if(numericMonth == 7)
            {
                return "Jul";
            }
            else if(numericMonth == 8)
            {
                return "Aug";
            }
            else if(numericMonth == 9)
            {
                return "Sep";
            }
            else if(numericMonth == 10)
            {
                return "Oct";
            }
            else if(numericMonth == 11)
            {
                return "Nov";
            }
            else
            {
                return "Dec";
            }
        }

        private void viewdetailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var detailsForm = new Details();
            detailsForm.ShowDialog();
            this.Close();
        }
    }
}

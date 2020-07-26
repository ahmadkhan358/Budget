using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class Details : Form
    {

        private Database db;
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            db = new Database();
            List<int> years = db.retrieveYears();

            foreach(int year in years)
            {
                yearbox.Items.Add(year);
            }

            List<Accounts> accounts = db.retrieveAllRecords();

            populateListView(accounts);
        }

        private void fetchbtn_Click(object sender, EventArgs e)
        {
            int day = 0;
            string month = "";
            int year = 0;
            if (daybox.SelectedItem != null)
            {
                day = Convert.ToInt32(daybox.SelectedItem);
            }
            
            if(yearbox.SelectedItem != null)
            {
                year = Convert.ToInt32(yearbox.SelectedItem);
            }

            if(monthbox.SelectedItem != null)
            {
                month = monthbox.SelectedItem.ToString();
            }
           
            List<Accounts> accounts = db.retrieveRecordsDate(day, month, year);
            populateListView(accounts);
        }

        private void populateListView(List<Accounts> accounts)
        {
            recordsview.Items.Clear();
            foreach (Accounts account in accounts)
            {
                ListViewItem item = new ListViewItem(account.description);
                item.SubItems.Add(account.amount.ToString());
                if (account.category == 0)
                {
                    item.SubItems.Add("Debit");
                }
                else
                {
                    item.SubItems.Add("Credit");
                }
                StringBuilder builder = new StringBuilder();
                builder.Append(account.day);
                builder.Append(" / ");
                builder.Append(account.month);
                builder.Append(" / ");
                builder.Append(account.year);

                item.SubItems.Add(builder.ToString());

                recordsview.Items.Add(item);
            }
        }

        private void mainscreenbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BudgetForm budget = new BudgetForm();
            budget.ShowDialog();
            this.Close();
        }
    }
}

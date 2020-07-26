using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Budget
{
    class Database
    {
        public SQLiteConnection myConnection;

        public Database()
        {
            myConnection = new SQLiteConnection("Data Source=C:\\Database\\database.sqlite3");
            if (!Directory.Exists("C:\\Database"))
            {
                Directory.CreateDirectory("C:\\Database");
            }
            if (!File.Exists("C:\\Database\\database.sqlite3"))
            {
                SQLiteConnection.CreateFile("C:\\Database\\database.sqlite3");
            }
        }


        public void OpenConnection()
        {
            if (myConnection.State != ConnectionState.Open)
            {
                myConnection.Open();
                
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }

        public void insertRecord(string desc, int amt, int category, int day, string month, int year)
        {
            string query = "insert into accounts('description', 'amount', 'day', 'month', 'year', 'category') values(@description, @amount, @day, @month, @year, @category)";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            myCommand.Parameters.AddWithValue("@description", desc);
            myCommand.Parameters.AddWithValue("@amount", amt);
            myCommand.Parameters.AddWithValue("@day", day);
            myCommand.Parameters.AddWithValue("@month", month);
            myCommand.Parameters.AddWithValue("@year", year);
            myCommand.Parameters.AddWithValue("@category", category);
            var result = myCommand.ExecuteNonQuery();
            CloseConnection();
        }


        public List<DebitCredit> retrieveRecords(string debitcredit)
        {
            int dc = -1;
            if (debitcredit.Equals("debit"))
            {
                dc = 0;
            }
            else
            {
                dc = 1;
            }

            DateTime date = DateTime.Now;
            string month = BudgetForm.getMonth(date.Month);

            List<DebitCredit> dataList = new List<DebitCredit>();

            string query = "select description, amount from accounts where category = '" + dc + "' and month = '" + month + "' order by day asc";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            SQLiteDataReader dr = myCommand.ExecuteReader();

            while (dr.Read())
            {
                DebitCredit data = new DebitCredit();
                data.description = dr[0].ToString();
                data.amount = Convert.ToInt32(dr[1]);

                dataList.Add(data);

            }
            CloseConnection();
            return dataList;
        }


        public Dictionary<string, int> retrieveAmountCurrentMonth()
        {
            Dictionary<string, int> sums = new Dictionary<string, int>();

            int incomeSum = 0;
            int expenseSum = 0;
            int totalSum = 0;
            DateTime date = DateTime.Now;
            string month = BudgetForm.getMonth(date.Month);

            string query = "select amount, category from accounts where month = '" + month + "'";

            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            SQLiteDataReader dr = myCommand.ExecuteReader();

            while (dr.Read())
            {
                if(Convert.ToInt32(dr[1]) == 1)
                {
                    incomeSum += Convert.ToInt32(dr[0]);
                }
                else
                {
                    expenseSum += Convert.ToInt32(dr[0]);
                }
            }

            CloseConnection();

            totalSum = incomeSum - expenseSum;

            sums.Add("income", incomeSum);
            sums.Add("expense", expenseSum);
            sums.Add("total", totalSum);

            return sums;
        }


        public List<int> retrieveYears()
        {
            List<int> years = new List<int>();

            string query = "select distinct year from accounts";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            SQLiteDataReader dr = myCommand.ExecuteReader();

            while (dr.Read())
            {
                years.Add(Convert.ToInt32(dr[0]));
            }
            CloseConnection();
            return years;
        }

        public List<Accounts> retrieveAllRecords()
        {
            List<Accounts> accounts = new List<Accounts>();
            string query = "select description, amount, category, day, month, year from accounts order by year asc, day asc";
            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            SQLiteDataReader dr = myCommand.ExecuteReader();
            while (dr.Read())
            {
                Accounts acc = new Accounts();
                acc.description = dr[0].ToString();
                acc.amount = Convert.ToInt32(dr[1]);
                acc.category = Convert.ToInt32(dr[2]);
                acc.day = Convert.ToInt32(dr[3]);
                acc.month = dr[4].ToString();
                acc.year = Convert.ToInt32(dr[5]);

                accounts.Add(acc);
            }

            CloseConnection();

            return accounts;
        }

        public List<Accounts> retrieveRecordsDate(int day, string month, int year)
        {
            List<Accounts> accounts = new List<Accounts>();
            string query = "select description, amount, category, day, month, year from accounts";

            
            if (day == 0 && month.Equals("") && year != 0)
            {
                query += " where year = '" + year + "' order by year asc, day asc";
            }
            else if (day == 0 && !month.Equals("") && year == 0)
            {
                query += " where month = '" + month + "' order by year asc, day asc";
            }
            else if (day == 0 && !month.Equals("") && year != 0)
            {
                query += " where month = '" + month + "' and year = '" + year + "' order by year asc, day asc";
            }
            else if (day != 0 && month.Equals("") && year == 0)
            {
                query += " where day = '" + day + "' order by year asc, day asc";
            }
            else if (day != 0 && month.Equals("") && year != 0)
            {
                query += " where day = '" + day + "' and year = '" + year + "' order by year asc, day asc";
            }
            else if (day != 0 && !month.Equals("") && year == 0)
            {
                query += " where day = '" + day + "' and month = '" + month + "' order by year asc, day asc";
            }
            else if (day != 0 && !month.Equals("") && year != 0)
            {
                query += " where day = '" + day + "' and month = '" + month + "' and year = '" + year + "' order by year asc, day asc";
            }
           


            SQLiteCommand myCommand = new SQLiteCommand(query, myConnection);
            OpenConnection();
            SQLiteDataReader dr = myCommand.ExecuteReader();

            while (dr.Read())
            {
                Accounts acc = new Accounts();
                acc.description = dr[0].ToString();
                acc.amount = Convert.ToInt32(dr[1]);
                acc.category = Convert.ToInt32(dr[2]);
                acc.day = Convert.ToInt32(dr[3]);
                acc.month = dr[4].ToString();
                acc.year = Convert.ToInt32(dr[5]);
                accounts.Add(acc);
            }

            CloseConnection();

            return accounts;

        }
    }
}

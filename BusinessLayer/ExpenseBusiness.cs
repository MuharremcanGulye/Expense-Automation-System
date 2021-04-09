using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;
using System.Data;

namespace BusinessLayer
{
    public class ExpenseBusiness
    {

        SqlDataProvider provider = new SqlDataProvider(Constants.ConnectionString);

        public int AddExpense(Expense expense)
        {
            string query = "INSERT INTO EXPENSE VALUES " +
                "(@ID, @Title, @Date, @Cost, @Description, @StaffID, @StatusID) ";

            provider.command.Parameters.Clear();

            provider.command.CommandText = query;
            provider.command.Parameters.AddWithValue("@ID", expense.ID);
            provider.command.Parameters.AddWithValue("@Title",expense.Title );
            provider.command.Parameters.AddWithValue("@Date", expense.Date );
            provider.command.Parameters.AddWithValue("@Cost", expense.Cost );
            provider.command.Parameters.AddWithValue("@Description", expense.Description );
            provider.command.Parameters.AddWithValue("@StaffID", expense.StaffID );
            provider.command.Parameters.AddWithValue("@StatusID", expense.StatusID );

            return provider.RunQuery(query);
        }

        public List<Expense> GetExpenses(int staffID)
        {
            List<Expense> expenses = new List<Expense>();

            string query = "SELECT * FROM EXPENSE WHERE StaffID = @staffID ";

            provider.command.CommandText = query;
            provider.command.Parameters.Clear();
            provider.command.Parameters.AddWithValue("@staffID", staffID);

            DataTable expenseTable = provider.GetDataTable(query);

            if(expenseTable.Rows.Count > 0)
            {
                foreach(DataRow dr in expenseTable.Rows)
                {
                    Expense expense = new Expense()
                    {
                        ID = new Guid(dr["ID"].ToString()),
                        Title = dr["Title"].ToString(),
                        Description = dr["Description"].ToString(),
                        Date = (DateTime)dr["Date"],
                        Cost = (decimal)dr["Cost"],
                        StaffID = (int)dr["StaffID"],
                        StatusID = (byte)dr["StatusID"]
                    };
                    expenses.Add(expense);
                }
            }
            return expenses;       
        }
    }
}

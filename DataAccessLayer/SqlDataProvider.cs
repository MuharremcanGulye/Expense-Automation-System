using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlDataProvider
    {

        public SqlConnection connection { get; set; }
        public SqlCommand command { get; set; }

        //When we create new instance from this class 
        //connection and command will be ready to get data from the database
        public SqlDataProvider(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
            this.command = connection.CreateCommand();
        }

        public DataTable GetDataTable(string query)
        {
            DataTable result = new DataTable();

            this.command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(this.command);
            adapter.Fill(result);

            return result;
        }

        public object GetSingleData(string query)
        {
            object result = null;

            this.connection.Open();
            result = this.command.ExecuteScalar();
            this.connection.Close();

            return result;
        }

        public int RunQuery(string query)
        {
            int result = 0;

            this.command.CommandText = query;

            this.connection.Open();

            result = this.command.ExecuteNonQuery();

            this.connection.Close();

            return result;
        }
    }
}

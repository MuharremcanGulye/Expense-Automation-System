using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using CommonLayer;
using EntityLayer;

namespace BusinessLayer
{
    public class UserBusiness
    {

        private SqlDataProvider provider = new SqlDataProvider(AppConfigHelper.GetConnectionString("ExpenseAutomationDBConnString"));
        

        public Staff StaffLogin(string username , string password)
        {
            string query = "SELECT * FROM Staff" +
                                " AS S WHERE S.Username = @Username AND S.Password = @Password AND IsActive = 1";

            provider.command.Parameters.AddWithValue("@Username", username);
            provider.command.Parameters.AddWithValue("@Password", password);

            DataTable result = provider.GetDataTable(query);
            Staff staff = null;

            if (result.Rows.Count > 0)
            {
                DataRow dr = result.Rows[0];

                staff = new Staff();

                staff.ID = (int)dr["ID"];
                staff.Name = dr["Name"].ToString();
                staff.Surname = dr["Surname"].ToString();
                staff.Username = dr["Username"].ToString();
                staff.Password = dr["Password"].ToString();
                staff.IsActive = (bool)dr["IsActive"];
                staff.ToResponsibleID = (dr.IsNull("ToResponsibleID") == true ? null : (int?)dr["ToResponsbleID"]);
                staff.StaffTypeID = (byte)dr["StaffTypeID"];
            }

            return staff;
        }
    }
}

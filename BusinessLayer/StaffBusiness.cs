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
    public class StaffBusiness
    {

        private SqlDataProvider provider = new SqlDataProvider(Constants.ConnectionString);
        

        public Staff StaffLogin(string username , string password)
        {
            string query = "SELECT * FROM Staff" +
                                " AS S WHERE S.Username = @Username AND S.Password = @Password AND IsActive = 1";

            provider.command.Parameters.Clear();

            provider.command.Parameters.AddWithValue("@Username", username);
            provider.command.Parameters.AddWithValue("@Password", password);

            DataTable result = provider.GetDataTable(query);
            Staff staff = new Staff();

            if (result.Rows.Count > 0)
            {
                DataRow dr = result.Rows[0];

                staff.ID = (int)dr["ID"];
                staff.Name = dr["Name"].ToString();
                staff.Surname = dr["Surname"].ToString();
                staff.Username = dr["Username"].ToString();
                staff.Password = dr["Password"].ToString();
                staff.IsActive = (bool)dr["IsActive"];
                staff.ToResponsibleID = (dr.IsNull("ToResponsibleID") == true ? null : (int?)dr["ToResponsibleID"]);
                staff.StaffTypeID = (byte)dr["StaffTypeID"];
            }

            return staff;
        }

        public List<Staff> GetStaffByResponsibleID(int RespID)
        {
            string query = "SELECT * FROM Staff WHERE IsActive = 1 AND ToResponsibleID = @ID";

            provider.command.Parameters.Clear();

            provider.command.Parameters.AddWithValue("@ID", RespID);

            DataTable StaffTable = provider.GetDataTable(query);

            List<Staff> StaffList = new List<Staff>();

            if(StaffTable.Rows.Count > 0)
            {
                foreach(DataRow dr in StaffTable.Rows)
                {
                    Staff staff = new Staff();

                    staff.ID = (int)dr["ID"];
                    staff.Name = dr["Name"].ToString();
                    staff.Surname = dr["Surname"].ToString();
                    staff.Username = dr["Username"].ToString();
                    staff.Password = dr["Password"].ToString();
                    staff.IsActive = (bool)dr["IsActive"];
                    staff.ToResponsibleID = (dr.IsNull("ToResponsibleID") == true ? null : (int?)dr["ToResponsibleID"]);
                    staff.StaffTypeID = (byte)dr["StaffTypeID"];

                    StaffList.Add(staff);

                }
            }

            return StaffList;
        }
    }
}

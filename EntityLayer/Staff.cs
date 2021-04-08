using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Staff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int? ToResponsibleID { get; set; }
        public byte StaffTypeID { get; set; }
        //Value type cannot be null
    }
}

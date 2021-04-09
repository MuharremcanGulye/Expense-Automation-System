using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseAutomationSystemWinForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public Staff LoggedInStaff { get; set; }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblStaffNameSurname.Text = LoggedInStaff.Name + " " + LoggedInStaff.Surname;
        }
    }
}

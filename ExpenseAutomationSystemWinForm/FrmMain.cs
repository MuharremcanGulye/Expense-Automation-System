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
using BusinessLayer;

namespace ExpenseAutomationSystemWinForm
{
    public partial class FrmMain : Form
    {
        ExpenseBusiness eb = new ExpenseBusiness();

        public FrmMain()
        {
            InitializeComponent();
        }

        public Staff LoggedInStaff { get; set; }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblStaffNameSurname.Text = LoggedInStaff.Name + " " + LoggedInStaff.Surname;

            List<Expense> expenses = eb.GetExpenses(LoggedInStaff.ID);

            lstExpenses.DataSource = expenses;

            lstExpenses.DisplayMember = "Title";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense()
            {
                ID = Guid.NewGuid(),
                Title = txtTitle.Text,
                Date = dtpDate.Value,
                Cost = nudPrice.Value,
                Description = txtDesc.Text,
                StaffID = LoggedInStaff.ID,
                StatusID = (byte)StatusEnum.WaitingForApprove
            };

            int result = eb.AddExpense(expense);

            if(result > 0)
            {

            }
            else
            {
                MessageBox.Show("Expense Could Not Added");
            }


        }
    }
}

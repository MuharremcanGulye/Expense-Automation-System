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
        ExpenseBusiness EB = new ExpenseBusiness();
        StaffBusiness SB = new StaffBusiness();

        public FrmMain()
        {
            InitializeComponent();
        }

        public Staff LoggedInStaff { get; set; }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblStaffNameSurname.Text = LoggedInStaff.Name + " " + LoggedInStaff.Surname;

            GetStaffExpenses();
            GetResponsibleForStaff();
        }

        private void GetResponsibleForStaff()
        {
            List<Staff> ResponsibleForList = new List<Staff>();
            ResponsibleForList.Add(LoggedInStaff);

            ResponsibleForList.AddRange(SB.GetStaffByResponsibleID(LoggedInStaff.ID));

            cmbExpenseOwner.DataSource = ResponsibleForList;
        }

        private void GetStaffExpenses()
        {
            if(cmbExpenseOwner.SelectedIndex > -1)
            {
                Staff staff = cmbExpenseOwner.SelectedItem as Staff;

                List<Expense> expenses = EB.GetExpenses(staff.ID);
                lstExpenses.DataSource = expenses;
            }
           
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

            int result = EB.AddExpense(expense);

            if(result > 0)
            {
                GetStaffExpenses();
            }
            else
            {
                MessageBox.Show("Expense Could Not Added");
            }


        }

        private void lstExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstExpenses.SelectedIndex == -1)
            {
                return;
            }

            Expense expense = lstExpenses.SelectedItem as Expense;

            if (expense != null)
            {
                txtTitle.Text = expense.Title;
                txtDesc.Text = expense.Description;
                nudPrice.Value = expense.Cost;
                dtpDate.Value = expense.Date;

                //We need to change expense status as needs approve.
            }

            if (expense.StatusID == (byte)StatusEnum.Declined || expense.StatusID == (byte)StatusEnum.Paid)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }

            if(expense.StatusID == (byte)StatusEnum.Paid)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lstExpenses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an expense to update");
                return;
            }

            Expense expense = lstExpenses.SelectedItem as Expense;

            expense.Title = txtTitle.Text;
            expense.Description = txtDesc.Text;
            expense.Date = dtpDate.Value;
            expense.Cost = nudPrice.Value;
            expense.StatusID = (byte)StatusEnum.WaitingForApprove;

            if(EB.UpdateExpense(expense) > 0)
            {
                MessageBox.Show("Expense has been Updated");
                GetStaffExpenses();
            }
            else
            {
                MessageBox.Show("Expense could not been updated");
            }
           
        }

        private void lstExpenses_Format(object sender, ListControlConvertEventArgs e)
        {
            Expense expense = e.ListItem as Expense;

            e.Value = string.Format("{0} ({1})", expense.Title, StatusEnumHelper.getStatusString(expense.StatusID));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstExpenses.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an expense to delete");
                return;
            }

            Expense expense = lstExpenses.SelectedItem as Expense;

            DialogResult result = MessageBox.Show("Are you sure to delete" + expense.Title + "titled expense?",
                "Expense Delete",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);

            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                if (EB.DeleteExpense(expense) > 0)
                {
                    MessageBox.Show("Expense has been deleted");
                    GetStaffExpenses();
                }
                else
                {
                    MessageBox.Show("Expense could not be deleted");
                }
            }

        }

        private void cmbExpenseOwner_Format(object sender, ListControlConvertEventArgs e)
        {
            Staff staff = e.ListItem as Staff;

            e.Value = string.Format("{0} {1} ", staff.Name, staff.Surname);
        }

        private void cmbExpenseOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbExpenseOwner.SelectedIndex == -1)
            {
                return;
            }

            Staff staff = cmbExpenseOwner.SelectedItem as Staff;

            if(staff.Equals(LoggedInStaff))
            {
                flpButtons.Enabled = true;
                lstExpenses.ContextMenuStrip = null;
            }
            else
            {
                flpButtons.Enabled = false;
                lstExpenses.ContextMenuStrip = cmsExpenseManage;
            }

            List<Expense> expenses = EB.GetExpenses(staff.ID);

            lstExpenses.DataSource = expenses;
            lstExpenses.DisplayMember = "Title";
        }

        private void cmsApprove_Click(object sender, EventArgs e)
        {
            if(lstExpenses.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Expense to Manage");
                return;
            }

            Expense expense = lstExpenses.SelectedItem as Expense;
            expense.StatusID = (byte)StatusEnum.Approved;

            if(EB.UpdateExpense(expense) > 0)
            {
                GetStaffExpenses();
            }
            else
            {
                MessageBox.Show("Expense Could not be Approved");
            }
        }

        private void cmsUpdate_Click(object sender, EventArgs e)
        {
            if (lstExpenses.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Expense to Manage");
                return;
            }

            Expense expense = lstExpenses.SelectedItem as Expense;
            expense.StatusID = (byte)StatusEnum.NeedsEdit;

            if (EB.UpdateExpense(expense) > 0)
            {
                GetStaffExpenses();
            }
            else
            {
                MessageBox.Show("Expense Could not be Updated");
            }
        }

        private void cmsDecline_Click(object sender, EventArgs e)
        {
            if (lstExpenses.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Expense to Manage");
                return;
            }

            Expense expense = lstExpenses.SelectedItem as Expense;
            expense.StatusID = (byte)StatusEnum.Declined;

            if (EB.UpdateExpense(expense) > 0)
            {
                GetStaffExpenses();
            }
            else
            {
                MessageBox.Show("Expense Could not be Declined");
            }
        }
    }
}

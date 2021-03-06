namespace ExpenseAutomationSystemWinForm
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStripExpenseSystem = new System.Windows.Forms.SplitContainer();
            this.gbExpense = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstExpenses = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbExpenseOwner = new System.Windows.Forms.ComboBox();
            this.lblExpenseOwner = new System.Windows.Forms.Label();
            this.mnuStripExpense = new System.Windows.Forms.MenuStrip();
            this.lblStaffNameSurname = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsExpenseManage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsApprove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsDecline = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.menuStripExpenseSystem)).BeginInit();
            this.menuStripExpenseSystem.Panel1.SuspendLayout();
            this.menuStripExpenseSystem.Panel2.SuspendLayout();
            this.menuStripExpenseSystem.SuspendLayout();
            this.gbExpense.SuspendLayout();
            this.flpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.mnuStripExpense.SuspendLayout();
            this.cmsExpenseManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripExpenseSystem
            // 
            this.menuStripExpenseSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripExpenseSystem.Location = new System.Drawing.Point(0, 0);
            this.menuStripExpenseSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menuStripExpenseSystem.Name = "menuStripExpenseSystem";
            // 
            // menuStripExpenseSystem.Panel1
            // 
            this.menuStripExpenseSystem.Panel1.Controls.Add(this.gbExpense);
            this.menuStripExpenseSystem.Panel1.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            // 
            // menuStripExpenseSystem.Panel2
            // 
            this.menuStripExpenseSystem.Panel2.Controls.Add(this.panel1);
            this.menuStripExpenseSystem.Panel2.Controls.Add(this.mnuStripExpense);
            this.menuStripExpenseSystem.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.menuStripExpenseSystem.Size = new System.Drawing.Size(900, 585);
            this.menuStripExpenseSystem.SplitterDistance = 299;
            this.menuStripExpenseSystem.TabIndex = 0;
            // 
            // gbExpense
            // 
            this.gbExpense.Controls.Add(this.txtDesc);
            this.gbExpense.Controls.Add(this.flpButtons);
            this.gbExpense.Controls.Add(this.lblDesc);
            this.gbExpense.Controls.Add(this.nudPrice);
            this.gbExpense.Controls.Add(this.lblPrice);
            this.gbExpense.Controls.Add(this.txtTitle);
            this.gbExpense.Controls.Add(this.lblTitle);
            this.gbExpense.Controls.Add(this.dtpDate);
            this.gbExpense.Controls.Add(this.lblDate);
            this.gbExpense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbExpense.Location = new System.Drawing.Point(11, 13);
            this.gbExpense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbExpense.Name = "gbExpense";
            this.gbExpense.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.gbExpense.Size = new System.Drawing.Size(277, 559);
            this.gbExpense.TabIndex = 0;
            this.gbExpense.TabStop = false;
            this.gbExpense.Text = "Expense Details";
            // 
            // txtDesc
            // 
            this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDesc.Location = new System.Drawing.Point(11, 238);
            this.txtDesc.MaxLength = 150;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(255, 208);
            this.txtDesc.TabIndex = 8;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnDelete);
            this.flpButtons.Controls.Add(this.btnAdd);
            this.flpButtons.Controls.Add(this.btnUpdate);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(11, 446);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(255, 100);
            this.flpButtons.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(132, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 49);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(246, 40);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesc.Location = new System.Drawing.Point(11, 208);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDesc.Size = new System.Drawing.Size(255, 30);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Description :";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudPrice.Location = new System.Drawing.Point(11, 180);
            this.nudPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            131072});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(255, 28);
            this.nudPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Location = new System.Drawing.Point(11, 150);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblPrice.Size = new System.Drawing.Size(255, 30);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price :";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Location = new System.Drawing.Point(11, 122);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(255, 28);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(11, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblTitle.Size = new System.Drawing.Size(255, 30);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title :";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpDate
            // 
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(11, 64);
            this.dtpDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(255, 28);
            this.dtpDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDate.Location = new System.Drawing.Point(11, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lblDate.Size = new System.Drawing.Size(255, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstExpenses);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 38);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(577, 537);
            this.panel1.TabIndex = 1;
            // 
            // lstExpenses
            // 
            this.lstExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstExpenses.FormattingEnabled = true;
            this.lstExpenses.ItemHeight = 21;
            this.lstExpenses.Location = new System.Drawing.Point(10, 50);
            this.lstExpenses.Name = "lstExpenses";
            this.lstExpenses.Size = new System.Drawing.Size(557, 477);
            this.lstExpenses.TabIndex = 1;
            this.lstExpenses.SelectedIndexChanged += new System.EventHandler(this.lstExpenses_SelectedIndexChanged);
            this.lstExpenses.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstExpenses_Format);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmbExpenseOwner);
            this.flowLayoutPanel1.Controls.Add(this.lblExpenseOwner);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmbExpenseOwner
            // 
            this.cmbExpenseOwner.FormattingEnabled = true;
            this.cmbExpenseOwner.Location = new System.Drawing.Point(204, 5);
            this.cmbExpenseOwner.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cmbExpenseOwner.Name = "cmbExpenseOwner";
            this.cmbExpenseOwner.Size = new System.Drawing.Size(350, 29);
            this.cmbExpenseOwner.TabIndex = 0;
            this.cmbExpenseOwner.SelectedIndexChanged += new System.EventHandler(this.cmbExpenseOwner_SelectedIndexChanged);
            this.cmbExpenseOwner.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbExpenseOwner_Format);
            // 
            // lblExpenseOwner
            // 
            this.lblExpenseOwner.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExpenseOwner.Location = new System.Drawing.Point(32, 5);
            this.lblExpenseOwner.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblExpenseOwner.Name = "lblExpenseOwner";
            this.lblExpenseOwner.Size = new System.Drawing.Size(169, 29);
            this.lblExpenseOwner.TabIndex = 1;
            this.lblExpenseOwner.Text = "Expense Owner : ";
            this.lblExpenseOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuStripExpense
            // 
            this.mnuStripExpense.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStripExpense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStaffNameSurname});
            this.mnuStripExpense.Location = new System.Drawing.Point(10, 10);
            this.mnuStripExpense.Name = "mnuStripExpense";
            this.mnuStripExpense.Size = new System.Drawing.Size(577, 28);
            this.mnuStripExpense.TabIndex = 0;
            this.mnuStripExpense.Text = "menuStrip1";
            // 
            // lblStaffNameSurname
            // 
            this.lblStaffNameSurname.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblStaffNameSurname.Name = "lblStaffNameSurname";
            this.lblStaffNameSurname.Size = new System.Drawing.Size(158, 24);
            this.lblStaffNameSurname.Text = "Staff Name Surname";
            // 
            // cmsExpenseManage
            // 
            this.cmsExpenseManage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsExpenseManage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsApprove,
            this.cmsUpdate,
            this.toolStripMenuItem1,
            this.cmsDecline});
            this.cmsExpenseManage.Name = "cmsExpenseManage";
            this.cmsExpenseManage.Size = new System.Drawing.Size(211, 110);
            // 
            // cmsApprove
            // 
            this.cmsApprove.Name = "cmsApprove";
            this.cmsApprove.Size = new System.Drawing.Size(210, 24);
            this.cmsApprove.Text = "Approve";
            this.cmsApprove.Click += new System.EventHandler(this.cmsApprove_Click);
            // 
            // cmsUpdate
            // 
            this.cmsUpdate.Name = "cmsUpdate";
            this.cmsUpdate.Size = new System.Drawing.Size(210, 24);
            this.cmsUpdate.Text = "Update";
            this.cmsUpdate.Click += new System.EventHandler(this.cmsUpdate_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // cmsDecline
            // 
            this.cmsDecline.Name = "cmsDecline";
            this.cmsDecline.Size = new System.Drawing.Size(210, 24);
            this.cmsDecline.Text = "Decline";
            this.cmsDecline.Click += new System.EventHandler(this.cmsDecline_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 585);
            this.Controls.Add(this.menuStripExpenseSystem);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStripExpense;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Automation : Expenses";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStripExpenseSystem.Panel1.ResumeLayout(false);
            this.menuStripExpenseSystem.Panel2.ResumeLayout(false);
            this.menuStripExpenseSystem.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuStripExpenseSystem)).EndInit();
            this.menuStripExpenseSystem.ResumeLayout(false);
            this.gbExpense.ResumeLayout(false);
            this.gbExpense.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.mnuStripExpense.ResumeLayout(false);
            this.mnuStripExpense.PerformLayout();
            this.cmsExpenseManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer menuStripExpenseSystem;
        private System.Windows.Forms.GroupBox gbExpense;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip mnuStripExpense;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstExpenses;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbExpenseOwner;
        private System.Windows.Forms.Label lblExpenseOwner;
        private System.Windows.Forms.ToolStripMenuItem lblStaffNameSurname;
        private System.Windows.Forms.ContextMenuStrip cmsExpenseManage;
        private System.Windows.Forms.ToolStripMenuItem cmsApprove;
        private System.Windows.Forms.ToolStripMenuItem cmsUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmsDecline;
    }
}
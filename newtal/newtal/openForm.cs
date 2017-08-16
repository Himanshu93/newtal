using newtal_core;
using newtal_sqlUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newtal
{
    public partial class openForm : Form
    {
        public openForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fix the window to maximum screen size
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            
        }


        private void btnSelectionConfirmation_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pnlTablePanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tlpMainMenuContainer.Enabled = false;
            pnlSelectCompany.Visible = true;
            
        }

        private void tlpHomeScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn2CreateCompany_Click(object sender, EventArgs e)
        {
            tlpMainMenuContainer.Enabled = false;
            pnlSelectCompany.Visible = true;
            dgvSelectCompany.Visible = false;
            pnlCreateCompany.Visible = true;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNewAccountSubmit_Click(object sender, EventArgs e)
        {
            string name = tbNewAccountName.Text;
            string startDate = dtbstartDate.Text;
            string endDate = dtbEndDate.Text;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvSelectCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtbstartDate_ValueChanged(object sender, EventArgs e)
        {
            string startDate = dtbstartDate.Text;
        }

        private void LoadAccounts()
        {
            SqlAccountUtility accountUtil = new SqlAccountUtility("SqlAccountConnection");
            List<Account> accounts = accountUtil.GetAllAccounts();
            dgvSelectCompany.DataSource = accounts;
        }
    }
}

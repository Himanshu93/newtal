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
            tlpMainMenuContainer.Visible = false;
            pnlSelectCompany.Visible = true;
            
        }

        private void tlpHomeScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn2CreateCompany_Click(object sender, EventArgs e)
        {
            tlpMainMenuContainer.Enabled = false;
            tlpMainMenuContainer.Visible = false;
        }
    }
}

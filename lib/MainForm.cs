using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lib
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide();
            }
        }

        private void returnBooks1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;

            dashboard dForm = dashboard1 as dashboard;
            if (dForm != null)
            {
                
            }
        }

        private void addbook_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = true;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
        }

        private void issuebook_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = true;
        }

        private void returnbook_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = true;
            issueBooks1.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Dashboard : Form
    {
        frm_log fl;
        frm_reg fr;
        frm_park fp;
        frm_order fo;
        frm_user fu;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            btn_current.BackColor = Color.RoyalBlue;

            lblUserName.Text = frm_log.user;
            lblUserType.Text = frm_log.type;
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_close1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CusDetails_Click(object sender, EventArgs e)
        {
            btn_CusDetails.BackColor = Color.RoyalBlue;

            btn_current.BackColor = Color.MidnightBlue;
            btn_ParkArea.BackColor = Color.MidnightBlue;
            btn_Recieve.BackColor = Color.MidnightBlue;
            btn_UserDetails.BackColor = Color.MidnightBlue;
            fr = new frm_reg();
            fr.Show();
        }

        private void btn_ParkArea_Click(object sender, EventArgs e)
        {
            btn_ParkArea.BackColor = Color.RoyalBlue;

            btn_current.BackColor = Color.MidnightBlue;
            btn_CusDetails.BackColor = Color.MidnightBlue;
            btn_Recieve.BackColor = Color.MidnightBlue;
            btn_UserDetails.BackColor = Color.MidnightBlue;
            fp = new frm_park();
            fp.Show();
        }

        private void btn_Recieve_Click(object sender, EventArgs e)
        {
            btn_Recieve.BackColor = Color.RoyalBlue;

            btn_current.BackColor = Color.MidnightBlue;
            btn_ParkArea.BackColor = Color.MidnightBlue;
            btn_CusDetails.BackColor = Color.MidnightBlue;
            btn_UserDetails.BackColor = Color.MidnightBlue;
            fo = new frm_order();
            fo.Show();
        }

        private void btn_UserDetails_Click(object sender, EventArgs e)
        {
            btn_UserDetails.BackColor = Color.RoyalBlue;

            btn_current.BackColor = Color.MidnightBlue;
            btn_Recieve.BackColor = Color.MidnightBlue;
            btn_ParkArea.BackColor = Color.MidnightBlue;
            btn_CusDetails.BackColor = Color.MidnightBlue;
            fu = new frm_user();
            fu.Show();
        }

        private void btn_current_Click(object sender, EventArgs e)
        {
            btn_current.BackColor = Color.RoyalBlue;

            btn_ParkArea.BackColor = Color.MidnightBlue;
            btn_Recieve.BackColor = Color.MidnightBlue;
            btn_UserDetails.BackColor = Color.MidnightBlue;
            btn_CusDetails.BackColor = Color.MidnightBlue;
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            fl = new frm_log();
            this.Hide();
            fl.Show();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

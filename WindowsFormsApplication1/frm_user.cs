using MySql.Data.MySqlClient;
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
    public partial class frm_user : Form
    {
       
        //......................my methods.................

        MySqlConnection Conn;
        MySqlCommand Cmd;
        DataTable DataTBL;
        MySqlDataAdapter DataADPT;
        MySqlCommandBuilder cmdBuild;

        public void user_data_fill()
        {
            String Str_Conn = "server=localhost;username=root;password=;database=car;";
            Conn = new MySqlConnection(Str_Conn);
            Cmd = new MySqlCommand("SELECT * FROM users", Conn);

            try
            {
                DataADPT = new MySqlDataAdapter();
                DataADPT.SelectCommand = Cmd;
                DataTBL = new DataTable();
                DataADPT.Fill(DataTBL);
                db_user.DataSource = DataTBL;

                /*                BindingSource Bind = new BindingSource();
                                Bind.DataSource = DataTBL;
                                db_cust.DataSource = Bind;
                                DataADPT.Update(DataTBL);
                */

                db_header();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }

        }

        public void db_header()
        {

            db_user.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke; //Color.FromArgb(A_0-255,r_0-255,g_0-255,b_0-255)
            db_user.ColumnHeadersDefaultCellStyle.ForeColor = Color.Maroon;
            db_user.EnableHeadersVisualStyles = false;
            db_user.ColumnHeadersDefaultCellStyle.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);

            db_user.Columns["U_Id"].ReadOnly = true;

            db_user.Columns[0].HeaderCell.Value = "User Id";
            db_user.Columns[1].HeaderCell.Value = "Name";
            db_user.Columns[2].HeaderCell.Value = "Date of birth";
            db_user.Columns[3].HeaderCell.Value = "Contact";
            db_user.Columns[4].HeaderCell.Value = "Address";
            db_user.Columns[5].HeaderCell.Value = "NIC";
            db_user.Columns[6].HeaderCell.Value = "E-mail";
            db_user.Columns[7].HeaderCell.Value = "Password";

        }

        public void db_update()
        {

            cmdBuild = new MySqlCommandBuilder(DataADPT);
            DataADPT.Update(DataTBL);

        }

        private String db_selectedRow()
        {
            if (db_user.SelectedCells.Count > 0)
            {
                int selectedrowindex = db_user.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = db_user.Rows[selectedrowindex];

                string User_ID = Convert.ToString(selectedRow.Cells["U_Id"].Value);

                return User_ID;
            }

            return null;
        }

        //.......................finished.................




        public frm_user()
        {
            InitializeComponent();
            user_data_fill();

        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String USER_ID = db_selectedRow();
            // for understanding ---            DialogResult dr = MessageBox.Show("Message.", "Title", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            DialogResult des = MessageBox.Show("Do you want to delete " + USER_ID + " ?...", "Conform your delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (des == DialogResult.Yes)
            {
                DB delete = new DB();
                delete.dbconn();
                delete.delete_row("users","U_Id",USER_ID);
                delete.dbclose();
                user_data_fill();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_update();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_admin_page admin = new frm_admin_page();
            admin.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

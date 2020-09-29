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
    public partial class frm_park : Form
    {
        //......................my methods.................

        MySqlConnection Conn;
        MySqlCommand Cmd;
        DataTable DataTBL;
        MySqlDataAdapter DataADPT;
        MySqlCommandBuilder cmdBuild;
        public void park_data_fill()
        {
            String Str_Conn = "server=localhost;username=root;password=;database=car;";
            Conn = new MySqlConnection(Str_Conn);
            Cmd = new MySqlCommand("SELECT * FROM area", Conn);
                     Conn.Open();

            try
            {


                DataADPT = new MySqlDataAdapter();
                DataADPT.SelectCommand = Cmd;
                DataTBL = new DataTable();
                DataADPT.Fill(DataTBL);
                db_area.DataSource = DataTBL;

                /*              BindingSource Bind = new BindingSource();
                                Bind.DataSource = DataTBL;
                                db_cust.DataSource = Bind;
                                DataADPT.Update(DataTBL);
                */

                grid_head();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());

            }

        }


        public void grid_head()
        {

            db_area.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke; //Color.FromArgb(A_0-255,r_0-255,g_0-255,b_0-255)
            db_area.ColumnHeadersDefaultCellStyle.ForeColor = Color.MidnightBlue;
            db_area.EnableHeadersVisualStyles = false;
            db_area.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);

            db_area.Columns["P_Id"].ReadOnly = true;

            db_area.Columns[0].HeaderCell.Value = "Parking place Id";
            db_area.Columns[1].HeaderCell.Value = "Floor Number";
            db_area.Columns[2].HeaderCell.Value = "Availability";
        }

        public void grid_update()
        {

            cmdBuild = new MySqlCommandBuilder(DataADPT);
            DataADPT.Update(DataTBL);

        }

        private String grid_selectedRow()
        {
            if (db_area.SelectedCells.Count > 0)
            {
                int selectedrowindex = db_area.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = db_area.Rows[selectedrowindex];

                string Park_ID = Convert.ToString(selectedRow.Cells["P_Id"].Value);

                return Park_ID;
            }

            return null;
        }

        //.......................finished.................

        public frm_park()
        {
            InitializeComponent();
            park_data_fill();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_admin_page admin = new frm_admin_page();
            admin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB Insert = new DB();
            String Query = "INSERT INTO `area`(`P_ID`, `Flr`, `Available`) VALUES ('"+txt_P_ID.Text.ToUpper()+ "','"+ cmb_flr.SelectedItem.ToString() + "','1')";
            Insert.dbconn();
            Insert.Ins_Upd_DB(Query);
            Insert.dbclose();
            park_data_fill();
        }

        private void cmb_flr_SelectedIndexChanged(object sender, EventArgs e)
        {
                     cmb_flr.Items.Add("abc"); //- Add item to combo box
                     cmb_flr.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Park_ID = grid_selectedRow();
            // for understanding ---            DialogResult dr = MessageBox.Show("Message.", "Title", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            DialogResult des = MessageBox.Show("Do you want to delete " + Park_ID + " ?...", "Conform your delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (des == DialogResult.Yes)
            {
                DB delete = new DB();
                delete.dbconn();
                delete.delete_row("area", "P_Id", Park_ID);
                delete.dbclose();
                park_data_fill();
            }
        }

        private void frm_park_Load(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();          
        }

        private void db_area_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}

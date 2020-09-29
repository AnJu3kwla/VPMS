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
    public partial class frm_reg : Form
    {
        //......................my methods.................

        MySqlConnection Conn;
        MySqlCommand Cmd;
        DataTable DataTBL;
        MySqlDataAdapter DataADPT;
        MySqlCommandBuilder cmdBuild;
        public void cust_data_fill()
        {
            String Str_Conn = "server=localhost;username=root;password=;database=car;";
            Conn = new MySqlConnection(Str_Conn);
            Cmd = new MySqlCommand("SELECT * FROM customer", Conn);
            Conn.Open();
            
            try {


                DataADPT = new MySqlDataAdapter();
                DataADPT.SelectCommand = Cmd;
                DataTBL = new DataTable();
                DataADPT.Fill(DataTBL);
                db_cust.DataSource = DataTBL;

                                /*BindingSource Bind = new BindingSource();
                                Bind.DataSource = DataTBL;
                                db_cust.DataSource = Bind;
                                DataADPT.Update(DataTBL);*/
               

                grid_head();
            }
            catch(Exception e){

                MessageBox.Show(e.ToString());

            }            

        }

        public void clear()
        {
            txt_Cust_Id.Text = " ";
            txt_Cust_Name.Text = " ";
            txt_Cust_Cont.Text = " ";
            txt_Cust_Add.Text = " ";
            txt_Cust_Nic.Text = " ";
            txt_Cust_Email.Text = " ";
            txt_Cust_Vectype.Text = " ";
            txt_Cust_Vecnum.Text = " ";
        }
        public void grid_head()
        {

            db_cust.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke; //Color.FromArgb(A_0-255,r_0-255,g_0-255,b_0-255)
            db_cust.ColumnHeadersDefaultCellStyle.ForeColor = Color.MidnightBlue;
            db_cust.EnableHeadersVisualStyles = false;
            db_cust.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold);

            db_cust.Columns["C_Id"].ReadOnly = true;

            db_cust.Columns[0].HeaderCell.Value = "Customer Id";
            db_cust.Columns[1].HeaderCell.Value = "Name";
            db_cust.Columns[2].HeaderCell.Value = "Contact";
            db_cust.Columns[3].HeaderCell.Value = "Address";
            db_cust.Columns[4].HeaderCell.Value = "NIC";
            db_cust.Columns[5].HeaderCell.Value = "E-mail";
            db_cust.Columns[6].HeaderCell.Value = "Vehicle Type";
            db_cust.Columns[7].HeaderCell.Value = "Vehicle Number";

        }

        public void grid_update()
        {

            cmdBuild = new MySqlCommandBuilder(DataADPT);
            DataADPT.Update(DataTBL);

        }

        private String grid_selectedRow()
        {
            if (db_cust.SelectedCells.Count > 0)
            {
                int selectedrowindex = db_cust.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = db_cust.Rows[selectedrowindex];

                string Cust_ID = Convert.ToString(selectedRow.Cells["C_Id"].Value);

                return Cust_ID;
            }

            return null;
        }

        //.......................finished.................
        public frm_reg()
        {
            InitializeComponent();
            cust_data_fill();
        }

        private void frm_reg_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void db_cust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Cust_Save_Click(object sender, EventArgs e)
        {
            DB Insert = new DB();
            String ID = txt_Cust_Nic.Text;
            String NIC = ID.Substring(0, ID.Length - 1);
            String Vehicle = txt_Cust_Vecnum.Text.ToUpper();
            String Cust = NIC + Vehicle;
            String Query = "INSERT INTO `customer`(`C_Id`, `C_Name`, `C_Cont`, `C_Add`, `C_NIC`, `C_Email`, `C_Vehicle_Type`, `C_Vehicle_Num`) VALUES ('" + txt_Cust_Id.Text + "','" + txt_Cust_Name.Text + "','"+txt_Cust_Cont.Text + "','" + txt_Cust_Add.Text + "','" + txt_Cust_Nic.Text.ToUpper() + "','" + txt_Cust_Email.Text + "','" + txt_Cust_Vectype.Text.ToUpper() + "','" + txt_Cust_Vecnum.Text.ToUpper() + "')";

            Insert.dbconn();
            Insert.Ins_Upd_DB(Query);
            Insert.dbclose();
            MessageBox.Show("Succesfully you endrolled to the system");
            cust_data_fill();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String CUST_ID = grid_selectedRow();
            // for understanding ---            DialogResult dr = MessageBox.Show("Message.", "Title", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
            DialogResult des = MessageBox.Show("Do you want to delete "+CUST_ID+" ?...", "Conform your delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (des == DialogResult.Yes)
            {
                DB delete = new DB();
                delete.dbconn();
                delete.delete_row("customer","C_Id",CUST_ID);
                delete.dbclose();
                cust_data_fill();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_admin_page admin = new frm_admin_page();
            admin.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
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

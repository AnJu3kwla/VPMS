using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_order : Form
    {

        //......................my methods.................

        MySqlConnection Conn;
        MySqlCommand Cmd;
        DataTable DataTBL;
        MySqlDataAdapter DataADPT;
        MySqlCommandBuilder cmdBuild;
        MySqlDataReader read,read_p;
        public void park_data_fill()
        {
            String Str_Conn = "server=localhost;username=root;password=;database=car;";
            Conn = new MySqlConnection(Str_Conn);
            Cmd = new MySqlCommand("SELECT * FROM park", Conn);
            Conn.Open();

            try
            {


                DataADPT = new MySqlDataAdapter();
                DataADPT.SelectCommand = Cmd;
                DataTBL = new DataTable();
                DataADPT.Fill(DataTBL);
                db_order.DataSource = DataTBL;

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

            db_order.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke; //Color.FromArgb(A_0-255,r_0-255,g_0-255,b_0-255)
            db_order.ColumnHeadersDefaultCellStyle.ForeColor = Color.Maroon;
            db_order.EnableHeadersVisualStyles = false;
            db_order.ColumnHeadersDefaultCellStyle.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold);

            db_order.Columns["Park_Id"].Visible = false;
            db_order.Columns["C_Id"].ReadOnly = true;
            db_order.Columns["P_ID"].ReadOnly = true;
            db_order.Columns["Park_Date"].ReadOnly = true;
            db_order.Columns["Park_In_Time"].ReadOnly = true;
            db_order.Columns["Park_Out_Time"].ReadOnly = true;

            db_order.Columns[1].HeaderCell.Value = "Customer Id";
            db_order.Columns[2].HeaderCell.Value = "Parking Space Id";
            db_order.Columns[3].HeaderCell.Value = "Pareked Date";
            db_order.Columns[4].HeaderCell.Value = "Arrived Time";
            db_order.Columns[5].HeaderCell.Value = "Dispatch Time";
        }

        public void grid_update()
        {

            cmdBuild = new MySqlCommandBuilder(DataADPT);
            DataADPT.Update(DataTBL);

        }

        private String grid_selectedRow()
        {
            if (db_order.SelectedCells.Count > 0)
            {
                int selectedrowindex = db_order.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = db_order.Rows[selectedrowindex];

                string Park_ID = Convert.ToString(selectedRow.Cells["Park_Id"].Value);

                return Park_ID;
            }

            return null;
        }

        public void cost()
        {
            double total = 0;
            DateTime now_time;

            String Str_Conn = "server=localhost;username=root;password=;database=car;";
            Conn = new MySqlConnection(Str_Conn);
            Cmd = new MySqlCommand("SELECT * FROM park WHERE Park_Id = '"+grid_selectedRow()+"'", Conn);
            Conn.Open();
            read_p = Cmd.ExecuteReader();
            read_p.Read();

            DB Input = new DB();
            String P_area_ID = read_p["P_ID"].ToString();
            String Slected_Cust = read_p["C_ID"].ToString();

            if (read_p["Park_Out_Time"].ToString().Equals("Parked"))
            {
                now_time = DateTime.Parse(current_datetime("time").ToString());

                String Query_Upd_1 = "UPDATE `area` SET `Available`='1' WHERE P_Id = '" + P_area_ID + "'";
                String Query_Upd_2 = "UPDATE `park` SET `Park_Out_Time`='" + now_time.ToLongTimeString() + "' WHERE Park_Id = '" + read_p["Park_Id"].ToString() + "'";

                Input.dbconn();
                Input.Ins_Upd_DB(Query_Upd_1);
                Input.dbclose();

                Input.dbconn();
                Input.Ins_Upd_DB(Query_Upd_2);
                Input.dbclose();
            }
            else
            {
                now_time = DateTime.Parse(read_p["Park_Out_Time"].ToString());
            }

            park_data_fill();

            DateTime arival_time = DateTime.Parse(read_p["Park_In_Time"].ToString());

            TimeSpan duration = (now_time - arival_time);
            double hours = duration.TotalHours;

            if (hours>24)
            {
                total = total + hours * 1000;
            }else if (hours<=24 && hours>10)
            {
                total = total + hours * 500;
            }
            else if (hours <= 10 && hours > 5)
            {
                total = total + hours * 250;
            }
            else if (hours <= 5 && hours > 2)
            {
                total = total + hours * 250;
            }
            else if (hours <= 2)
            {
                total = total + hours * 50;
            }

            fill_combo("area", "P_ID", cmb_Park_Id);
            //           MessageBox.Show("total = "+ total + "\nParking area ID = "+ P_area_ID + "\nSelected Customer ID = "+ Slected_Cust+"\nNow time is "+now_time+"\n Arival Time"+arival_time);

            print_pdf docu = new print_pdf();
            docu.Create_pdf(read_p["Park_In_Time"].ToString(), now_time.ToLongTimeString(),total, Slected_Cust);


        }

        public String current_datetime(String dateortime) {

            DateTime current = DateTime.Now;

            if (dateortime.Equals("date")) {
                return current.ToString("yyyy-MM-dd");
            }
            if (dateortime.Equals("time"))
            {
                return current.ToLongTimeString();
            }
            // Change String to time-----------   DateTime enteredDate = DateTime.Parse(enteredString);
            return null;
        }

        public void fill_combo(String Table,String Field_Name,ComboBox Combo_Name)
        {
            Combo_Name.Items.Clear();
            String Str_Conn = "server=localhost;username=root;password=;database=car;";
            Conn = new MySqlConnection(Str_Conn);
            Cmd = new MySqlCommand("SELECT * FROM "+Table, Conn);
            Conn.Open();
            read = Cmd.ExecuteReader();
            while (read.Read())
            {
                if (Table.Equals("area") && Field_Name.Equals("P_Id"))
                {
                    /*if (Convert.ToInt32(read["Available"].ToString()) != 0)
                    {
                        Combo_Name.Items.Add(read[Field_Name].ToString());
                    }else
                        Combo_Name.Items.Add("All are Booked");*/
                }
                else
                    Combo_Name.Items.Add(read[Field_Name].ToString());
            }
            Conn.Close();
        }

        //.......................finished.................



        public frm_order()
        {
            InitializeComponent();
            park_data_fill();
            fill_combo("customer", "C_Id", cmb_C_Id);
            fill_combo("area", "P_Id", cmb_Park_Id);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_admin_page admin = new frm_admin_page();
            admin.Show();
            this.Close();
        }

        private void frm_order_Load(object sender, EventArgs e)
        {

        }

        private void cmb_C_Id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!cmb_Park_Id.SelectedItem.ToString().Equals("All are Booked"))
            {

                DB Input = new DB();

                String Query_Ins = "INSERT INTO `park`(`C_Id`, `P_Id`, `Park_Date`, `Park_In_Time`, `Park_Out_Time`) VALUES ('" + cmb_C_Id.SelectedItem.ToString() + "','" + cmb_Park_Id.SelectedItem.ToString() + "','" + current_datetime("date") + "','" + current_datetime("time") + "','Parked')";

                String Query_Upd = "UPDATE `area` SET `Available`='0' WHERE P_Id = '" + cmb_Park_Id.SelectedItem.ToString() + "'";

                Input.dbconn();
                Input.Ins_Upd_DB(Query_Ins);
                Input.dbclose();
                Input.dbconn();
                Input.Ins_Upd_DB(Query_Upd);
                Input.dbclose();
            }
            else
                MessageBox.Show("Please wait until a place is Vacant");
            
            park_data_fill();
            fill_combo("area", "P_Id", cmb_Park_Id);

        }

        private void db_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

    /*        if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.db_order.Rows[e.RowIndex];
                txt_Park_Id.Text = row.Cells["Park_Id"].Value.ToString();
                txt_C_ID.Text = row.Cells["C_Id"].Value.ToString();
                txt_P_ID.Text = row.Cells["P_ID"].Value.ToString();
                txt_P_Date.Text = row.Cells["Park_Date"].Value.ToString();
                txt_In_time.Text = row.Cells["Park_In_Time"].Value.ToString();
                txt_Out_time.Text = row.Cells["Park_Out_Time"].Value.ToString();
            }
*/
                lbl_Box.Text = "Selected Customer Id for Billing is \n"+grid_selectedRow();
 //               */
        }

        private void lbl_Box_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cost();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
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

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmb_Park_Id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

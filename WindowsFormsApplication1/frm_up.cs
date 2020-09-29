using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  

namespace WindowsFormsApplication1
{
    public partial class frm_up : Form
    {
        frm_log fl;
        public frm_up()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void lblnme_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           //try  {
                dob.Format = DateTimePickerFormat.Custom;
                dob.CustomFormat = "yyyy-MM-dd";
                DB Insert = new DB();
                Insert.dbconn();
              //  String U_ID = Insert.create_Cust_Id("CUST",4);
	            string Query = "INSERT INTO users(U_Id,U_Name,U_Dob,U_Cont,U_Add,U_Nic,U_Email,U_Pass,U_Type) values('"+text_UId.Text+"','" + txt_name.Text+ "','" +dob.Text+ "','" +txt_mobile.Text+ "','" +txt_add.Text+ "','" +txt_nic.Text+ "','" +txt_mail.Text+ "','" +txt_pass.Text+ "','" + textBoxUType.Text + "')";
                Insert.Ins_Upd_DB(Query);
                MessageBox.Show("Data has Saved");
                Insert.dbclose();
	        /*}  
	        catch (Exception ex)  
	        {   
	            MessageBox.Show(ex.Message);  
	        }  */
	}

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_log f1 = new frm_log();
            f1.Show();
            this.Close();
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            fl = new frm_log();       
            this.Hide();
            fl.Show();          
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

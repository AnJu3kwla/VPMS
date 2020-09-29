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
    public partial class frm_log : Form
    {
        Dashboard db;
        public static string user;
        public static string type;

        MySqlConnection Conn,Conn1;
        MySqlCommand Cmd,Cmd1;
        MySqlDataReader read,isAreaFull;

        public frm_log()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            frm_up f2 = new frm_up();
            f2.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            String Str_Conn = "server=localhost;username=root;password=;database=car;";
            Conn = new MySqlConnection(Str_Conn);
            Conn1 = new MySqlConnection(Str_Conn);
            Cmd = new MySqlCommand("SELECT U_Email,U_Pass,U_Type FROM users", Conn);
            //Cmd1 = new MySqlCommand("SELECT Available FROM area WHERE Available = '1'", Conn1);
            Conn1.Open();
            //isAreaFull = Cmd1.ExecuteReader();
            Conn.Close();
            Conn.Open();
            read = Cmd.ExecuteReader();

            while (read.Read())
            {
                if (read["U_Email"].Equals(txt_mail.Text))
                {
                    if (read["U_Pass"].Equals(txt_pass.Text))
                    {
                       if (read["U_Type"].Equals(comboBoxUType.SelectedItem.ToString()))
                        {
                            /* if (!isAreaFull.Read())
                             {
                                 MessageBox.Show("Sorry All area's are parked");

                             }*/
                            user = txt_mail.Text;
                            type = comboBoxUType.SelectedItem.ToString();
                            //frm_admin_page admin = new frm_admin_page();
                            db = new Dashboard();
                            db.Show();
                            this.Hide();

                        }
                       else
                        {
                            MessageBox.Show("Invalid user type");
                            break;
                        }
                        
                   }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                        break;
                    }
                }
                else
                {
                    //MessageBox.Show("Invalid Username");
                    //break;
                }
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void txt_mail_Enter(object sender, EventArgs e)
        {
            if(txt_mail.Text == "Enter your E-mail")
            {
                txt_mail.Text = "";
                txt_mail.ForeColor = Color.Black;
            }
        }

        private void txt_mail_Leave(object sender, EventArgs e)
        {
            if (txt_mail.Text == "")
            {
                txt_mail.Text = "Enter your E-mail";
                txt_mail.ForeColor = Color.Gray;
            }
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Enter your password")
            {
                txt_pass.Text = "";
                txt_pass.PasswordChar = '*';
                txt_pass.ForeColor = Color.Gray;
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                txt_pass.PasswordChar = '\0';
                txt_pass.Text = "Enter your password";
                txt_pass.ForeColor = Color.Gray;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void login_Enter(object sender, EventArgs e)
        {

        }
    }
}

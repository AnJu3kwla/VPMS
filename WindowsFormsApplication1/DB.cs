using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DB
    {
        MySqlConnection Conn;
        string Str_Conn;
        public void dbconn() {  
            Str_Conn = "server=localhost;username=root;password=;database=car;"; 
            Conn = new MySqlConnection(Str_Conn); 
        }
        public void Ins_Upd_DB(String Query){
            MySqlCommand Command = new MySqlCommand(Query, Conn);
            Conn.Open();
            Command.ExecuteReader();
        }

        public void dbclose()
        {
            Conn.Close();
        }
        public String create_Cust_Id(String st,int start)
        {
            MySqlCommand Command = new MySqlCommand("SELECT * FROM users ORDER BY U_Id DESC LIMIT 1", Conn);
            Conn.Open();
            MySqlDataReader rd;
            rd = Command.ExecuteReader();
            if (rd.Read() == true)
            {
                String ID = rd["U_Id"].ToString();
                int ID_Length = ID.Length;
                String Str_ID = ID.Substring(start, ID_Length - start).ToString();     //Substring(int startIndex,int length); Index of String is starts from Zero.
                int old_ID = Convert.ToInt32(Str_ID);
                dbclose();
                old_ID += 1;
                return st + old_ID;
            }
            else
            {
                dbclose();
                return st + "1";
            }

        }

        public void delete_row(String table,String ID_Field,String ID) {

                MySqlCommand Command = new MySqlCommand("DELETE FROM " + table + " WHERE "+ID_Field+" ='"+ID+"'", Conn);
                Conn.Open();
                Command.ExecuteReader();

        }

        
    }
}

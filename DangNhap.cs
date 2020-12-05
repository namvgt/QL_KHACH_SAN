using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection connect;
        SqlCommand comand;
        string str = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];


        private void Username_Click(object sender, EventArgs e)
        {
            
        }

        private void Password_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Username.Text == "Admin")
            {
                return;
            }
            using (connect = new SqlConnection(str))
            {
                comand = new SqlCommand("select NV.*, TENBP from NHANVIEN NV, BOPHAN BP where NV.MABP = BP.MABP", connect);
                connect.Open();
                SqlDataReader data = comand.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if(Username.Text+"      " == data[0] as string && Password.Text==data[4]as string && data[6].ToString().Trim() == "BP01")
                        {
                            TrangChu f = new TrangChu();
                            f.Tb_MANV = data[0] as string;
                            f.Tb_Hoten= data[1] as string;
                            f.Tb_DCHI = data[2] as string;
                            f.Tb_SDT = data[3] as string;
                            f.Tb_GT = data[5] as string;
                            f.Tb_BP = data[10] as string;
                            string ngsinh = Convert.ToDateTime(data[7]).ToString("dd/MM/yyyy"); 
                            f.Tb_NGSINH =  ngsinh;
                            this.Hide();
                            f.Visible = true;
                            break;
                        }
                    }
                    label3.Visible = true;
                }
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.PasswordChar = (char)0;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.PasswordChar = '*';
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '*')
            {
                Password.PasswordChar = (char)0;
            }
            else Password.PasswordChar = '*';
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "User Name";

            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "User Name")
                Username.Text = "";
        }
    }
}

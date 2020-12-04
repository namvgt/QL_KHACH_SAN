using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Doanhthu : UserControl
    {
        DataTable table;
        Series s;
    public Doanhthu()
        {
            InitializeComponent();
        }

        
        private void load()
        {
            using (SqlConnection connect = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"]))
            {
                connect.Open();
                DateTime time;
                double tt = 0;
                SqlCommand command = new SqlCommand("select NGAYTHANHTOAN, TONGTIEN from HOADON where NGAYTHANHTOAN like '%-" + comboBox1.Text + "-%'", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        time = (DateTime)data[0];
                        tt = (double)data[1];
                        foreach (DataRow r in table.Rows)
                        {
                            if (time.Day.ToString() == r[0].ToString())
                            {
                                r[1] = (double)r[1] + tt;
                            }
                        }
                    }
                }
                
                s = new Series();
        
                s.XValueMember = "Ngày";
                s.YValueMembers = "Doanh thu";

            }
        }
        private void Doanhthu_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart2.Series.Clear();
            table = new DataTable();
            table.Columns.Add("Ngày", typeof(int));
            table.Columns.Add("Doanh thu", typeof(double));
            for (int i = 1; i < 16; i++)
            {
                table.Rows.Add(i, 0);
            }
            load();
            chart1.DataSource = table;
            chart1.Series.Add(s);
            table = new DataTable();
            table.Columns.Add("Ngày", typeof(int));
            table.Columns.Add("Doanh thu", typeof(double));
            for (int i = 16; i < 31; i++)
            {
                table.Rows.Add(i, 0);
            }
            load();
            chart2.DataSource = table;
            chart2.Series.Add(s);
        }
    }
}

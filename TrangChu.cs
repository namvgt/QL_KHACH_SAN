using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TrangChu : Form
    {
        private SqlConnection connect;
        private SqlCommand command;
        private ArrayList phong;
        //private DataTable table;
        private int image = 1;
        private string str = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];
        public TrangChu()
        {

            InitializeComponent();
            phong = new ArrayList();
            phong.Add(p101);
            phong.Add(p102);
            phong.Add(p103);
            phong.Add(p104);
            phong.Add(p105);
            phong.Add(p106);
            phong.Add(p107);
            phong.Add(p108);
            phong.Add(p201);
            phong.Add(p202);
            phong.Add(p203);
            phong.Add(p204);
            phong.Add(p205);
            phong.Add(p206);
            phong.Add(p207);
            phong.Add(p208);
            phong.Add(p301);
            phong.Add(p302);
            phong.Add(p303);
            phong.Add(p304);
            phong.Add(p305);
            phong.Add(p306);
            phong.Add(p307);
            phong.Add(p308);
            phong.Add(p401);
            phong.Add(p402);
            phong.Add(p403);
            phong.Add(p404);
            phong.Add(p405);
            phong.Add(p406);
            phong.Add(p407);
            phong.Add(p408);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_ThongTinPhong(Button map)
        {
            if (label4.Location == new Point(1, pictureBox4.Location.Y))
            {
                pn_thongtinphong.Visible = true;
                lb_sophong.Text = map.Text;
                using (connect = new SqlConnection(str))
                {
                    connect.Open();
                    command = new SqlCommand("select * from XemCTPhong('" + map.Text + "')", connect);
                    SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                    if (data.HasRows)
                    {
                        while (data.Read())
                        {
                            if (data[9].ToString().Trim() != "")
                            {
                                lb_tt.Text = data[0].ToString();
                                lb_lp.Text = data[1].ToString();
                                lb_dongia.Text = (Convert.ToDouble(data[2])).ToString();
                                lb_thietbi.Text = data[3].ToString();
                                lb_mapdp.Text = data[4].ToString();
                                lb_tenkh.Text = data[5].ToString();
                                lb_quoctich.Text = data[6].ToString();
                                lb_ngaydat.Text = string.Format("{0:dd/MM/yyyy}", (DateTime)data[7]);
                                lb_sdt.Text = data[8].ToString();
                                lb_cmnd.Text = data[9].ToString();
                            }
                            else
                            {
                                lb_tt.Text = data[0].ToString();
                                lb_lp.Text = data[1].ToString();
                                lb_dongia.Text = (Convert.ToDouble(data[2])).ToString();
                                lb_thietbi.Text = data[3].ToString();
                            }
                        }
                    }
                }
                pn_thongtinphong.Visible = true;
                pn_thongtinphong.Size = new Size(504, 466);
                pn_thongtinphong.Location = new Point(288, 56);
            }
            else
            {
                if (panel5.Visible == false || panel5.Location != new Point(map.Location.X + 30, map.Location.Y + 10))
                {
                    panel5.Visible = true;
                    panel5.Location = new Point(map.Location.X + 30, map.Location.Y + 10);
                }
                else
                    panel5.Visible = false;
            }
        }
        private void button41_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(button41);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p308);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            load_ThongTinPhong(p307);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p407);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p408);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p305);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p107);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p108);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p207);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p208);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p105);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p303);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p304);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p403);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p404);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p306);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p103);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p104);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p203);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p204);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p106);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p101);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p102);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p201);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p202);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p205);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p301);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p302);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p401);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p402);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p405);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p206);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            load_ThongTinPhong(p406);
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (Panel2.Size.Width == 49)
            {
                panel4.Location = new Point(199, 34);
                Panel2.Size = new Size(199, 605);
            }
            else
            {
                panel4.Location = new Point(49, 34);
                Panel2.Size = new Size(49, 605);
            }

        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            label4.Location = new Point(1, pictureBox4.Location.Y);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            panel_datphong.Visible = false;

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "" ||
            textBox1.Text == "" ||
            comboBox2.Text == "" ||
            textBox8.Text == "" ||
            comboBox3.Text == "" ||
            label117.Text == "" ||
            textBox7.Text == "")
            {
                MessageBox.Show("Thông tin chưa đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (Button item in phong)
            {
                if (panel5.Location == new Point(item.Location.X + 30, item.Location.Y + 10))
                {
                    item.BackColor = Color.Brown;
                    item.AllowDrop = true;
                }
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }
            panel_datphong.Visible = false;
            string madt = "";
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select MADOITUONG from DOITUONG where LOAIDOITUONG = '" + label124.Text + "'", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        madt = data[0] as string;
                    }
                }
            }
            bool k = false;
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select MAKH from KHACHHANG where MAKH = '" + label117.Text + "'", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    k = true;
                }
            }
            if (!k)
            {
                using (connect = new SqlConnection(str))
                {
                    connect.Open();
                    command = new SqlCommand("exec themKH'" + label117.Text + "',N'" + textBox2.Text + "'" +
                    ",N'" + textBox1.Text + "',N'" + comboBox2.Text + "','" + textBox8.Text + "'" +
                    ",'" + textBox7.Text + "',N'" + comboBox3.Text + "','" + madt + "','0'", connect);
                    command.ExecuteNonQuery();
                }
            }
            string map = "";
            foreach (Button bt in phong)
            {
                if (panel5.Location == new Point(bt.Location.X + 30, bt.Location.Y + 10))
                {
                    map = bt.Text;
                }
            }
            string mapd = "";
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select count(*) from PHIEUDATPHONG", connect);
                var n = (int)command.ExecuteScalar();
                n += 1;
                if (n < 10)
                {
                    mapd = "PD00" + n.ToString();
                }
                else
                {
                    if (n >= 10 && n < 100)
                    {
                        mapd = "PD0" + n.ToString();
                    }
                    else mapd = "PD" + n.ToString();
                }

            }
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("exec ThemPDP'" + mapd + "','" + textBox5.Text + "'" +
                    ",'" + label117.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + label122.Text + "'", connect);
                command.ExecuteNonQuery();
                command = new SqlCommand("exec Them_CTPDP'" + mapd + "','" + map + "',null,null", connect);
                command.ExecuteNonQuery();
                command = new SqlCommand("update PHONG set TRANGTHAI = N'Đã Thuê' where MAPHONG = '" + map + "'", connect);
                command.ExecuteNonQuery();
            }
            
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
               // TODO: This line of code loads data into the 'dataSet1.DICHVU' table. You can move, or remove it, as needed.
               this.dICHVUTableAdapter1.Fill(this.dataSet1.DICHVU);
               // TODO: This line of code loads data into the 'dataSet1.DICHVU' table. You can move, or remove it, as needed.
               this.dICHVUTableAdapter1.Fill(this.dataSet1.DICHVU);
               // TODO: This line of code loads data into the 'dataset2.DICHVU' table. You can move, or remove it, as needed.
               //this.dICHVUTableAdapter.Fill(this.dataset2.DICHVU);
               // TODO: This line of code loads data into the 'dataSet1.DICHVU' table. You can move, or remove it, as needed.
               // TODO: This line of code loads data into the 'dataSet1.PHIEUDATPHONG' table. You can move, or remove it, as needed.
               int n = 1;
            panel3.Visible = true;
            using (connect = new SqlConnection(str))
            {
                command = new SqlCommand("select * from PHONG", connect);
                connect.Open();
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if (data[2] as string == "Đã Thuê")
                        {
                            switch (n)
                            {
                                case 1:
                                    p101.BackColor = Color.Brown;
                                    p101.AllowDrop = true;
                                    break;
                                case 2:
                                    p102.BackColor = Color.Brown;
                                    p102.AllowDrop = true;
                                    break;
                                case 3:
                                    p103.BackColor = Color.Brown;
                                    p103.AllowDrop = true;
                                    break;
                                case 4:
                                    p104.BackColor = Color.Brown;
                                    p104.AllowDrop = true;
                                    break;
                                case 5:
                                    p105.BackColor = Color.Brown;
                                    p105.AllowDrop = true;
                                    break;
                                case 6:
                                    p106.BackColor = Color.Brown;
                                    p106.AllowDrop = true;
                                    break;
                                case 7:
                                    p107.BackColor = Color.Brown;
                                    p107.AllowDrop = true;
                                    break;
                                case 8:
                                    p108.BackColor = Color.Brown;
                                    p108.AllowDrop = true;
                                    break;
                                case 9:
                                    p201.BackColor = Color.Brown;
                                    p201.AllowDrop = true;
                                    break;
                                case 10:
                                    p202.BackColor = Color.Brown;
                                    p202.AllowDrop = true;
                                    break;
                                case 11:
                                    p203.BackColor = Color.Brown;
                                    p203.AllowDrop = true;
                                    break;
                                case 12:
                                    p204.BackColor = Color.Brown;
                                    p204.AllowDrop = true;
                                    break;
                                case 13:
                                    p205.BackColor = Color.Brown;
                                    p205.AllowDrop = true;
                                    break;
                                case 14:
                                    p206.BackColor = Color.Brown;
                                    p206.AllowDrop = true;
                                    break;
                                case 15:
                                    p207.BackColor = Color.Brown;
                                    p207.AllowDrop = true;
                                    break;
                                case 16:
                                    p208.BackColor = Color.Brown;
                                    p208.AllowDrop = true;
                                    break;
                                case 17:
                                    p301.BackColor = Color.Brown;
                                    p301.AllowDrop = true;
                                    break;
                                case 18:
                                    p302.BackColor = Color.Brown;
                                    p302.AllowDrop = true;
                                    break;
                                case 19:
                                    p303.BackColor = Color.Brown;
                                    p303.AllowDrop = true;
                                    break;
                                case 20:
                                    p304.BackColor = Color.Brown;
                                    p304.AllowDrop = true;
                                    break;
                                case 21:
                                    p305.BackColor = Color.Brown;
                                    p305.AllowDrop = true;
                                    break;
                                case 22:
                                    p306.BackColor = Color.Brown;
                                    p306.AllowDrop = true;
                                    break;
                                case 23:
                                    p307.BackColor = Color.Brown; p307.AllowDrop = true;
                                    break;
                                case 24:
                                    p308.BackColor = Color.Brown; p308.AllowDrop = true;
                                    break;
                                case 25:
                                    p401.BackColor = Color.Brown; p401.AllowDrop = true;
                                    break;
                                case 26:
                                    p402.BackColor = Color.Brown; p402.AllowDrop = true;
                                    break;
                                case 27:
                                    p403.BackColor = Color.Brown; p403.AllowDrop = true;
                                    break;
                                case 28:
                                    p404.BackColor = Color.Brown; p404.AllowDrop = true;
                                    break;
                                case 29:
                                    p405.BackColor = Color.Brown; p405.AllowDrop = true;
                                    break;
                                case 30:
                                    p406.BackColor = Color.Brown; p406.AllowDrop = true;
                                    break;
                                case 31:
                                    p407.BackColor = Color.Brown; p407.AllowDrop = true;
                                    break;
                                case 32:
                                    p408.BackColor = Color.Brown; p408.AllowDrop = true;
                                    break;
                                default:
                                    break;
                            }
                        }
                        n++;
                    }
                }

            }
            panel3.Parent = pictureBox13;

        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(str))
            {
                command = new SqlCommand("select KH.*, LOAIDOITUONG from KHACHHANG KH," +
                    " DOITUONG DT where KH.MADOITUONG = DT.MADOITUONG", connect);
                connect.Open();
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if (textBox7.Text + "      " == data[5].ToString())
                        {
                            textBox2.Text = data[1] as string;
                            textBox1.Text = data[2] as string;
                            comboBox2.Text = data[3] as string;
                            textBox8.Text = data[4] as string;
                            comboBox3.Text = data[6] as string;
                            label117.Text = data[0] as string;
                            label124.Text = data[8] as string;
                            break;
                        }
                    }
                }
            }
        }

        private void OK_datphong_MouseMove(object sender, MouseEventArgs e)
        {
            OK_datphong.BackColor = Color.LightSkyBlue;
        }

        private void OK_datphong_MouseLeave(object sender, EventArgs e)
        {
            OK_datphong.BackColor = Color.White;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
        }

        private void button9_MouseMove(object sender, MouseEventArgs e)
        {
            button9.BackColor = Color.LightSkyBlue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pn_ThanhToan.Visible = false;
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            
            int so = 0;
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select count(MAHD) from HOADON", connect);
                so = (int)command.ExecuteScalar();
            }
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("exec Tao_Hoadon " + so + 1 + ", null,'" + DateTimeOffset.Now.Date.ToString("yyyy-MM-dd") + "','" + textBox4.Text + "'," +
                    "'" + textBox10.Text + "','" + textBox13.Text + "','" + textBox12.Text + "','" + textBox20.Text + "','" + tb_MANV.Text + "' ", connect);
                command.ExecuteNonQuery();
            }
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select MAPHONG from PHONG where TRANGTHAI = N'Chưa Thuê' ", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        foreach (Button item in phong)
                        {
                            if (item.Text + "      " == data[0] as string)
                            {
                                item.BackColor = Color.Green;
                                item.AllowDrop = false;
                                break;
                            }
                        }
                    }
                }
            }
            pn_ThanhToan.Visible = false;
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            foreach (Button item in phong)
            {
                if (panel5.Location == new Point(item.Location.X + 30, item.Location.Y + 10))
                {
                    if (item.BackColor == Color.Brown)
                    {
                        MessageBox.Show("Phòng này đã được thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            panel5.Visible = false;
            panel_datphong.Dock = DockStyle.Fill;
            panel_datphong.Visible = true;
            textBox7.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
            comboBox2.Text = "";
            textBox8.Text = "";
            comboBox3.Text = "";
            label122.Text = tb_MANV.Text;
            dateTimePicker1.MinDate = DateTime.UtcNow;
            dateTimePicker2.MinDate = DateTime.UtcNow;
            using (connect = new SqlConnection(str))
            {
                command = new SqlCommand("select count(*) from KHACHHANG", connect);
                connect.Open();
                var n = (int)command.ExecuteScalar();
                n += 1;
                label117.Text = "KH" + n.ToString();
            }
            label124.Text = "NORMAL";

        }

        private void button41_Click_2(object sender, EventArgs e)
        {
            foreach (Button item in phong)
            {
                if (panel5.Location == new Point(item.Location.X + 30, item.Location.Y + 10))
                {
                    if (item.BackColor == Color.Green)
                    {
                        MessageBox.Show("Phòng này chưa được thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        label127.Text = item.Text;
                        break;
                    }
                }
            }
            while (dataGridView2.Rows.Count != 0)
            {
                dataGridView2.Rows.RemoveAt(0);
            }
            panel5.Visible = false;
            pn_DichVu.Visible = true;
            pn_DichVu.Dock = DockStyle.Fill;
            comboBox5.Text = "";
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            foreach (Button item in phong)
            {
                if (panel5.Location == new Point(item.Location.X + 30, item.Location.Y + 10))
                {
                    if (item.BackColor == Color.Green)
                    {
                        MessageBox.Show("Phòng này chưa được thuê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            panel5.Visible = false;
            pn_ThanhToan.Visible = true;
            pn_ThanhToan.Dock = DockStyle.Fill;
            string map = "";
            foreach (Button item in phong)
            {
                if (panel5.Location == new Point(item.Location.X + 30, item.Location.Y + 10))
                {
                    textBox17.Text = item.Text;
                    map = item.Text;
                    break;
                }
            }
            textBox14.Text = DateTimeOffset.Now.Date.ToString("dd/MM/yyyy");
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select * from tt_khachle('" + map + "')", connect);
                SqlDataReader data1 = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data1.HasRows)
                {
                    while (data1.Read())
                    {
                        textBox18.Text = data1[0].ToString();
                        textBox13.Text = data1[1].ToString();
                        textBox10.Text = data1[2].ToString();
                        textBox4.Text = data1[3].ToString();
                        textBox12.Text = ((double)data1[0] + (double)data1[1]).ToString();
                        textBox9.Text = ((double)data1[0] + (double)data1[1] - (double)data1[2] - (double)data1[3]).ToString();
                    }
                }
            }
            using (connect = new SqlConnection(str))
            {

                connect.Open();
                command = new SqlCommand("select KH.*, HESOGIAMGIA, NGAYTRA, TIENTRATRUOC, NGAYDAT, MANV, MAPSDDV " +
                                           " from KHACHHANG KH, PHIEUDATPHONG PD, CT_PHIEUDATPHONG ct, DOITUONG dt " +
                                           " where ct.MAPHONG = '" + map + "' and NGAYTRA is null and ct.MAPDP = PD.MAPDP " +
                                           " and PD.MAKH = KH.MAKH  and KH.MADOITUONG = dt.MADOITUONG", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        textBox20.Text = data[0] as string;
                        textBox4.Text = ((double)data[11]).ToString();
                        textBox16.Text = ((DateTime)data[12]).ToString("dd/MM/yyyy");
                        break;
                    }
                }
            }
            DataTable table = new DataTable();
            table.Columns.Add("Tên dịch vụ", typeof(string));
            table.Columns.Add("Ngày đặt", typeof(string));
            table.Columns.Add("Số lượng", typeof(int));
            table.Columns.Add("Đơn giá", typeof(double));
            table.Columns.Add("Thành tiền", typeof(double));
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select TENDV, DONGIA, SOLUONG, SOTIENTRATRUOC, NGAYSUDUNGDV " +
                                          "  from CT_PHIEUDATPHONG pdp, CT_PHIEUSUDUNGDICHVU ctdv, DICHVU dv, PHIEUSUDUNGDICHVU pdv " +
                                         " where pdv.MAPSDDV = pdp.MAPSDDV and pdv.MAPSDDV = ctdv.MAPSDDV and ctdv.MADV = dv.MADV " +
                                        " and pdp.MAPHONG = '" + textBox17.Text + "      " + "' and pdp.NGAYTRA is null ", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        table.Rows.Add(data[0] as string, ((DateTime)data[4]).ToString("dd/MM/yyyy")
                            , (int)data[2], (double)data[1], ((double)data[1] * (int)data[2]));
                    }
                }
            }
            label13.Text = textBox13.Text;
            dataGridView3.DataSource = table;
        }

        private void label89_Click(object sender, EventArgs e)
        {
            Bitmap bt;
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bt = new Bitmap(open.FileName);
                circlePictureBox1.Image = bt;
            }
        }

        private void label83_Click(object sender, EventArgs e)
        {
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            pn_DoiMK.Visible = true;
            pn_DoiMK.Location = new Point(351, 57);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            pn_DichVu.Visible = false;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dịch vụ nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mapd = "";
            string mapdp = "";
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select count(*) from PHIEUSUDUNGDICHVU", connect);
                var n = (int)command.ExecuteScalar();
                n += 1;
                if (n < 10)
                {
                    mapd = "P00" + n.ToString();

                }
                else
                {
                    if (n < 100)
                    {
                        mapd = "P0" + n.ToString();
                    }
                    else mapd = "P" + n.ToString();
                }
                command = new SqlCommand("select top 1 MAPDP from CT_PHIEUDATPHONG where MAPHONG = '" + label127.Text + "' and NGAYTRA is null", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        mapdp = data[0].ToString();
                    }
                }
            }

            string date = DateTimeOffset.Now.DateTime.ToString("yyyy-MM-dd");
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("insert PHIEUSUDUNGDICHVU values('" + mapd + "','" + textBox3.Text + "','" + tb_MANV.Text + "','" + date + "')", connect);
                command.ExecuteNonQuery();
                command = new SqlCommand("insert CT_PHIEUDATPHONG values('" + mapdp + "', '" + label127.Text + "',null,'" + mapd + "')", connect);
                command.ExecuteNonQuery();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells[1].Value.ToString() != "0")
                    {
                        command = new SqlCommand("insert CT_PHIEUSUDUNGDICHVU values('" + mapd + "','" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "','" + dataGridView2.Rows[i].Cells[2].Value.ToString() + "')", connect);
                        command.ExecuteNonQuery();
                    }
                }
            }
            pn_DichVu.Visible = false;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            pn_HoSo.Visible = false;
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            if (Panel2.Size.Width == 49)
            {

                Panel2.Size = new Size(190, 603);
            }
            else Panel2.Size = new Size(49, 603);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label4.Location = new Point(1, pictureBox4.Location.Y);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            label4.Location = new Point(1, pictureBox5.Location.Y);
            pn_HoSo.Visible = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            pictureBox6_Click_1(sender, e);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label4.Location = new Point(1, pictureBox1.Location.Y);
            panel3.Visible = true;
            pn_HoSo.Visible = true;
            pn_HoSo.Dock = DockStyle.Fill;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            this.Dispose();
            DangNhap lg = new DangNhap();
            lg.Visible = true;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            label4.Location = new Point(1, pictureBox4.Location.Y);
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            label4.Location = new Point(1, pictureBox5.Location.Y);
            pn_HoSo.Visible = false;
            foreach (Button item in phong)
            {
                if (item.Image == global::WindowsFormsApp1.Properties.Resources.Red1)
                {
                    item.Enabled = false;
                }
            }
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            //label4.Location = new Point(1, pictureBox6.Location.Y);
            if (pn_tt.Visible == true) pn_tt.Visible = false;
            pn_Khachdoan.Dock = DockStyle.Fill;
            pn_Khachdoan.Visible = true;
            KhachDoan();
            pn_HoSo.Visible = false;


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            label4.Location = new Point(1, pictureBox1.Location.Y);
            panel3.Visible = true;
            pn_HoSo.Visible = true;
            pn_HoSo.Dock = DockStyle.Fill;
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            label4.Location = new Point(1, pictureBox7.Location.Y);
            this.Dispose();
            DangNhap lg = new DangNhap();
            lg.Visible = true;
        }

        private void button40_MouseMove(object sender, MouseEventArgs e)
        {
            button40.BackColor = Color.CornflowerBlue;
        }

        private void button40_MouseLeave(object sender, EventArgs e)
        {
            button40.BackColor = Color.White;
        }

        private void button41_MouseMove(object sender, MouseEventArgs e)
        {
            button41.BackColor = Color.CornflowerBlue;
        }

        private void button41_MouseLeave(object sender, EventArgs e)
        {
            button41.BackColor = Color.White;
        }

        private void button42_MouseLeave(object sender, EventArgs e)
        {
            button42.BackColor = Color.White;
        }

        private void button42_MouseMove(object sender, MouseEventArgs e)
        {
            button42.BackColor = Color.CornflowerBlue;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            pn_DoiMK.Visible = false;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            bool check = false;
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select MANV, MK from NHANVIEN", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        if (data[0] as string == tb_MANV.Text && data[1] as string == textBox25.Text)
                        {
                            check = true;
                            break;
                        }
                    }
                }
            }
            if (!check)
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox24.Text != textBox23.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("update NHANVIEN set MK = '" + textBox23.Text + "' where MANV = '" + tb_MANV.Text + "'", connect);
                command.ExecuteNonQuery();
            }
            pn_HoSo.Visible = false;
        }

        private void textBox25_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (textBox25.PasswordChar == '*')
            {
                textBox25.PasswordChar = (char)0;
            }
            else textBox25.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox24.PasswordChar == '*')
            {
                textBox24.PasswordChar = (char)0;
            }
            else textBox24.PasswordChar = '*';
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox23.PasswordChar == '*')
            {
                textBox23.PasswordChar = (char)0;
            }
            else textBox23.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pn_ThanhToan.Visible = false;

            pn_chitiet.Visible = true;
            pn_chitiet.Dock = DockStyle.Fill;
        }

        private void pn_DichVu_Paint(object sender, PaintEventArgs e)
        {

            label15.Text = DateTimeOffset.Now.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows.Count != 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells[0].Value.ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {

                        return;
                    }
                }
            }

            dataGridView2.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), 1.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void pn_ThanhToan_Paint(object sender, PaintEventArgs e)
        {
            textBox19.Text = tb_Hoten.Text;
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            pn_ThanhToan.Visible = true;
            pn_chitiet.Visible = false;
        }

        private void p101_MouseMove(object sender, MouseEventArgs e)
        {

        }



        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (Panel2.Size.Width == 49)
            {
                Panel2.Size = new Size(190, 603);
            }
            label4.Location = new Point(1, pictureBox11.Location.Y);
            if (button6.Visible == true)
            {
                button6.Visible = button30.Visible = pictureBox12.Visible = pictureBox6.Visible = false;
            }
            else button6.Visible = button30.Visible = pictureBox12.Visible = pictureBox6.Visible = true;
        }
        private void KhachDoan()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Số phòng", typeof(string));
            table.Columns.Add("Loại phòng", typeof(string));
            table.Columns.Add("Trạng thái", typeof(string));
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select * from PhongChuaThue()", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        table.Rows.Add(data[0] as string, data[2] as string, data[1] as string);
                    }
                }
            }
            dataGridView4.DataSource = table;
            label73.Text = tb_Hoten.Text;
            int n = 0;
            List<string> item = new List<string>();
            AutoCompleteStringCollection ite = new AutoCompleteStringCollection();
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select count(*) from KHACHHANG", connect);
                n = (int)command.ExecuteScalar();
                n += 1;

                command = new SqlCommand("select CMND from KHACHHANG", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        item.Add(data[0] as string);
                        ite.Add(data[0] as string);
                    }
                }
            }
            cbCMND.DataSource = item;
            cbCMND.AutoCompleteCustomSource = ite;
            textBox15.Text = textBox27.Text = textBox30.Text = comboBox4.Text = textBox31.Text = cbCMND.Text = "";
            lbMAKH.Text = "KH" + n.ToString();
        }
        private void button27_Click_1(object sender, EventArgs e)
        {
            if (Panel2.Size.Width == 49)
            {
                Panel2.Size = new Size(190, 603);
            }
            label4.Location = new Point(1, pictureBox11.Location.Y);
            if (button6.Visible == true)
            {
                button6.Visible = button30.Visible = pictureBox12.Visible = pictureBox6.Visible = false;
            }
            else button6.Visible = button30.Visible = pictureBox12.Visible = pictureBox6.Visible = true;
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Rows.Count != 0)
            {
                for (int i = 0; i < dataGridView5.Rows.Count; i++)
                {
                    if (dataGridView5.Rows[i].Cells[0].Value.ToString() == dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        return;
                    }
                }
            }
            dataGridView5.Rows.Add(dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString());
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 2)
            {
                dataGridView5.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            pn_Khachdoan.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 3)
            {
                dataGridView2.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            if (cbCMND.Text == "")
            {
                MessageBox.Show("Không được bỏ trống thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridView5.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có phòng nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mapd = "";
            bool k = false;
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select MAKH from KHACHHANG where MAKH = '" + lbMAKH.Text + "'", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    k = true;
                }
            }

            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select count(*) from PHIEUDATPHONG", connect);
                var n = (int)command.ExecuteScalar();
                n += 1;
                if (n < 10)
                {
                    mapd = "PD00" + n.ToString();
                }
                else
                {
                    if (n < 100)
                    {
                        mapd = "PD0" + n.ToString();
                    }
                    else mapd = "PD" + n.ToString();
                }
                if (!k)
                {
                    command = new SqlCommand("EXEC ThemMoiKH '" + lbMAKH.Text + "',N'" + textBox15.Text + "',N'" + textBox27.Text + "', " +
                    "N'" + textBox30.Text + "', '" + textBox31.Text + "', '" + cbCMND.Text + "', N'" + comboBox4.Text + "','DT04','0'", connect);
                    command.ExecuteNonQuery();
                }
                string date = DateTimeOffset.Now.Date.ToString("yyyy-MM-dd");
                command = new SqlCommand("EXEC ThemPDP '" + mapd + "','" + textBox22.Text + "', " +
                    "'" + lbMAKH.Text + "','" + date + "','" + tb_MANV.Text + "'", connect);
                command.ExecuteNonQuery();
                for (int i = 0; i < dataGridView5.Rows.Count; i++)
                {
                    command = new SqlCommand("EXEC Them_CTPDP'" + mapd + "','" + dataGridView5.Rows[i].Cells[0].Value.ToString() + "',null,null", connect);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("update PHONG set TRANGTHAI = N'Đã Thuê' where MAPHONG = '" + dataGridView5.Rows[i].Cells[0].Value.ToString() + "'", connect);
                    command.ExecuteNonQuery();
                    foreach (Button item in phong)
                    {
                        if (item.Text + "      " == dataGridView5.Rows[i].Cells[0].Value.ToString())
                        {
                            item.BackColor = Color.Brown;
                            break;
                        }
                    }
                }
            }
            pn_Khachdoan.Visible = false;
        }

        private void pn_Khachdoan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCMND_SelectedValueChanged(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select * from KHACHHANG where CMND = '" + cbCMND.Text + "'", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        textBox15.Text = data[1] as string;
                        lbMAKH.Text = data[0] as string;
                        textBox27.Text = data[2] as string;
                        textBox30.Text = data[3] as string;
                        textBox31.Text = data[4] as string;
                        comboBox4.Text = data[6] as string;
                    }
                }
            }
        }

        private void cbCMND_Leave(object sender, EventArgs e)
        {
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("select * from KHACHHANG where CMND = '" + cbCMND.Text + "'", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        textBox15.Text = data[1] as string;
                        lbMAKH.Text = data[0] as string;
                        textBox27.Text = data[2] as string;
                        textBox30.Text = data[3] as string;
                        textBox31.Text = data[4] as string;
                        comboBox4.Text = data[6] as string;
                    }
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            if (pn_Khachdoan.Visible == true)
            {
                pn_Khachdoan.Visible = false;
            }
            pn_tt.Visible = true;
            pn_tt.Dock = DockStyle.Fill;
            DataTable table = new DataTable();
            table.Columns.Add("Mã KH", typeof(string));
            table.Columns.Add("Tên trưởng đoàn", typeof(string));
            table.Columns.Add("CMND", typeof(string));
            table.Columns.Add("Danh sách phòng", typeof(string));
            table.Columns.Add("MAPDP", typeof(string));
            table.Columns.Add("Trả trước", typeof(double));
            table.Columns.Add("Giảm giá", typeof(double));
            table.Columns.Add("ngày đến", typeof(string));
            using (connect = new SqlConnection(str))
            {
                connect.Open();
                command = new SqlCommand("EXEC KHChuaTraPhong", connect);
                SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                if (data.HasRows)
                {
                    string cmnd = "";
                    while (data.Read())
                    {
                        if (data[1] as string != cmnd)
                        {
                            table.Rows.Add(data[3] as string, data[0] as string, data[1] as string, data[2] as string, data[4] as string,
                                (double)data[5], (double)data[7], ((DateTime)data[6]).ToString("dd/MM/yyyy"));
                            cmnd = data[1] as string;
                        }
                        else
                        {
                            string s1 = ", " + data[2] as string;
                            string s2 = table.Rows[table.Rows.Count - 1][3].ToString();
                            table.Rows[table.Rows.Count - 1][3] = s2 + s1;
                        }
                    }
                }
            }

            dataGridView6.DataSource = table;
            dataGridView6.Columns[1].Visible = false;
            dataGridView6.Columns[5].Visible = false;
            dataGridView6.Columns[6].Visible = false;
            dataGridView6.Columns[7].Visible = false;
            dataGridView6.Columns[8].Visible = false;

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                pn_tt.Dock = DockStyle.None;
                pn_ThanhToan.Dock = DockStyle.Fill;
                pn_ThanhToan.Visible = true;
                textBox20.Text = dataGridView6.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox17.Text = dataGridView6.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox14.Text = DateTimeOffset.Now.Date.ToString("dd/MM/yyyy");
                textBox16.Text = dataGridView6.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBox4.Text = dataGridView6.Rows[e.RowIndex].Cells[6].Value.ToString();
                using (connect = new SqlConnection(str))
                {
                    connect.Open();
                    command = new SqlCommand("select * from tt_khachdoan('" + dataGridView6.Rows[e.RowIndex].Cells[3].Value.ToString().Trim() + "')", connect);
                    SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                    if (data.HasRows)
                    {
                        while (data.Read())
                        {
                            textBox18.Text = data[0].ToString();
                            textBox13.Text = data[1].ToString();
                            textBox10.Text = data[2].ToString();
                            textBox4.Text = data[3].ToString();
                            textBox12.Text = ((double)data[0] + (double)data[1]).ToString();
                        }
                    }
                }
                DataTable table = new DataTable();
                table.Columns.Add("Tên dịch vụ", typeof(string));
                table.Columns.Add("Ngày đặt", typeof(string));
                table.Columns.Add("Số lượng", typeof(int));
                table.Columns.Add("Đơn giá", typeof(double));
                table.Columns.Add("Thành tiền", typeof(double));
                using (connect = new SqlConnection(str))
                {
                    connect.Open();
                    command = new SqlCommand("EXEC XemDVTheoPhong'" + dataGridView6.Rows[e.RowIndex].Cells[5].Value.ToString().Trim() + "' ", connect);
                    SqlDataReader data = command.ExecuteReader(CommandBehavior.CloseConnection);
                    if (data.HasRows)
                    {
                        while (data.Read())
                        {
                            table.Rows.Add(data[0] as string, ((DateTime)data[4]).ToString("dd/MM/yyyy")
                                , (int)data[2], (double)data[1], ((double)data[1] * (int)data[2]));
                        }
                    }
                }
                label13.Text = textBox13.Text;
                dataGridView3.DataSource = table;
            }
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            pn_tt.Dock = DockStyle.None;
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            pictureBox12_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (image == 6)
            {
                image = 1;
            }
            pictureBox13.ImageLocation = string.Format(@"Images\{0}.jpg", image);
            image++;
        }

        private void TrangChu_Leave(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            pn_thongtinphong.Visible = false;
            lb_mapdp.Text = "";
            lb_tenkh.Text = "";
            lb_sdt.Text = "";
            lb_quoctich.Text = "";
            lb_ngaydat.Text = "";
            lb_cmnd.Text = "";
        }

        private void pn_thongtinphong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

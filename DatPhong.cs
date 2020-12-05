using System;
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
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = "Data Source=SCORPION;Initial Catalog=QuanLyKhachSan_SQL6;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand command;
        SqlDataReader docdulieu;
        int i = 0;

        private void btn_datphong_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();

            sql = "update Phong set trangthai = N'Đã thuê' where MAPHONG = '" + tb_ma.Text + "'";
            command = new SqlCommand(sql, ketnoi);
            command.ExecuteNonQuery();
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_loaiphong.Text = "";
            tb_trangbi.Text = "";
            tb_dongia.Text = "";
            tb_phutrach.Text = "";
            tb_trangthai.Text = "";
            HienThiDSChuaThue();
        }

        public void HienThiDSChuaThue()
        {
            lv_dsdathue.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            sql = "select p.MAPHONG,p.TENPHONG,lp.TENLP,lp.TRANGBI,lp.DONGIA,p.MABP,p.TRANGTHAI from PHONG p, LOAIPHONG lp " +
                  "where p.TRANGTHAI = N'Chưa thuê' and p.MALP = lp.MALP";
            command = new SqlCommand(sql, ketnoi);
            docdulieu = command.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                lv_dsdathue.Items.Add(docdulieu[0].ToString());
                lv_dsdathue.Items[i].SubItems.Add(docdulieu[1].ToString());
                lv_dsdathue.Items[i].SubItems.Add(docdulieu[2].ToString());
                lv_dsdathue.Items[i].SubItems.Add(docdulieu[3].ToString());
                lv_dsdathue.Items[i].SubItems.Add(docdulieu[4].ToString());
                lv_dsdathue.Items[i].SubItems.Add(docdulieu[5].ToString());
                lv_dsdathue.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grbx_dschuathue.Visible = true;
            HienThiDSChuaThue();
        }

        private void lv_dsdathue_Click(object sender, EventArgs e)
        {
            tb_ma.Text = lv_dsdathue.SelectedItems[0].SubItems[0].Text;
            tb_ten.Text = lv_dsdathue.SelectedItems[0].SubItems[1].Text;
            tb_loaiphong.Text = lv_dsdathue.SelectedItems[0].SubItems[2].Text;
            tb_trangbi.Text = lv_dsdathue.SelectedItems[0].SubItems[3].Text;
            tb_dongia.Text = lv_dsdathue.SelectedItems[0].SubItems[4].Text;
            tb_phutrach.Text = lv_dsdathue.SelectedItems[0].SubItems[5].Text;
            tb_trangthai.Text = lv_dsdathue.SelectedItems[0].SubItems[6].Text;
        }
    }
}

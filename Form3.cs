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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlykhachsan_btl.PHONG' table. You can move, or remove it, as needed.
            Hienthi_dsChuathue();
            Hienthi_dsDathue();
        }

        private void btnExit_form3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelQuanly_phong.Visible = true;
        }

        public void Hienthi_dsChuathue()
        {
            lstv_dsChuathue.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            sql = "select p.MAPHONG,p.TENPHONG,lp.TENLP,lp.TRANGBI,lp.DONGIA,p.MABP,p.TRANGTHAI from PHONG p, LOAIPHONG lp "+
                  "where p.TRANGTHAI = N'Chưa thuê' and p.MALP = lp.MALP";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while(docdulieu.Read())
            {

                lstv_dsChuathue.Items.Add(docdulieu[0].ToString());
                lstv_dsChuathue.Items[i].SubItems.Add(docdulieu[1].ToString());
                lstv_dsChuathue.Items[i].SubItems.Add(docdulieu[2].ToString());
                lstv_dsChuathue.Items[i].SubItems.Add(docdulieu[3].ToString());
                lstv_dsChuathue.Items[i].SubItems.Add(docdulieu[4].ToString());
                lstv_dsChuathue.Items[i].SubItems.Add(docdulieu[5].ToString());
                lstv_dsChuathue.Items[i].SubItems.Add(docdulieu[6].ToString());
                
                i++;
            }
            ketnoi.Close();
        }

        public void Hienthi_dsDathue()
        {
            lstvds_Dathue.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            sql = "select p.MAPHONG,p.TENPHONG,lp.TENLP,lp.TRANGBI,lp.DONGIA,p.MABP,p.TRANGTHAI from PHONG p, LOAIPHONG lp " +
                  "where p.TRANGTHAI = N'Đã thuê' and p.MALP = lp.MALP";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {

                lstvds_Dathue.Items.Add(docdulieu[0].ToString());
                lstvds_Dathue.Items[i].SubItems.Add(docdulieu[1].ToString());
                lstvds_Dathue.Items[i].SubItems.Add(docdulieu[2].ToString());
                lstvds_Dathue.Items[i].SubItems.Add(docdulieu[3].ToString());
                lstvds_Dathue.Items[i].SubItems.Add(docdulieu[4].ToString());
                lstvds_Dathue.Items[i].SubItems.Add(docdulieu[5].ToString());
                lstvds_Dathue.Items[i].SubItems.Add(docdulieu[6].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btnDanhsach_phongtrong_Click(object sender, EventArgs e)
        {
            grb_chuathue.Visible = true;
            grb_dathue.Visible = false;
            Hienthi_dsChuathue();
        }

        private void btnDanhsach_phongdathue_Click(object sender, EventArgs e)
        {
            grb_chuathue.Visible = false;
            grb_dathue.Visible = true;
            Hienthi_dsDathue();
            
        }

        private void lstvds_Dathue_Click(object sender, EventArgs e)
        {
            txtMa_phong.Text = lstvds_Dathue.SelectedItems[0].SubItems[0].Text;
            txtTen_phong.Text = lstvds_Dathue.SelectedItems[0].SubItems[1].Text;
            txtLoai_phong.Text = lstvds_Dathue.SelectedItems[0].SubItems[2].Text;
            txtTrangbi_phong.Text = lstvds_Dathue.SelectedItems[0].SubItems[3].Text;
            txtDongia_phong.Text = lstvds_Dathue.SelectedItems[0].SubItems[4].Text;
            txtMa_bpphong.Text = lstvds_Dathue.SelectedItems[0].SubItems[5].Text;
            txtTrangthai_phong.Text = lstvds_Dathue.SelectedItems[0].SubItems[6].Text;
        }

        private void lstv_dsChuathue_Click(object sender, EventArgs e)
        {
            txtMa_phong.Text = lstv_dsChuathue.SelectedItems[0].SubItems[0].Text;
            txtTen_phong.Text = lstv_dsChuathue.SelectedItems[0].SubItems[1].Text;
            txtLoai_phong.Text = lstv_dsChuathue.SelectedItems[0].SubItems[2].Text;
            txtTrangbi_phong.Text = lstv_dsChuathue.SelectedItems[0].SubItems[3].Text;
            txtDongia_phong.Text = lstv_dsChuathue.SelectedItems[0].SubItems[4].Text;
            txtMa_bpphong.Text = lstv_dsChuathue.SelectedItems[0].SubItems[5].Text;
            txtTrangthai_phong.Text = lstv_dsChuathue.SelectedItems[0].SubItems[6].Text;
        }





    }
    // FORM của các panel : 904, 452
}

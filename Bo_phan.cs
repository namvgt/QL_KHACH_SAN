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

namespace WindowsFormsApp1
{
    public partial class Bo_phan : UserControl
    {
        public Bo_phan()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = @"Data Source=NAM\SQLDEV2019;Initial Catalog=QuanLyKhachSan_SQL6;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

        private void Bo_phan_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(chuoiketnoi);
        }
        public void Hienthi()
        {
            lstBP.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            sql = "select * from BOPHAN";
            ketnoi.Open();
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                lstBP.Items.Add(docdulieu[0].ToString());
                lstBP.Items[i].SubItems.Add(docdulieu[1].ToString());
                lstBP.Items[i].SubItems.Add(docdulieu[2].ToString());

                string ng_nchuc = Convert.ToDateTime(docdulieu[3].ToString()).ToString("dd/MM/yyyy");

                lstBP.Items[i].SubItems.Add(ng_nchuc);
                lstBP.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void lstBP_Click(object sender, EventArgs e)
        {
            txtMabp.Text = txtSua_maBp.Text= lstBP.SelectedItems[0].SubItems[0].Text;
            txtTenbp.Text = txtSuatenbp.Text= lstBP.SelectedItems[0].SubItems[1].Text;
            txtMaTRBP.Text = cbSua_matruongBp.Text= lstBP.SelectedItems[0].SubItems[2].Text;
            txtNgaynhanchuc.Text =  lstBP.SelectedItems[0].SubItems[3].Text;
            txtSlnv.Text = lstBP.SelectedItems[0].SubItems[4].Text;
        }

        private void btnExít_thembP_Click(object sender, EventArgs e)
        {
            panel_Thembophan.Visible = false;
        }

        private void btnExit_Sua_Click(object sender, EventArgs e)
        {
            panel_Suabp.Visible = false;
        }

        private void btnSuaBP_Click(object sender, EventArgs e)
        {
            txtMabp.Enabled = false;
            panel_Suabp.Visible = true;
        }

        private void btnThemBp_Click(object sender, EventArgs e)
        {
            txtThemMaBP.Text = "";
            txtThemTenBP.Text = "";
            cbThem_maTRBP.Text = "";
            panel_Thembophan.Visible = true;
        }

        private void btnXoaBP_Click(object sender, EventArgs e)// xóa bộ phận
        {
            try
            {
                ketnoi.Open();
 

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                DialogResult d = MessageBox.Show("Bạn muốn xóa bộ phận này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (d == DialogResult.Yes)
                {
                    sql = "UPDATE NHANVIEN SET MABP = null, MA_NQL = null WHERE MABP = '" +txtMabp.Text + "'";
                    sql += "UPDATE DICHVU SET MABP = null WHERE MABP = '"+txtMabp.Text+"' ";
                    sql += "UPDATE PHONG SET MABP = null WHERE MABP = '"+txtMabp.Text+"' ";
                    sql += "DELETE FROM BOPHAN WHERE MABP = '" + txtMabp.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công.", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                if (d == DialogResult.No)
                {
                    ketnoi.Close();
                }
            }
        }

        private void btnAdd_dichvu_Click(object sender, EventArgs e)// Thêm bộ phận
        {
            try
            {
                ketnoi.Open();

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                DialogResult d = MessageBox.Show("Bạn muốn thêm bộ phận này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                if (d == DialogResult.Yes)
                {
                    sql = "INSERT BOPHAN VALUES('" + txtThemMaBP.Text + "',N'" + txtThemTenBP.Text + "','" + cbThem_maTRBP.Text + "','" + dtp_ThemNgay.Value.ToString("yyyy/MM/dd") + "',0)";
                    sql += "UPDATE NHANVIEN SET MABP = '"+txtThemMaBP.Text+"', MA_NQL = NULL WHERE MANV = '"+cbThem_maTRBP.Text+"'";
                    //sql += "UPDATE NHANVIEN SET MABP = '"+txtThemMaBP.Text+"' , MA_NQL = '"+cbThem_maTRBP.Text+"' WHERE MA_NQL IS NULL AND MABP IS NULL ";

                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công.", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                    panel_Thembophan.Visible = false;
                }

            }
        }

        private void btn_Capnhat_sua_Click(object sender, EventArgs e)// sửa bộ phận
        {
            try
            {
                ketnoi.Open();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                sql = "UPDATE BOPHAN SET TENBP = N'" + txtSuatenbp.Text + "' WHERE MABP = '" + txtSua_maBp.Text + "'";
                sql += "UPDATE BOPHAN SET NGAY_NHANCHUC = '" + dtpSua_ngaynhanchuc.Value.ToString("yyyy/MM/dd") + "' WHERE MABP = '" + txtSua_maBp.Text + "'";
                sql += "UPDATE BOPHAN SET MA_TRBP = '" + cbSua_matruongBp.Text + "' WHERE MABP = '" + txtSua_maBp.Text + "'";
                sql += "UPDATE NHANVIEN SET MA_NQL = '"+cbSua_matruongBp.Text+"' WHERE MABP = '"+txtSua_maBp.Text+"'";
                sql += "UPDATE NHANVIEN SET MA_NQL = null, MABP = '" + txtSua_maBp.Text + "' WHERE MANV = '" + cbSua_matruongBp.Text + "'";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                DialogResult d = MessageBox.Show("Sửa thông tin thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (d == DialogResult.OK) panel_Suabp.Visible = false;
                ketnoi.Close();
            }
        }

        private void btnTimkiem_BP_Click(object sender, EventArgs e)// Tìm kiếm
        {
            if (cbMuctimkiem_BP.Text == cbMuctimkiem_BP.Items[0].ToString())
            {
                //sql = "SELECT * FROM BOPHAN WHERE MABP LIKE '%"+txtTim_bophan.Text+"%'";
                sql = "SELECT* FROM TK_BP(1, '"+txtTim_bophan.Text+"')";
            }
            if (cbMuctimkiem_BP.Text == cbMuctimkiem_BP.Items[1].ToString())
            {
                //sql = "SELECT * FROM BOPHAN WHERE TENBP LIKE N'%" + txtTim_bophan.Text + "%'";
                sql = "SELECT* FROM TK_BP(2, '" + txtTim_bophan.Text + "')";
            }
            if (cbMuctimkiem_BP.Text == cbMuctimkiem_BP.Items[2].ToString())
            {
                //sql = "SELECT * FROM BOPHAN WHERE MA_TRBP LIKE '%" + txtTim_bophan.Text + "%'";
                sql = "SELECT* FROM TK_BP(3, '" + txtTim_bophan.Text + "')";
            }
            if (cbMuctimkiem_BP.Text == cbMuctimkiem_BP.Items[3].ToString())
            {
                //sql = "SELECT * FROM BOPHAN WHERE NGAY_NHANCHUC LIKE '%" + txtTim_bophan.Text + "%'";
                sql = "SELECT* FROM TK_BP(4, '" + txtTim_bophan.Text + "')";
            }
            if (cbMuctimkiem_BP.Text == cbMuctimkiem_BP.Items[4].ToString())
            {
                //sql = "SELECT * FROM BOPHAN WHERE SLNV LIKE '%"+txtTim_bophan.Text+"%'";
                sql = "SELECT* FROM TK_BP(5, '" + txtTim_bophan.Text + "')";
            }
            lstBP.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                lstBP.Items.Add(docdulieu[0].ToString());
                lstBP.Items[i].SubItems.Add(docdulieu[1].ToString());
                lstBP.Items[i].SubItems.Add(docdulieu[2].ToString());

                string ng_nchuc = Convert.ToDateTime(docdulieu[3].ToString()).ToString("dd/MM/yyyy");

                lstBP.Items[i].SubItems.Add(ng_nchuc);
                lstBP.Items[i].SubItems.Add(docdulieu[4].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void txtTim_bophan_Click(object sender, EventArgs e)
        {
            txtTim_bophan.Text = null;
            txtTim_bophan.ForeColor = Color.Black;
        }

        private void btnCapnhat_MouseMove(object sender, MouseEventArgs e)
        {
            btnCapnhat.BackColor = Color.Red;
        }

        private void btnCapnhat_MouseLeave(object sender, EventArgs e)
        {
            btnCapnhat.BackColor = Color.Blue;
        }

        private void btnSuaBP_MouseMove(object sender, MouseEventArgs e)
        {
            btnSuaBP.BackColor = Color.Red;
        }

        private void btnSuaBP_MouseLeave(object sender, EventArgs e)
        {
            btnSuaBP.BackColor = Color.Blue;
        }

        private void btnThemBp_MouseMove(object sender, MouseEventArgs e)
        {
            btnThemBp.BackColor = Color.Red;
        }

        private void btnThemBp_MouseLeave(object sender, EventArgs e)
        {
            btnThemBp.BackColor = Color.Blue;
        }

        private void btnXoaBP_MouseMove(object sender, MouseEventArgs e)
        {
            btnXoaBP.BackColor = Color.Red;
        }

        private void btnXoaBP_MouseLeave(object sender, EventArgs e)
        {
            btnXoaBP.BackColor = Color.Blue;
        }

        private void btnExit_Sua_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit_Sua.BackColor = Color.Bisque;
        }

        private void btnExit_Sua_MouseLeave(object sender, EventArgs e)
        {
            btnExit_Sua.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        }

        private void btnExít_thembP_MouseMove(object sender, MouseEventArgs e)
        {
            btnExít_thembP.BackColor = Color.Bisque;
        }

        private void btnExít_thembP_MouseLeave(object sender, EventArgs e)
        {
            btnExít_thembP.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        }

        private void btn_Capnhat_sua_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Capnhat_sua.ForeColor = Color.Red;
        }

        private void btn_Capnhat_sua_MouseLeave(object sender, EventArgs e)
        {
            btn_Capnhat_sua.ForeColor = Color.Yellow;
        }

        private void btnAdd_dichvu_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd_dichvu.ForeColor = Color.Red;
        }

        private void btnAdd_dichvu_MouseLeave(object sender, EventArgs e)
        {
            btnAdd_dichvu.ForeColor = Color.Yellow;
        }
    }
}

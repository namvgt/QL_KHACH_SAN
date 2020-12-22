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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            paneldsnv.Visible = false;
        }
        Dichvu dv = new Dichvu();
        Bo_phan bp = new Bo_phan();
        Doanhthu dt = new Doanhthu();
        Trogiup help = new Trogiup();
        Ghichu ghi = new Ghichu();
        string sql;
        string chuoiketnoi = @"Data Source=NAM\SQLDEV2019;Initial Catalog=QuanLyKhachSan_SQL6;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
 
            ketnoi = new SqlConnection(chuoiketnoi);
            //Hienthi();
        }
        public void Hienthi()
        {
            lstvDanhsachNv.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            sql = "SELECT * FROM NHANVIEN";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {

                string ng_sinh = Convert.ToDateTime(docdulieu[7].ToString()).ToString("dd/MM/yyyy");

                lstvDanhsachNv.Items.Add(docdulieu[0].ToString());
                lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[1].ToString());

                lstvDanhsachNv.Items[i].SubItems.Add(ng_sinh);

                lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[2].ToString());
                lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[3].ToString());
                lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[4].ToString());
                lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[5].ToString());
                lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[6].ToString());
                lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[8].ToString());
                lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[9].ToString());
                i++;
            }
            ketnoi.Close();
        }

        private void lstvDanhsachNv_Click(object sender, EventArgs e)
        {

            // Đưa dữ liệu vào thông tin nhân viên
            cbManv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[0].Text;
            txtTennv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[1].Text;
            txtDiachinv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[3].Text; ;
            txtSdtnv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[4].Text;
            txtGioitinhnv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[6].Text;
            txtNv_mabp.Text = lstvDanhsachNv.SelectedItems[0].SubItems[7].Text;
            txtLuong_nv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[8].Text;
            txtMaNQLnv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[9].Text;
            txtNgaysinh_nv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[2].Text; //-------------- New

            /// đưa dữ liệu vào panel sửa thông tin
            cbSua_Manv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[0].Text;
            txtSua_Tennv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[1].Text;
            txtSua_Diachinv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[3].Text; ;
            txtSua_Sdtnv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[4].Text;


            if (lstvDanhsachNv.SelectedItems[0].SubItems[6].Text == ckbNam_suathongtin.Text)
            {
                ckbNam_suathongtin.Checked = true;
                ckbNu_suathongtin.Checked = false;
            }
            else
            {
                ckbNu_suathongtin.Checked = true;
                ckbNam_suathongtin.Checked = false;
            }
            cbSuaNv_maBP.Text = lstvDanhsachNv.SelectedItems[0].SubItems[7].Text;
            txtSua_luongnv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[8].Text;
            txtSua_manql_nv.Text = lstvDanhsachNv.SelectedItems[0].SubItems[9].Text;
        }

        private void btnnhanvien_Click(object sender, EventArgs e)   // button nhân viên
        {
            dv.Visible = false;
            bp.Visible = false;
            dt.Visible = false;
            ghi.Visible = false;
            help.Visible = false;
            lbContro.Visible = true;
            lbContro.Location = new Point(0, 6);
            panelphong.Visible = false;
            label1.Controls.Add(paneldsnv);
            paneldsnv.Visible = true;
            paneldsnv.Size = new System.Drawing.Size(950, 490);
            paneldsnv.Location = new System.Drawing.Point(114, 61);
        }

        private void btnComeback_Click(object sender, EventArgs e)   // Hiển thị lại danh sách nhân viên
        {
            Hienthi();
        }

        private void btnThemNv_Click(object sender, EventArgs e)   /// Thêm nhân viên
        {
            grb_TK.Visible = false;
            txtThem_manv.Text = null;
            txtthem_Tennv.Text = null;
            txtthem_Diachinv.Text = null;
            txtthem_Sdtnv.Text = null;
            ckbNam_themnv.Checked=false;
            ckbNu_themnv.Checked = false;
            cbAddNv_MaBp.Text = null;
            txtThem_luong_nv.Text = null;
            txtThem_manqlnv.Text =null;
            panel_themthongtin_nhanvien.Visible = true;
            panel_suathongtin_nhanvien.Visible = false;

        }

        private void btnXoaNv_Click(object sender, EventArgs e)     // Xóa nhân viên này
        {
            try
            {
                ketnoi.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            finally
            {
                DialogResult a = MessageBox.Show("Bạn muốn xóa nhân viên này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    //sql = "delete from NHANVIEN where(MANV = '" + cbManv.Text + "')";
                    sql = "EXEC DELETE_NV WHERE MANV = '" + cbManv.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    DialogResult b = MessageBox.Show("Xóa thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (b == DialogResult.OK)
                    {
                        ketnoi.Close();
                    }
                }
                if (a == DialogResult.No)
                {
                    ketnoi.Close();
                }
            }
        }

        private void btnphong_Click(object sender, EventArgs e)      // button Phòng
        {
            lbContro.Visible = true;
            dt.Visible = false;
            paneldsnv.Visible = false;
            dv.Visible = false;
            bp.Visible = false;
            ghi.Visible = false;
            help.Visible = false;
            label1.Controls.Add(panelphong);
            panelphong.Visible = true;
            panelphong.Size = new System.Drawing.Size(950, 490);
            panelphong.Location = new System.Drawing.Point(114, 61);
            lbContro.Location = new Point(0, 64);

            //Hienthi_phong();
        }

        private void btnExit_form2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Hienthi_phong()                                         // Phòng
        {
            lstph.Items.Clear();
            ketnoi = new SqlConnection(chuoiketnoi);
            ketnoi.Open();
            //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp where p.MALP = lp.MALP ";
            sql = "EXEC XEM_PHONG";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                lstph.Items.Add(docdulieu[0].ToString());
                lstph.Items[i].SubItems.Add(docdulieu[1].ToString());
                lstph.Items[i].SubItems.Add(docdulieu[2].ToString());
                lstph.Items[i].SubItems.Add(docdulieu[3].ToString());
                lstph.Items[i].SubItems.Add(docdulieu[4].ToString());
                lstph.Items[i].SubItems.Add(docdulieu[5].ToString());
                lstph.Items[i].SubItems.Add(docdulieu[6].ToString());
                lstph.Items[i].SubItems.Add(docdulieu[7].ToString());
                i++;
            }

            ketnoi.Close();
        }

        private void lstph_Click(object sender, EventArgs e)
        {
            txtMaphong.Text = lstph.SelectedItems[0].SubItems[0].Text;
            txtTenphong.Text = lstph.SelectedItems[0].SubItems[1].Text;
            txtTrangthai_phong.Text = lstph.SelectedItems[0].SubItems[2].Text;
            txtMaloaiphong.Text = lstph.SelectedItems[0].SubItems[3].Text;
            txtMabp_phong.Text = lstph.SelectedItems[0].SubItems[4].Text;
            txtLoaiphong.Text = lstph.SelectedItems[0].SubItems[5].Text;
            txtTrangbi.Text = lstph.SelectedItems[0].SubItems[6].Text;
            txtDongia_phong.Text = lstph.SelectedItems[0].SubItems[7].Text;

            // Đưa dữ liệu vào Panel sửa thông tin phòng
            txtSua_maphong.Text = lstph.SelectedItems[0].SubItems[0].Text;
            txtSua_tenPhong.Text = lstph.SelectedItems[0].SubItems[1].Text;
            cbSua_trangthaiphong.Text = lstph.SelectedItems[0].SubItems[2].Text;
            txtSua_maloaiphong.Text = lstph.SelectedItems[0].SubItems[3].Text;
            cbSuaPhong_maBP.Text = lstph.SelectedItems[0].SubItems[4].Text;
            txtSua_loaiphong.Text = lstph.SelectedItems[0].SubItems[5].Text;
            txtSua_trangbiphong.Text = lstph.SelectedItems[0].SubItems[6].Text;
            txtSua_dongiaPhong.Text = lstph.SelectedItems[0].SubItems[7].Text;



        }

        private void btnSuathongtinNv_Click(object sender, EventArgs e)  // Sửa thông tin nhân viên
        {
            grb_TK.Visible = false;
            panel_suathongtin_nhanvien.Visible = true;
            panel_themthongtin_nhanvien.Visible = false;
        }

        private void btnExit_form_themthongtin_Click_1(object sender, EventArgs e)
        {
            panel_themthongtin_nhanvien.Visible = false;
            paneldsnv.Enabled = true;
            grb_TK.Visible = true;
        }

        private void btnExit_form_suathongtin_Click_1(object sender, EventArgs e)
        {
            panel_suathongtin_nhanvien.Visible = false;
            paneldsnv.Enabled = true;
            grb_TK.Visible = true;
        }

        private void btnCap_nhat_Nhanvien_Click_1(object sender, EventArgs e)              // Sửa nhân viên
        {
            ketnoi.Open();
            try
            {

                sql = "update NHANVIEN set TENNV=N'" + txtSua_Tennv.Text + "' where MANV ='" + cbSua_Manv.Text + "'" +
                      "update NHANVIEN set NGAYSINH ='" + dtpSua_Ngaysinh.Value.ToString("yyyy/MM/dd") + "' where MANV ='" + cbSua_Manv.Text + "'" +
                      "update NHANVIEN set DIACHI =N'" + txtSua_Diachinv.Text + "' where MANV ='" + cbSua_Manv.Text + "'" +
                      "update NHANVIEN set SDT ='" + txtSua_Sdtnv.Text + "' where MANV ='" + cbSua_Manv.Text + "'" +
                      "update NHANVIEN set MABP ='" + cbSuaNv_maBP.Text + "' where MANV ='" + cbSua_Manv.Text + "'";
                if (ckbNam_suathongtin.Checked == true)
                {
                    sql += "update NHANVIEN set GIOITINH =N'" + ckbNam_suathongtin.Text + "' where MANV ='" + cbSua_Manv.Text + "'";
                }
                if (ckbNu_suathongtin.Checked == true)
                {
                    sql += "update NHANVIEN set GIOITINH =N'" + ckbNu_suathongtin.Text + "' where MANV ='" + cbSua_Manv.Text + "'";
                }
                sql += "update NHANVIEN set LUONG= " + int.Parse(txtSua_luongnv.Text) + " where MANV ='" + cbSua_Manv.Text + "'" +
                    "update NHANVIEN set MA_NQL= '" + txtSua_manql_nv.Text + "' where MANV ='" + cbSua_Manv.Text + "'";

                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());

            }
            finally
            {
                DialogResult d = MessageBox.Show("Sửa thông tin thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (d == DialogResult.OK) panel_suathongtin_nhanvien.Visible = false;
            }
            ketnoi.Close();
            grb_TK.Visible = true;
        }

        private void btnThem_nv_Click_1(object sender, EventArgs e)      // Thêm nhân viên
        {
            ketnoi.Open();
            try
            {
                if (ckbNam_themnv.Checked == true)
                {
                    //sql = "insert NHANVIEN values('" + txtThem_manv.Text + "',N'" + txtthem_Tennv.Text + "',N'" + txtthem_Diachinv.Text + "','" +
                    //                               "" + txtthem_Sdtnv.Text + "','123456',N'" + ckbNam_themnv.Text + "','" + cbAddNv_MaBp.Text + "','" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd") + "'" +
                    //                               ",'" + Convert.ToInt32(txtThem_luong_nv.Text) + "','" + txtThem_manqlnv.Text + "')";
                    sql = "EXEC INSERT_NV   @MANV = '" + txtThem_manv.Text + "',@TENNV = N'" + txtthem_Tennv.Text + "',@DIACHI = N'" + txtthem_Diachinv.Text + "',@SDT = '" + txtthem_Sdtnv.Text + "'," +
                        "@MK = '123456',@GIOITINH = N'" + ckbNam_themnv.Text + "',@MABP = '" + cbAddNv_MaBp.Text + "'," +
                           "@NGAYSINH = '" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd") + "',@LUONG = " + Convert.ToInt32(txtThem_luong_nv.Text) + ",@MA_NQL = '" + txtThem_manqlnv.Text + "'";

                }
                if (ckbNu_themnv.Checked == true)
                {
                    //sql = "insert NHANVIEN values('" + txtThem_manv.Text + "',N'" + txtthem_Tennv.Text + "',N'" + txtthem_Diachinv.Text + "','" +
                    //                               "" + txtthem_Sdtnv.Text + "','123456',N'" + ckbNu_themnv.Text + "','" + cbAddNv_MaBp.Text + "','" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd") + "'" +
                    //                               ",'" + Convert.ToInt32(txtThem_luong_nv.Text) + "','" + txtThem_manqlnv.Text + "')";
                    sql = "EXEC INSERT_NV   @MANV = '" + txtThem_manv.Text + "',@TENNV = N'" + txtthem_Tennv.Text + "',@DIACHI = N'" + txtthem_Diachinv.Text + "',@SDT = '" + txtthem_Sdtnv.Text + "'," +
                                            "@MK = '123456',@GIOITINH = N'" + ckbNu_themnv.Text + "',@MABP = '" + cbAddNv_MaBp.Text + "'," +
                                               "@NGAYSINH = '" + dtpThem_ngaysinh.Value.ToString("yyyy/MM/dd") + "',@LUONG = " + Convert.ToInt32(txtThem_luong_nv.Text) + ",@MA_NQL = '" + txtThem_manqlnv.Text + "'";
                }
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            finally
            {
                DialogResult d = MessageBox.Show("Thêm thành công.", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (d == DialogResult.OK)
                {
                    panel_themthongtin_nhanvien.Visible = false;
                }
            }
            ketnoi.Close();
            grb_TK.Visible = true;
        }

        private void btnClear_panel_Click(object sender, EventArgs e)
        {
            paneldsnv.Visible = false;
            panelphong.Visible = false;
            lbContro.Visible = false;
            // paneldsnv 950, 490
        }

        private void ckbNam_suathongtin_CheckedChanged(object sender, EventArgs e)
        {
            ckbNu_suathongtin.Checked = false;
        }

        private void ckbNu_suathongtin_CheckedChanged(object sender, EventArgs e)
        {
            ckbNam_suathongtin.Checked = false;
        }

        private void ckbNam_themnv_CheckedChanged(object sender, EventArgs e)
        {
            ckbNu_themnv.Checked = false;
        }

        private void ckbNu_themnv_CheckedChanged(object sender, EventArgs e)
        {
            ckbNam_themnv.Checked = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)                     // Tìm kiếm nhân viên
        {
            if (txtTimkiem.Text == null)
            {
                MessageBox.Show("Lỗi tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[0].ToString())   // Tìm kiếm theo mã
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE MANV LIKE '%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(1, '" + txtTimkiem.Text + "')";
                }
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[1].ToString())                 // Tìm kiếm theo tên
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE TENNV LIKE N'%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(2, '" + txtTimkiem.Text + "')";
                }   // Tìm kiếm theo tên
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[2].ToString())                 // Tìm kiếm theo địa chỉ
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE DIACHI LIKE N'%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(3, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo địa chỉ
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[3].ToString())                 // Tìm kiếm theo ngày sinh
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE NGAYSINH LIKE '%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(4, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo ngày sinh
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[4].ToString())                 // Tìm kiếm theo sđt
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE SDT LIKE '%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(5, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo sđt
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[5].ToString())                 // Tìm kiếm theo giới tính
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE GIOITINH LIKE N'%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(6, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo giới tính
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[6].ToString())                 // Tìm kiếm theo lương
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE LUONG LIKE '%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(7, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo lương
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[7].ToString())                 // Tìm kiếm theo mã người quản lý
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE MA_NQL LIKE '%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(8, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo mã quản lý
                if (cbDanhmucTK.Text == cbDanhmucTK.Items[8].ToString())                 // Tìm kiếm theo mã bộ phận
                {
                    //sql = "SELECT * FROM NHANVIEN WHERE MABP LIKE '%" + txtTimkiem.Text + "%'";
                    sql = "SELECT* FROM TK_NV(9, '" + txtTimkiem.Text + "')";
                }  // Tìm kiếm theo max bộ phân
                lstvDanhsachNv.Items.Clear();
                ketnoi.Open();
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
                i = 0;
                while (docdulieu.Read())
                {
                    string ng_sinh = Convert.ToDateTime(docdulieu[7].ToString()).ToString("dd/MM/yyyy");

                    lstvDanhsachNv.Items.Add(docdulieu[0].ToString());
                    lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[1].ToString());

                    lstvDanhsachNv.Items[i].SubItems.Add(ng_sinh);

                    lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[2].ToString());
                    lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[3].ToString());
                    lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[4].ToString());
                    lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[5].ToString());
                    lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[6].ToString());
                    lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[8].ToString());
                    lstvDanhsachNv.Items[i].SubItems.Add(docdulieu[9].ToString());
                    i++;
                }
                ketnoi.Close();
            }
        }   // Tìm kiếm

        private void btnBophan_Click(object sender, EventArgs e)     // Button Bộ phận
        {
            dv.Visible = false;
            lbContro.Visible = true;
            bp.Visible = true;
            dt.Visible = false;
            help.Visible = false;
            ghi.Visible = false;
            lbContro.Location = new Point(0, 180);
            paneldsnv.Visible = false;
            panelphong.Visible = false;
            bp.Location = new System.Drawing.Point(114, 61);
            label1.Controls.Add(bp);

        }

        private void btnCapnhat_DSphong_Click(object sender, EventArgs e)
        {
            Hienthi_phong();
        }

        private void btnSuathongtinPhong_Click(object sender, EventArgs e)
        {
            panel_SuaPhong.Visible = true;
            txtSua_maphong.Enabled = false;
            panel_Addphong.Visible = false;
        }

        private void btnThemphong_Click(object sender, EventArgs e)
        {
            panel_Addphong.Visible = true;
            panel_SuaPhong.Visible = false;
        }

        private void btnCapnhat_suaphong_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
               sql = " UPDATE PHONG SET TENPHONG = N'"+txtSua_tenPhong.Text+"' ," +
                    " TRANGTHAI = N'"+cbSua_trangthaiphong.Text+"', MABP = '"+cbSuaPhong_maBP.Text+"' WHERE MAPHONG = '"+txtSua_maphong.Text+"'";
               sql += "  UPDATE LOAIPHONG SET TENLP = '"+txtSua_loaiphong.Text+"', TRANGBI = N'"+txtSua_trangbiphong.Text+"'," +
                    " DONGIA = "+Convert.ToInt32(txtSua_dongiaPhong.Text)+" WHERE MALP = '"+txtSua_maloaiphong.Text+"'";
               thuchien = new SqlCommand(sql, ketnoi);  
               thuchien.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                DialogResult d = MessageBox.Show("Sửa thông tin thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (d == DialogResult.OK) panel_SuaPhong.Visible = false;
            }
            ketnoi.Close();
        } // Sửa phòng

        private void btnXoaphong_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            finally
            {
                DialogResult a = MessageBox.Show("Bạn muốn xóa phòng này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    sql = "delete from PHONG where(MAPHONG = '" + txtMaphong.Text + "')";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    DialogResult b = MessageBox.Show("Xóa thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (b == DialogResult.OK)
                    {
                        ketnoi.Close();
                    }
                }
                if (a == DialogResult.No)
                {
                    ketnoi.Close();
                }
            }
        }   // Xóa phòng

        private void btnAdd_Phong_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            try
            {
                sql = "INSERT PHONG VALUES('"+txtAdd_maphong.Text+"', N'"+txtAdd_tenphong.Text+"', N'"+cbAdd_trangthaiphong.Text+"'," +
                    " '"+cbAdd_maloaiphong.Text+"', '"+cbAdd_mabpql.Text+"')";
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DialogResult d = MessageBox.Show("Thêm thành công.", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (d == DialogResult.OK)
                {
                    panel_Addphong.Visible = false;
                }
            }
            ketnoi.Close();
            //INSERT LOAIPHONG VALUES('LP01', N'VIP đôi', N'Ti vi, Điều hòa, Máy nước nóng, Tủ lớn', 1000000)
        }          // Thêm phòng

        private void btnExit_Suaphong_Click(object sender, EventArgs e)
        {
            panel_SuaPhong.Visible = false;
        }

        private void btnExit_Addphong_Click(object sender, EventArgs e)
        {
            panel_Addphong.Visible = false;
        }

        private void btnTimkiem_phong_Click(object sender, EventArgs e)
        {
            if (txtTim_phong.Text == null)
            {
                MessageBox.Show("Lỗi tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lstph.Items.Clear();
                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[0].ToString())  // tìm theo mã
                {
                    //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp " +
                    //    "where p.MALP = lp.MALP and p.MAPHONG like '%" + txtTim_phong.Text + "%'";
                    sql = "SELECT * FROM TK_PHONG(1,'"+txtTim_phong.Text+"')";  // T-sql
                }  
                if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[1].ToString())  // tìm theo tên phòng
                {
                    //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp where p.MALP = lp.MALP " +
                    //    "and TENPHONG like N'%" + txtTim_phong.Text + "%'";
                    sql = "SELECT * FROM TK_PHONG(2,'" + txtTim_phong.Text + "')";  // T-sql
                }
                if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[2].ToString())  // tìm theo trạng thái
                {
                    //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp where p.MALP = lp.MALP " +
                    //    "and TRANGTHAI like N'%" + txtTim_phong.Text + "%'";
                    sql = "SELECT * FROM TK_PHONG(3,'" + txtTim_phong.Text + "')";  // T-sql
                }
                if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[3].ToString())  // tìm theo mã loại phòng
                {
                    //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp where p.MALP = lp.MALP " +
                    //    "and p.MALP like '%" + txtTim_phong.Text + "%'";
                    sql = "SELECT * FROM TK_PHONG(4,'" + txtTim_phong.Text + "')";  // T-sql
                }
                if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[4].ToString())  // tìm theo tên loại phòng
                {
                    //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp where p.MALP = lp.MALP " +
                    //    "and lp.TENLP like N'%" + txtTim_phong.Text + "%'";
                    sql = "SELECT * FROM TK_PHONG(5,'" + txtTim_phong.Text + "')";  // T-sql
                }
                if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[5].ToString())  // tìm theo trang bị
                {
                    //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp where p.MALP = lp.MALP " +
                    //    "and lp.TRANGBI like N'%" + txtTim_phong.Text + "%'";
                    sql = "SELECT * FROM TK_PHONG(6,'" + txtTim_phong.Text + "')";  // T-sql
                }
                if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[6].ToString())  // tìm theo đơn giá
                {
                    //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp where p.MALP = lp.MALP " +
                    //    "and lp.DONGIA like '%" + txtTim_phong.Text + "%'";
                    sql = "SELECT * FROM TK_PHONG(7,'" + txtTim_phong.Text + "')";  // T-sql
                }
                if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[7].ToString())  // tìm theo mã bộ phận
                {
                    //sql = "select p.*, lp.TENLP,lp.TRANGBI,lp.DONGIA from PHONG as p, LOAIPHONG as lp where p.MALP = lp.MALP " +
                    //    "and p.MABP like '%" + txtTim_phong.Text + "%'";
                    sql = "SELECT * FROM TK_PHONG(8,'" + txtTim_phong.Text + "')";  // T-sql
                }
                thuchien = new SqlCommand(sql, ketnoi);
                docdulieu = thuchien.ExecuteReader();
                i = 0;
                while (docdulieu.Read())
                {
                    lstph.Items.Add(docdulieu[0].ToString());
                    lstph.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lstph.Items[i].SubItems.Add(docdulieu[2].ToString());
                    lstph.Items[i].SubItems.Add(docdulieu[3].ToString());
                    lstph.Items[i].SubItems.Add(docdulieu[4].ToString());
                    lstph.Items[i].SubItems.Add(docdulieu[5].ToString());
                    lstph.Items[i].SubItems.Add(docdulieu[6].ToString());
                    lstph.Items[i].SubItems.Add(docdulieu[7].ToString());
                    i++;
                }
                ketnoi.Close();
            }
        }

        private void btndichvu_Click(object sender, EventArgs e)    //  button Dịch vụ
        {
            dv.Visible = true;
            bp.Visible = false;
            dt.Visible = false;
            ghi.Visible = false;
            help.Visible = false;
            lbContro.Visible = true;
            lbContro.Location = new Point(0, 122);
            paneldsnv.Visible = false;
            panelphong.Visible = false;
            dv.Location = new System.Drawing.Point(114, 61);
            label1.Controls.Add(dv);
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)   // Doanhthu
        {
            dv.Visible = false;
            bp.Visible = false;
            ghi.Visible = false;
            help.Visible = false;
            lbContro.Visible = true;
            lbContro.Location = new Point(0, 238);
            paneldsnv.Visible = false;
            panelphong.Visible = false;
            
            dt.Visible = true;
            dt.Location = new System.Drawing.Point(114, 61);
            label1.Controls.Add(dt);
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            txtTimkiem.ForeColor = Color.Black;
            txtTimkiem.Text = null;
        }

        private void txtTim_phong_Click(object sender, EventArgs e)
        {
            txtTim_phong.Text = null;
            txtTim_phong.ForeColor = Color.Black;
        }

        private void btnTrogiup_Click(object sender, EventArgs e)   // TRỢ GIÚP
        {
            dv.Visible = false;
            dt.Visible = false;
            bp.Visible = false;
            ghi.Visible = false;
            help.Visible = true;
            lbContro.Visible = true;
            lbContro.Location = new Point(0, 296);
            help.Location = new System.Drawing.Point(114,61);
            label1.Controls.Add(help);
            paneldsnv.Visible = false;
            panelphong.Visible = false;
           
        }

        private void btnGhichu_Click(object sender, EventArgs e)
        {
            dv.Visible = false;
            dt.Visible = false;
            bp.Visible = false;
            help.Visible = false;
            ghi.Visible = true;
            lbContro.Visible = true;
            lbContro.Location = new Point(0, 354);
            paneldsnv.Visible = false;
            panelphong.Visible = false;
            ghi.Location = new System.Drawing.Point(114, 61);
            label1.Controls.Add(ghi); 
        }

        private void btnThemNv_MouseMove(object sender, MouseEventArgs e)
        {
            btnThemNv.BackColor = Color.Red;
        }

        private void btnThemNv_MouseLeave(object sender, EventArgs e)
        {
            btnThemNv.BackColor = Color.Blue;
        }

        private void btnSuathongtinNv_MouseLeave(object sender, EventArgs e)
        {
            btnSuathongtinNv.BackColor = Color.Blue;
        }

        private void btnSuathongtinNv_MouseMove(object sender, MouseEventArgs e)
        {
            btnSuathongtinNv.BackColor = Color.Red;
        }

        private void btnXoaNv_MouseMove(object sender, MouseEventArgs e)
        {
            btnXoaNv.BackColor = Color.Red;
        }

        private void btnXoaNv_MouseLeave(object sender, EventArgs e)
        {
            btnXoaNv.BackColor = Color.Blue;
        }

        private void btnCapnhat_DSphong_MouseMove(object sender, MouseEventArgs e)
        {
            btnCapnhat_DSphong.BackColor = Color.Red;
        }

        private void btnCapnhat_DSphong_MouseLeave(object sender, EventArgs e)
        {
            btnCapnhat_DSphong.BackColor = Color.Blue;
        }

        private void btnSuathongtinPhong_MouseMove(object sender, MouseEventArgs e)
        {
            btnSuathongtinPhong.BackColor = Color.Red;
        }

        private void btnSuathongtinPhong_MouseLeave(object sender, EventArgs e)
        {
            btnSuathongtinPhong.BackColor = Color.Blue;
        }

        private void btnThemphong_MouseLeave(object sender, EventArgs e)
        {
            btnThemphong.BackColor = Color.Blue;
        }

        private void btnThemphong_MouseMove(object sender, MouseEventArgs e)
        {
            btnThemphong.BackColor = Color.Red;
        }

        private void btnXoaphong_MouseMove(object sender, MouseEventArgs e)
        {
            btnXoaphong.BackColor = Color.Red;
        }

        private void btnXoaphong_MouseLeave(object sender, EventArgs e)
        {
            btnXoaphong.BackColor = Color.Blue;
        }

        private void btnExit_form_suathongtin_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit_form_suathongtin.BackColor = Color.Bisque;
        }

        private void btnExit_form_suathongtin_MouseLeave(object sender, EventArgs e)
        {
            btnExit_form_suathongtin.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))); 
        }

        private void btnExit_form_themthongtin_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit_form_themthongtin.BackColor = Color.Bisque;
        }

        private void btnExit_form_themthongtin_MouseLeave(object sender, EventArgs e)
        {
            btnExit_form_themthongtin.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        }

        private void btnThem_nv_MouseMove(object sender, MouseEventArgs e)
        {
            btnThem_nv.BackColor = Color.Khaki;
        }

        private void btnThem_nv_MouseLeave(object sender, EventArgs e)
        {
            btnThem_nv.BackColor = Color.DarkKhaki;
        }

        private void btnCap_nhat_Nhanvien_MouseLeave(object sender, EventArgs e)
        {
            btnCap_nhat_Nhanvien.BackColor = Color.DarkKhaki;
        }

        private void btnCap_nhat_Nhanvien_MouseMove(object sender, MouseEventArgs e)
        {
            btnCap_nhat_Nhanvien.BackColor = Color.Khaki;
        }

        private void btnExit_Addphong_MouseLeave(object sender, EventArgs e)
        {
            btnExit_Addphong.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        }

        private void btnExit_Addphong_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit_Addphong.BackColor = Color.Bisque;
        }

        private void btnAdd_Phong_MouseLeave(object sender, EventArgs e)
        {
            btnAdd_Phong.ForeColor = Color.Yellow;
        }

        private void btnAdd_Phong_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd_Phong.ForeColor = Color.Red;
        }

        private void btnExit_Suaphong_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit_Suaphong.BackColor = Color.Bisque;
        }

        private void btnExit_Suaphong_MouseLeave(object sender, EventArgs e)
        {
            btnExit_Suaphong.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        }

        private void btnCapnhat_suaphong_MouseMove(object sender, MouseEventArgs e)
        {
            btnCapnhat_suaphong.ForeColor = Color.Red;
        }

        private void btnCapnhat_suaphong_MouseLeave(object sender, EventArgs e)
        {
            btnCapnhat_suaphong.ForeColor = Color.Yellow;
        }

        private void btnComeback_MouseLeave(object sender, EventArgs e)
        {
            btnComeback.BackColor = Color.Blue;
        }

        private void btnComeback_MouseMove(object sender, MouseEventArgs e)
        {
            btnComeback.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DangNhap dn = new DangNhap();
            dn.Visible = true;
        }
    }
}

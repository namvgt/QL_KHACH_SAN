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
    public partial class Dichvu : UserControl
    {
        public Dichvu()
        {
            InitializeComponent();
        }
        string sql;
        string chuoiketnoi = System.Configuration.ConfigurationSettings.AppSettings["Main.ConnectionString"];
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;

          private void Dichvu_Load(object sender, EventArgs e)
          {

               ketnoi = new SqlConnection(chuoiketnoi);
          }
          public void Hienthi()
          {
               lstDichvu.Items.Clear();
               ketnoi = new SqlConnection(chuoiketnoi);
               sql = "select dv.MADV,dv.TENDV,dv.DONGIA,dv.MABP from DICHVU dv";
               ketnoi.Open();
               thuchien = new SqlCommand(sql, ketnoi);
               docdulieu = thuchien.ExecuteReader();
               i = 0;
               while (docdulieu.Read())
               {
                    lstDichvu.Items.Add(docdulieu[0].ToString());
                    lstDichvu.Items[i].SubItems.Add(docdulieu[1].ToString());
                    lstDichvu.Items[i].SubItems.Add(docdulieu[2].ToString());
                    lstDichvu.Items[i].SubItems.Add(docdulieu[3].ToString());
                    i++;
               }
               ketnoi.Close();
          }

          private void btnCapnhat_Click(object sender, EventArgs e)
          {
               Hienthi();
          }

          private void lstDichvu_Click(object sender, EventArgs e)
          {
               txtMadv.Text = txtSua_madv.Text = lstDichvu.SelectedItems[0].SubItems[0].Text;
               txtTendv.Text = txtSuatendv.Text = lstDichvu.SelectedItems[0].SubItems[1].Text;
               txtDongia.Text = txtSua_dongia.Text = lstDichvu.SelectedItems[0].SubItems[2].Text;
               txtMabpql.Text = cbSua_mabpql.Text = lstDichvu.SelectedItems[0].SubItems[3].Text;
          }

          private void btnThemdv_Click(object sender, EventArgs e)
          {
               txtThemDongia.Text = "";
               txtThemMadv.Text = "";
               txtThemTendv.Text = "";
               cbThemMabpql.Text = "";
               panel_Themdichvu.Visible = true;
          }

          private void btnExít_themdichvu_Click(object sender, EventArgs e)
          {
               panel_Themdichvu.Visible = false;
          }

          private void btnAdd_dichvu_Click(object sender, EventArgs e)
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
                    DialogResult d = MessageBox.Show("Bạn muốn thêm dịch vụ này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (d == DialogResult.Yes)
                    {
                         sql = "INSERT DICHVU VALUES('" + txtThemMadv.Text + "',N'" + txtThemTendv.Text + "',N'Còn trống'," +
                                "" + Convert.ToInt32(txtThemDongia.Text) + ",'" + cbThemMabpql.Text + "')";
                         thuchien = new SqlCommand(sql, ketnoi);
                         thuchien.ExecuteNonQuery();
                         MessageBox.Show("Thêm thành công.", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                         panel_Themdichvu.Visible = false;
                    }
                    if (d == DialogResult.No)
                    {
                         ketnoi.Close();
                         panel_Themdichvu.Visible = false;
                    }
               }

          }

          private void btnXoadv_Click(object sender, EventArgs e)
          {
               try
               {
                    ketnoi.Open();
                    sql = "DELETE FROM DICHVU WHERE MADV = '" + txtMadv.Text + "'";

               }
               catch (Exception ex)
               {
                    throw;
               }
               finally
               {
                    DialogResult d = MessageBox.Show("Bạn muốn xóa dịch vụ này?", "Thông báo hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (d == DialogResult.Yes)
                    {
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

          private void btnSuadv_Click(object sender, EventArgs e)
          {
               txtSua_madv.Enabled = false;
               panel_Suadv.Visible = true;
          }

          private void btnExit_Suadv_Click(object sender, EventArgs e)
          {
               panel_Suadv.Visible = false;
          }

          private void btn_Capnhat_sua_Click(object sender, EventArgs e)
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
                    sql = "UPDATE DICHVU SET TENDV = N'" + txtSuatendv.Text + "' WHERE MADV = '" + txtSua_madv.Text + "'";
                    sql += "UPDATE DICHVU SET DONGIA = '" + Convert.ToInt32(txtSua_dongia.Text) + "' WHERE MADV = '" + txtSua_madv.Text + "'";
                    sql += "UPDATE DICHVU SET MABP = '" + cbSua_mabpql.Text + "' WHERE MADV = '" + txtSua_madv.Text + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    DialogResult d = MessageBox.Show("Sửa thông tin thành công!", "Thông báo hệ thống", MessageBoxButtons.OK, MessageBoxIcon.None);
                    if (d == DialogResult.OK) panel_Suadv.Visible = false;
                    ketnoi.Close();
               }
          }

          private void btnTimkiem_phong_Click(object sender, EventArgs e)
          {
               ketnoi.Open();
               if (txtTim_phong.ToString() == null)
               {
                    MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ketnoi.Close();
               }
               else
               {
                    lstDichvu.Items.Clear();
                    if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[0].ToString()) // tìm theo mã
                    {
                         //sql = "select dv.MADV,dv.TENDV,dv.DONGIA,dv.MABP from DICHVU dv WHERE MADV like '%" + txtTim_phong.Text + "%'";
                         sql = "select * from TK_DV(1,'" + txtTim_phong.Text + "')";
                    }
                    if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[1].ToString()) // tìm theo tên dịch vụ
                    {
                         //sql = "select dv.MADV,dv.TENDV,dv.DONGIA,dv.MABP from DICHVU dv WHERE TENDV like N'%" + txtTim_phong.Text + "%'";
                         sql = "select * from TK_DV(2,'" + txtTim_phong.Text + "')";
                    }
                    if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[2].ToString()) // tìm theo mã bộ phận
                    {
                         //sql = "select dv.MADV,dv.TENDV,dv.DONGIA,dv.MABP from DICHVU dv WHERE MABP like '%" + txtTim_phong.Text + "%'";
                         sql = "select * from TK_DV(3,'" + txtTim_phong.Text + "')";
                    }
                    if (cbMuctimkiem_phong.Text == cbMuctimkiem_phong.Items[3].ToString()) //tìm theo đơn giá
                    {
                         //sql = "select dv.MADV,dv.TENDV,dv.DONGIA,dv.MABP from DICHVU dv WHERE DONGIA like '%" + txtTim_phong.Text + "%'";
                         sql = "select * from TK_DV(4,'" + txtTim_phong.Text + "')";
                    }
                    thuchien = new SqlCommand(sql, ketnoi);
                    docdulieu = thuchien.ExecuteReader();
                    i = 0;
                    while (docdulieu.Read())
                    {
                         lstDichvu.Items.Add(docdulieu[0].ToString());
                         lstDichvu.Items[i].SubItems.Add(docdulieu[1].ToString());
                         lstDichvu.Items[i].SubItems.Add(docdulieu[2].ToString());
                         lstDichvu.Items[i].SubItems.Add(docdulieu[3].ToString());
                         i++;
                    }
                    ketnoi.Close();
               }
          }
          private void txtTim_phong_Click(object sender, EventArgs e)
          {
               txtTim_phong.Text = null;
               txtTim_phong.ForeColor = Color.Black;
          }

          private void btnCapnhat_MouseLeave(object sender, EventArgs e)
          {
               btnCapnhat.BackColor = Color.Blue;
          }

          private void btnCapnhat_MouseMove(object sender, MouseEventArgs e)
          {
               btnCapnhat.BackColor = Color.Red;
          }

          private void btnSuadv_MouseMove(object sender, MouseEventArgs e)
          {
               btnSuadv.BackColor = Color.Red;
          }

          private void btnSuadv_MouseLeave(object sender, EventArgs e)
          {
               btnSuadv.BackColor = Color.Blue;
          }

          private void btnThemdv_MouseMove(object sender, MouseEventArgs e)
          {
               btnThemdv.BackColor = Color.Red;
          }

          private void btnThemdv_MouseLeave(object sender, EventArgs e)
          {
               btnThemdv.BackColor = Color.Blue;
          }

          private void btnXoadv_MouseMove(object sender, MouseEventArgs e)
          {
               btnXoadv.BackColor = Color.Red;
          }

          private void btnXoadv_MouseLeave(object sender, EventArgs e)
          {
               btnXoadv.BackColor = Color.Blue;
          }

          private void btnExit_Suadv_MouseMove(object sender, MouseEventArgs e)
          {
               btnExit_Suadv.BackColor = Color.Bisque;
          }

          private void btnExit_Suadv_MouseLeave(object sender, EventArgs e)
          {
               btnExit_Suadv.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
          }

          private void btn_Capnhat_sua_MouseLeave(object sender, EventArgs e)
          {
               btn_Capnhat_sua.ForeColor = Color.Yellow;
          }

          private void btn_Capnhat_sua_MouseMove(object sender, MouseEventArgs e)
          {
               btn_Capnhat_sua.ForeColor = Color.Red;
          }

          private void btnExít_themdichvu_MouseMove(object sender, MouseEventArgs e)
          {
               btnExít_themdichvu.BackColor = Color.Bisque;
          }

          private void btnExít_themdichvu_MouseLeave(object sender, EventArgs e)
          {
               btnExít_themdichvu.BackColor = Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
          }

          private void btnAdd_dichvu_MouseLeave(object sender, EventArgs e)
          {
               btnAdd_dichvu.ForeColor = Color.Yellow;
          }

          private void btnAdd_dichvu_MouseMove(object sender, MouseEventArgs e)
          {
               btnAdd_dichvu.ForeColor = Color.Red;
          }
     }
}

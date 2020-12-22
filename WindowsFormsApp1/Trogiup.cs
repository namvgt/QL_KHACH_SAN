using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Trogiup : UserControl
    {
        public Trogiup()
        {
            InitializeComponent();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
           
        }

        private void btndoipass_Click(object sender, EventArgs e)
        {

        }

        private void btndoipass_Leave(object sender, EventArgs e)
        {

        }

        private void btndoipass_MouseMove(object sender, MouseEventArgs e)
        {
            btndoipass.BackColor = Color.Red;
        }

        private void btnDangxuat_MouseMove(object sender, MouseEventArgs e)
        {
            btnDangxuat.BackColor = Color.Red;
        }

        private void btnDangxuat_MouseLeave(object sender, EventArgs e)
        {
            btnDangxuat.BackColor = Color.Blue;
        }

        private void btndoipass_MouseLeave(object sender, EventArgs e)
        {
            btndoipass.BackColor = Color.Blue;
        }
    }
}

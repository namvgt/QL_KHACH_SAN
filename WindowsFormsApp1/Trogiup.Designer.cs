namespace WindowsFormsApp1
{
    partial class Trogiup
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btndoipass = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.GhostWhite;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(532, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 49);
            this.label10.TabIndex = 115;
            this.label10.Text = "TRỢ GIÚP";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDangxuat);
            this.groupBox4.Controls.Add(this.btndoipass);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox4.Location = new System.Drawing.Point(412, 95);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(488, 125);
            this.groupBox4.TabIndex = 116;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BackColor = System.Drawing.Color.Blue;
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
            this.btnDangxuat.Location = new System.Drawing.Point(266, 34);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(183, 60);
            this.btnDangxuat.TabIndex = 3;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.UseVisualStyleBackColor = false;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            this.btnDangxuat.MouseLeave += new System.EventHandler(this.btnDangxuat_MouseLeave);
            this.btnDangxuat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDangxuat_MouseMove);
            // 
            // btndoipass
            // 
            this.btndoipass.BackColor = System.Drawing.Color.Blue;
            this.btndoipass.FlatAppearance.BorderSize = 0;
            this.btndoipass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoipass.ForeColor = System.Drawing.Color.White;
            this.btndoipass.Location = new System.Drawing.Point(34, 34);
            this.btndoipass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndoipass.Name = "btndoipass";
            this.btndoipass.Size = new System.Drawing.Size(183, 60);
            this.btndoipass.TabIndex = 0;
            this.btndoipass.Text = "Đổi mật khẩu";
            this.btndoipass.UseVisualStyleBackColor = false;
            this.btndoipass.Click += new System.EventHandler(this.btndoipass_Click);
            this.btndoipass.Leave += new System.EventHandler(this.btndoipass_Leave);
            this.btndoipass.MouseLeave += new System.EventHandler(this.btndoipass_MouseLeave);
            this.btndoipass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndoipass_MouseMove);
            // 
            // Trogiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Trogiup";
            this.Size = new System.Drawing.Size(1425, 754);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btndoipass;
    }
}

namespace WindowsFormsApp1
{
    partial class DatPhong
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_datphong = new System.Windows.Forms.Button();
            this.grbx_dschuathue = new System.Windows.Forms.GroupBox();
            this.lv_dsdathue = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_phutrach = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_trangthai = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_trangbi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_loaiphong = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.btn_dsphong = new System.Windows.Forms.Button();
            this.grbx_dschuathue.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_datphong
            // 
            this.btn_datphong.BackColor = System.Drawing.Color.Blue;
            this.btn_datphong.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_datphong.FlatAppearance.BorderSize = 0;
            this.btn_datphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_datphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datphong.ForeColor = System.Drawing.Color.White;
            this.btn_datphong.Location = new System.Drawing.Point(634, 16);
            this.btn_datphong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_datphong.Name = "btn_datphong";
            this.btn_datphong.Size = new System.Drawing.Size(227, 43);
            this.btn_datphong.TabIndex = 9;
            this.btn_datphong.Text = "Đặt phòng";
            this.btn_datphong.UseVisualStyleBackColor = false;
            this.btn_datphong.Click += new System.EventHandler(this.btn_datphong_Click);
            // 
            // grbx_dschuathue
            // 
            this.grbx_dschuathue.Controls.Add(this.lv_dsdathue);
            this.grbx_dschuathue.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbx_dschuathue.ForeColor = System.Drawing.Color.Crimson;
            this.grbx_dschuathue.Location = new System.Drawing.Point(34, 253);
            this.grbx_dschuathue.Margin = new System.Windows.Forms.Padding(4);
            this.grbx_dschuathue.Name = "grbx_dschuathue";
            this.grbx_dschuathue.Padding = new System.Windows.Forms.Padding(4);
            this.grbx_dschuathue.Size = new System.Drawing.Size(565, 247);
            this.grbx_dschuathue.TabIndex = 8;
            this.grbx_dschuathue.TabStop = false;
            this.grbx_dschuathue.Text = "Danh sách phòng chưa thuê";
            // 
            // lv_dsdathue
            // 
            this.lv_dsdathue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lv_dsdathue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.lv_dsdathue.FullRowSelect = true;
            this.lv_dsdathue.GridLines = true;
            this.lv_dsdathue.HideSelection = false;
            this.lv_dsdathue.Location = new System.Drawing.Point(9, 27);
            this.lv_dsdathue.Margin = new System.Windows.Forms.Padding(4);
            this.lv_dsdathue.Name = "lv_dsdathue";
            this.lv_dsdathue.Size = new System.Drawing.Size(545, 202);
            this.lv_dsdathue.TabIndex = 0;
            this.lv_dsdathue.UseCompatibleStateImageBehavior = false;
            this.lv_dsdathue.View = System.Windows.Forms.View.Details;
            this.lv_dsdathue.Click += new System.EventHandler(this.lv_dsdathue_Click);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Mã";
            this.columnHeader15.Width = 37;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tên phòng";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 72;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Loại phòng";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader17.Width = 76;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Trang bị";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader18.Width = 159;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Đơn giá";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Mã bộ phận";
            this.columnHeader20.Width = 0;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "trạng thái";
            this.columnHeader21.Width = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_dongia);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_phutrach);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_trangthai);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tb_trangbi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_loaiphong);
            this.groupBox2.Controls.Add(this.tb_ten);
            this.groupBox2.Controls.Add(this.tb_ma);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(565, 220);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng";
            // 
            // tb_dongia
            // 
            this.tb_dongia.Location = new System.Drawing.Point(404, 127);
            this.tb_dongia.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(132, 26);
            this.tb_dongia.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(315, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "Đơn giá :";
            // 
            // tb_phutrach
            // 
            this.tb_phutrach.Location = new System.Drawing.Point(404, 79);
            this.tb_phutrach.Margin = new System.Windows.Forms.Padding(4);
            this.tb_phutrach.Name = "tb_phutrach";
            this.tb_phutrach.Size = new System.Drawing.Size(132, 26);
            this.tb_phutrach.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(300, 84);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 22);
            this.label11.TabIndex = 12;
            this.label11.Text = "Phụ trách :";
            // 
            // tb_trangthai
            // 
            this.tb_trangthai.Location = new System.Drawing.Point(404, 32);
            this.tb_trangthai.Margin = new System.Windows.Forms.Padding(4);
            this.tb_trangthai.Name = "tb_trangthai";
            this.tb_trangthai.Size = new System.Drawing.Size(132, 26);
            this.tb_trangthai.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(296, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 22);
            this.label12.TabIndex = 10;
            this.label12.Text = "Trạng thái :";
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(36, 175);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "Trang bị :";
            // 
            // tb_trangbi
            // 
            this.tb_trangbi.Location = new System.Drawing.Point(131, 171);
            this.tb_trangbi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_trangbi.Name = "tb_trangbi";
            this.tb_trangbi.Size = new System.Drawing.Size(405, 26);
            this.tb_trangbi.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(17, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Loại phòng :";
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(69, 82);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 23);
            this.label15.TabIndex = 5;
            this.label15.Text = "Tên :";
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(75, 37);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Mã :";
            // 
            // tb_loaiphong
            // 
            this.tb_loaiphong.Location = new System.Drawing.Point(131, 126);
            this.tb_loaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.tb_loaiphong.Name = "tb_loaiphong";
            this.tb_loaiphong.Size = new System.Drawing.Size(132, 26);
            this.tb_loaiphong.TabIndex = 3;
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(131, 79);
            this.tb_ten.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(132, 26);
            this.tb_ten.TabIndex = 1;
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(131, 33);
            this.tb_ma.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(80, 26);
            this.tb_ma.TabIndex = 0;
            // 
            // btn_dsphong
            // 
            this.btn_dsphong.BackColor = System.Drawing.Color.Blue;
            this.btn_dsphong.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btn_dsphong.FlatAppearance.BorderSize = 0;
            this.btn_dsphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsphong.ForeColor = System.Drawing.Color.White;
            this.btn_dsphong.Location = new System.Drawing.Point(634, 84);
            this.btn_dsphong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dsphong.Name = "btn_dsphong";
            this.btn_dsphong.Size = new System.Drawing.Size(227, 43);
            this.btn_dsphong.TabIndex = 10;
            this.btn_dsphong.Text = "Danh sách phòng";
            this.btn_dsphong.UseVisualStyleBackColor = false;
            this.btn_dsphong.Click += new System.EventHandler(this.button2_Click);
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 527);
            this.Controls.Add(this.btn_dsphong);
            this.Controls.Add(this.btn_datphong);
            this.Controls.Add(this.grbx_dschuathue);
            this.Controls.Add(this.groupBox2);
            this.Name = "DatPhong";
            this.Text = "DatPhong";
            this.grbx_dschuathue.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_datphong;
        private System.Windows.Forms.GroupBox grbx_dschuathue;
        private System.Windows.Forms.ListView lv_dsdathue;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_phutrach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_trangthai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_trangbi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_loaiphong;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.Button btn_dsphong;
    }
}
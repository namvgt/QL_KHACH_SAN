using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class DangNhap
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
               this.label4 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.Username = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.button1 = new System.Windows.Forms.Button();
               this.label3 = new System.Windows.Forms.Label();
               this.Password = new System.Windows.Forms.TextBox();
               this.pictureBox5 = new System.Windows.Forms.PictureBox();
               this.pictureBox4 = new System.Windows.Forms.PictureBox();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
               this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.Maroon;
               this.label4.Location = new System.Drawing.Point(205, 417);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(54, 19);
               this.label4.TabIndex = 8;
               this.label4.Text = "Sign up";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(77, 417);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(132, 19);
               this.label5.TabIndex = 9;
               this.label5.Text = "Don\'t have account?";
               // 
               // Username
               // 
               this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(153)))));
               this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.Username.ForeColor = System.Drawing.SystemColors.Info;
               this.Username.Location = new System.Drawing.Point(108, 207);
               this.Username.Name = "Username";
               this.Username.Size = new System.Drawing.Size(159, 13);
               this.Username.TabIndex = 3;
               this.Username.Text = "User Name";
               this.Username.Click += new System.EventHandler(this.Username_Click);
               this.Username.Enter += new System.EventHandler(this.Username_Enter);
               this.Username.Leave += new System.EventHandler(this.Username_Leave);
               // 
               // label1
               // 
               this.label1.BackColor = System.Drawing.Color.DimGray;
               this.label1.Location = new System.Drawing.Point(79, 225);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(180, 2);
               this.label1.TabIndex = 11;
               // 
               // label2
               // 
               this.label2.BackColor = System.Drawing.Color.DimGray;
               this.label2.Location = new System.Drawing.Point(79, 273);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(180, 2);
               this.label2.TabIndex = 12;
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(122)))), ((int)(((byte)(203)))));
               this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
               this.button1.FlatAppearance.BorderSize = 0;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.Color.Black;
               this.button1.Location = new System.Drawing.Point(77, 305);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(182, 31);
               this.button1.TabIndex = 13;
               this.button1.Text = "Sign in";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.label3.ForeColor = System.Drawing.Color.Maroon;
               this.label3.Location = new System.Drawing.Point(91, 355);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(154, 38);
               this.label3.TabIndex = 14;
               this.label3.Text = "Tên tài khoản hoặc mật \r\n  khẩu không chính xác";
               this.label3.Visible = false;
               // 
               // Password
               // 
               this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(153)))));
               this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.Password.ForeColor = System.Drawing.SystemColors.Info;
               this.Password.Location = new System.Drawing.Point(108, 255);
               this.Password.Name = "Password";
               this.Password.Size = new System.Drawing.Size(159, 13);
               this.Password.TabIndex = 4;
               this.Password.Text = "Password";
               this.Password.Click += new System.EventHandler(this.Password_Click);
               this.Password.Enter += new System.EventHandler(this.Password_Enter);
               this.Password.Leave += new System.EventHandler(this.Password_Leave);
               // 
               // pictureBox5
               // 
               this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.eye;
               this.pictureBox5.Location = new System.Drawing.Point(255, 246);
               this.pictureBox5.Name = "pictureBox5";
               this.pictureBox5.Size = new System.Drawing.Size(27, 28);
               this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox5.TabIndex = 15;
               this.pictureBox5.TabStop = false;
               this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
               // 
               // pictureBox4
               // 
               this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
               this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.exit2;
               this.pictureBox4.Location = new System.Drawing.Point(309, 1);
               this.pictureBox4.Name = "pictureBox4";
               this.pictureBox4.Size = new System.Drawing.Size(23, 22);
               this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox4.TabIndex = 10;
               this.pictureBox4.TabStop = false;
               this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
               // 
               // pictureBox3
               // 
               this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.username;
               this.pictureBox3.Location = new System.Drawing.Point(73, 193);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(29, 28);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox3.TabIndex = 2;
               this.pictureBox3.TabStop = false;
               // 
               // pictureBox2
               // 
               this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
               this.pictureBox2.Location = new System.Drawing.Point(73, 244);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(29, 28);
               this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox2.TabIndex = 1;
               this.pictureBox2.TabStop = false;
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
               this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._60582800_hotel_icon_hotel_vector_isolated_on_white_background__removebg_preview__1_;
               this.pictureBox1.Location = new System.Drawing.Point(78, 12);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(167, 211);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // DangNhap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(153)))));
               this.ClientSize = new System.Drawing.Size(332, 497);
               this.Controls.Add(this.pictureBox5);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.pictureBox4);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.Password);
               this.Controls.Add(this.Username);
               this.Controls.Add(this.pictureBox3);
               this.Controls.Add(this.pictureBox2);
               this.Controls.Add(this.pictureBox1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "DangNhap";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username;
        private TextBox Password;
        private PictureBox pictureBox5;
    }
}


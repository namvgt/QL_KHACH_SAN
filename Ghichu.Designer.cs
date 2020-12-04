namespace WindowsFormsApp1
{
    partial class Ghichu
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
               this.SuspendLayout();
               // 
               // label10
               // 
               this.label10.BackColor = System.Drawing.Color.GhostWhite;
               this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label10.ForeColor = System.Drawing.Color.Red;
               this.label10.Location = new System.Drawing.Point(0, 458);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(950, 32);
               this.label10.TabIndex = 115;
               this.label10.Text = "CODE BY : NHÓM 6";
               this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // Ghichu
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.label10);
               this.Name = "Ghichu";
               this.Size = new System.Drawing.Size(950, 490);
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
    }
}

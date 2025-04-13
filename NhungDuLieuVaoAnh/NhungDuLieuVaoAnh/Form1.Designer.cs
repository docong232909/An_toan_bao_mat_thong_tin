namespace NhungDuLieuVaoAnh
{
    partial class Form1
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
            this.radMaHoa = new System.Windows.Forms.RadioButton();
            this.radGiaiMa = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuLieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radMaHoa
            // 
            this.radMaHoa.AutoSize = true;
            this.radMaHoa.Location = new System.Drawing.Point(61, 335);
            this.radMaHoa.Name = "radMaHoa";
            this.radMaHoa.Size = new System.Drawing.Size(73, 20);
            this.radMaHoa.TabIndex = 0;
            this.radMaHoa.TabStop = true;
            this.radMaHoa.Text = "Mã hóa";
            this.radMaHoa.UseVisualStyleBackColor = true;
            this.radMaHoa.Click += new System.EventHandler(this.radMaHoa_CheckedChanged);
            // 
            // radGiaiMa
            // 
            this.radGiaiMa.AutoSize = true;
            this.radGiaiMa.Location = new System.Drawing.Point(61, 361);
            this.radGiaiMa.Name = "radGiaiMa";
            this.radGiaiMa.Size = new System.Drawing.Size(74, 20);
            this.radGiaiMa.TabIndex = 1;
            this.radGiaiMa.TabStop = true;
            this.radGiaiMa.Text = "Giải mã";
            this.radGiaiMa.UseVisualStyleBackColor = true;
            this.radGiaiMa.Click += new System.EventHandler(this.radGiaiMa_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 198);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(179, 254);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(112, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm kiếm ảnh";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(199, 346);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 4;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(64, 226);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(355, 22);
            this.txtDuongDan.TabIndex = 5;
            this.txtDuongDan.Text = "Đường dẫn tới ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lựa chọn";
            // 
            // txtDuLieu
            // 
            this.txtDuLieu.Location = new System.Drawing.Point(64, 387);
            this.txtDuLieu.Name = "txtDuLieu";
            this.txtDuLieu.Size = new System.Drawing.Size(355, 22);
            this.txtDuLieu.TabIndex = 8;
            this.txtDuLieu.Text = "Nội dung mã hóa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.txtDuLieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radGiaiMa);
            this.Controls.Add(this.radMaHoa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radMaHoa;
        private System.Windows.Forms.RadioButton radGiaiMa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuLieu;
    }
}


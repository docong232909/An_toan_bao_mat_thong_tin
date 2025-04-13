using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhungDuLieuVaoAnh
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void radGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (radGiaiMa.Checked)
            {
                radMaHoa.Checked = false;
                txtDuLieu.ReadOnly = true;
            }
        }

        private void radMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (radMaHoa.Checked)
            {
                radGiaiMa.Checked = false;
                txtDuLieu.ReadOnly = false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Ảnh định dạng bmp (*.bmp) | *.bmp";
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = od.FileName;

                // Hiển thị ảnh trong PictureBox
                pictureBox1.Image = new Bitmap(od.FileName);
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (radMaHoa.Checked)
            {
                // Mã hóa
                if (!File.Exists(txtDuongDan.Text))
                {
                    MessageBox.Show("Bạn phải chọn tệp tin ảnh");
                    btnTim.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtDuLieu.Text))
                {
                    MessageBox.Show("Bạn phải nhập dữ liệu cần nhúng vào ảnh");
                    txtDuLieu.Focus();
                    return;
                }

                string bits = StringToBinary(txtDuLieu.Text);
                Bitmap bmp = new Bitmap(txtDuongDan.Text);

                if (bits.Length > bmp.Width * bmp.Height)
                {
                    MessageBox.Show("Dữ liệu quá lớn so với ảnh đã chọn.");
                    return;
                }

                for (int i = 0; i < bits.Length; i++)
                {
                    int x = i % bmp.Width;
                    int y = i / bmp.Width;
                    Color px = bmp.GetPixel(x, y);
                    int rEncrypted = EncryptPixel(px.R, bits[i].ToString());
                    Color encryptedPixel = Color.FromArgb(px.A, rEncrypted, px.G, px.B);
                    bmp.SetPixel(x, y, encryptedPixel);
                }

                // Ghi độ dài dữ liệu (tính theo ký tự) vào kênh R của pixel cuối cùng
                int x1 = bmp.Width - 1;
                int y1 = bmp.Height - 1;
                Color lastPx = bmp.GetPixel(x1, y1);
                Color modifiedLastPx = Color.FromArgb(lastPx.A, txtDuLieu.Text.Length, lastPx.G, lastPx.B);
                bmp.SetPixel(x1, y1, modifiedLastPx);

                // Lưu ảnh mới
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Ảnh định dạng bmp (*.bmp) | *.bmp";
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(sd.FileName);
                    MessageBox.Show("Nhúng dữ liệu thành công!");
                    txtDuLieu.Text = "";
                    txtDuongDan.Text = "";
                }

                bmp.Dispose();
            }
            else if (radGiaiMa.Checked)
            {
                // Giải mã
                if (!File.Exists(txtDuongDan.Text))
                {
                    MessageBox.Show("Bạn phải chọn tệp tin ảnh");
                    btnTim.Focus();
                    return;
                }

                Bitmap bmp = new Bitmap(txtDuongDan.Text);
                int x1 = bmp.Width - 1;
                int y1 = bmp.Height - 1;
                Color lastPx = bmp.GetPixel(x1, y1);
                int dataLength = lastPx.R; // Số ký tự
                int totalBits = dataLength * 8;

                StringBuilder bits = new StringBuilder();

                for (int i = 0; i < totalBits; i++)
                {
                    int x = i % bmp.Width;
                    int y = i / bmp.Width;
                    Color px = bmp.GetPixel(x, y);
                    bits.Append(DecryptPixel(px.R));
                }

                string result = BinaryToString(bits.ToString());
                txtDuLieu.Text = result;
                MessageBox.Show("Giải mã thành công!");
            }
        }

        private int EncryptPixel(byte r, string bit)
        {
            if (bit == "0")
            {
                return (r % 2 == 0) ? r : (r - 1 + 256) % 256;
            }
            else
            {
                return (r % 2 == 1) ? r : (r + 1) % 256;
            }
        }

        private string DecryptPixel(byte r)
        {
            return (r % 2 == 0) ? "0" : "1";
        }

        private string StringToBinary(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in text.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }

        private string BinaryToString(string bits)
        {
            List<byte> byteList = new List<byte>();
            for (int i = 0; i < bits.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(bits.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
    }
}

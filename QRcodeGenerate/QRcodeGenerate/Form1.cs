using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QRcodeGenerate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string URL = urlBox.Text;

            QRCodeEncoder encoder=new QRCodeEncoder();
            Bitmap qrcoder=encoder.Encode(URL);

            qrimage.Image=qrcoder as Image;
            urlBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp|GIP|.gif";
            if(s.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                qrimage.Image.Save(s.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog o=new OpenFileDialog();
            if(o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                qrimage.ImageLocation = o.FileName;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder =new  QRCodeDecoder();
            MessageBox.Show(decoder.decode(new QRCodeBitmapImage(qrimage.Image as Bitmap)));
        }
    }
}

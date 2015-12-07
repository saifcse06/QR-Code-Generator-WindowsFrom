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
using System.Diagnostics;
using System.IO;

namespace QRcodeGenerate
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            idBox.Hide();
            saveButton.Hide();
            Id.Hide();

            string path = Environment.CurrentDirectory + "/" + "abc.txt";
            if (!File.Exists(path))
            {
                File.CreateText(path);
            }

            using (StreamReader red = new StreamReader(path))
            {
                string text = red.ReadLine();
                //text = text.Trim();
                if (text == null)
                {
                    idBox.Show();
                    saveButton.Show();
                    Id.Show();
                }
                else if (text == string.Empty)
                {
                    idBox.Show();
                    saveButton.Show();
                    Id.Show();
                }
            }
            
        }
            
        string path = Environment.CurrentDirectory + "/" + "abc.txt";
          
        private void button1_Click(object sender, EventArgs e)
        {

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
 
            
                QRCodeDecoder decoder = new QRCodeDecoder();
                MessageBox.Show(decoder.decode(new QRCodeBitmapImage(qrimage.Image as Bitmap)));
           
            
            
            
        
        }

        private void qrimage_Click(object sender, EventArgs e)
        {

        }

        private void urlBox_KeyUp(object sender, KeyEventArgs e)
        {
            string URL = urlBox.Text;
            string yourid = URL.Substring(0,4);
            using (StreamReader red = new StreamReader(path))
            {
                string text = red.ReadLine();
                string textid = text.Substring(0, 4);
                if (yourid == textid)
                {
                    text = text.Insert(3, URL);
                    QRCodeEncoder encoder = new QRCodeEncoder();
                    Bitmap qrcoder = encoder.Encode(URL);
                    qrimage.Image = qrcoder as Image;
                    
                }
                else
                {
                    MessageBox.Show("id not found!");
                }
            }        

            
             
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkClickedEventArgs e)
        {
            ////this.linkLabel.LinkVisited = true;

            //// Navigate to a URL.
            //System.Diagnostics.Process.Start("http://www.asofttask.com/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.asofttask.com/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Id.Text = openFileDialog1.FileName;
                idBox.Text = File.ReadAllText(Id.Text);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    File.WriteAllText(saveFileDialog1.FileName, idBox.Text);
                
            //}
           using(StreamWriter sa=new StreamWriter(path))
           {
               sa.WriteLine(idBox.Text);
                
           }

           idBox.Clear();
           idBox.Hide();
           saveButton.Hide();
           Id.Hide();
           MessageBox.Show("Register SuccessFull!!");
           //using (StreamReader red = new StreamReader(path))
           //{
           //    string text = red.ReadLine();
           //    //text = text.Trim();
           //    if (text != null)
           //    {
           //        idBox.Hide();
           //        saveButton.Hide();

           //    }
           //    else if (text != string.Empty)
           //    {
           //        idBox.Hide();
           //        saveButton.Hide();
           //    }
           //}
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string URL = urlBox.Text;
            string yourid = URL.Substring(0, 4);
            using (StreamReader red = new StreamReader(path))
            {
                string text = red.ReadLine();
                string textid = text.Substring(0, 4);
                if (yourid == textid)
                {
                    text = text.Insert(3, URL);
                    QRCodeEncoder encoder = new QRCodeEncoder();
                    Bitmap qrcoder = encoder.Encode(URL);
                    qrimage.Image = qrcoder as Image;

                }
                else
                {
                    MessageBox.Show("id not found!");
                }
            }        

        }

        private void savecodeButton_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + "/" + "qrcodesave.txt";
            string code = "";
            using(StreamReader savered=new StreamReader(path)){
                code= savered.ReadLine();
            }

            if (!File.Exists(path))
            {
                File.CreateText(path);
            }
            using(StreamWriter sacode=new StreamWriter(path)){

                sacode.WriteLine(code + "," + urlBox.Text);

            }
            urlBox.Clear();
        }
    }
}

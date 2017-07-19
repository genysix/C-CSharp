using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacheJpeg
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
    }

        Stream myStream1, myStream2;
        public static string strPassword = "";

        private int ConvertHex()
        {
            int i = myStream1.ReadByte(), j = myStream1.ReadByte(), k = myStream1.ReadByte(), l = myStream1.ReadByte(), m = 0;
            m = l * 16777216 + k * 65536 + j * 256 + i * 1;

            return m;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Form2 t = new Form2(true);
            t.ShowDialog();
            CacheJpeg(false);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            Form2 t = new Form2(false);
            t.ShowDialog();
            CacheJpeg(true);
        }

        private void CacheJpeg(bool ShowHide)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Sélectionnez le fichier JPEG";
            openFileDialog1.Filter = "JPG (*.jpg,*.jpeg)|*.jpg;*.jpeg";
            openFileDialog1.RestoreDirectory = true;

            OpenFileDialog info = new OpenFileDialog();

            info.FilterIndex = 1;
            info.Title = "Sélectionnez le fichier Bitmap";
            info.Filter = "bitmap (*.bmp)|*.bmp";
            info.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK && info.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    myStream1 = openFileDialog1.OpenFile();
                    
                    if (ShowHide == false)
                    {
                        FileStream theFile = new FileStream(info.FileName, FileMode.Open, FileAccess.ReadWrite);
                        StreamWriter sw = new StreamWriter(theFile);

                        theFile.ReadByte(); theFile.ReadByte(); theFile.ReadByte(); theFile.ReadByte();

                        sw.Write(myStream1.Length);

                        
                        for (int i = 0; i < strPassword.Length * 50; i++)
                        {
                            theFile.ReadByte();
                        }

                        sw.Write(strPassword);

                        /*byte[] File = new byte[myStream1.Length];

                        for (int i = 0; i < myStream1.Length; i++)
                        {
                            File[i] = (byte)myStream1.ReadByte();
                        }

                        for (int i = 0; i < myStream1.Length; i++)
                        {
                            sw.Write(File[i]);
                        }

                        myStream2.Seek(0, SeekOrigin.Begin);

                        /*for (int i =0; i< strPassword.Length;i++)
                        {
                            if(strPassword[i])
                            myStream2.WriteByte = myStream2.ReadByte
                        }

                        int iByteStream1 = 0, iByteStream2 = 0, h =0;
                        
                        for (int i = 0; i < myStream1.Length; i++)
                        {
                            iByteStream2 = myStream2.ReadByte();
                            if (i % 7 == 0)
                            {
                                h++;
                                if (h == 8)
                                {
                                    iByteStream1 = myStream1.ReadByte();
                                    
                                }
                            }
                        }*/
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

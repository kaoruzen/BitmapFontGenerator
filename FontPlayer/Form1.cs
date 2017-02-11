using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FontPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFontPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "";
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "FontFile(*.dat)|*.dat|すべてのファイル(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(ofd.FileName);
                textBoxFontFile.Text = ofd.FileName;

                if(File.Exists(textBoxFontFile.Text) && File.Exists(textBoxTextFile.Text))
                {
                    Rendering();
                }
            }
        }

        private void buttonTextPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "";
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "TextFile(*.txt)|*.txt|すべてのファイル(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(ofd.FileName);
                textBoxTextFile.Text = ofd.FileName;

                if (File.Exists(textBoxFontFile.Text) && File.Exists(textBoxTextFile.Text))
                {
                    Rendering();
                }
            }
        }


        private void Rendering()
        {
            int[,] graphicRam = new int[128, 64];

            for(int i=0; i<128; i++)
            {
                for(int j=0; j<64; j++)
                {
                    graphicRam[i, j] = 0;
                }
            }


            //テキストファイルのバイナリ読み出し
            FileStream fsTxt = new FileStream(textBoxTextFile.Text, FileMode.Open, FileAccess.Read);

            int txtFileSize = (int)fsTxt.Length;
            byte[] buf = new byte[2];
            int txtNokori = txtFileSize;
            int txtPointer = 0;

            int charPosX = 0;
            int charPosY = 0;

            while(txtNokori > 0)
            {
                bool halfSize = false;

                fsTxt.Seek(txtPointer, SeekOrigin.Begin);
                int readSize = fsTxt.Read(buf, 0, Math.Min(2, txtNokori));  //2byteずつ読み込み
                
                txtPointer += readSize;
                txtNokori -= readSize;



                //上位バイトが0x81未満ならば、ASCII (1byte文字)
                byte[] fontData;
                if(buf[0] < 0x81)   //半角
                {
                    byte[] sjis = new byte[] {buf[0], 0x00};
                    Console.WriteLine(" " + BitConverter.ToString(sjis));
                    fontData = getFontData(sjis, (int)numericUpDownFontSize.Value);
                    
                    //ポインタを1バイト戻す
                    txtPointer--;
                    txtNokori++;

                    halfSize = true;
                }
                else
                {
                    //全角
                    Console.WriteLine(" " + BitConverter.ToString(buf));
                    fontData = getFontData(buf, (int)numericUpDownFontSize.Value);

                    halfSize = false;
                }

                

                //フォント領域のグラフィックデータを作成
                int[,] charData = new int[(int)numericUpDownFontSize.Value, (int)numericUpDownFontSize.Value];
                int ptr = 0;
                for (int x = 0; x < (int)numericUpDownFontSize.Value; x++)
                {
                    for (int y = 0; y < (int)numericUpDownFontSize.Value; y++)
                    {
                        charData[x, y] = (fontData[(int)(ptr / 8)] >> ptr % 8 ) & (0x01);
                        ptr++;
                    }
                }


                //グラフィックRAMに書き出し
                for (int x = 0; x < (int)numericUpDownFontSize.Value; x++)
                {
                    for (int y = 0; y < (int)numericUpDownFontSize.Value; y++)
                    {
                        graphicRam[x + charPosX, y + charPosY] = charData[y, x];
                    }
                }

                //次の座標へ移動
                if (halfSize == true)
                {
                    charPosX += (int)(numericUpDownFontSize.Value / 2) + 4;
                }
                else
                {
                    charPosX += (int)numericUpDownFontSize.Value;
                }


                if (charPosX > 128 - (int)numericUpDownFontSize.Value)
                {
                    charPosY += (int)numericUpDownFontSize.Value;
                    charPosX = 0;
                }


                //領域を超えたら終了
                if(charPosY > 64 - (int)numericUpDownFontSize.Value )
                {
                    break;
                }

            }



            //画面に描画
            Bitmap bmp = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(Brushes.OliveDrab, new Rectangle(0, 0, bmp.Width, bmp.Height));

            for(int i=0; i< 128; i++)
            {
                for(int j=0; j<64; j++)
                {
                    if (graphicRam[i, j] > 0)
                    {
                        g.FillRectangle(Brushes.Black, new Rectangle(i * 5, j * 5, 4, 4));
                    }
                }
            }

            pictureBoxCanvas.Image = bmp;
            g.Dispose();


        }


        private byte[] getFontData(byte[] sjis , int fontsize)
        {
            //フォントファイルのバイナリ読み出し
            FileStream fsFnt = new FileStream(textBoxFontFile.Text, FileMode.Open, FileAccess.Read);
            long length = fsFnt.Length;

            int bytesize = (fontsize * fontsize) / 8;
            if((fontsize * fontsize) % 8 != 0)
            {
                bytesize++;
            }

            byte[] charData = new byte[bytesize];

            //フォント格納アドレスの計算
            int pointer = (int)((uint)sjis[0] * 0x100 + (uint)sjis[1]) * bytesize;  //sjis[1]が下位

            fsFnt.Seek(pointer, SeekOrigin.Begin);

            fsFnt.Read(charData, 0, bytesize);

            Console.WriteLine(pointer.ToString() + "  " + BitConverter.ToString(charData));

            return charData;

        }


    }
}

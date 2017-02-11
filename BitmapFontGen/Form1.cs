using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BitmapFontGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool processing = false;

        public byte[] RenderForDisplay()
        {
            if(!File.Exists(textBoxFontName.Text))
            {
                byte[] err = new byte[0];
                return err;
            }

            if(textBoxChar.Text.Length == 0)
            {
                byte[] err = new byte[0];
                return err;
            }
            else
            {
                byte[] data = System.Text.Encoding.GetEncoding("shift_jis").GetBytes(textBoxChar.Text);
                labelSJIS.Text = BitConverter.ToString(data);
            }

            char ch = textBoxChar.Text[0];

            byte[] retData = Render(ch);

            labelData.Text = BitConverter.ToString(retData);

            return retData;
        }


        public byte[] Render(char ch)
        {
            Bitmap bmp = new Bitmap((int)numericUpDownFontSize.Value, (int)numericUpDownFontSize.Value);
            Graphics g = Graphics.FromImage(bmp);

            Bitmap disp = new Bitmap(pictureBoxGriph.Width, pictureBoxGriph.Height);
            Graphics dispG = Graphics.FromImage(disp);

            g.FillRectangle(Brushes.White, new Rectangle(0, 0, bmp.Width, bmp.Height));
            

            //Fontの選択
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(textBoxFontName.Text);
            
            //PrivateFontCollectionの先頭のフォントのFontオブジェクトを作成する
            System.Drawing.Font f;
            try
            {
                f = new System.Drawing.Font(pfc.Families[0], (float)numericUpDownSize.Value, FontStyle.Regular);
            }
            catch
            {

                MessageBox.Show("This font does not support \"Regular\" style.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                byte[] err = new byte[0];
                return err;
            }
            pfc.Dispose();

            g.DrawString(ch.ToString(), f, Brushes.Black, new PointF((float)numericUpDownX.Value, (float)numericUpDownY.Value));

            //pictureBoxGriph.Image = bmp;
            pictureBox1.Image = bmp;
            int count = 0;

            int haba = (pictureBoxGriph.Width / (int)numericUpDownFontSize.Value);
            dispG.FillRectangle(Brushes.OliveDrab, new Rectangle(0, 0, haba * (int)numericUpDownFontSize.Value + 1, haba * (int)numericUpDownFontSize.Value + 1));


            //FontDataの作成
            int[] data = new int[(int)numericUpDownFontSize.Value * (int)numericUpDownFontSize.Value];
            for (int y = 0; y < (int)numericUpDownFontSize.Value; y++)
            {
                for(int x = 0; x < (int)numericUpDownFontSize.Value; x++)
                {
                    //Color c = bmp.GetPixel(x, y);
                    if (bmp.GetPixel(x, y).R < (int)numericUpDownThreshold.Value)
                    {
                        data[y * (int)numericUpDownFontSize.Value + x] = 1;

                        
                        dispG.FillRectangle(Brushes.Black, new Rectangle(
                            x * haba,
                            y * haba,
                            haba - 1,
                            haba - 1));
                        //Console.Write("1");
                        count++;
                    }
                    else
                    {
                        data[y * (int)numericUpDownFontSize.Value + x] = 0;
                        //Console.Write("0");
                    }
                }
            }

            //Console.WriteLine("");
            //Console.WriteLine(count.ToString());

            pictureBoxGriph.Image = disp;


            //配列サイズの決定
            int size = data.Length / 8;
            if(data.Length % 8 > 0)
            {
                size++;
            }

            byte[] fontData = new byte[size];

            //byte型へ変換
            for (int i = 0; i < data.Length; i++)
            {
                //何バイト目？
                int bytePointer = i / 8;
                //何ビット目？
                int bitPointer = i % 8;

                if (data[i] == 1)
                {
                    fontData[bytePointer] |= (byte)(0x01 << bitPointer);
                }
                else
                {
                    fontData[bytePointer] |= (byte)(0x00 << bitPointer);
                }
            }

            g.Dispose();
            dispG.Dispose();

            return fontData;

        }

        private void evRenderForDisplay(object sender, EventArgs e)
        {
            if (processing == false)
            {
                RenderForDisplay();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.FileName = "";
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "FontFile(*.ttf)|*.ttf|すべてのファイル(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(ofd.FileName);
                textBoxFontName.Text = ofd.FileName;
            }
        }

        private void buttonSelectOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "";
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter ="BinaryFile(*.dat)|*.dat|すべてのファイル(*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(sfd.FileName);
                textBoxOutput.Text = sfd.FileName;
            }
        }


        public void GenerateFontFile()
        {

            processing = true;

            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");

            System.IO.FileStream fs = null;

            try
            {
                fs = new System.IO.FileStream(textBoxOutput.Text, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            }
            catch
            {
                MessageBox.Show("Couldn't write to fontfile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                processing = false;
                return;
            }


            textBoxChar.Enabled = false;
            textBoxFontName.Enabled = false;
            textBoxOutput.Enabled = false;
            numericUpDownFontSize.Enabled = false;
            numericUpDownSize.Enabled = false;
            numericUpDownThreshold.Enabled = false;
            numericUpDownX.Enabled = false;
            numericUpDownY.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            buttonSelectOutput.Enabled = false;

            int pointer = 0;
            int counter = 0;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 0xFFFF + 0x01;

            for(byte i=0x00; i<=0xFF; i++) //上位
            {
                for(byte j=0x00; j<=0xFF; j++)  //下位
                {
                    byte[] sjis = new byte[] {i,j};
                    char target = sjisEnc.GetString(sjis)[0];

                    labelSJIS.Text = i.ToString("X") + "-" + j.ToString("X");

                    textBoxChar.Text = target.ToString();
                    byte[] fontdata = Render(target);

                    fs.Write(fontdata, 0, fontdata.Length);
                    pointer += fontdata.Length;

                    counter++;
                    progressBar1.Value = counter;

                    Application.DoEvents();
                    
                    if(j==0xFF)
                    {
                        break;
                    }
                }
                if(i==0xFF)
                {
                    break;
                }
            }
            fs.Close();


            textBoxChar.Enabled = true;
            textBoxFontName.Enabled = true;
            textBoxOutput.Enabled = true;
            numericUpDownFontSize.Enabled = true;
            numericUpDownSize.Enabled = true;
            numericUpDownThreshold.Enabled = true;
            numericUpDownX.Enabled = true;
            numericUpDownY.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            buttonSelectOutput.Enabled = true;


            MessageBox.Show("Done.", "Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

            progressBar1.Value = 0;

            processing = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!File.Exists(textBoxFontName.Text))
            {
                MessageBox.Show("Couldn't find original font file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(textBoxOutput.Text.Length < 2)
            {
                MessageBox.Show("Please select output file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GenerateFontFile();
        }



    }
}

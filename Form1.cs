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

namespace EncryptingByBmp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            
            char[] unencryptedText = UnencryptedTextTB.Text.ToCharArray();
            int length = unencryptedText.Length;
            byte[] lang = new byte[length];
            byte[] asciibytes = new byte[length];
            for (int i = 0; i < length; i++)
            {
                if(unencryptedText[i] > 1000)
                {
                    lang[i] = 1;
                    asciibytes[i] = (byte)(unencryptedText[i] - 1000);
                }
                else
                {
                    lang[i] = 0;
                    asciibytes[i] = (byte)unencryptedText[i];
                }
            }
            //byte[] asciibytes = Encoding.ASCII.GetBytes(unencryptedText);

            int width = 0, height = 0;
            double preSize = 0;
            preSize = Math.Sqrt(length) % 1;
            if(preSize == 0)
            {
                width = Convert.ToInt32(Math.Sqrt(length));
                height = width;
            }
            else
            {
                width = Convert.ToInt32(Math.Sqrt(length));
                height = width + 1;
            }

            byte[][] symbols = new byte[height][];
            byte[][] langs = new byte[height][];
            for (int i = 0; i < height; i++)
            {
                symbols[i] = new byte[width];
                langs[i] = new byte[width];
            }

            int it = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (it < length)
                    {
                        symbols[i][j] = asciibytes[it];
                        langs[i][j] = lang[it];
                    }
                    else
                    {
                        symbols[i][j] = 0;
                        langs[i][j] = 0;
                    }
                    it++;
                }
            }

            if(width == 0 || height == 0)
            {
                MessageBox.Show("Вы ничего не ввели!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap bmp = new Bitmap(width, height);

            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Color color = new Color();
                    color = Color.FromArgb(symbols[i][j], langs[i][j], 0);
                    bmp.SetPixel(j, i, color);
                }
            }

            pictureBox1.Image = bmp;
        }

        private void SaveImageBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            dialog.CreatePrompt = true;
            dialog.CheckPathExists = true;

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs;
                try
                {
                    fs = new FileStream(dialog.FileName, FileMode.OpenOrCreate);
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    fs.Close();
                    MessageBox.Show("Изображение успешно сохранено!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void LoadImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "bmp files (*.bmp)|*.bmp";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            dialog.ShowReadOnly = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;

            String  filePath = "";
            Bitmap  fileContent;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                try
                {
                    fileContent = new Bitmap(filePath);
                    pictureBox2.Image = fileContent;

                    MessageBox.Show("Файл загружен.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }catch(Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void UnencryptBtn_Click(object sender, EventArgs e)
        {
            DecryptedTB.Text = "";
            try
            {
                Bitmap bmp = new Bitmap(pictureBox2.Image);

                int height = bmp.Height;
                int width = bmp.Width;

                String decrypted = "";
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Color color = bmp.GetPixel(j, i);
                        if (color.G == 0)
                        {
                            char c = (char)color.R;
                            decrypted += c;
                        }
                        else if (color.G == 1)
                        {
                            char c = (char)(color.R + 1000);
                            decrypted += c;
                        }
                    }
                }

                DecryptedTB.Text = decrypted;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Ошибка!");
            }
        }

        int SaveToFile(String text)
        {
            //создаем файлдиалог и настраиваем его свойства
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            dialog.CreatePrompt = true;
            dialog.CheckPathExists = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs;
                StreamWriter sw;
                String saveStr = text;

                try
                {
                    fs = new FileStream(dialog.FileName, FileMode.OpenOrCreate);
                    sw = new StreamWriter(fs);

                    sw.Write(saveStr);

                    sw.Close();
                    fs.Close();

                    MessageBox.Show("Файл сохранен.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 1;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            return 0;
        }

        private void SaveTextEnBtn_Click(object sender, EventArgs e)
        {
            SaveToFile(UnencryptedTextTB.Text);
        }

        private void SaveTextDeBtn_Click(object sender, EventArgs e)
        {
            SaveToFile(DecryptedTB.Text);
        }

        private void LoadTextEnBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            dialog.ShowReadOnly = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;

            String filePath = "";
            String fileContent = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                try
                {
                    Stream fileStream = dialog.OpenFile();
                    StreamReader reader = new StreamReader(fileStream);

                    fileContent = reader.ReadToEnd();

                    reader.Close();
                    fileStream.Close();
                    UnencryptedTextTB.Text = fileContent;
                    MessageBox.Show("Файл загружен.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}

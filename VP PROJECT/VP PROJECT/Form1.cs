using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // For encoding of text into image.
        //private void button1_Click(object sender, EventArgs e, int amount)
        //{
        //    Bitmap img = new Bitmap(DataTextBox.Text);

        //    int red, green, blue;
        //for (int i = 0; i < img.Width; i++)
        //    {
        //        for (int j = 0; j < img.Height; j++)
        //        {
        //            Color C = img.GetPixel(i, j);

        //            red = (C.R + amount > 255) ? 255 : (C.R + amount);
        //            green = (C.G + amount > 255) ? 255 : (C.G + amount);
        //            blue = (C.B + amount > 255) ? 255 : (C.B + amount);

        //            Bitmap.GetPixelFormatSize(i, j.color.);

        private void increase()




                }
                {
                    
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }





        // for the functionlity of the browse for image button using the openfiledialog option.

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "ImageFiles(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog()==DialogResult.OK)
            {
                PictureBox1.Image= new Bitmap(open.FileName);
                LocationTextBox.Text = open.FileName;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
            
                
            }
        }
    


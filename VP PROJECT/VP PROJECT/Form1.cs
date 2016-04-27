using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VP_PROJECT
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }


        // For encoding of text into image.


        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap img = new Bitmap(PicturexBox1Ali.Image);

            for (int i = 0; i < img.Width; i++)
            {
                for (int j = 0; j < img.Height; j++)
                {
                    Console.WriteLine("Width=" + i);
                    Console.WriteLine("height=" + j);


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
            if (open.ShowDialog() == DialogResult.OK)
            {
                PicturexBox1Ali.Image = new Bitmap(open.FileName);
                LocationTextBox.Text = open.FileName;
                MessageBox.Show("Image Opened!");
            
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            //save.ShowDialog();
            //save.RestoreDirectory = true;
            //save.Title = "saved image";
            save.Filter = "image (*.bmp)|*.bmp|PNG Files (*.png)|*.png";
    

            if (save.ShowDialog()==DialogResult.OK)
            {
                PicturexBox1Ali.Image.Save(save.FileName);
               // LocationTextBox.Text = save.FileName;
                MessageBox.Show("Image Is Saved Successfully");
            }



           
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms1 form = new Forms1();
            form.ShowDialog(this);
        }
    }
}


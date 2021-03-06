﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace VPP_Project
{
    public partial class Form1 : Form
    {
        private Bitmap bmp = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)ImagePictureBox.Image;

            string text = DataTextBox.Text;

            if (text.Equals(""))
            {
                MessageBox.Show("No Data For Encryption");
                return;
            }

            bmp = Steganographyhelp.encode(text, bmp);

            MessageBox.Show("Your text was hidden in the image successfully");
            Note.Text = "Note: don't forget to save your new image.";
            Note.ForeColor = Color.OrangeRed;
           
           
        }

        private void DataTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Filters (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                ImagePictureBox.Image = Image.FromFile(open.FileName);
            }
            Note.Text = "Note";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    ImagePictureBox.Image.Save(save.FileName);
                    MessageBox.Show("Your Image Has Been Saved Successfully.");
                    DataTextBox.Text = "";
                    Note.Text = "Note";
                    Note.ForeColor = Color.Black;
                    
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Source+""+ee.StackTrace);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Please Select and image(From File) \n 2. Write some text you want to hide in the image \n 3. Save the image(From File)");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Extract_Click(object sender, EventArgs e)
        {
            Note.Text = "Note: This is your hidden text";
       

       //The Extraction button that is used to decode the text out from the image.

            bmp = (Bitmap)ImagePictureBox.Image;

            string extractedText = Steganographyhelp.extractText(bmp);

            DataTextBox.Text = extractedText;
            if (DataTextBox.Text=="")
            {
                Note.Text = "Nothing is hidden";
                MessageBox.Show("No Hidden Text");
            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public bool IsMdiContainer { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void ImagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void clearScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTextBox.Text = "";
            Note.Text = "Note";
            ImagePictureBox.Image = Image.FromFile("C:/Users/Ali/Desktop/VP PROJECT INFORMATION/Practice Image.PNG");
            Note.ForeColor = Color.Black; 
        }

        
    }
}

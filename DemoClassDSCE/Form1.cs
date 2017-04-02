using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace DemoClassDSCE
{
    public partial class Form1 : Form
    {
        Bitmap originalImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if(openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                originalImage = new Bitmap(openDialog.FileName);
                pictureBox1.Image = originalImage;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 grayObj = new GrayscaleBT709();
            Bitmap grayImage = grayObj.Apply(originalImage);
            pictureBox2.Image = grayImage; 
        }
    }
}

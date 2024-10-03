using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteOnPicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string image;

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            image = openFileDialog1.FileName;
        }

        Color color;

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
        }

        Bitmap bitmap;

        private void btnWrite_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(image);
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawString(txtText.Text, new Font("Segoe UI", Convert.ToInt16(txtDimension.Text), FontStyle.Bold), new SolidBrush(color), 20, 30);
            pictureBox1.Image = bitmap;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Picture|.jpg";
            saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName);
        }
    }
}

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

namespace Forms2HW
{
 
    public partial class Form1 : Form
    {
        class BgImages
        {
            public void AddImage(string path)
            {
                urls.Add(path);
            }
            public Image GetRandomImage()
            {
                if (urls.Count == 0)
                {
                    throw new Exception("Haven`t images");
                }
                Random rnd = new Random();
                return Image.FromFile(urls[rnd.Next(urls.Count)]);
            }
            public int CountImages { get => urls.Count; }
            List<string> urls = new List<string>();
        }
        private int count1 = 0;
        private int count2 = 0;
        BgImages bgImages = new BgImages();
        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundImages();
        }
        public void InitializeBackgroundImages()
        {
            bgImages.AddImage("../../../Resources/1.jpg");
            bgImages.AddImage("../../../Resources/2.jpeg");
            bgImages.AddImage("../../../Resources/3.jpg");
            bgImages.AddImage("../../../Resources/4.png");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Visible = true;
            this.label1.Text = (++this.count1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label2.Visible = true;
            this.label2.Text = (++this.count2).ToString();
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                MessageBox.Show("This is Max opacity", "OpacityWarning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Opacity += 0.1;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (this.Opacity <= 0.3)
            {
                MessageBox.Show("This is Min opacity", "OpacityWarning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            this.Opacity -= 0.1;
        }

        private void randomBgBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage=this.bgImages.GetRandomImage();
        }
    }
}

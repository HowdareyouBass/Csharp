using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        Image playerImage;
        Graphics graph;
        private int frame;
        private int animation;
        Stickman stick;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(DownKey);
            this.KeyUp += new KeyEventHandler(UpKey);
            playerImage = new Bitmap("D:\\Visual Proj\\Project\\resources\\img\\Stay_stick.png");
            stick = new Stickman(new Size(45, 78), 0, 150, playerImage, 3);
            graph = this.CreateGraphics();
            timer1.Interval = 40;
            timer2.Interval = 10;
            timer1.Tick += new EventHandler(Move);
            timer2.Tick += new EventHandler(Animate);
            timer1.Start();
            timer2.Start();
        }

        private void Animate(object sender, EventArgs e)
        {
            //graph.Clear(Color.White);
            graph.DrawImage(stick.StickmanImg, new Point(stick.x, stick.y));
            this.Invalidate();
        }

        private void UpKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "D")
            {
                animation = 0;
            }
            else if (e.KeyCode.ToString() == "A")
            {
                animation = 0;
            }
            if(e.KeyCode.ToString() == "W")
            {
                animation = 0;
            }
            this.Invalidate();
        }

        private void Move(object sender, EventArgs e)
        {
            switch (animation)
            {
                case 0:
                    break;
                case 1:
                    stick.Right();
                    break;
                case 2:
                    stick.Left();
                    break;
                case 3:
                    break;
            }
            this.Invalidate();
        }


        private void DownKey(object sender, KeyEventArgs e)
        {
           if(e.KeyCode.ToString() == "D")
            {
                animation = 1;
            }
           else if(e.KeyCode.ToString() == "A")
            {
                animation = 2;
            }
           if(e.KeyCode.ToString() == "W")
            {
                animation = 3;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics gro = e.Graphics;
            gro.DrawImage(stick.StickmanImg, new Point(stick.x, stick.y));
        }
    }
}

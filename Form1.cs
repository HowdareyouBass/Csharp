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
        private int frame;
        private int animation;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(keyboard);
        }

        private void keyboard(object sender, KeyEventArgs e)
        {
           switch (e.KeyCode.ToString())
            {
                case "W":
                    animation = 3;
                    break;
                case "D":
                    animation = 1;
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 2,pictureBox1.Location.Y);
                    break;
                case "A":
                    animation = 2;
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 2, pictureBox1.Location.Y);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

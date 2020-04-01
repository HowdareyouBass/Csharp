using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Stickman
    {
        public Image StickmanImg;
        public int x, y;
        public Size Siz;
        public int frame;
        public int animation;
        public int speed;
        public Stickman(Size Siz,int x,int y,Image StickmanImg,int speed)
        {
            this.x = x;
            this.y = y;
            this.Siz = Siz;
            this.StickmanImg = StickmanImg;
            this.speed = speed;
        }
        public void Left()
        {
            x -= speed;
        }
        public void Right()
        {
            x += speed;
        }
        public void Jump()
        {

        }
    }
}

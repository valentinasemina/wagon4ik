using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    class MyWagon:MyRectangle
    {
        public MyCircle wheel1 = new MyCircle();
        public MyCircle wheel2 = new MyCircle();
        public MyWagon() : base()
        {

        }
        public override void Draw(Graphics graphics)
        {
            base.Draw(graphics);
            wheel1.X = X + W / 3 - W / 4;
            wheel1.Y = Y + H;
            wheel1.W = W / 3;
            wheel2.X = X + W / 3 + W / 4;
            wheel2.Y = Y + H;
            wheel2.W = W / 3;
            wheel1.Draw(graphics);
            wheel2.Draw(graphics);
        }
    }
}
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
            wheel1.X = X + L / 3 - L / 4;
            wheel1.Y = Y + H;
            wheel1.W = L / 3;
            wheel2.X = X + L / 3 + L / 4;
            wheel2.Y = Y + H;
            wheel2.W = L / 3;
            wheel1.Draw(graphics);
            wheel2.Draw(graphics);
        }
    }
}
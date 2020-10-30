using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyWagon:MyRectangle
    { 
        public MyWagon() : base()
        {

        }
        private int l = 20;
        public override int L
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
            }
        }
        private void wheel (Graphics graphics, int L)
        {
            graphics.DrawEllipse(new Pen(Color.Black), x + L / 3-L/4, y + L / 2, L / 3, L / 3);
            graphics.DrawEllipse(new Pen(Color.Black), x + L / 3 + L / 3, y + L / 2, L / 3, L / 3);
        }
        private int x, y;
        public override int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public override int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public override void Draw(Graphics graphics)
        {
           graphics.DrawRectangle(new Pen(Color.Black),x,y,l,l/2);
           wheel(graphics,l);
        }
    }
}
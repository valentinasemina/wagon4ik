using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyCircle:MyFigure
    {
        private int x, y;
        private int r = 15;

        public override int W
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
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
        public override void Draw(Graphics graph)
        {
            graph.DrawEllipse(new Pen(Color.Black,1), X, Y, r, r);
        }       
    }
}

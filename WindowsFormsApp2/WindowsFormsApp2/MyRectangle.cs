using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp2
{
    class MyRectangle:MyFigure
    {
        
        private int x, y;
        private int w = 20, h = 15;

        public override int H { get { return h; } set { h = value; } }
        public override int W { get { return w; } set { w = value; } }
        public override int Y { get { return y; } set { y = value; } }
        public override int X { get { return x; } set { x = value; } }
        public override void Fill(Graphics graphics,Color clr)
        {
            SolidBrush brush = new SolidBrush(clr);
            graphics.FillRectangle(brush, x, y, w, h);
        }
        public override void Draw(Graphics graph)
        {
            graph.DrawRectangle(new Pen(Color.Black), x, y, w, h);
        }
    }
}

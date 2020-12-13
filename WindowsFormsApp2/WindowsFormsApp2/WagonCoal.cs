using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
    class WagonCoal : MyWagon
    {
        public MyRectangle coal = new MyRectangle();
        public override void Draw(Graphics graphics)
        {
                base.Draw(graphics);
                coal.X = X + W / 6;
                coal.Y = Y - H / 2+ H/6;
                coal.H = H / 3;
                coal.W = W - 2 * (W / 6);
                coal.Fill(graphics,Color.Black);
                coal.Draw(graphics);
        }
    }
}
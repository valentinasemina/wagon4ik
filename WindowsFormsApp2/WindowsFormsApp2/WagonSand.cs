using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
    class WagonSand:MyWagon
    {
         public MyRectangle sand = new MyRectangle();
         public override void Draw(Graphics graphics)
         {
                 base.Draw(graphics);
                 sand.X = X + W / 6;
                 sand.Y = Y - H / 2 + H / 6;
                 sand.H = H / 3;
                 sand.W = W - 2 * (W / 6);
                 sand.Fill(graphics, Color.Yellow);
         }
    }
}
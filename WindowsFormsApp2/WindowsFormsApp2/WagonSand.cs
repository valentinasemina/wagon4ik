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
        private int count = 2;
        public override int Count { get { return count; } set { count = value; } }
        public override void Draw(Graphics graphics)
        {
            List<MyWagon> WagonSand = new List<MyWagon>();
            for (int i = 0; i < this.Count; i++)
            {
                base.X = i == 0 ? X : X + W + 10;
                base.Draw(graphics);
                MyWagon wgsand = new MyWagon();
                sand.X = X + W / 6;
                sand.Y = Y - H / 2 + H / 6;
                sand.H = H / 3;
                sand.W = W - 2 * (W / 6);
                WagonSand.Add(wgsand);
                sand.Fill(graphics, Color.Yellow);
            }
        }
    }
}
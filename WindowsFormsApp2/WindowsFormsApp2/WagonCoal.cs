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
        private int count = 2;
        public override int Count { get { return count; } set { count = value; } }
        public override void Draw(Graphics graphics)
        {
            List<MyWagon> WagonCoal = new List<MyWagon>();
            for (int i = 0; i < this.Count; i++)
            {
                base.X = i == 0 ? X : X + W + 10;
                base.Draw(graphics);
                MyWagon wgcl = new MyWagon();
                coal.X = X + W / 6;
                coal.Y = Y - H / 2+ H/6;
                coal.H = H / 3;
                coal.W = W - 2 * (W / 6);
                WagonCoal.Add(wgcl);
                coal.Fill(graphics,Color.Black);
                coal.Draw(graphics);
            }
        }
    }
}

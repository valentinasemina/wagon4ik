using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class MyTrain:MyWagon
    {
        private int count = 2;
        private int x, y, w, h, l;

        public override int X { get { return x; } set { x = value;  } }
        public override int Y { get { return y; } set { y = value; } }
        public override int W { get { return w; } set { w = value; } }
        public override int H { get { return h; } set { h = value; } }
        public override int L { get { return l; } set { l = value; } }
        public override int Count { get { return count; } set { count = value; } }
        public override void Draw(Graphics graphics)
        {
            List<MyWagon> MyTrain = new List<MyWagon>();
            for (int i = 0; i < this.Count; i++)
            {
                MyWagon temp = new MyWagon();
                temp.X = X + W * i;
                temp.Y = Y;
                temp.W = W;
                temp.H = H;
                temp.L = L;
                MyTrain.Add(temp);
                temp.Draw(graphics);
            }
        }
    }
}

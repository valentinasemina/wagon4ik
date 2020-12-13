using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    
    class MyTrain:MyFigure
    { 
        private int x, y;
        private int w = 15, h = 15;
        public override int H { get { return h; } set { h = value; } }
        public override int W { get { return w; } set { w = value; } }
        public override int Y { get { return y; } set { y = value; } }
        public override int X { get { return x; } set { x = value; } }
        public List<MyWagon> wagons = new List<MyWagon>();
        private int count = 3;     
        public override int Count { get { return count; } set { count = value; } }
        private void ReCreate(MyWagon wag, int x, int y, int w, int h, int i, Graphics graphics)
        {
            wag.X = x + (w + 5) * i; wag.Y = y; wag.H = h; wag.W = w; wag.Draw(graphics);
            wagons.Add(wag);
        }
        public override void Draw(Graphics graphics)
        {
            for (int i = 0; i < this.Count; i++)
            {
                Random rand = new Random();
                double cur = rand.NextDouble();
                if (cur >= 0.5) { WagonCoal wag = new WagonCoal(); ReCreate(wag, x, y, w, h, i, graphics); }
                else { WagonSand wag = new WagonSand(); ReCreate(wag, x, y, w, h, i, graphics); }
            }
        }
    }
}
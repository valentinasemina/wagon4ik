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
        private int count = 3;
        List<MyWagon> wagons;
        public MyTrain(int Count)
        {
            wagons = new List<MyWagon>();
            Random rand = new Random();
            for (int i=0;i<Count;i++)
            {
                double cur = rand.NextDouble();
                if (cur >= 0.5) wagons.Add(new WagonCoal());
                else wagons.Add(new WagonSand());
            }
        }
        public override int H { get { return h; } set { h = value; } }
        public override int W { get { return w; } set { w = value; } }
        public override int Y { get { return y; } set { y = value; } }
        public override int X { get { return x; } set { x = value; } }
        public override int Count { get { return count; } set { count = value; } }
        private void ReCreate(MyWagon wag, int x, int y, int w, int h,int i, Graphics graphics)
        {
            wag.X = x+(w+5)*i; wag.Y = y; wag.H = h; wag.W = w; wag.Draw(graphics); 
        }
        public override void Draw(Graphics graphics)
        {
            int i = 0;
            foreach (MyWagon wagon in wagons)
            {
               ReCreate(wagon, x, y, w, h,i, graphics);
                i++;
            }
        }
    }
}
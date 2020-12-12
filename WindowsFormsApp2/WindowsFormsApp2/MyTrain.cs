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
        public override int Count { get { return count; } set { count = value; } }
        public override void Draw(Graphics graphics)
        {
            List<MyWagon> MyTrain = new List<MyWagon>();
            for (int i = 0; i < this.Count; i++)
            {
                MyWagon wag = new MyWagon();
                wag.X = X + W * i+i*10;
                wag.Y = Y;
                wag.W = W;
                wag.H = H;
                wag.L = W;
               
                wag.Draw(graphics);
                MyTrain.Add(wag);
            }
        }
    }
}
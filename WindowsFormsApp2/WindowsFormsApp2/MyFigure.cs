using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class MyFigure
    {
        public virtual int X { get; set; }
        public virtual int L { get; set; }
        public virtual int Y { get; set; }
        public virtual int Count { get; set; }
        public virtual int W { get; set; }
        public virtual int H { get; set; }

        public virtual void Draw(Graphics graphics)
        {
        }

    }
}

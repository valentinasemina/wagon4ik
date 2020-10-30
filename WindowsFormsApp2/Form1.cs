using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool IsClicked = false;
        int dX = 0;
        MyFigure movedFigure;
        int dY = 0;
        Graphics GRdraw;
        MyFigure draw = new MyFigure();
        List<MyFigure> fig = new List<MyFigure>();
        int W, H, L;
        public Form1()
        {
            InitializeComponent();
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            tb2.Visible = true;
        }


        private void pbPaint_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsClicked)
            {
                if (rbCircle.Checked)
                    draw = new MyCircle();
                else if (rbRectangle.Checked)
                    draw = new MyRectangle();
                else
                    draw = new MyWagon();
            }
            draw.X = e.X;
            draw.Y = e.Y;
            draw.W = W;
            draw.H = H;
            draw.L = L;
            draw.Draw(GRdraw);
            fig.Add(draw);
        }

        private void rbCircle_CheckedChanged(object sender, EventArgs e)
        {
            tb2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GRdraw = panel1.CreateGraphics();
        }

        private void btcreate_Click(object sender, EventArgs e)
        {
            W = 15;
            H = 15;
            L = 20;
        }

        private void btpar_Click(object sender, EventArgs e)
        {
            W = Convert.ToInt32(tb1.Text);
            if (tb2.Visible) H = Convert.ToInt32(tb2.Text);
            L = Convert.ToInt32(tb1.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {   
            foreach (MyFigure figure in fig)
            {
                if ((e.X < figure.X + figure.W) && (e.X > figure.X))
                    if ((e.Y < figure.Y + figure.H) && (e.Y > figure.Y))
                    {
                        IsClicked = true;
                        movedFigure = figure;
                        break;
                    }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsClicked)
            {
                movedFigure.X = e.X - dX;
                movedFigure.Y = e.Y - dY;
                panel1.Invalidate();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
        }

        private void rbwagon_CheckedChanged(object sender, EventArgs e)
        {
            tb2.Visible = false;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (MyFigure figure in fig)
            {
                figure.Draw(GRdraw);
            }
        }
    }
}

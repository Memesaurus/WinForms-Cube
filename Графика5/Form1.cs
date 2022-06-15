using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графика5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawCube();
        }

        Color Front = Color.White;
        Color Up = Color.Blue;
        Color Right = Color.Red;
        Color Left = Color.Yellow;
        Color Down = Color.Green;
        Color Back = Color.Orange;
        Color Z;

        void DrawCube()
        {
            Graphics g;
            g = this.CreateGraphics();
            Point P1 = new Point(100, 100);
            Point P2 = new Point(150, 50);
            Point P3 = new Point(350, 350);
            Point P4 = new Point(400, 300);
            Point P5 = new Point(350, 100);
            Point P6 = new Point(400, 50);
            Point[] R1 = { P1, P5, P6, P2 };
            Point[] R2 = { P3, P5, P6, P4 };
            SolidBrush BF = new SolidBrush(Front);
            SolidBrush BU = new SolidBrush(Up);
            SolidBrush BR = new SolidBrush(Right);
            Pen P = new Pen(Color.Black, 1.5f);

            g.FillRectangle(BF, 100, 100, 250, 250);
            g.DrawRectangle(P, 100, 100, 250, 250);

            g.FillPolygon(BU, R1);
            g.DrawPolygon(P, R1);
            g.FillPolygon(BR, R2);
            g.DrawPolygon(P, R2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawCube();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Z = Front;
            Front = Down;
            Down = Back;
            Back = Up;
            Up = Z;
            DrawCube();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Z = Front;
            Front = Right;
            Right = Back;
            Back = Left;
            Left = Z;
            DrawCube();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Z = Front;
            Front = Left;
            Left = Back;
            Back = Right;
            Right = Z;
            DrawCube();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Z = Front;
            Front = Up;
            Up = Back;
            Back = Down;
            Down = Z;
            DrawCube();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            DrawCube();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            DrawCube();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JugglingApp
{
    public partial class Form1 : Form
    {
        public Pen pen;
        public Graphics formGraphics;
        public SolidBrush brush;
        public Color color;
        public int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        public int screenWidth = Screen.PrimaryScreen.Bounds.Width;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formGraphics.DrawArc(pen, 200, 200, 300, 500, 180, 180);
        }

        void Draw()
        {
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    formGraphics.DrawEllipse(pen, 187 + 100 * i, screenHeight * 9 / 10, 25, 25);
                }
                else
                {
                    formGraphics.FillEllipse(brush, 187 + 100 * i, screenHeight * 9 / 10, 25, 25);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            formGraphics = CreateGraphics();
            Color color = Color.Black;
            pen = new Pen(color, 3);
            brush = new SolidBrush(color);
            Draw();
        }
    }
}

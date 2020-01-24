using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JugglingApp
{
    public partial class Form1 : Form
    {
        public Pen pen;
        public Graphics formGraphics;
        public SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics;
            formGraphics = CreateGraphics();
            Color color = Color.Black;
            Pen pen = new Pen(color, 3);
            SolidBrush brush = new SolidBrush(color);
            formGraphics.DrawArc(pen, 200, 600, 300, 500, 180, 180);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formGraphics = CreateGraphics();
            Color color = Color.Black;
            pen = new Pen(color, 3);
            brush = new SolidBrush(color);
            Draw();

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
            
        }
        void Draw()
        {
            formGraphics.DrawLine(pen, 0, 0, 1000, 1000);
            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    formGraphics.DrawEllipse(pen, 187 + 100 * i, 100, 25, 25);
                }
                else
                {
                    formGraphics.FillEllipse(brush, 187 + 100 * i, 100, 25, 25);
                }
            }
        }
    }
}

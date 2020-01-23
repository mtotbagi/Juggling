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
            formGraphics.DrawArc(pen, 200, 600, 300, 500, 180, 180);

            for (int i = 0; i < 12; i++)
            {
                formGraphics.DrawEllipse(pen, 185 + 100 * i, 835, 25, 25);
            }
        }
    }
}

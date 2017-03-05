using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int txtno = int.Parse(textBox1.Text);
                int pointX = 20;
                int pointY = 40;
                int pointX1 = 100;
                int pointY1 = 40;

            panel1.Controls.Clear();
            for (int i = 0; i < txtno; i++)
            {
                TextBox a = new TextBox();
                TextBox b = new TextBox();
                //a.Text = (i + 1).ToString();
                a.Location = new Point(pointX, pointY);
                b.Location = new Point(pointX1, pointY1);
                panel1.Controls.Add(a);
                panel1.Controls.Add(b);
                panel1.Show();
               
             //   panel1.Show();
                pointY += 30;
                pointY1 += 30;
            }
        }
    }
}

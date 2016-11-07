using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1200;
            Height = 600;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Dictionary<string, List<int>> medics = new Dictionary<string, List<int>>();
       
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                string name = richTextBox1.Lines[i].Split('-')[0];
                string[] value = richTextBox1.Lines[i].Split('-')[1].Split(' ');
                List <int> days = new List<int>();

                for (int j = 0; j < value.Length; j++)
                {
                    days.Add(int.Parse(value[j]));
                }

                medics[name] = days;
            }

            int cikul = int.Parse(textBox2.Text);

            panel1.CreateGraphics();
            Create.DrawGrafic(medics, cikul, g);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = default(string);           
            richTextBox1.Text = default(string);            
            panel1.Invalidate();
        }
    }
}

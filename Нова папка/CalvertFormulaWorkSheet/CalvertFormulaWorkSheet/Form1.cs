using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CalvertFormulaWorkSheet
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textAge.Text);
            double weight = double.Parse(textBox3.Text);
            string weightOrPound = comboBox1.Text;
            bool isFemale = checkBox1.Checked;
            int serumCreatininie = int.Parse(textSerum.Text);
            List<AucModel> auc = new List<AucModel>();

            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                string name = richTextBox1.Lines[i].Split(' ')[0];
                int value = int.Parse(richTextBox1.Lines[i].Split(' ')[1]);
                auc.Add(new AucModel(name, value));
            }

            Dictionary<string, double> result = GfrCreate.Create(age, weight, weightOrPound, isFemale, serumCreatininie, auc);
            label7.Text = GfrCreate.Calcilate(age, weight, weightOrPound, isFemale, serumCreatininie).ToString("0.00");

            foreach (var s in result.OrderBy(x => x.Value))
            {
                textBox4.AppendText(s.Key + "          " + s.Value.ToString("0.00") + "           " + "does in mg" + Environment.NewLine);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textAge.Text = default(string);
            textBox3.Text = default(string);
            comboBox1.Text = default(string);
            checkBox1.Checked = default(bool);
            textSerum.Text = default(string);
            label7.Text = default(string);
            textBox4.Text = default(string);
            richTextBox1.Text = default(string);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
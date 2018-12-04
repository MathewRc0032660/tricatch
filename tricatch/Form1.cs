using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tricatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(textBox1.Text);
                double n2 = double.Parse(textBox2.Text);
                double ans = Math.Pow(n1, 1.0 / 3.0);
                textBox3.Text = ans.ToString();











            }
            catch
            {
            }
        }
    }
}

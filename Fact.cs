using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Fact : Form
    {
        public Fact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            long fct;
            if (textBox1.Text.Length>2)
            {
                MessageBox.Show("Numbers upto 25 are allowed");
            }
            num = Int32.Parse(textBox1.Text);
            fct = 1;
            while (num>=1 && num<=25)
            {
                fct = fct * num;
                num--;

            }
            textBox2.Text = fct + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class PrimeNo : Form
    {
        public PrimeNo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            double prime, sqr_root;
            prime = double.Parse(textBox1.Text);
            sqr_root = Math.Sqrt(prime);
            for(num=2; num<=sqr_root;num++)
            {
                if(prime%num==0)
                {
                    MessageBox.Show(prime + " is not a prime number");
                    break;

                }

            }
            if (num > sqr_root)
                MessageBox.Show(prime + " is a prime number");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

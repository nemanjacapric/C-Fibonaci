using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokvijum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassLibrary1.clsMath m = new ClassLibrary1.clsMath();
            long[] x = m.GenFibonacci(Convert.ToInt32(txtBox.Text));

            lstBox.Items.Clear();

            foreach (long a in x)
            {
                lstBox.Items.Add(a.ToString());
            }
        }
    }
}

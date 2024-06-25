using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiro_projeto
{
    public partial class Calculadora : Form
    {

     


        public Calculadora()
        {
            InitializeComponent();
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb1.SelectedIndex == 0)
            {
               lbResultado.Text = (float.Parse(txtNo1.Text) + float.Parse(txtNo2.Text)).ToString();

            }
            if (cb1.SelectedIndex == 1)
            {
                lbResultado.Text = (float.Parse(txtNo1.Text) - float.Parse(txtNo2.Text)).ToString();

            }
            if (cb1.SelectedIndex == 2)
            {
                lbResultado.Text = (float.Parse(txtNo1.Text) * float.Parse(txtNo2.Text)).ToString();

            }
            if (cb1.SelectedIndex == 3)
            {
                lbResultado.Text = (float.Parse(txtNo1.Text) / float.Parse(txtNo2.Text)).ToString();

            }
            txtNo1.Clear();
            txtNo2.Clear();
            
            
        }

        
    }
}

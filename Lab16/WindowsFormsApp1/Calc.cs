using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calc : Form
    {
        Input i1;



        public Calc(Input inp)
        {
            InitializeComponent();
            this.i1 = inp;
        }
        private void Calc_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void GoneCalc_Click(object sender, EventArgs e)
        {
            double n1 = i1.N1;
            double n2 = i1.N2;
            double n3 = i1.N3;
            if (!i1.SummChecker)
            {
                SummBox.Text = "";
            }
            else
            {
                SummBox.Text = (i1.N1 + i1.N2 + i1.N3).ToString(); 
            }
            if (!i1.LeastChecker)
            {
                LeastBox.Text = "";
            }
            else
            {
                int tmp = i1.N1 * i1.N2 * i1.N3;
                for (int i = 1; i < i1.N1*i1.N2*i1.N3; i++)
                {
                    if (i % i1.N1 == 0 && i % i1.N2 == 0 && i % i1.N3 == 0)
                    {
                        tmp = i;
                        break;
                    }
                }
                LeastBox.Text = tmp.ToString();
            }
        }
    }
    
}

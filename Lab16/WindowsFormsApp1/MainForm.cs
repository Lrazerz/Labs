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
    public partial class MainForm : Form
    {
        About about;
        Help help;
        Input input;
        public MainForm()
        {
            InitializeComponent();
            about = new About();
            help = new Help();
            input = new Input();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about.Show();
        }

        private void InputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            input.ShowDialog();
            if (input.but1)
            {
                calcToolStripMenuItem.Enabled = true;
            }
            else
                calcToolStripMenuItem.Enabled = false;
        }

        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc(input);
            calc.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class Input : Form
    {
        public bool but1 { get { return button1.Enabled; } }

        bool errprov1 = false;
        bool errprov2 = false;
        bool errprov3 = false;

        public int N1
        {
            get
            {
                {
                    return Convert.ToInt32(Numb1.Text);
                }
            }
        }
        public int N2
        {
            get
            {
                {
                    return Convert.ToInt32(Numb2.Text);
                }
            }
        }
        public int N3
        {
            get
            {
                {
                    return Convert.ToInt32(Numb3.Text);
                }
            }
        }
        public Input()
        {
            InitializeComponent();
        }
        private void Input_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public bool SummChecker
        {
            get
            {
                return SumCheckBox.Checked;
            }
        }
        public bool LeastChecker
        {
            get
            {
                return LeaseCheckBox.Checked;
            }
        }
        private void Numb1_TextChanged(object sender, EventArgs e)
        {
            bool dot = false, hasletter = false, comma = false;
            foreach (char letter in Numb1.Text)
            {
                if (Char.IsLetter(letter))
                {
                    hasletter = true;
                    break;
                }
                if (letter == '.')
                {
                    dot = true;
                }
                if (letter == ',')
                {
                    comma = true;
                }
            }
            if (hasletter)
            {
                errorProviderNumber1.SetError(Numb1, "Only digits allowed!");
                errprov1 = true;
            }
            else if (dot)
            {
                errorProviderNumber1.SetError(Numb1, "You should use only whole numbers instead of '.'");
                errprov1 = true;
            }
            else if (comma)
            {
                errorProviderNumber1.SetError(Numb1, "You should use only whole numbers instead of ','");
                errprov1 = true;
            }
            else
            {
                errorProviderNumber1.Clear();
                errprov1 = false;
            }
            Checker();
        }
        private void Numb2_TextChanged(object sender, EventArgs e)
        {
            bool dot = false, hasletter = false, comma = false;
            foreach (char letter in Numb2.Text)
            {
                if (Char.IsLetter(letter))
                {
                    hasletter = true;
                    break;
                }
                if (letter == '.')
                {
                    dot = true;
                }
                if (letter == ',')
                {
                    comma = true;
                }
            }
            if (hasletter)
            {
                errorProviderNumber2.SetError(Numb2, "Only digits allowed!");
                errprov2 = true;
            }
            else if (dot)
            {
                errorProviderNumber2.SetError(Numb2, "You should use only whole numbers instead of '.'");
                errprov2 = true;
            }
            else if (comma)
            {
                errorProviderNumber1.SetError(Numb2, "You should use only whole numbers instead of ','");
                errprov2 = true;
            }
            else
            {
                errorProviderNumber2.Clear();
                errprov2 = false;
            }
            Checker();
        }
        private void Numb3_TextChanged(object sender, EventArgs e)
        {
            bool dot = false, hasletter = false, comma = false;
            foreach (char letter in Numb3.Text)
            {
                if (Char.IsLetter(letter))
                {
                    hasletter = true;
                    break;
                }
                if (letter == '.')
                {
                    dot = true;
                }
                if (letter == ',')
                {
                    comma = true;
                }
            }
            if (hasletter)
            {
                errorProviderNumber3.SetError(Numb3, "Only digits allowed!");
                errprov3 = true;
            }
            else if (dot)
            {
                errorProviderNumber3.SetError(Numb3, "You should use ',' instead of '.'");
                errprov3 = true;
            }
            else if (comma)
            {
                errorProviderNumber1.SetError(Numb3, "You should use only whole numbers instead of ','");
                errprov3 = true;
            }
            else
            {
                errorProviderNumber3.Clear();
                errprov3 = false;
            }
            Checker();
        }

        private void Checker()
        {
            if (Numb1.Text.Length != 0 && Numb2.Text.Length != 0 && Numb3.Text.Length != 0 && !errprov1 && !errprov2 && !errprov3)
            {
                if (SumCheckBox.Checked == true || LeaseCheckBox.Checked == true)
                    button1.Enabled = true;
                else
                    button1.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void Input_Load(object sender, EventArgs e)
        {
        }

        private void SumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Checker();
        }

        private void LeaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Checker();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stos
{
    public partial class Form1 : Form
    {
        public int welju=0;
        public int j=0;
        Stack<int> stos = new Stack<int>();
        List<TextBox> txt = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt.Add(textBox2);
            txt.Add(textBox3);
            txt.Add(textBox4);
            txt.Add(textBox5);
            txt.Add(textBox6);
            txt.Add(textBox7);
            txt.Add(textBox8);
            txt.Add(textBox9);
            txt.Add(textBox10);
            txt.Add(textBox11);
            foreach(TextBox i in txt)
            {
                i.Visible = false;
            }
        }

        private void Push_Click(object sender, EventArgs e)
        {
            if (stos.Count <= 9 && timer1.Enabled==false)
            {
                j = 0;
                timer1.Enabled = true;
                welju = int.Parse(textBox1.Text);
                stos.Push(welju);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==false)
            {
                if (stos.Count == 0)
                {
                    MessageBox.Show("Nie mozna pobrac wartosci.", "Stos pusty");
                }
                else
                {
                    txt[10-stos.Count].Text = "";
                    txt[10-stos.Count].Visible = false;
                    MessageBox.Show((stos.Pop()).ToString(), "Pobrales wartosc:");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                stos.Clear();
                foreach (TextBox i in txt)
                {
                    i.Text = "";
                    i.Visible = false;
                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (j > 0 && j < (10 - stos.Count + 1))
            {
                txt[j - 1].Visible = false;
                txt[j - 1].Text = "";
            }
            if (j < (10 - stos.Count + 1))
            {
                txt[j].Visible = true;
                txt[j].Text = welju.ToString();
                j++;
            }
            if (j == (10 - stos.Count + 1))
            {
                timer1.Enabled = false;
            }
        }
    }
}

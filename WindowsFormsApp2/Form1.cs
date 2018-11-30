using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = textBox1;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {   

          
            int num1 , k=0;
                try
                {
                    num1 = Convert.ToInt32(textBox1.Text);
                }
                catch (Exception)
                {
                    
                    num1 = 0;
                }
            if (num1 <= 0)
            {
                this.BackColor = Color.White;
                label1.Text = ("Introduce un numar valid");
            }
            else
            {
                if (num1 != 1)
                {
                    for (int a = 2; a <= num1 / 2; a++)
                    {
                        if (num1 % a == 0)
                            k++;
                    }
                    if (k != 0)
                    {
                        this.BackColor = Color.Red;
                        label1.Text = ("   Numarul nu este prim");
                    }
                    else
                    {
                        this.BackColor = Color.DarkGreen;
                        label1.Text = ("   Numarul este prim");
                    }
                }
                else
                {
                    if (num1 == 1)
                    {
                        this.BackColor = Color.DarkRed;
                        label1.Text = ("   Numarul nu este prim");
                    }
                }
            }

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}

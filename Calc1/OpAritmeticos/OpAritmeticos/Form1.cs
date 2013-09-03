using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpAritmeticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long privalor, segvalor, resultado;
            
            privalor = int.Parse(textBox1.Text);
            segvalor = int.Parse(textBox2.Text);

            if (radioButton1.Checked)
            {
                resultado = privalor + segvalor;
                textBox3.Text = resultado.ToString();
            }
            else
                if (radioButton2.Checked)
                {
                    resultado = privalor - segvalor;
                    textBox3.Text = resultado.ToString();
                }
                else
                    if (radioButton3.Checked)
                    {
                        resultado = privalor * segvalor;
                        textBox3.Text = resultado.ToString();
                    }
                    else
                        if (radioButton4.Checked)
                        {
                            resultado = privalor / segvalor;
                            textBox3.Text = resultado.ToString();
                        }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

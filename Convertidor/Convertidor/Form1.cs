using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor
{
    public partial class Form1 : Form
    {
        int bandera = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Centigrados_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)//converit//
        {
            try
            {
                double grados;
                if (bandera == 1)
                {
                    grados = Convert.ToDouble(textBox1.Text) * 9 / 5 + 32;
                    //Mostramos resultado
                    textBox1.Text = string.Format("{0:F2", grados);
                }
                if (bandera == 2)
                {
                    grados = (Convert.ToDouble(textBox2.Text) -32)* 5 / 9;
                    //Mostramos resultado
                    textBox2.Text = string.Format("{0:F2", grados);
                }

            }
            catch (Exception)
            {
                textBox1.Text = "0.0";
                textBox2.Text = "32.0";
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
            if(e.KeyChar==13)
            {
                Button1_Click(sender, e);
            }
        }

        private void TextBox2_TextChanged(object sender, KeyPressEventArgs e)
        {
            bandera = 2;
            if (e.KeyChar == 13)
            {
                Button1_Click(sender, e);
            }
        }
    }
}

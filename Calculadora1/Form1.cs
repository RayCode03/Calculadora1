using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Operaciones obj = new Operaciones();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            if (obj.IsNumeric(textBox1.Text) && !obj.IsNumeric(textBox2.Text))
            {
                tex_resultado.Text = "Ingrese un Valor valido";


            }

            else
            {
                int suma = obj.Suma(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                tex_resultado.Text = suma.ToString();
            }
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {

            if (obj.IsNumeric(textBox1.Text) && !obj.IsNumeric(textBox2.Text))
            {
                tex_resultado.Text = "Ingrese un Valor valido";


            }

            else
            {
                int restar = obj.Resta(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                tex_resultado.Text = restar.ToString();
            }

        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            if (obj.IsNumeric(textBox1.Text) && !obj.IsNumeric(textBox2.Text))
            {
                tex_resultado.Text = "Ingrese un Valor valido";


            }

            else
            {
                int multiplicar = obj.Multiplicar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                tex_resultado.Text = multiplicar.ToString();
            }
        }

        private void btn_divicion_Click(object sender, EventArgs e)
        {
            if (obj.IsNumeric(textBox1.Text) && !obj.IsNumeric(textBox2.Text))
            {
                tex_resultado.Text = "Ingrese un Valor valido";


            }

            else
            {
                int dividir = obj.Dividir(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                tex_resultado.Text = dividir.ToString();
            }
        }
    }
}

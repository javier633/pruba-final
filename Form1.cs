using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_progra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Intentamos parsear los números
            if (int.TryParse(textBox1.Text, out int num1))

            {
                if (int.TryParse(textBox1.Text, out int num2))

                {
                    // Comparar los números y mostrar el resultado adecuado
                    if (num1 > num2)
                    {
                        MessageBox.Show($"El número {num1} es mayor que {num2}");
                    }
                    else if (num1 < num2)
                    {
                        MessageBox.Show($"El número {num2} es mayor que {num1}");
                    }
                    else
                    {
                        MessageBox.Show("Ambos números son iguales.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido en el segundo campo.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido en el primer campo.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
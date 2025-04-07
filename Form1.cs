using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNumber1.Text);
                double num2 = Convert.ToDouble(txtNumber2.Text);
                double sum = num1 + num2;
                lblResult.Text = "Result: "+sum.ToString();

            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor, Ingrese valores numericos validos");
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNumber1.Text);
                double num2 = Convert.ToDouble(txtNumber2.Text);
                double sum = num1 - num2;
                lblResult.Text = "Result: " + sum.ToString();

            }
            catch (FormatException)
            {

                MessageBox.Show("Por favor, Ingrese valores numericos validos");
            }
        }

        private string operacion = "";
        private double numero1 = 0;
        private bool nuevaOperacion = false;
        // Método para manejar los botones numéricos
        private void btn1_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (nuevaOperacion)
            {
                lblResultado.Text = "";
                nuevaOperacion = false;
            }

            Button btn = sender as Button;
            lblResultado.Text += btn.Text;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblResultado.Text))
                {
                    numero1 = Convert.ToDouble(lblResultado.Text);
                    Button btn = sender as Button;
                    operacion = btn.Text;
                    lblResultado.Text += " " + operacion + " ";
                    nuevaOperacion = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede agregar dos veces seguidas una operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "";
                return;
            }
            
        }


        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblResultado.Text))
                {
                    numero1 = Convert.ToDouble(lblResultado.Text);
                    Button btn = sender as Button;
                    operacion = btn.Text;
                    lblResultado.Text += " " + operacion + " ";
                    nuevaOperacion = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede agregar dos veces seguidas una operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "";
                return;
            }
            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblResultado.Text))
                {
                    numero1 = Convert.ToDouble(lblResultado.Text);
                    Button btn = sender as Button;
                    operacion = btn.Text;
                    lblResultado.Text += " " + operacion + " ";
                    nuevaOperacion = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede agregar dos veces seguidas una operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "";
                return;
            }
           
        }

        private void BtnDivi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(lblResultado.Text))
                {
                    numero1 = Convert.ToDouble(lblResultado.Text);
                    Button btn = sender as Button;
                    operacion = btn.Text;
                    lblResultado.Text += " " + operacion + " ";
                    nuevaOperacion = false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se puede agregar dos veces seguidas una operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "";
                return;
            
        }
           
        }

        private void btnResltudado_Click(object sender, EventArgs e)
        {
            try
            {
                string[] partes = lblResultado.Text.Split(' ');
                if (partes.Length == 3) // Verifica si hay un número, una operación y otro número
                {
                    double numero1 = Convert.ToDouble(partes[0]);
                    string operacion = partes[1];
                    double numero2 = Convert.ToDouble(partes[2]);
                    double resultado = 0;

                    switch (operacion)
                    {
                        case "+":
                            resultado = numero1 + numero2;
                            break;
                        case "-":
                            resultado = numero1 - numero2;
                            break;
                        case "*":
                            resultado = numero1 * numero2;
                            break;
                        case "/":
                            if (numero2 == 0)
                            {
                                MessageBox.Show("No se puede dividir por cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                lblResultado.Text = "";
                                return;
                            }
                            resultado = numero1 / numero2;
                            break;
                    }

                    lblResultado.Text = resultado.ToString();
                }
                else
                {
                    MessageBox.Show("Operación inválida. Asegúrate de ingresar un número, una operación y otro número.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblResultado.Text = "";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultado.Text = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }
    }
}

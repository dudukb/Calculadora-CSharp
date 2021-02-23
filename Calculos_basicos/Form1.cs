using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_basicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            resultado.Text = "";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
       
        private void btnsomar_Click(object sender, EventArgs e)
        {
            try
            {
                   


            
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 + num2;
            this.resultado.Text = resultado.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Digite um Número!.");

            }
            
           

        }

     
        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }
 
        private void button5_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 * num2;
            this.resultado.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 - num2;
            this.resultado.Text = resultado.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 / num2;
            this.resultado.Text = resultado.ToString();
        }        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

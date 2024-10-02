using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosTema2
{
    public partial class frmTriangulo : Form
    {
        public frmTriangulo()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            bool booNum1=int.TryParse(txtLado1.Text, out int lado1);
            bool booNum2=int.TryParse(txtLado2.Text, out int lado2);
            bool booNum3 = int.TryParse(txtLado3.Text, out int lado3);

            if (!booNum1 || !booNum2 || !booNum3) {
                MessageBox.Show("Error","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int perimetro = lado1 + lado2 + lado3;

            if (lado1 == lado2 && lado2 == lado3)
            {
                txtResultado.Text = "Es un triangulo equilatero";
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                txtResultado.Text = "Es un trianguilo isosceles";
            }
            else {
                txtResultado.Text = "Es un triangulo escaleno";
            }

            txtResultado.Text = txtResultado.Text + "\n y su permitro es "+perimetro;


        }
    }
}

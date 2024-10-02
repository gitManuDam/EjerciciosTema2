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
    public partial class frmTextBox : Form
    {
        public frmTextBox()
        {
            InitializeComponent();
        }

        private void btnCambiarModo_Click(object sender, EventArgs e)
        {
            if (btnCambiarModo.Text == "Escritura")
            {
                txtBNombre.ReadOnly = true;
                btnCambiarModo.Text = "Solo Lectura";
            }
            else
            {
                txtBNombre.ReadOnly = false;
                btnCambiarModo.Text = "Escritura";
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if(btnVisible.Text =="Hacer Visible")
            {
                txtBContraseña.PasswordChar = '\0';
                btnVisible.Text = "Ocultar";
                
            }
            else
            {
                txtBContraseña.PasswordChar = '*';
                btnVisible.Text = "Hacer Visible";
            }
        }

        private void btnFoco_Click(object sender, EventArgs e)
        {
            txtBMusica.Focus();
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if(btnActivar.Text == "Activar")
            {
                txtBApellido.Enabled = true;
                btnActivar.Text = "Desactivar";
            }
            else
            {
                txtBApellido.Enabled=false;
                btnActivar.Text = "Activar";
            }
        }
    }
}

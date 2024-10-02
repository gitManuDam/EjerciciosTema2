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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmtriangulo")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar la ventana", "Atenciooooon",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        this.MdiChildren[0].Close();
                        frmTriangulo f = new frmTriangulo();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }

            }
            else
            {
                frmTriangulo f = new frmTriangulo();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

       

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (this.MdiChildren[0].Name != "frmTextBox")
                {
                    DialogResult rs = MessageBox.Show("¿Desea cerrar la ventana","Atenciooooon",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes) 
                    {
                        this.MdiChildren[0].Close();
                        frmTextBox f = new frmTextBox();
                        f.MdiParent = this;
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                }
                
            }
            else 
            {
                frmTextBox f = new frmTextBox();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
    }
}

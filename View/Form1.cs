using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLube.View;

namespace CLube
{
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoria fcategoria = new FormCategoria();

            fcategoria.Show();
        }

        private void sócioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSocio fsocio = new FormSocio();

            fsocio.Show();
        }

        private void dependenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDependente fdependente = new FormDependente();

            fdependente.Show();
        }

        private void mensalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMensalidade fmensalidade = new FormMensalidade();

            fmensalidade.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

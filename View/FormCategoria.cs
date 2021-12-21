using CLube.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLube.View
{
    public partial class FormCategoria : Form
    {
        
        public FormCategoria()
        {
            InitializeComponent();
            
            
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Nome = txtDescricaoCategoria.Text;
            CategoriaDAO categoria = new CategoriaDAO(cat);
            MessageBox.Show(categoria.mensagem);

        }
    }
}

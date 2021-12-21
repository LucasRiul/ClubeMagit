using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLube.Controller;

namespace CLube.View
{
    public partial class FormSocio : Form
    {
        public FormSocio()
        {
            InitializeComponent();
            PreencherComboboxCategoria();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarSocio_Click(object sender, EventArgs e)
        {
            Socio soc = new Socio();
            
            Categoria cat = new Categoria();
            cat.Id = cbxCategoriaSocio.SelectedIndex + 1;
            soc.Nome = txtNomeSocio.Text;
            soc.Endereco = txtEnderecoSocio.Text;
            soc.Telefone = txtTelefoneSocio.Text;
            soc.Email = txtEmailSocio.Text;
            soc.Categoria = cat;
            

            SocioDAO socio = new SocioDAO(soc);
            MessageBox.Show(socio.mensagem);

        }

        private void FormSocio_Load(object sender, EventArgs e)
        {

        }

        public void PreencherComboboxCategoria()
        {
            DataTable dt = new SocioDAO().ListarCategoria();

            if(dt != null)
            {
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow linha in dt.Rows)
                        cbxCategoriaSocio.Items.Add(linha[0].ToString());
                    cbxCategoriaSocio.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}

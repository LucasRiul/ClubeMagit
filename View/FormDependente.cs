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
    public partial class FormDependente : Form
    {
        public FormDependente()
        {
            InitializeComponent();
            PreencherComboboxSocio();
        }

        private void FormDependente_Load(object sender, EventArgs e)
        {

        }

        private void lblCadastroDependente_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarDependente_Click(object sender, EventArgs e)
        {
            Dependente dep = new Dependente();

            Socio soc = new Socio();
            soc.Id = cbxSocioDependente.SelectedIndex + 1;

            dep.Nome = txtNomeDependente.Text;
            dep.Email = txtEmailDependente.Text;
            dep.Socio = soc;
            dep.Parentesco = txtParentescoDependente.Text;

            DependenteDAO dependente = new DependenteDAO(dep);
            MessageBox.Show(dependente.mensagem);
        }

        public void PreencherComboboxSocio()
        {
            DataTable dt = new DependenteDAO().ListarSocio();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                        cbxSocioDependente.Items.Add(linha[0].ToString());
                    cbxSocioDependente.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}

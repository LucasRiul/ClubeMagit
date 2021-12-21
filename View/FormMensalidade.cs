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
    public partial class FormMensalidade : Form
    {
        public FormMensalidade()
        {
            InitializeComponent();
            PreencherComboboxSocio();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMensalidade_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mensalidade men = new Mensalidade();

            Socio soc = new Socio();

            soc.Id = cbxNomeSocio.SelectedIndex + 1;


            men.Socio = soc;
            men.DataVencimento = txtDataVencimento.Text;
            men.DataBaixa = txtDataBaixa.Text;
            men.ValorParcela = int.Parse(txtValorMensalidade.Text);
            men.Juros = int.Parse(txtJuros.Text);
            men.ValorPago = int.Parse(txtValorPagamento.Text);

            MensalidadeDAO mensalidade = new MensalidadeDAO(men);
            MessageBox.Show(mensalidade.mensagem);

        }

        public void PreencherComboboxSocio()
        {
            DataTable dt = new MensalidadeDAO().ListarSocio();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                        cbxNomeSocio.Items.Add(linha[0].ToString());
                    cbxNomeSocio.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }

        private void txtValorPagamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

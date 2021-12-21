using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube
{
    public abstract class Pagamento
    {
        private string dataVencimento;
        private string dataBaixa;
        private double valorParcela;
        private double juros;
        private double valorPago;

        public string DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public string DataBaixa { get => dataBaixa; set => dataBaixa = value; }
        public double Juros { get => juros; set => juros = value; }
        public double ValorPago { get => valorPago; set => valorPago = value; }
        public double ValorParcela { get => valorParcela; set => valorParcela = value; }

        
    }
}

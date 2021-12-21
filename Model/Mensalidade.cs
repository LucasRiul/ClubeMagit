using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube
{
    public class Mensalidade : Pagamento
    {
        private int id;
        private Socio socio;

        public int Id { get => id; set => id = value; }
        public Socio Socio { get => socio; set => socio = value; }
    }
}

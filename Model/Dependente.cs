using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube
{
    public class Dependente : Pessoa
    {
        private int id;
        private string parentesco;
        private Socio socio;

        public string Parentesco { get => parentesco; set => parentesco = value; }
        public int Id { get => id; set => id = value; }
        public Socio Socio { get => socio; set => socio = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube
{
    public class Socio : Pessoa
    {
        private int id;
        private string endereco;
        private string telefone;
        private Categoria categoria;
        private List <Dependente> dependente=new List<Dependente>();

        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public List<Dependente> Dependente { get => dependente; set => dependente = value; }
        public int Id { get => id; set => id = value; }
    }
}

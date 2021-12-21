using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLube
{
    public class Categoria
    {
        private int id;
        private string nome;
        private List <Socio> socios = new List<Socio>();  
                
      
        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public List<Socio> Socios { get => socios; set => socios = value; }

        


    }
}

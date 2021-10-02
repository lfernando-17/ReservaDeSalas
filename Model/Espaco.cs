using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Espaco
    {
        private static int cod = 0;

        public int id { get;set; }

        public string nome{ get; set; }
        public int capacidade{ get; set; }
        public string situacao { get; set; }
        public Equipamento equipamento{ get; set; }

        public Espaco (string nome,int capacidade , string situacao , Equipamento equipamento)
        {
            this.id = cod++;
            this.capacidade = capacidade;
            this.situacao = situacao;
            this.equipamento = equipamento;
            this.nome = nome;
        }

        public Espaco()
        {
          
        }
    }
}

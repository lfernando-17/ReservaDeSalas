using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Equipamento
    {
        private static int cod = 0;
        public int id { get; set; }
        public string status { get; set; }

        public int quantidade { get; set; }
        public string descricao { get; set; }

        public Equipamento(String status , string descricao , int quantidade)
        {
            this.id = cod++;
            this.status = status;
            this.quantidade = quantidade;
            this.descricao = descricao;
        }
        public Equipamento()
        {
          
        }
    }
}

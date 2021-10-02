using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reserva
    {
        private static int cod = 0;

        public int id { get; set; }

        public string nome { get; set; }
        public string dt_inicio { get; set; }
        public string dt_fim { get; set; }

        public string hora { get; set; }

        public Espaco Sala { get; set; }

        public Reserva(String nome,String dt_inicio , String dt_fim , String hora,Espaco Sala)
        {
            this.id = cod++;
            this.nome = nome;
            this.dt_inicio = dt_inicio;
            this.dt_fim = dt_fim;
            this.hora = hora;
            this.Sala = Sala;
        }
        public Reserva()
        {
            
        }
    }
}


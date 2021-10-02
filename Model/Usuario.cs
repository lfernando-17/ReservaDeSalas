using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario 
    {
        public Int64 CPF { get; set ; }

        public String User { get; set; }

        public String Senha{ get; set; }

        public Endereco adress { get; set; }

        
    }
}

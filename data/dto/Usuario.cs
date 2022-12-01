using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETSYS
{
    public class Usuario
    {
        [Key]public int ID { get; set; } 
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Loja { get; set; }
        public string Dia_Cadastro { get; set; }
    }
}


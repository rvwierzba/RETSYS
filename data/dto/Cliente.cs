using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETSYS
{
    public class Cliente
    {
        [Key] public int ID { get; set; }

        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Tel_fixo { get; set; }
        public string Whatsapp { get; set; }
        public string Obs { get; set; }
        public string Data_Cadastro { get; set; }

        //FK
        public ICollection<Os> Oss { get; set; }
    }
}

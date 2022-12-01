using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETSYS
{
    public class Armacao
    {
        [Key] public int ID { get; set; }
        public string Codigo { get; set; }
        public string Fabricante { get; set; }
        public string Referencia { get; set; }
        public string Modelo { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public string Material { get; set; }
        public string Qtd_Estoque { get; set; }
        public string Preco_Final_Venda { get; set; }
        public string Tipo { get; set; }
    }
}

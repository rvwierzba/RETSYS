using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RETSYS
{
    public class Pagamento
    {
        [Key] public int ID { get; set; }
        public string Parcela_Nome { get; set; }
        public string Num_Parcelas { get; set; }
        public string Data_Pagamento { get; set; }
        public string Forma_Pagamento { get; set; }
        public string Valor { get; set; }
        public string Valor_Parc { get; set; }


        //FK - REFERENCES: ID-OS
        /**/
        public int Cod_Pgaf_ID { get; set; }
        
        public int Os_ID { get; set; }
        public Os OS { get; set; }
    }
}

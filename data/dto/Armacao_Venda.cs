using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETSYS
{
    public class Armacao_Venda
    {
        [Key] public int ID { get; set; }
        public string Obs { get; set; }
        public string Referencia_Armacao{ get; set; }

        //FK - REFERENCES: OS_ID
        public int Os_ID { get; set; }
        public Os OS { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RETSYS
{
    public class Os
    {
        [Key] public int ID { get; set; }
        public string OS { get; set; }
        public string Data_Receita { get; set; }
        public string  Medico { get; set; }
        public string Tipo_Lente { get; set; }
        public string Marca_Modelo_Lente { get; set; }
        public string ESF_D_LONG { get; set; }
        public string ESF_E_LONG { get; set; }
        public string ESF_D_PERT { get; set; }
        public string ESF_E_PERT { get; set; }
        public string CIL_D_LONG { get; set; }
        public string CIL_E_LONG { get; set; }
        public string CIL_D_PERT { get; set; }
        public string CIL_E_PERT { get; set; }
        public string EIXO_D_LONG { get; set; }
        public string EIXO_E_LONG { get; set; }
        public string EIXO_D_PERT { get; set; }
        public string EIXO_E_PERT { get; set; }
        public string ESF_SIGN_LONG_D { get; set; }
        public string ESF_SIGN_LONG_E { get; set; }
        public string ESF_SIGN_PERT_D { get; set; }
        public string ESF_SIGN_PERT_E { get; set; }
        public string Material_Lente { get; set; }
        public string Obs { get; set; }
        public string Adicao { get; set; }
        public string Data_Final_Pagamento { get; set; }
        public string Data_Venda { get; set; }
        public string Valor_Total_Venda { get; set; }
        public string Seller { get; set; }
                
        //FK - REFERENCES: ID Cliente
         public int Cliente_ID { get; set; }
         public Cliente Cliente { get; set; }

        //FK: OS <- ARMAÇOES
        public ICollection<Armacao_Venda> Arms_Venda { get; set; }

        //FK: OS <- PAGAMENTOS_A_FAZER
        public ICollection<Pagamento_A_Receber> Pags_A_Fazer { get; set; }

        //FK: OS <- PAGAMENTOS
        public ICollection<Pagamento> Pags { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RETSYS { 

   

    public partial class Select_Qual_Pgto : Form
    {
    internal string form_selected { get; set; }
    public Select_Qual_Pgto()
        {
            InitializeComponent();

              
            
            
            
                
    }
            

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calc_grauPert_Click(object sender, EventArgs e)
        {

            if (cbx_selecione.Text != null || cbx_selecione.Text != "")
            {
                form_selected = cbx_selecione.Text;

                switch (form_selected)
                {
                    case "PAGAMENTOS À RECEBER":
                        Cad_Pgtos_A_Receber pgto_a_rec = new Cad_Pgtos_A_Receber(0);
                        pgto_a_rec.ShowDialog();
                        break;

                    case "PAGAMENTOS FEITOS":
                        Pagamentos_Feitos pgto_feitos = new Pagamentos_Feitos();
                        pgto_feitos.ShowDialog();
                        break;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("ATENÇÂO: Fromulário não SELECIONADO!");
            }





            
        }
    }
}

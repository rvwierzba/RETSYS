using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RETSYS
{
    public partial class Select_Pgto_A_Receb : Form
    {
        public Select_Pgto_A_Receb()
        {
            InitializeComponent();

            txt_instrucaoSelect.Text = "Selecione o PAGAMENTO que deseja, clicando na ultima coluna \n" +
            " na linha correspondente. No botão SELECIONAR";

            try
            {
                Acesso_FB acesso_fb = new Acesso_FB();
                DataTable dt = acesso_fb.fb_GetDados("select PGAR_ID, PGAR_PARCELA_NOME, PGAR_DATA_PAGAMENTO, PGAR_VALOR_PARC from PAGAMENTOS_A_RECEBER");
                dgv_select_pagtosAreceb.DataSource = dt;

            }
            catch(FbException fbex)
            {
                throw fbex;
            }
        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgv_select_pagtosAreceb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.SELECIONAR.Index && e.RowIndex >= 0)
            {
                Pagamento_A_Receber selected_pag_aReceb = new Pagamento_A_Receber();
                selected_pag_aReceb.ID = Convert.ToInt32(dgv_select_pagtosAreceb.Rows[e.RowIndex].Cells["PGAR_ID"].Value.ToString());
                Cad_Pgtos_A_Receber form_pag_aReceb = new Cad_Pgtos_A_Receber(selected_pag_aReceb.ID);
                form_pag_aReceb.ShowDialog();
                this.Close();
            }
        }
    }
}

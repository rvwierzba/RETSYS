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
    public partial class Select_Armacao : Form
    {    
        public Select_Armacao()
        {
            InitializeComponent();

            txt_instrucaoSelect.Text = "Selecione a ARMAÇÂO que deseja, clicando na ultima coluna \n" +
          " na linha correspondente. No botão SELECIONAR";
                              

            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                DataTable dt = acesso_fb.fb_GetDados("select ARM_ID, ARM_FABRICANTE, ARM_MODELO, ARM_TIPO, ARM_COR from ARMACOES");
                dgv_arms.DataSource = dt;

                dgv_arms.Show();

            }catch(FbException fbex)
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

        private void dgv_arms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            if (e.ColumnIndex == this.SELECIONAR.Index && e.RowIndex >= 0)
            {
                Armacao arm_selected = new Armacao();
                arm_selected.ID = Convert.ToInt32(dgv_arms.Rows[e.RowIndex].Cells["ARM_ID"].Value);
                  
                 Cad_Armacao show_arm = new Cad_Armacao(arm_selected.ID);
                 show_arm.ver_armSelecionada(arm_selected.ID);
                 show_arm.ShowDialog();
                
                this.Close();
            }
        }

        
    }
}

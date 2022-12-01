using System;
using FirebirdSql.Data.FirebirdClient;
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
    public partial class Select_Os : Form
    {        
        public Select_Os()
        {
            InitializeComponent();

            txt_instrucaoSelect.Text = "Selecione a OS que deseja, clicando na ultima coluna \n" +
          " na linha correspondente. No botão SELECIONAR";

          
            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {// testar porque dgv duplica valores da OS
                DataTable dt = acesso_fb.fb_GetDados("select OS_ID, OS_OS, OS_VENDEDOR, OS_DATA_VENDA, OS_VALOR_TOTAL_VENDA from OSS");
                dgv_selectOS.DataSource = dt;
            }
            catch (FbException fbex)
            {
                throw fbex;
            }
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_selectOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.SELECIONAR.Index && e.RowIndex >= 0)
            {
                Os selected_os = new Os();
                selected_os.ID = Convert.ToInt32(dgv_selectOS.Rows[e.RowIndex].Cells["OS_ID"].Value.ToString());
                Cad_Os view_os = new Cad_Os(selected_os.ID, 0);
                view_os.ShowDialog();
                this.Close();
            }
        }
    }
}

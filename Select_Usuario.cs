using System;
using System.Collections.Generic;
using System.ComponentModel;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RETSYS
{
    public partial class Select_Usuario : Form
    {
        public Select_Usuario()
        {
            InitializeComponent();

            txt_instrucaoSelect.Text = "Selecione o USUARIO que deseja, clicando na ultima coluna \n" +
                " na linha correspondente. No botão SELECIONAR";

            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                DataTable dt = acesso_fb.fb_GetDados("select USR_ID, USR_NOME, USR_LOJA from USUARIOS");
                dgv_users.DataSource = dt;
                
                dgv_users.Show();
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

        
        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == this.SELECIONAR.Index && e.RowIndex >= 0)
            {
                Usuario user_selected = new Usuario();
                user_selected.ID = Convert.ToInt32(dgv_users.Rows[e.RowIndex].Cells["USR_ID"].Value.ToString());
                Cad_Usuario show_user = new Cad_Usuario(user_selected.ID);
                show_user.ShowDialog();
                this.Close();
            }
                      

        }

        
    }
}

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
    public partial class Select_Client : Form
    {
        internal string form_origem { get; set; }
        public Select_Client(string form_que_chamou)
        {
            InitializeComponent();


            txt_instrucaoSelect.Text = "Selecione o CLIENTE que deseja, clicando na ultima coluna \n" +
          " na linha correspondente. No botão SELECIONAR";

            form_origem = form_que_chamou;

            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                DataTable dt = acesso_fb.fb_GetDados("select CLI_ID, CLI_NOME, CLI_CELULAR, CLI_TELFIXO from CLIENTES");
                dgv_clients.DataSource = dt;
            }
            catch (FbException fbex)
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

        private void dgv_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.SELECIONAR.Index && e.RowIndex >= 0)
            {
                Cliente selected_cli = new Cliente();
                selected_cli.ID = Convert.ToInt32(dgv_clients.Rows[e.RowIndex].Cells["CLI_ID"].Value);

                switch (form_origem)
                {
                    case "Cad_Cliente":

                        Cad_Cliente view_client = new Cad_Cliente(selected_cli.ID);
                        view_client.ShowDialog();
                        
                        break;


                    case "Cad_Os":

                        Cad_Os add_cli = new Cad_Os(0, selected_cli.ID);
                        add_cli.ShowDialog();
                        
                        break;

                }

                this.Close();
            }
        }
    }
}

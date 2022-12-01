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
    public partial class Home : Form
    {
        public Home(string userLog)
        {
            InitializeComponent();
            lbl_userLogado.Text = "Seja Bem-vindo(a): " + userLog;
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbx_usuarios_Click(object sender, EventArgs e)
        {
            Cad_Usuario frm_cad_user = new Cad_Usuario(0);
            frm_cad_user.ShowDialog();
        }

        private void pbx_estoque_Click(object sender, EventArgs e)
        {
            Cad_Armacao frm_cad_arms = new Cad_Armacao(0);
            frm_cad_arms.ShowDialog();

        }

        private void pbx_clientes_Click(object sender, EventArgs e)
        {
            Cad_Cliente form_cad_cliente = new Cad_Cliente(0);
            form_cad_cliente.ShowDialog();
        }

        private void pbx_os_Click(object sender, EventArgs e)
        {
            Cad_Os cad_os = new Cad_Os(0, 0);
            cad_os.ShowDialog();
        }

        private void pbx_pagamentos_Click(object sender, EventArgs e)
        {
            Select_Qual_Pgto qual_pgto = new Select_Qual_Pgto();
            qual_pgto.ShowDialog();
        }
    }
}

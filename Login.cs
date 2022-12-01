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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt_senha.UseSystemPasswordChar = true;
            Acesso_FB.tentativaLogin = 0;
        }

        internal void login_invalido()
        {
           
            if (Acesso_FB.tentativaLogin <= 2)
            {
                Acesso_FB.tentativaLogin++;
                lbl_avisoTentativa.Text = $"Atenção USUARIO e ou SENHA Inválido(s)! - Tentativa ({Acesso_FB.tentativaLogin}/3)";
            }
            else
            {
                MessageBox.Show("As três tentativas de logar deram errada. O programa será FECHADO!");
                Application.Exit();
            }

        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text != "" && txt_senha.Text != "")
            {
                Usuario login_user = new Usuario();
                Acesso_FB fb_connect = new Acesso_FB();

                try
                {                       
                        login_user.Nome = txt_usuario.Text;
                        login_user.Senha = txt_senha.Text;
                                                                     
                         DataTable dt = fb_connect.fb_GetDados($"select * from USUARIOS where USR_NOME = '{login_user.Nome}' and USR_SENHA = '{login_user.Senha}'");

                    if (dt.Rows.Count > 0)
                    {
                        Home frm_home = new Home(Acesso_FB.usuario_logado = login_user.Nome);
                        frm_home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                         login_invalido();
                    }
                   
                 
                }
                catch(FbException fbex)
                {
                    throw fbex;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira o USUÁRIO e a SENHA para acessar o Sistema!");
            }

        }

        private void chk_mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
             if (chk_mostrarSenha.Checked)
             {
                txt_senha.UseSystemPasswordChar = false;
             }
            else
            {
                txt_senha.UseSystemPasswordChar = true;
            }
        }
    }
}
    


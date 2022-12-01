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
    public partial class Cad_Usuario : Form
    {
        int use_selected_id { get; set; }
        public Cad_Usuario(int id)
        {
            InitializeComponent();
            txt_senha.UseSystemPasswordChar = true;
            use_selected_id = id;
            addListCbxAnoSlct();
            ver_vendasMes_func(id);

            if (id > 0)
            {
                verUserSelecionado(id);
            }
            

        }

        internal void addListCbxAnoSlct()
        {
            cbx_ano.Items.Add(DateTime.Now.Year - 5);
            cbx_ano.Items.Add(DateTime.Now.Year - 4);
            cbx_ano.Items.Add(DateTime.Now.Year - 3);
            cbx_ano.Items.Add(DateTime.Now.Year - 2);
            cbx_ano.Items.Add(DateTime.Now.Year - 1);
            cbx_ano.Items.Add(DateTime.Now.Year);
            cbx_ano.Items.Add(DateTime.Now.Year + 1);
            cbx_ano.Items.Add(DateTime.Now.Year + 2);
            cbx_ano.Items.Add(DateTime.Now.Year + 3);
            cbx_ano.Items.Add(DateTime.Now.Year + 4);
            cbx_ano.Items.Add(DateTime.Now.Year + 5);
        }

        internal void preencherDgv(int Selct_id, string Mes, string Ano)
        {
            Acesso_FB acesso_fb = new Acesso_FB();
            Usuario func = new Usuario();
            func.ID = Selct_id;
            try
            {
               
                func.Nome = acesso_fb.fb_Get_Info_Dtr($"select USR_NOME from USUARIOS where USR_ID = {func.ID}", "usr_nome");
                DataTable dt = acesso_fb.fb_GetDados($"select OS_ID as ID, OS_OS as OS, OS_DATA_VENDA as DataVenda, OS_VALOR_TOTAL_VENDA as R$, OS_VENDEDOR AS Vendedor "
              + $"from OSS where OS_VENDEDOR = '{func.Nome}' AND OS_DATA_VENDA between '01.{DateTime.Now.Month}.{DateTime.Now.Year}' " +
                $"and '{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}'");//'31.{Mes}.{Ano}'"

                dgv_vendasMes.DataSource = dt;

                decimal tot_vendas_mensal = 0;
                foreach (var row in dgv_vendasMes.Rows.Cast<DataGridViewRow>())
                {
                    tot_vendas_mensal += Convert.ToDecimal(row.Cells["R$"].Value);
                }
                              
            }
            catch (FbException fbex)
            {
                throw fbex;
            }
        }

        internal void ver_vendasMes_func(int slc_usr_id)
        {           
            string mes; 
            string ano;

            if(cbx_selectedMes.Text == "" || cbx_selectedMes.Text == null)
            {
                mes = DateTime.Now.Month.ToString();
            }
                                     
                switch (cbx_selectedMes.Text)
                {
                    case "01 - JANEIRO":
                        mes = "1";
                       break;

                    case "02 - FEVEREIRO":
                        mes = "2";
                       break;

                    case "03 - MARÇO":
                        mes = "3";
                       break;

                    case "04 - ABRIL":
                        mes = "4";
                       break;

                    case "05 - MAIO":
                        mes = "5";
                       break;

                    case "06 - JUNHO":
                        mes = "6";
                       break;

                    case "07 - JULHO":
                        mes = "7";
                       break;

                    case "08 - AGOSTO":
                        mes = "8";
                       break;

                    case "09 - SETEMBRO":
                        mes = "9";
                       break;

                    case "10 - OUTUBRO":
                        mes = "10";
                      break;

                    case "11 - NOVEMBRO":
                        mes = "11";
                       break;

                    case "12 - DEZEMBRO":
                        mes = "12";
                       break;

                    default: mes = DateTime.Now.Month.ToString(); break;
                
                }
                           
            if (cbx_ano.Text == "" || cbx_ano.Text == null)
            {
                ano = DateTime.Now.Year.ToString();
            }
            else
            {
                ano = cbx_ano.Text;
            }

            lbl_titleDGV.Text = $"VENDAS: {mes}/{ano} - POR USUÁRIO";

            if(slc_usr_id > 0)
            {
                preencherDgv(slc_usr_id, mes, ano);
            }
               
        }

        internal void verUserSelecionado(int id)
        {
            try
            {
                Acesso_FB acesso_fb = new Acesso_FB();
                Usuario user_selected = new Usuario();
                user_selected.ID = id;
                user_selected.Nome = acesso_fb.fb_Get_Info_Dtr($"select USR_NOME from USUARIOS where USR_ID = '{id}'", "usr_nome");
                user_selected.Senha = acesso_fb.fb_Get_Info_Dtr($"select USR_SENHA from USUARIOS where USR_ID = '{id}'", "usr_senha");
                user_selected.Loja = acesso_fb.fb_Get_Info_Dtr($"select USR_LOJA from USUARIOS where USR_ID = '{id}'", "usr_loja");
                user_selected.Dia_Cadastro = acesso_fb.fb_Get_Info_Dtr($"select USR_DIA_CAD from USUARIOS where  USR_ID = '{id}'", "usr_dia_cad");

                txt_id.Text = user_selected.ID.ToString();
                txt_usuario.Text = user_selected.Nome;
                txt_senha.Text = user_selected.Senha;
                cbx_loja.Text = user_selected.Loja;
                chk_mostrarSenha.Checked = false;
                msk_dataCadUsr.Text = user_selected.Dia_Cadastro;

            }catch(FbException fbex)
            {
                throw fbex;
            }
            
        }

        internal void limparForm()
        {
            txt_id.Clear(); 
            txt_usuario.Clear();
            txt_senha.Clear();
            cbx_loja.Text = "";
            chk_mostrarSenha.Checked = false;
            dgv_vendasMes.DataSource = "";
            lbl_valorTotVendasMo.Text = "TOTAL: R$";
            msk_dataCadUsr.Clear();
            lbl_titleDGV.Text = "";
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Usuario new_user = new Usuario();
            
            Acesso_FB acesso_fb = new Acesso_FB();

            try
            {
                new_user.Nome = "NOVO USUARIO";
                new_user.Dia_Cadastro = DateTime.Today.ToString("dd.MM.yyyy");
                acesso_fb.exe_CRUD($"insert into USUARIOS(USR_NOME, USR_DIA_CAD) values('{new_user.Nome}', '{new_user.Dia_Cadastro}')");
                new_user.ID = Convert.ToInt32(acesso_fb.fb_Get_Info_Dtr("select USR_ID from USUARIOS where USR_ID = (select max(USR_ID) from USUARIOS)", "USR_ID"));
                txt_id.Text = new_user.ID.ToString();
                txt_usuario.Text = new_user.Nome;
                msk_dataCadUsr.Text = new_user.Dia_Cadastro;
            }
            catch(FbException fbex)
            {
                throw fbex;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_id.Text != "")
            {
                Usuario updt_user = new Usuario();
                updt_user.ID = Convert.ToInt32(txt_id.Text);
                updt_user.Nome = txt_usuario.Text;
                updt_user.Senha = txt_senha.Text;
                updt_user.Loja = cbx_loja.Text;

                try
                {
                    Acesso_FB acesso_fb = new Acesso_FB();
                    acesso_fb.exe_CRUD($"update USUARIOS set USR_ID = {updt_user.ID}, USR_NOME = '{updt_user.Nome}'," +
                    $"USR_SENHA = '{updt_user.Senha}', USR_LOJA = '{updt_user.Loja}' where USR_ID = '{updt_user.ID}'");
                   
                    MessageBox.Show("Alterações feitas com sucesso!");
                }
                catch(FbException fbex)
                {
                    throw fbex;
                }

            }
            else
            {
                MessageBox.Show("ID Vazio. Por favor, clique no botão PROCURAR e selecione o usuário!");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && MessageBox.Show("Deseja mesmo DELETAR PERMANENTEMENTE esse USUARIO? Os Dados dele serão Excluídos!", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Usuario del_user = new Usuario();
                del_user.ID = Convert.ToInt32(txt_id.Text);

                Acesso_FB acesso_fb = new Acesso_FB();
                try
                {
                    acesso_fb.exe_CRUD($"delete from USUARIOS where USR_ID = {del_user.ID}");
                    MessageBox.Show("USUARIO APAGADO(A)  com Sucesso!");
                    limparForm();
                }
                catch(FbException fbex)
                {
                    throw fbex;
                }
            }
            else
            {
                MessageBox.Show("ID Vazio. Por favor, clique no botão PROCURAR e selecione o usuário!");
            }
        }

        private void btn_limparForm_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {           
            Select_Usuario slct_user = new Select_Usuario();
            slct_user.ShowDialog();
            this.Close();


        }

        private void cbx_selectedMes_SelectedIndexChanged(object sender, EventArgs e)
        {
           ver_vendasMes_func(use_selected_id);
        }

        private void cbx_ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            ver_vendasMes_func(use_selected_id);
        }
    }
}

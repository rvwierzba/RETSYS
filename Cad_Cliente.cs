using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViaCep;

namespace RETSYS
{
	public partial class Cad_Cliente : Form
	{
		public Cad_Cliente(int id)
		{
			InitializeComponent();
			
			if(id > 0)
            {
				view_selected_cli(id);
				view_oss_client(id);
			}
            
		}

		internal void view_selected_cli(int slct_id)
        {
			Cliente view_cli = new Cliente();
			Acesso_FB acesso_fb = new Acesso_FB();

            try
            {
				view_cli.Email = acesso_fb.fb_Get_Info_Dtr($"select CLI_EMAIL from CLIENTES where CLI_ID = '{slct_id}'", "cli_email");
				view_cli.Cpf = acesso_fb.fb_Get_Info_Dtr($"select CLI_CPF from CLIENTES where CLI_ID = '{slct_id}'", "cli_cpf");
				view_cli.Data_Nascimento = acesso_fb.fb_Get_Info_Dtr($"select CLI_DATANASCIMENTO from CLIENTES where CLI_ID = '{slct_id}'", "cli_datanascimento");
				view_cli.Endereco = acesso_fb.fb_Get_Info_Dtr($"select CLI_RUA from CLIENTES where CLI_ID = '{slct_id}'", "cli_rua");
				view_cli.Obs = acesso_fb.fb_Get_Info_Dtr($"select CLI_OBS from CLIENTES where CLI_ID = '{slct_id}'", "cli_obs");
				view_cli.Uf = acesso_fb.fb_Get_Info_Dtr($"select CLI_UF from CLIENTES where CLI_ID = '{slct_id}'", "cli_uf");
				view_cli.Whatsapp = acesso_fb.fb_Get_Info_Dtr($"select CLI_CELULAR from CLIENTES where CLI_ID = '{slct_id}'", "cli_celular");
				view_cli.Nome = acesso_fb.fb_Get_Info_Dtr($"select CLI_NOME from CLIENTES where CLI_ID = '{slct_id}'", "cli_nome");
				view_cli.Bairro = acesso_fb.fb_Get_Info_Dtr($"select CLI_BAIRRO from CLIENTES where CLI_ID = '{slct_id}'", "cli_bairro");
				view_cli.Cep = acesso_fb.fb_Get_Info_Dtr($"select CLI_CEP from CLIENTES where CLI_ID = '{slct_id}'", "cli_cep");
				view_cli.Cidade = acesso_fb.fb_Get_Info_Dtr($"select CLI_CIDADE from CLIENTES where CLI_ID = '{slct_id}'", "cli_cidade");
				view_cli.ID = Convert.ToInt32(slct_id);
				view_cli.Numero = acesso_fb.fb_Get_Info_Dtr($"select CLI_NUMERO from CLIENTES where CLI_ID = '{slct_id}'", "cli_numero");
				view_cli.Rg = acesso_fb.fb_Get_Info_Dtr($"select CLI_RG from CLIENTES where CLI_ID = '{slct_id}'", "cli_rg");
				view_cli.Data_Cadastro = acesso_fb.fb_Get_Info_Dtr($"select CLI_DATA_CADASTRO from CLIENTES where CLI_ID = '{slct_id}'", "cli_data_cadastro");
				view_cli.Tel_fixo = acesso_fb.fb_Get_Info_Dtr($"select CLI_TELFIXO from CLIENTES where CLI_ID = '{slct_id}'", "cli_telfixo");

				msk_cep.Text = view_cli.Cep;
				msk_cpf.Text = view_cli.Cpf;
				msk_rg.Text = view_cli.Rg;
				msk_telFixo.Text = view_cli.Tel_fixo;
				msk_whatsapp.Text = view_cli.Whatsapp;
				txt_bairro.Text = view_cli.Bairro;
				txt_cidade.Text = view_cli.Cidade;
				txt_email.Text = view_cli.Email;
				txt_id.Text = view_cli.ID.ToString();
				txt_nome.Text = view_cli.Nome;
				txt_num.Text = view_cli.Numero;
				txt_rua.Text = view_cli.Endereco;
				rtx_obs.Text = view_cli.Obs;
				cbx_uf.Text = view_cli.Uf;
                msk_dataNasc.Text = view_cli.Data_Nascimento;
				msk_dataCadCli.Text = view_cli.Data_Cadastro;
			}
			catch(FbException fbex)
            {
				throw fbex;
            }
						
		}

		internal void limparForm()
        {
			this.msk_cep.Clear();
			this.msk_cpf.Clear();
			msk_cpf.BackColor = Color.White;
			this.msk_rg.Clear();
			this.msk_dataNasc.Clear();
			this.msk_whatsapp.Clear();
			this.txt_bairro.Clear();
			this.txt_cidade.Clear();
			this.txt_email.Clear();
			this.txt_id.Clear();
			this.txt_nome.Clear();
			this.txt_num.Clear();
			this.txt_rua.Clear();
			this.rtx_obs.Clear();
			this.cbx_uf.Text = "";
			this.msk_dataNasc.Clear();
			dgv_oss_client.DataSource = "";
			dgv_oss_client.Refresh();
			msk_dataCadCli.Clear();
			msk_telFixo.Clear();
		}

		internal void view_oss_client(int cli_id)
        {
			Acesso_FB acesso_view = new Acesso_FB();
						
            try
            {					
				DataTable dt_view = acesso_view.fb_GetDados($"select OS_OS, OS_DATA_VENDA, FK_ID_CLIENTE from OSS where FK_ID_CLIENTE = '{cli_id}'");
				dgv_oss_client.DataSource = dt_view;
			}
			catch(FbException fbex)
            {
				throw fbex;
            }
			

		}

		internal void buscarCEP()
        {           
			if(!string.IsNullOrWhiteSpace(msk_cep.Text))
            {
                try
                { // WS => ViaCep
					ViaCepClient pesquisa_cep = new ViaCepClient();
					ViaCepResult endereco = pesquisa_cep.Search(msk_cep.Text);
										
					cbx_uf.Text = endereco.StateInitials;
					txt_cidade.Text = endereco.City;
					txt_bairro.Text = endereco.Neighborhood;
					txt_rua.Text = endereco.Street;
					
				}
				catch (Exception ex)	
				{
					MessageBox.Show(ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Informe um CEP válido!");
			}

		}


		internal static bool validarCpf(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}



		private void pbx_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pbx_minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

        private void btn_validarCpf_Click(object sender, EventArgs e)
        {//melhorar
			if(validarCpf(msk_cpf.Text) == false)
            {
				msk_cpf.BackColor = Color.Red;
            }
            else
            {
				msk_cpf.BackColor = Color.GreenYellow;
			}
         		
        }

        private void btn_buscarEndereco_Click(object sender, EventArgs e)
        {
			buscarCEP();
        }

        private void rtx_obs_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.KeyChar = Char.ToUpper(e.KeyChar);
		}

        private void btn_limparForm_Click(object sender, EventArgs e)
        {
			limparForm();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
			Cliente new_cli = new Cliente();
			Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
				new_cli.Nome = "NOVO CLIENTE";
				new_cli.Data_Cadastro = DateTime.Today.ToString("dd.MM.yyyy");
				acesso_fb.exe_CRUD($"insert into CLIENTES(CLI_NOME, CLI_DATA_CADASTRO) values('{new_cli.Nome}', '{new_cli.Data_Cadastro}')");
				new_cli.ID = Convert.ToInt32(acesso_fb.fb_Get_Info_Dtr($"select CLI_ID from CLIENTES where CLI_ID = (select max(CLI_ID) from CLIENTES)", $"cli_id"));
				txt_id.Text = new_cli.ID.ToString();
				txt_nome.Text = new_cli.Nome;
				msk_dataCadCli.Text = new_cli.Data_Cadastro;
								
			}
			catch(FbException fbex)
            {
				throw fbex;
            }
		}

        private void btn_save_Click(object sender, EventArgs e)
        {
			Cliente updt_cli = new Cliente();
			Acesso_FB acesso_fb = new Acesso_FB();

			updt_cli.Cep = msk_cep.Text;
			updt_cli.Cpf = msk_cpf.Text;
			updt_cli.Rg = msk_rg.Text;
			updt_cli.Tel_fixo = msk_telFixo.Text;
			updt_cli.Whatsapp = msk_whatsapp.Text;
			updt_cli.Bairro = txt_bairro.Text;
			updt_cli.Cidade = txt_cidade.Text;
			updt_cli.Email = txt_email.Text;
			updt_cli.Nome = txt_nome.Text;
			updt_cli.Numero = txt_num.Text;
			updt_cli.Endereco = txt_rua.Text;
			updt_cli.Obs = rtx_obs.Text;
			updt_cli.Uf = cbx_uf.Text;
			updt_cli.Data_Nascimento = msk_dataNasc.Text;
			updt_cli.ID = Convert.ToInt32(txt_id.Text);

			try
            {
				acesso_fb.exe_CRUD($"update CLIENTES set " +
				$"CLI_ID = {updt_cli.ID}, " +
				$"CLI_NOME = '{updt_cli.Nome}', " +
				$"CLI_RG = '{updt_cli.Rg}', " +
				$"CLI_CPF = '{updt_cli.Cpf}', " +
				$"CLI_DATANASCIMENTO = '{updt_cli.Data_Nascimento}', " +
				$"CLI_EMAIL = '{updt_cli.Email}', " +
				$"CLI_BAIRRO = '{updt_cli.Bairro}', " +
				$"CLI_NUMERO = '{updt_cli.Numero}', " +
				$"CLI_CELULAR = '{updt_cli.Whatsapp}', " +
				$"CLI_TELFIXO = '{updt_cli.Tel_fixo}', " +
				$"CLI_OBS = '{updt_cli.Obs}', " +
				$"CLI_CIDADE = '{updt_cli.Cidade}', " +
				$"CLI_UF = '{updt_cli.Uf}', " +
				$"CLI_CEP = '{updt_cli.Cep}', " +
				$"CLI_RUA = '{updt_cli.Endereco}' " +
				$"where CLI_ID = '{updt_cli.ID}'");

				MessageBox.Show("Alterações feitas com sucesso!");
				
			}
			catch(FbException fbex)
            {
				throw fbex;
            }
			
		}

        private void dgv_oss_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.ColumnIndex == this.SELECIONAR.Index && e.RowIndex >= 0)
            {
				Os os_selected = new Os();
				os_selected.Cliente_ID = Convert.ToInt32(dgv_oss_client.Rows[e.RowIndex].Cells["FK_ID_CLIENTE"].Value.ToString());

				Cad_Os show_os = new Cad_Os(0, Convert.ToInt32(os_selected.Cliente_ID));
				this.Close();
				show_os.ShowDialog();
				
			}

		}

        private void btn_excluir_Click(object sender, EventArgs e)
        {
			if(txt_id.Text != "" && MessageBox.Show("Deseja mesmo DELETAR PERMANENTEMENTE esse CLIENTE? Os Dados dele, suas OS's e PAGAMENTOS serão Excluídos!", "Atenção",
				MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
				MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
				Cliente del_cli = new Cliente();
				Acesso_FB acesso_fb = new Acesso_FB();
				del_cli.ID = Convert.ToInt32(txt_id.Text);
								
				Pagamento_A_Receber del_pag_a_fazer = new Pagamento_A_Receber();
								
                try
                {
					string get_id_os = acesso_fb.fb_Get_Info_Dtr($"select OS_ID from OSS where FK_ID_CLIENTE = {del_cli.ID}", "os_id");
					if(get_id_os == null)
                    {
                        acesso_fb.exe_CRUD($"delete from CLIENTES where CLI_ID = '{del_cli.ID}'");
                        
                    }
                    else
                    {
						DataTable dt = acesso_fb.fb_GetDados($"select * from PAGAMENTOS_A_FAZER where FK_OS_ID = '{get_id_os}'");
						if (dt.Rows.Count > 0)
						{
							MessageBox.Show("Não será possível EXCLUIR esse CLIENTE. Ele possui PARCELAS À SEREM PAGAS!");
                        }
                        else
                        {							
							acesso_fb.exe_CRUD($"delete from OSS where OS_ID = '{get_id_os}'");
                            acesso_fb.exe_CRUD($"delete from PAGAMENTOS where FK_OS_ID = '{get_id_os}'");

                       	}


                    }

                    MessageBox.Show("Dados DELETADOS com Sucesso!");
                    limparForm();
                }
				catch(FbException fbex)
                {
					throw fbex;
                }
            }
            else
            {
				MessageBox.Show("Por favor. Clique em PESQUISAR e SELECIONE o CLIENTE Desejado!");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
			Select_Client select_cli = new Select_Client("Cad_Cliente");
			select_cli.ShowDialog();
			this.Close();
        }

        private void btn_conversarWhatsapp_Click(object sender, EventArgs e)
        {
			if(msk_whatsapp.Text == "(  ) .    -")
            {
				MessageBox.Show("ATENÇÂO!: Número de Whatsapp vazio. Por favor INSIRA UM NÚMERO VÁLIDO.");
			}
			else
            {
				string link = $"https://wa.me/55{msk_whatsapp.Text.Replace("(", "").Replace(")", "").Replace(".", "").Replace("-", "")}";
				Process my_web_process = new Process();
				try
				{
					my_web_process.StartInfo.UseShellExecute = true;
					my_web_process.StartInfo.FileName = link;
					my_web_process.Start();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
           
            
				
						
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace RETSYS
{
    public partial class Cad_Os : Form
    {
        internal decimal valor_tot_arms { get; set; }

        public Cad_Os(int id_os, int id_cli)
        {
            InitializeComponent();

            verfica_Text_esf_longe();
            listarAmsForAdd();


            if (id_os > 0 && txt_id.Text != null || txt_id.Text != "")
            {
                ver_os_selected(id_os);
                view_pagamentos_a_receb(id_os);
            }

            if (id_cli > 0)
            {
                add_client(id_cli);
                nova_venda_OS(id_cli);
                try
                {
                    Acesso_FB acesso_fb = new Acesso_FB();
                    acesso_fb.exe_CRUD($"update OSS set FK_ID_CLIENTE = '{txt_add_cli.Text}' where FK_ID_CLIENTE = '1'");

                }catch(FbException fbex)
                {
                    throw fbex;
                }
            }
                
        }

        

        internal void save_Os(string cmd_name)
        {
            Os updt_os = new Os();
            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                updt_os.ESF_SIGN_LONG_D = cbx_sign_long_d.Text;
                updt_os.ESF_D_LONG = msk_esf_long_d.Text;
                updt_os.CIL_D_LONG = msk_cil_long_d.Text;
                updt_os.EIXO_D_LONG = txt_eixo_long_d.Text;

                updt_os.ESF_SIGN_LONG_E = cbx_sign_long_e.Text;
                updt_os.ESF_E_LONG = msk_esf_long_e.Text;
                updt_os.CIL_E_LONG = msk_cil_long_e.Text;
                updt_os.EIXO_E_LONG = txt_eixo_long_e.Text;

                updt_os.ESF_SIGN_PERT_D = cbx_sign_pert_d.Text;
                updt_os.ESF_D_PERT = msk_esf_pert_d.Text;
                updt_os.CIL_D_PERT = msk_cil_pert_d.Text;
                updt_os.EIXO_D_PERT = txt_eixo_pert_d.Text;

                updt_os.ESF_SIGN_PERT_E = cbx_sign_pert_e.Text;
                updt_os.ESF_E_PERT = msk_esf_pert_e.Text;
                updt_os.CIL_E_PERT = msk_cil_pert_e.Text;
                updt_os.EIXO_E_PERT = txt_eixo_pert_e.Text;

                updt_os.ID = Convert.ToInt32(txt_id.Text);
                updt_os.Medico = txt_medico.Text;
                updt_os.OS = txt_os.Text;
                updt_os.Adicao = msk_adicao.Text;
                updt_os.Data_Receita = msk_receita.Text;
                updt_os.Data_Final_Pagamento = msk_ultm_pgto.Text;
                updt_os.Valor_Total_Venda = msk_valorTotalVenda.Text;
                updt_os.Marca_Modelo_Lente = cbx_marca_lnt.Text;
                updt_os.Material_Lente = cbx_material_lnt.Text;
                updt_os.Tipo_Lente = cbx_tipo_lnt.Text;
                updt_os.Obs = rtx_obs.Text;
                updt_os.Seller = txt_seller.Text;
                updt_os.Data_Venda = msk_dataVenda.Text;

                acesso_fb.exe_CRUD($"update OSS set OS_DATA_RECEITA = '{updt_os.Data_Receita}', " +
                    $"OS_MEDICO = '{updt_os.Medico}', OS_TIPO_LENTE = '{updt_os.Tipo_Lente}', "
                   + $"OS_MARCA_MODELO_LENTE = '{updt_os.Marca_Modelo_Lente}', "
                  + $"OS_ESF_D_LONG = '{updt_os.ESF_D_LONG}', "
                  + $"OS_ESF_E_LONG = '{updt_os.ESF_E_LONG}', "
                  + $"OS_ESF_D_PERT = '{updt_os.ESF_D_PERT}', "
                  + $"OS_ESF_E_PERT = '{updt_os.ESF_E_PERT}', "
                  + $"OS_CIL_D_LONG = '{updt_os.CIL_D_LONG}', "
                  + $"OS_CIL_E_LONG = '{updt_os.CIL_E_LONG}', "
                  + $"OS_CIL_D_PERT = '{updt_os.CIL_D_PERT}', "
                  + $"OS_CIL_E_PERT = '{updt_os.CIL_E_PERT}', "
                 + $" OS_EIXO_D_LONG = '{updt_os.EIXO_D_LONG}', "
                 + $"OS_EIXO_E_LONG = '{updt_os.EIXO_E_LONG}', "
                 + $" OS_EIXO_D_PERT = '{updt_os.EIXO_D_PERT}', "
                 + $" OS_EIXO_E_PERT = '{updt_os.EIXO_E_PERT}', "
                 + $" OS_ESF_SIGN_LONG_D = '{updt_os.ESF_SIGN_LONG_D}', "
                 + $" OS_ESF_SIGN_LONG_E = '{updt_os.ESF_SIGN_LONG_E}', "
                 + $" OS_ESF_SIGN_PERT_D = '{updt_os.ESF_SIGN_PERT_D}', "
                 + $"OS_ESF_SIGN_PERT_E = '{updt_os.ESF_SIGN_PERT_E}', "
                 + $"OS_MATERIAL_LENTE = '{updt_os.Material_Lente}', OS_OBS = '{updt_os.Obs}', OS_ADICAO = '{updt_os.Adicao}',"
                 + $"OS_DATAFINAL_PAGAMENTO = '{updt_os.Data_Final_Pagamento}', OS_DATA_VENDA = '{updt_os.Data_Venda}', " +
                   $"FK_ID_CLIENTE = '{txt_add_cli.Text}', OS_VALOR_TOTAL_VENDA = '{updt_os.Valor_Total_Venda}',"
                 + $"OS_OS = '{updt_os.OS}', OS_VENDEDOR = '{updt_os.Seller}' where OS_ID = {updt_os.ID}"); 

                if(cmd_name == "update")
                {
                    MessageBox.Show("Dados gravados com SUCESSO!");
                }
            }
            catch (FbException fbex)
            {
                throw fbex;
            }
        }

        internal void nova_venda_OS(int id_cli)
        {
            if (txt_os.Text == "NOVA OS" || txt_os.Text == "" || txt_os.Text == null)
            {                
              rtx_obs.Text = "DNP OD:{DIGITE AQUI}" +
                            "\nDNP OE:{DIGITE AQUI}" +
                            "\nALT OD:{DIGITE AQUI}" +
                            "\nALT OE:{DIGITE AQUI}" +
                            "\nPO: {DIGITE AQUI}" +
                            "\nARO: {DIGITE AQUI}" +
                            "\nVERT: {DIGITE AQUI}" +
                            "\nDM: {DIGITE AQUI} ";

                msk_receita.Text = DateTime.Today.ToString("dd.MM.yyyy");
                msk_ultm_pgto.Text = DateTime.Today.ToString("dd.MM.yyyy");
                if(id_cli > 0)
                {
                    txt_add_cli.Text = id_cli.ToString();
                }
                else
                {
                    txt_add_cli.Text = "1";
                }
                msk_dataVenda.Text = DateTime.Today.ToString("dd.MM.yyyy");
                txt_seller.Text = Acesso_FB.usuario_logado;

            }
            else
            {
                Acesso_FB acesso_fb = new Acesso_FB();
                Os os_jaExiste = new Os();
                try
                {
                    os_jaExiste.Obs = acesso_fb.fb_Get_Info_Dtr($"select OS_OBS from OSS where OS_ID = '{txt_id.Text}'", "os_obs");
                    os_jaExiste.Seller = acesso_fb.fb_Get_Info_Dtr($"select OS_VENDEDOR from OSS where OS_ID = '{txt_id.Text}'", "os_vendedor");
                    os_jaExiste.Data_Receita = acesso_fb.fb_Get_Info_Dtr($"select OS_DATA_RECEITA from OSS where OS_ID = '{txt_id.Text}'", "os_data_receita");
                    os_jaExiste.Data_Venda = acesso_fb.fb_Get_Info_Dtr($"select OS_DATA_VENDA from OSS where OS_ID = '{txt_id.Text}'", "os_data_venda");
                    os_jaExiste.Data_Final_Pagamento = acesso_fb.fb_Get_Info_Dtr($"select OS_DATAFINAL_PAGAMENTO from OSS where OS_ID = '{txt_id.Text}'", "os_datafinal_pagamento");
                    
                    rtx_obs.Text = os_jaExiste.Obs;
                    msk_receita.Text = os_jaExiste.Data_Receita;
                    msk_ultm_pgto.Text = os_jaExiste.Data_Final_Pagamento;
                    txt_add_cli.Text = acesso_fb.fb_Get_Info_Dtr($"select FK_ID_CLIENTE from OSS where OS_ID = '{txt_id.Text}'", "fk_id_cliente");
                    msk_dataVenda.Text = os_jaExiste.Data_Venda;
                    txt_seller.Text = os_jaExiste.Seller;

                }
                catch(FbException fbex)
                {
                    throw fbex;
                }

            }

        }

        internal void listarAmsForAdd()
        {
            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                FbConnection fb_conn = acesso_fb.getConexao();
                fb_conn.Open();
                string cmd_sql = "select ARM_ID, ARM_REFERENCIA from ARMACOES";
                FbDataAdapter fadapter = new FbDataAdapter(cmd_sql, fb_conn);
                DataTable dt = new DataTable();
                dt.Clear();
                fadapter.Fill(dt);

                DataView dtv = dt.DefaultView;
                dtv.Sort = "ARM_ID";
                DataTable dtS = dtv.ToTable();

               cbx_add_arm.Items.Clear();
               cbx_add_arm.DataSource = dt;
               cbx_add_arm.ValueMember = "ARM_ID";
               cbx_add_arm.DisplayMember = "ARM_REFERENCIA"; 
               cbx_add_arm.SelectedItem = null;
               cbx_add_arm.Refresh();

                fb_conn.Close();
                             

            }catch(FbException fbex)
            {
                throw fbex;
            }
           
        }

        internal void verfica_Text_esf_longe()
        {
            if(msk_esf_long_d.Text == " .")
            {
                msk_esf_long_d.Text = "000";
            }

           if(msk_esf_long_e.Text == " .")
           {
               msk_esf_long_e.Text = "000";
           }
            
        }

        internal void view_pagamentos_a_receb(int os_id)
        {            
            Pagamento_A_Receber pgto_a_receb = new Pagamento_A_Receber();
            pgto_a_receb.Os_ID = os_id;
            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                DataTable dt = acesso_fb.fb_GetDados($"select PGAR_PARCELA_NOME as Nome_Parc, PGAR_VALOR as R$, PGAR_DATA_PAGAMENTO as Data, FK_OS_ID from PAGAMENTOS_A_RECEBER where FK_OS_ID = {pgto_a_receb.Os_ID}");
                dgv_pgto_aReceb.DataSource = dt; 

            }
            catch(FbException fbex)
            {
                throw fbex;
            }
        }

        internal void limparForm()
        {
            txt_add_cli.Clear();
            txt_eixo_long_d.Clear();
            txt_eixo_long_e.Clear();
            txt_eixo_pert_d.Clear();
            txt_eixo_pert_e.Clear();
            txt_id.Clear();
            txt_medico.Clear();
            txt_os.Clear();
            msk_adicao.Clear();
            msk_cil_long_d.Clear();
            msk_cil_long_e.Clear();
            msk_cil_pert_d.Clear();
            msk_cil_pert_e.Clear();
            msk_esf_long_d.Clear();
            msk_esf_long_e.Clear();
            msk_esf_pert_d.Clear();
            msk_esf_pert_e.Clear();
            msk_receita.Clear();
            msk_ultm_pgto.Clear();
            msk_valorTotalVenda.Clear();
            cbx_marca_lnt.Text = "";
            cbx_material_lnt.Text = "";
            cbx_sign_long_d.Text = "";
            cbx_sign_long_e.Text = "";
            cbx_sign_pert_d.Text = "";
            cbx_sign_pert_e.Text = "";
            cbx_tipo_lnt.Text = "";
            rtx_obs.Text = "";
            txt_seller.Clear();
            cbx_add_arm.Text = "";
            dgv_armsInseridas.DataSource = "";
            dgv_exibirOS.DataSource = "";
            dgv_pgto_aReceb.DataSource = "";
            msk_dataVenda.Clear();
            lbl_valorTotArms.Text = "Total: R$";
        }

        internal void ver_os_selected(int id_os)
        {
            Acesso_FB acesso_fb = new Acesso_FB();
            Os os_view = new Os();
            try
            {
                os_view.ID = id_os;
                os_view.Seller = acesso_fb.fb_Get_Info_Dtr($"select OS_VENDEDOR from OSS where OS_ID = {os_view.ID}", "os_vendedor");
                os_view.Obs = acesso_fb.fb_Get_Info_Dtr($"select OS_OBS from OSS where OS_ID = {os_view.ID}", "os_obs");
                os_view.Data_Venda = acesso_fb.fb_Get_Info_Dtr($"select OS_DATA_VENDA from OSS where OS_ID = {os_view.ID}", "os_data_venda");
                os_view.Valor_Total_Venda = acesso_fb.fb_Get_Info_Dtr($"select OS_VALOR_TOTAL_VENDA from OSS where OS_ID = {os_view.ID}", "os_valor_total_venda");
                os_view.Data_Receita = acesso_fb.fb_Get_Info_Dtr($"select OS_DATA_RECEITA from OSS where OS_ID = {os_view.ID}", "os_data_receita");
                os_view.Data_Final_Pagamento = acesso_fb.fb_Get_Info_Dtr($"select OS_DATAFINAL_PAGAMENTO from OSS where OS_ID = {os_view.ID}", "os_datafinal_pagamento");
                os_view.Marca_Modelo_Lente = acesso_fb.fb_Get_Info_Dtr($"select OS_MARCA_MODELO_LENTE from OSS where OS_ID = {os_view.ID}", "os_marca_modelo_lente");
                os_view.Material_Lente = acesso_fb.fb_Get_Info_Dtr($"select OS_MATERIAL_LENTE from OSS where OS_ID = {os_view.ID}", "os_material_lente");
                os_view.Medico = acesso_fb.fb_Get_Info_Dtr($"select OS_MEDICO from OSS where OS_ID = {os_view.ID}", "os_medico");
                os_view.Obs = acesso_fb.fb_Get_Info_Dtr($"select OS_OBS from OSS where OS_ID = {os_view.ID}", "os_obs");
                os_view.OS = acesso_fb.fb_Get_Info_Dtr($"select OS_OS from OSS where OS_ID = {os_view.ID}", "os_os");
                os_view.Tipo_Lente = acesso_fb.fb_Get_Info_Dtr($"select OS_TIPO_LENTE from OSS where OS_ID = {os_view.ID}", "os_tipo_lente");
                os_view.Adicao = acesso_fb.fb_Get_Info_Dtr($"select OS_ADICAO from OSS where OS_ID = {os_view.ID}", "os_adicao");
                txt_add_cli.Text = acesso_fb.fb_Get_Info_Dtr($"select FK_ID_CLIENTE from OSS where OS_ID = {os_view.ID}", "fk_id_cliente");
                txt_id.Text = os_view.ID.ToString();
                os_view.ESF_D_LONG = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_D_LONG from OSS where OS_ID = {os_view.ID}", "os_esf_d_long");
                os_view.ESF_E_LONG = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_E_LONG from OSS where OS_ID = {os_view.ID}", "os_esf_e_long");
                os_view.ESF_D_PERT = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_D_PERT from OSS where OS_ID = {os_view.ID}", "os_esf_d_pert");
                os_view.ESF_E_PERT = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_E_PERT from OSS where OS_ID = {os_view.ID}", "os_esf_e_pert");
                os_view.CIL_D_PERT = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_E_PERT from OSS where OS_ID = {os_view.ID}", "os_esf_e_pert");
                os_view.CIL_D_LONG = acesso_fb.fb_Get_Info_Dtr($"select OS_CIL_D_LONG from OSS where OS_ID = {os_view.ID}", "os_cil_d_long");
                os_view.CIL_E_LONG = acesso_fb.fb_Get_Info_Dtr($"select OS_CIL_E_LONG from OSS where OS_ID = {os_view.ID}", "os_cil_e_long");
                os_view.CIL_D_PERT = acesso_fb.fb_Get_Info_Dtr($"select OS_CIL_D_PERT from OSS where OS_ID = {os_view.ID}", "os_cil_d_pert");
                os_view.CIL_E_PERT = acesso_fb.fb_Get_Info_Dtr($"select OS_CIL_E_PERT from OSS where OS_ID = {os_view.ID}", "os_cil_e_pert");
                os_view.EIXO_D_LONG = acesso_fb.fb_Get_Info_Dtr($"select OS_EIXO_D_LONG from OSS where OS_ID = {os_view.ID}", "os_eixo_d_long");
                os_view.EIXO_E_LONG = acesso_fb.fb_Get_Info_Dtr($"select OS_EIXO_E_LONG from OSS where OS_ID = {os_view.ID}", "os_eixo_e_long");
                os_view.EIXO_D_PERT = acesso_fb.fb_Get_Info_Dtr($"select OS_EIXO_D_PERT from OSS where OS_ID = {os_view.ID}", "os_eixo_d_pert");
                os_view.EIXO_E_PERT = acesso_fb.fb_Get_Info_Dtr($"select OS_EIXO_E_PERT from OSS where OS_ID = {os_view.ID}", "os_eixo_e_pert");
                os_view.ESF_SIGN_LONG_D = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_SIGN_LONG_D from OSS where OS_ID = {os_view.ID}", "os_esf_sign_long_d");
                os_view.ESF_SIGN_LONG_E = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_SIGN_LONG_E from OSS where OS_ID = {os_view.ID}", "os_esf_sign_long_e");
                os_view.ESF_SIGN_PERT_D = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_SIGN_PERT_D from OSS where OS_ID = {os_view.ID}", "os_esf_sign_pert_d");
                os_view.ESF_SIGN_PERT_E = acesso_fb.fb_Get_Info_Dtr($"select OS_ESF_SIGN_PERT_E from OSS where OS_ID = {os_view.ID}", "os_esf_sign_pert_e");

                txt_medico.Text = os_view.Medico;
                txt_os.Text = os_view.OS;
                msk_adicao.Text = os_view.Adicao;
                msk_esf_long_d.Text = os_view.ESF_D_LONG;
                msk_esf_long_e.Text = os_view.ESF_E_LONG;
                msk_cil_long_d.Text = os_view.CIL_D_LONG;
                msk_cil_long_e.Text = os_view.CIL_E_LONG;
                msk_esf_pert_d.Text = os_view.ESF_D_PERT;
                msk_esf_pert_e.Text = os_view.ESF_E_PERT;
                msk_cil_pert_d.Text = os_view.CIL_D_PERT; 
                msk_cil_pert_e.Text = os_view.CIL_E_PERT; 
                txt_eixo_long_d.Text = os_view.EIXO_D_LONG;
                txt_eixo_long_e.Text = os_view.EIXO_E_LONG;
                txt_eixo_pert_d.Text = os_view.EIXO_D_PERT;
                txt_eixo_pert_e.Text = os_view.EIXO_E_PERT;
                cbx_sign_long_d.Text = os_view.ESF_SIGN_LONG_D;
                cbx_sign_long_e.Text = os_view.ESF_SIGN_LONG_E;
                cbx_sign_pert_d.Text = os_view.ESF_SIGN_PERT_D;
                cbx_sign_pert_e.Text = os_view.ESF_SIGN_PERT_E;
                msk_receita.Text = os_view.Data_Receita;
                msk_ultm_pgto.Text = os_view.Data_Final_Pagamento;
                msk_valorTotalVenda.Text = os_view.Valor_Total_Venda;
                cbx_marca_lnt.Text = os_view.Marca_Modelo_Lente;
                cbx_material_lnt.Text = os_view.Material_Lente;
                cbx_tipo_lnt.Text = os_view.Tipo_Lente;
                rtx_obs.Text = os_view.Obs;
                txt_seller.Text = os_view.Seller;
                msk_dataVenda.Text = os_view.Data_Venda;
            }
            catch(FbException fbex)
            {
                throw fbex;
            }
        }

        internal void add_client(int id_cli)
        {
            Acesso_FB acesso_fb = new Acesso_FB();
            Os os = new Os();
            
            try
            {
               os.ID = Convert.ToInt32(acesso_fb.fb_Get_Info_Dtr("select OS_ID from OSS where OS_ID = (select max(OS_ID) from OSS)", "os_id"));
            }
            catch (FbException fbex)
            {
                throw fbex;
            }

            txt_id.Text = os.ID.ToString();
            txt_os.Text = "NOVA OS";
            txt_add_cli.Text = id_cli.ToString();
        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_limparForm_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            nova_venda_OS(0);
                                       
            Acesso_FB acesso_fb = new Acesso_FB();
            Os new_os = new Os();
            new_os.OS = "NOVA OS";
            new_os.Valor_Total_Venda = "0000.00";
            new_os.Data_Venda = DateTime.Today.ToString("dd.MM.yyyy");
            Usuario user_venda = new Usuario();
            user_venda.Nome = Acesso_FB.usuario_logado;
            msk_cil_long_d.Text = "000.00";
            msk_cil_long_e.Text = "000.00";
            msk_cil_pert_e.Text = "000.00";
            msk_cil_pert_d.Text = "000.00";
            msk_esf_pert_d.Text = "000.00";
            msk_esf_pert_e.Text = "000.00";
            txt_eixo_long_d.Text = "000";
            txt_eixo_long_e.Text = "000";
            txt_eixo_pert_d.Text = "000";
            txt_eixo_pert_e.Text = "000";
            cbx_sign_long_d.Text = "+";
            cbx_sign_long_e.Text = "-";
            cbx_sign_pert_d.Text = "-";
            cbx_sign_pert_e.Text = "+";

            try
            {
                acesso_fb.exe_CRUD($"insert into OSS(OS_OS, OS_VALOR_TOTAL_VENDA, OS_DATA_VENDA, OS_VENDEDOR)" +
                $" VALUES('{new_os.OS}', '{new_os.Valor_Total_Venda}', '{new_os.Data_Venda}', '{user_venda.Nome}')");
                 
                txt_id.Text = acesso_fb.fb_Get_Info_Dtr($"select OS_ID from OSS where OS_ID = (select max(OS_ID) FROM OSS)", "os_id");
                txt_os.Text = new_os.OS;
                msk_valorTotalVenda.Text = new_os.Valor_Total_Venda;
                txt_seller.Text = user_venda.Nome;
                msk_dataVenda.Text = new_os.Data_Venda;

                save_Os("insert");

            }
            catch(FbException fbex)
            {
                throw fbex;
            }
        }

        private void rtx_obs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dgv_pgto_aReceb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.VER_CLI.Index && e.RowIndex >= 0)
            {

                Acesso_FB acesso_fb = new Acesso_FB();
                Pagamento_A_Receber pag_a_rec = new Pagamento_A_Receber();
                pag_a_rec.Os_ID = Convert.ToInt32(acesso_fb.fb_Get_Info_Dtr($"select FK_OS_ID from PAGAMENTOS_A_RECEBER where FK_OS_ID = '{dgv_pgto_aReceb.Rows[e.RowIndex].Cells["FK_OS_ID"].Value}'", "fk_os_id"));
                    
                Os os_pgar_cli = new Os();
                os_pgar_cli.Cliente_ID = Convert.ToInt32(acesso_fb.fb_Get_Info_Dtr($"select FK_ID_CLIENTE from OSS where OS_ID = '{pag_a_rec.Os_ID}'", "fk_id_cliente"));

                Cad_Cliente show_cli = new Cad_Cliente(os_pgar_cli.Cliente_ID);
                show_cli.ShowDialog();
            }
        }

        private void btn_add_cli_Click(object sender, EventArgs e)
        {
            Select_Client add_cli = new Select_Client("Cad_Os");
            add_cli.ShowDialog();
            this.Close();

        }

        private void btn_calc_grauPert_Click(object sender, EventArgs e)
        {
            if(msk_adicao.Text == "+ .")
            {
                MessageBox.Show("ATENÇÂO: O Campo da ADIÇÂO não pode estar VAZIO!");
            }
            else
            {
                decimal esf_longe_d = Convert.ToDecimal(cbx_sign_long_d.Text + msk_esf_long_d.Text);
                decimal esf_longe_e = Convert.ToDecimal(cbx_sign_long_e.Text + msk_esf_long_e.Text);
                decimal ad = Convert.ToDecimal(msk_adicao.Text.Replace("+", ""));

                decimal esf_perto_d = esf_longe_d + ad;
                decimal esf_perto_e = esf_longe_e + ad;

                msk_cil_pert_d.Text = msk_cil_long_d.Text;
                msk_cil_pert_e.Text = msk_cil_long_e.Text;
                txt_eixo_pert_d.Text = txt_eixo_long_d.Text;
                txt_eixo_pert_e.Text = txt_eixo_long_e.Text;

                if (esf_perto_d >= 0)
                {
                    cbx_sign_pert_d.Text = "+";
                }
                else
                {
                    cbx_sign_pert_d.Text = "-";
                }


                if (esf_perto_e >= 0)
                {
                    cbx_sign_pert_e.Text = "+";
                }
                else
                {
                    cbx_sign_pert_e.Text = "-";
                }

                msk_esf_pert_d.Text = esf_perto_d.ToString();
                msk_esf_pert_e.Text = esf_perto_e.ToString();

            }
          
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save_Os("update");
        }

        private void btn_addArms_Click(object sender, EventArgs e)
        {
            if(cbx_add_arm.Text != null)
            {
                Armacao arms = new Armacao();
                Armacao_Venda arm_slct = new Armacao_Venda();
                Acesso_FB acesso_fb = new Acesso_FB();
                   
                try
                {
                    
                   if(txt_add_cli.Text == null || txt_add_cli.Text == "")
                   {
                        MessageBox.Show("ATENÇÂO! Cliente não selecionado. Insira o CLIENTE antes de inserir a ARMAÇÂO!");
                   }
                    else
                    {
                        if(txt_add_cli.Text == "1")
                        {
                            MessageBox.Show("ATENÇÃO: O CLIENTE de ID 1 é APENAS 'teste', Por favor escolha outro CLIENTE!");
                        }
                        else
                        {
                            arms.Referencia = cbx_add_arm.Text;

                            arms.ID = Convert.ToInt32(acesso_fb.fb_Get_Info_Dtr($"select ARM_ID from ARMACOES where ARM_REFERENCIA = '{arms.Referencia}'", "arm_id"));
                            arms.Preco_Final_Venda = acesso_fb.fb_Get_Info_Dtr($"select ARM_PRECO_FINAL_VENDA from ARMACOES where ARM_ID = '{arms.ID}'", "arm_preco_final_venda");
                                                     
                           
                            string qtd_estq_str = acesso_fb.fb_Get_Info_Dtr($"select ARM_QTD_ESTOQUE from ARMACOES where ARM_REFERENCIA = '{arms.Referencia}'", "arm_qtd_estoque");
                            int qtd_arm_n = Convert.ToInt32(qtd_estq_str);

                            if (qtd_estq_str == null || qtd_estq_str == "" && qtd_arm_n > 0)
                            {
                                MessageBox.Show("A ARMAÇÂO Selecionado NÃO TEM EM ESTOQUE ! Por favor: Verifique! ");
                            }
                            else
                            {

                                int qtd_estq_atual = Convert.ToInt32(qtd_estq_str);

                                acesso_fb.exe_CRUD($"update ARMACOES set ARM_QTD_ESTOQUE = '{qtd_estq_atual - 1}' where ARM_REFERENCIA = '{arms.Referencia}'");
                                acesso_fb.exe_CRUD($"insert into ARMACOES_VENDA(FK_OS_ID, REFERENCIA_ARM) values('{txt_id.Text}', '{arms.Referencia}')");
                                if (arms.Preco_Final_Venda == null || arms.Preco_Final_Venda == "    ." || arms.Preco_Final_Venda == "")
                                {
                                    valor_tot_arms = Convert.ToDecimal(000.00);
                                }
                                else
                                {
                                    valor_tot_arms += Convert.ToDecimal(arms.Preco_Final_Venda);
                                }

                                DataTable dt_1 = acesso_fb.fb_GetDados($"select REFERENCIA_ARM as REF from ARMACOES_VENDA where FK_OS_ID = '{txt_id.Text}'");
                                dgv_armsInseridas.DataSource = dt_1;
                                acesso_fb.exe_CRUD($"update OSS set OS_OS = '{txt_os.Text}'");
                                DataTable dt_2 = acesso_fb.fb_GetDados($"select OS_OS as OS from OSS where OS_ID = '{txt_id.Text}'");
                                dgv_exibirOS.DataSource = dt_2;                              
                                MessageBox.Show($"Armação REF: {arms.Referencia} Inserida na OS: {txt_os.Text} !");
                                lbl_valorTotArms.Text += $" {valor_tot_arms}";
                                msk_valorTotalVenda.Text += $" {valor_tot_arms}";
                                dgv_armsInseridas.Refresh();
                            }
                        }
                       
                           
                      
                    }
                   
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
            }
            else
            {
                MessageBox.Show($"ATENÇÂO. Selecione uma ARMAÇÂO para adicionar a OS: {txt_id.Text}");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(txt_id.Text == "" || txt_id.Text == null)
            {
                MessageBox.Show("OS não Selecionada! Por favor clique em PESQUISAR e SELECIONE uma OS.");
            }
            else
            {
                Acesso_FB acesso_fb = new Acesso_FB();
                DataTable dt = acesso_fb.fb_GetDados($"select * from PAGAMENTOS_A_RECEBER where FK_OS_ID = '{txt_id.Text}'");
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("ATENÇÃO: Essa OS possuí PAGAMENTOS À RECEBER. Por favor. Confira.");
                }
                else
                {
                    if(MessageBox.Show("Deseja mesmo DELETAR PERMANENTEMENTE essa OS? Os Dados dela, suas ARMAÇÕES INSERIDAS e PAGAMENTOS REALIZADOS serão Excluídos!", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Os del_os = new Os();
                        del_os.ID = Convert.ToInt32(txt_id.Text);

                        acesso_fb.exe_CRUD($"delete from PAGAMENTOS where FK_OS_ID = {del_os.ID}");
                        acesso_fb.exe_CRUD($"delete from ARMACOES_VENDA where FK_OS_ID = {del_os.ID}");
                        acesso_fb.exe_CRUD($"delete from OSS where OS_ID = {del_os.ID}");

                        MessageBox.Show("Dados EXCLUÍDOS com Sucesso!");
                        limparForm();
                    }
                }
            }
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Select_Os select_os = new Select_Os();
            select_os.ShowDialog();
            this.Close();
        }
                
    }
}

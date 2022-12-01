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
    public partial class Cad_Pgtos_A_Receber : Form
    {

        public Cad_Pgtos_A_Receber(int pgto_a_rec_ID)
        {
            InitializeComponent();

            view_oss();

            if (pgto_a_rec_ID > 0)
            {
                view_pgtoARceb(pgto_a_rec_ID);
            }


        }

        internal void view_oss()
        {
            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                FbConnection fb_conn = acesso_fb.getConexao();
                fb_conn.Open();
                string cmd_sql = "select OS_ID, OS_OS from OSS";
                FbDataAdapter fadapter = new FbDataAdapter(cmd_sql, fb_conn);
                DataTable dt = new DataTable();
                dt.Clear();
                fadapter.Fill(dt);

                DataView dtv = dt.DefaultView;
                dtv.Sort = "OS_ID";
                DataTable dtS = dtv.ToTable();

                cbx_slc_os.Items.Clear();
                cbx_slc_os.DataSource = dt;
                cbx_slc_os.ValueMember = "OS_ID";
                cbx_slc_os.DisplayMember = "OS_OS";
                cbx_slc_os.SelectedItem = null;
                cbx_slc_os.Refresh();
                

                fb_conn.Close();
            }
            catch (FbException fbex)
            {
                throw fbex;
            }
        }

        internal void view_pgtoARceb(int id_aReceb)
        {
            Acesso_FB acesso_fb = new Acesso_FB();

            try
            {
                Pagamento_A_Receber view_pag_a_receb = new Pagamento_A_Receber();
                view_pag_a_receb.ID = id_aReceb;
                view_pag_a_receb.Forma_Pagamento = acesso_fb.fb_Get_Info_Dtr($"select PGAR_FORMA_PAGAMENTO from PAGAMENTOS_A_RECEBER where PGAR_ID = {view_pag_a_receb.ID}", "pgar_forma_pagamento");
                view_pag_a_receb.Data_Pagamento = acesso_fb.fb_Get_Info_Dtr($"select PGAR_DATA_PAGAMENTO from PAGAMENTOS_A_RECEBER where PGAR_ID = {view_pag_a_receb.ID}", "pgar_data_pagamento");
                view_pag_a_receb.Num_Parcelas = acesso_fb.fb_Get_Info_Dtr($"select PGAR_NUM_PARCELAS from PAGAMENTOS_A_RECEBER where PGAR_ID = {view_pag_a_receb.ID}", "pgar_num_parcelas");
                view_pag_a_receb.Data_Pagamento = acesso_fb.fb_Get_Info_Dtr($"select PGAR_DATA_PAGAMENTO from PAGAMENTOS_A_RECEBER where PGAR_ID = {view_pag_a_receb.ID}", "pgar_data_pagamento");
                view_pag_a_receb.Parcela_Nome = acesso_fb.fb_Get_Info_Dtr($"select PGAR_PARCELA_NOME from PAGAMENTOS_A_RECEBER where PGAR_ID = {view_pag_a_receb.ID}", "pgar_parcela_nome");
                view_pag_a_receb.Valor = acesso_fb.fb_Get_Info_Dtr($"select PGAR_VALOR from PAGAMENTOS_A_RECEBER where PGAR_ID = {view_pag_a_receb.ID}", "pgar_valor");
                view_pag_a_receb.Valor_Parc = acesso_fb.fb_Get_Info_Dtr($"select PGAR_VALOR_PARC from PAGAMENTOS_A_RECEBER  where PGAR_ID = {view_pag_a_receb.ID}", "pgar_valor_parc");

                string os = acesso_fb.fb_Get_Info_Dtr($"select FK_OS_ID from PAGAMENTOS_A_RECEBER where PGAR_ID = {view_pag_a_receb.ID}", "fk_os_id");
                string os_os = acesso_fb.fb_Get_Info_Dtr($"select OS_OS from OSS where OS_ID = '{os}'", "os_os");

                cbx_formaPgto.Text = view_pag_a_receb.Forma_Pagamento;
                cbx_n_parc.Text = view_pag_a_receb.Num_Parcelas;
                cbx_slc_os.Text = os_os;
                msk_dataPgto.Text = view_pag_a_receb.Data_Pagamento;
                msk_valorTotalVenda.Text = view_pag_a_receb.Valor;
                txt_id.Text = view_pag_a_receb.ID.ToString();
                txt_nomePag.Text = view_pag_a_receb.Parcela_Nome;
                msk_valorParc.Text = view_pag_a_receb.Valor_Parc;

                if(Convert.ToDateTime(msk_dataPgto.Text) > DateTime.Now)
                {
                    MessageBox.Show("ATENÇÃO: Esse PAGAMENTO ESTÁ EM ATRASO! Por favor verifique o CLIENTE na OS e no CADASTRO de CLIENTE para Informações de CONTATO.");
                    this.BackColor = Color.Coral;
                }
            }
            catch (FbException fbex)
            {
                throw fbex;
            }
        }

        internal void limparForm()
        {
            cbx_formaPgto.Text = "";
            cbx_n_parc.Text = "";
            cbx_slc_os.Text = "";
            msk_dataPgto.Clear();
            msk_valorTotalVenda.Clear();
            txt_id.Clear();
            txt_nomePag.Clear();
            msk_valorParc.Clear();
            this.BackColor = Color.YellowGreen;
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limparForm_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Select_Pgto_A_Receb select_Pgto_A_Receb = new Select_Pgto_A_Receb();
            select_Pgto_A_Receb.ShowDialog();
            this.Close();
        }

        

        private void btn_calcPrecoEMontNome_Click(object sender, EventArgs e)
        {
            if (cbx_formaPgto.Text == "" || msk_valorTotalVenda.Text == "" || cbx_n_parc.Text == "" && cbx_slc_os.Text == "")
            {
                MessageBox.Show("ATENÇÃO: A FORMA DE PAGEMENTO, VALOR TOTAL DA VENDA, o NÚMERO DE PARCELAS e a OS devem estar PREENCHIDOS!");
            }
            else
            {
                decimal valorParc = Convert.ToDecimal(msk_valorTotalVenda.Text) / Convert.ToDecimal(cbx_n_parc.Text);
                msk_valorParc.Text = valorParc.ToString("n2");
                int  tot_parc = Convert.ToInt32(cbx_n_parc.Text);//
                                
                    txt_nomePag.Text = $"PARC. 1 / {cbx_n_parc.Text} - REF a OS: {cbx_slc_os.Text}";
                
                // teste for para numero de parcelas   
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {

            if (cbx_formaPgto.Text == "" && msk_valorTotalVenda.Text == "" && cbx_n_parc.Text == "" && cbx_slc_os.Text == "")
            {
                MessageBox.Show("ATENÇÃO: A FORMA DE PAGEMENTO, VALOR TOTAL DA VENDA, o NÚMERO DE PARCELAS e a OS devem estar PREENCHIDOS!");
            }
            else
            {
                if (MessageBox.Show("Deseja mesmo INSERIR PERMANENTEMENTE esse(s) PAGAMENTO(s) À RECEBER? Seus Dados, podem ser ALTERADOS mas não EXCLUÍDOS. CONFIRME POR FAVOR!", "Atenção",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                     MessageBoxDefaultButton.Button1) == DialogResult.Yes) {

                    int n_parc = Convert.ToInt32(cbx_n_parc.Text);
                    int day = DateTime.Today.Day; //dia atual
                    int mo = DateTime.Today.Month;//mes a tual
                    int yr = DateTime.Today.Year; //ano atua
                    msk_dataPgto.Text = DateTime.Today.ToString("dd.MM.yyyy"); // data completa atual
                    string addResult = null;
                    Acesso_FB acesso_fb = new Acesso_FB();
                    string likeAbool = null;
                    string id_os = acesso_fb.fb_Get_Info_Dtr($"select OS_ID from OSS where OS_OS = '{cbx_slc_os.Text}'", "os_id");

                    int sum_mo = 0;
                    if(n_parc > 1)
                    {
                        for (int i = 1; i <= n_parc; i++)
                        {
                            try
                            {

                                if (sum_mo >= 12)// se soma de meses for >= 12
                                {
                                    yr++; // vai para o proximo ano
                                    sum_mo = 1; //mes volta pra 1 - janeiro
                                }

                                if (cbx_n_parc.Text == "1")// se o numero de parcela for == 1
                                {
                                    sum_mo = mo; // a soma de meses recebe 1
                                }


                                else
                                { // o erro esta nesse else
                                    sum_mo = mo + 1; // senao a soma de meses recebe 1 + (i)
                                }



                                string date_parc = $"{day}.{sum_mo}.{yr}";

                                acesso_fb.exe_CRUD($"insert into PAGAMENTOS_A_RECEBER (PGAR_PARCELA_NOME, PGAR_NUM_PARCELAS, "
                                                + "PGAR_DATA_PAGAMENTO, PGAR_FORMA_PAGAMETO, PGAR_VALOR, FK_OS_ID, "
                                                + "PGAR_VALOR_PARC) "
                                                + " values("
                                                + $"'PARC. {i} / {n_parc} - REF a OS: {cbx_slc_os.Text}', "
                                                + $"{sum_mo}, "
                                                + $"'{date_parc}',"
                                                + $"'{cbx_formaPgto.Text}', "
                                                + $"'{msk_valorTotalVenda.Text}', "
                                                + $"'{id_os}', "
                                                + $"'{msk_valorParc.Text.Replace(",", ".")}'"
                                          + ")");

                                likeAbool = "true";

                            }
                            catch (FbException fbex)
                            {
                                throw fbex;
                            }


                        }

                        switch (likeAbool)
                        {
                            case "true":
                                addResult += $"Total de {n_parc} parc. - REF a OS: {cbx_slc_os.Text}\n";
                                MessageBox.Show("Os Seguintes PAGAMENTOS À RECEBER foram INCLUÍDOS COM SUCESSO: " +
                                                                $"{addResult}");
                                break;

                            case "":
                                MessageBox.Show("Dados NÃO SALVOS: Por favor Verifique as Informações Inseridas!");
                                break;
                        }

                    }
                }
                else
                {
                    try
                    {
                        Acesso_FB acesso_fb = new Acesso_FB();

                        string id_os = acesso_fb.fb_Get_Info_Dtr($"select OS_ID from OSS where OS_OS = '{cbx_slc_os.Text}'", "os_id");
                                               
                        acesso_fb.exe_CRUD($"insert into PAGAMENTOS_A_RECEBER (PGAR_PARCELA_NOME, PGAR_NUM_PARCELAS, "
                                               + "PGAR_DATA_PAGAMENTO, PGAR_FORMA_PAGAMETO, PGAR_VALOR, FK_OS_ID, "
                                               + "PGAR_VALOR_PARC) "
                                               + " values("
                                               + $"'1 / 1 - REF a OS: {cbx_slc_os.Text}', "
                                               + $"1, "
                                               + $"'{DateTime.Now.ToString("dd.MM.yyyy")}',"
                                               + $"'{cbx_formaPgto.Text}', "
                                               + $"'{msk_valorTotalVenda.Text}', "
                                               + $"'{id_os}', "
                                               + $"'{msk_valorParc.Text.Replace(",", ".")}'"
                                         + ")");

                    }
                    catch(FbException ex)
                    {
                        throw ex;
                    }
                }
            }                

        }

       
        

        private void btn_confirmPgto_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == null || txt_id.Text == "")
            {
                MessageBox.Show("ATENÇÃO: PAGAMENTO Á RECEBER não Selecionado. Por favor, cique em PESQUISAR e selecione o PAGAMENTO desejado.");
            }
            else
            {

                if (MessageBox.Show("Deseja CONFIRMAR PERMANENTEMENTE esse PAGAMENTO? Os Dados dele não poderão ser ALTERADOS!", "Atenção",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {

                    Acesso_FB acesso_fb = new Acesso_FB();
                    Pagamento_A_Receber pgto_a_fazer = new Pagamento_A_Receber();
                    pgto_a_fazer.ID = Convert.ToInt32(txt_id.Text);
                    pgto_a_fazer.Forma_Pagamento = acesso_fb.fb_Get_Info_Dtr($"select PGAR_FORMA_PAGAMENTO from PAGAMENTOS_A_RECEBER where PGAR_ID = {pgto_a_fazer.ID}", "pgar_forma_pagamento");
                    pgto_a_fazer.Data_Pagamento = acesso_fb.fb_Get_Info_Dtr($"select PGAR_DATA_PAGAMENTO from PAGAMENTOS_A_RECEBER where PGAR_ID = {pgto_a_fazer.ID}", "pgar_data_pagamento");
                    pgto_a_fazer.Num_Parcelas = acesso_fb.fb_Get_Info_Dtr($"select PGAR_NUM_PARCELAS from PAGAMENTOS_A_RECEBER where PGAR_ID = {pgto_a_fazer.ID}", "pgar_num_parcelas");
                    pgto_a_fazer.Data_Pagamento = acesso_fb.fb_Get_Info_Dtr($"select PGAR_DATA_PAGAMENTO from PAGAMENTOS_A_RECEBER where PGAR_ID = {pgto_a_fazer.ID}", "pgar_data_pagamento");
                    pgto_a_fazer.Parcela_Nome = acesso_fb.fb_Get_Info_Dtr($"select PGAR_PARCELA_NOME from PAGAMENTOS_A_RECEBER where PGAR_ID = {pgto_a_fazer.ID}", "pgar_parcela_nome");
                    pgto_a_fazer.Valor = acesso_fb.fb_Get_Info_Dtr($"select PGAR_VALOR from PAGAMENTOS_A_RECEBER where PGAR_ID = {pgto_a_fazer.ID}", "pgar_valor");
                    pgto_a_fazer.Valor_Parc = acesso_fb.fb_Get_Info_Dtr($"select PGAR_VALOR_PARC from PAGAMENTOS_A_RECEBER  where PGAR_ID = {pgto_a_fazer.ID}", "pgar_valor_parc");

                    string os = acesso_fb.fb_Get_Info_Dtr($"select FK_OS_ID from PAGAMENTOS_A_RECEBER where PGAR_ID = {pgto_a_fazer.ID}", "fk_os_id");
                    pgto_a_fazer.Os_ID = Convert.ToInt32(acesso_fb.fb_Get_Info_Dtr($"select OS_OS from OSS = where OS_ID = '{os}'", "os_os"));

                    acesso_fb.exe_CRUD($"delete from PAGAMENTOS_A_RECEBER where PGAR_ID = {pgto_a_fazer.ID}");

                    Pagamento pag = new Pagamento();
                    pag.Os_ID = Convert.ToInt32(os);
                    pag.Data_Pagamento = DateTime.Today.ToString("dd.MM.yyyy");
                    pag.Forma_Pagamento = pgto_a_fazer.Forma_Pagamento;
                    pag.Num_Parcelas = pgto_a_fazer.Num_Parcelas;
                    pag.Parcela_Nome = pgto_a_fazer.Parcela_Nome;
                    pag.Valor = pgto_a_fazer.Valor_Parc;
                    pag.Cod_Pgaf_ID = pgto_a_fazer.ID;
                    

                    acesso_fb.exe_CRUD($"insert into PAGAMENTOS " +
                    $"(PAG_PARCELA_NOME, PAG_NUM_PARCELAS, PAG_DATA_PAGAMENTO, PAG_VALOR, COD_PGAF_ID, FK_OS_ID, PAG_VALOR_PARC, PAG_FORMA_PAGAMENTO) " +
                    $"values('{pag.Parcela_Nome}', '{pag.Num_Parcelas}', '{pag.Data_Pagamento}' ,'{pag.Valor}', {pag.Cod_Pgaf_ID}, {pag.Os_ID}, '{pag.Valor_Parc}', '{pag.Forma_Pagamento}')");

                    limparForm();
                    MessageBox.Show($"PAGAMENTO de R$ {pag.Valor}. Em forma de: {pag.Forma_Pagamento}, em {pag.Data_Pagamento}");
                }


            }
        }

        //private void cbx_slc_os_Click(object sender, EventArgs e)
        //{
        //    Check_OS();
        //}

    }

}
                
                    


   
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
    public partial class Cad_Armacao : Form
    {
        public Cad_Armacao(int id)
        {
            InitializeComponent();
        }

        internal void novo_ou_select_arm()
        {
            if (txt_qtd_estoque.Text == "" || txt_qtd_estoque.Text == null)
                txt_qtd_estoque.Text = "0";

            if(txt_valor_final.Text == "" || txt_valor_final.Text == null)
                txt_valor_final.Text = "000.00";
        }

        internal void ver_armSelecionada(int id_selected)
        {
            Armacao selected_arm = new Armacao();
            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                selected_arm.ID = id_selected;
                selected_arm.Codigo = acesso_fb.fb_Get_Info_Dtr($"select ARM_CODIGO from ARMACOES where ARM_ID = '{id_selected}'", "arm_codigo");
                selected_arm.Cor = acesso_fb.fb_Get_Info_Dtr($"select ARM_COR from ARMACOES where ARM_ID = '{id_selected}'", "arm_cor");
                selected_arm.Modelo = acesso_fb.fb_Get_Info_Dtr($"select ARM_MODELO from ARMACOES where ARM_ID = '{id_selected}'", "arm_modelo");
                string qtd_estoque_txt = acesso_fb.fb_Get_Info_Dtr($"select ARM_QTD_ESTOQUE from ARMACOES where ARM_ID = '{id_selected}'", "arm_qtd_estoque");
                selected_arm.Tamanho = acesso_fb.fb_Get_Info_Dtr($"select ARM_TAMANHO from ARMACOES where ARM_ID = '{id_selected}'", "arm_tamanho");
                selected_arm.Referencia = acesso_fb.fb_Get_Info_Dtr($"select ARM_REFERENCIA from ARMACOES where ARM_ID = '{id_selected}'", "arm_referencia");
                string valor_final_vnd_txt =  acesso_fb.fb_Get_Info_Dtr($"select ARM_PRECO_FINAL_VENDA from ARMACOES where ARM_ID = '{id_selected}'", "arm_preco_final_venda");
                selected_arm.Fabricante = acesso_fb.fb_Get_Info_Dtr($"select ARM_FABRICANTE from ARMACOES where ARM_ID = '{id_selected}'", "arm_fabricante");
                selected_arm.Material = acesso_fb.fb_Get_Info_Dtr($"select ARM_MATERIAL from ARMACOES where ARM_ID = '{id_selected}'", "arm_material");
                selected_arm.Tipo = acesso_fb.fb_Get_Info_Dtr($"select ARM_TIPO from ARMACOES where ARM_ID = '{id_selected}'", "arm_tipo");
               
                txt_id.Text = selected_arm.ID.ToString();
                txt_cod.Text = selected_arm.Codigo;
                txt_cor.Text = selected_arm.Cor;
                txt_modelo.Text = selected_arm.Modelo;
                txt_qtd_estoque.Text = qtd_estoque_txt;
                txt_tamanho.Text = selected_arm.Tamanho;
                txt_ref.Text = selected_arm.Referencia;
                txt_valor_final.Text = valor_final_vnd_txt.Replace(",", ".");
                cbx_fabricante.Text = selected_arm.Fabricante;
                cbx_material.Text = selected_arm.Material;
                cbx_tipo.Text = selected_arm.Tipo;
               
                novo_ou_select_arm();
            }
            catch(FbException fbex)
            {
                throw fbex;
            }
        }

        internal void limparForm()
        {
            txt_id.Clear();
            txt_cod.Clear();
            txt_cor.Clear();
            txt_modelo.Clear();
            txt_qtd_estoque.Clear();
            txt_tamanho.Clear();
            txt_ref.Clear();
            txt_valor_final.Clear();
            cbx_fabricante.Text = "";
            cbx_material.Text = "";
            cbx_tipo.Text = "";
          
        }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
        private void txt_qdt_estoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
               e.Handled = true;
            }
        } 

        private void btn_limparForm_Click(object sender, EventArgs e)
        {
            limparForm();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Armacao new_arm = new Armacao();
            Acesso_FB acesso_fb = new Acesso_FB();

            try
            {
                new_arm.Modelo = "NOVA ARMACAO";
                acesso_fb.exe_CRUD($"insert into ARMACOES(ARM_MODELO) values('{new_arm.Modelo}')");
               
                txt_id.Text = acesso_fb.fb_Get_Info_Dtr("select ARM_ID from ARMACOES where ARM_ID = (select max(ARM_ID) from ARMACOES)", "ARM_ID");
                txt_modelo.Text = new_arm.Modelo;
                novo_ou_select_arm();
            }
            catch(FbException fbex)
            {
                throw fbex;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_id.Text != "")
            {
                Armacao updt_arm = new Armacao();
                updt_arm.ID = Convert.ToInt32(txt_id.Text);
                updt_arm.Tamanho = txt_tamanho.Text;
                updt_arm.Fabricante = cbx_fabricante.Text;
                updt_arm.Qtd_Estoque = txt_qtd_estoque.Text;
                updt_arm.Tipo = cbx_tipo.Text;
                updt_arm.Preco_Final_Venda = txt_valor_final.Text.Replace(",",".");
                updt_arm.Codigo = txt_cod.Text;
                updt_arm.Cor = txt_cor.Text;
                updt_arm.Material = cbx_material.Text;
                updt_arm.Referencia = txt_ref.Text;
                updt_arm.Modelo = txt_modelo.Text;
            

                Acesso_FB acesso_fb = new Acesso_FB();
                try
                {
                    acesso_fb.exe_CRUD($"update ARMACOES set ARM_ID = {updt_arm.ID}, ARM_CODIGO = '{updt_arm.Codigo}', ARM_FABRICANTE = '{updt_arm.Fabricante}',"+
                     $"ARM_REFERENCIA = '{updt_arm.Referencia}', ARM_MODELO = '{updt_arm.Modelo}', ARM_TAMANHO = '{updt_arm.Tamanho}', ARM_COR = '{updt_arm.Cor}'," +
                     $"ARM_MATERIAL = 'ARM_MATERIAL', ARM_QTD_ESTOQUE = '{updt_arm.Qtd_Estoque}', " +
                     $"ARM_PRECO_FINAL_VENDA = '{updt_arm.Preco_Final_Venda}', ARM_TIPO = '{updt_arm.Tipo}' where ARM_ID = '{updt_arm.ID}'");

                    MessageBox.Show("Alterações feitas com sucesso!");
                    
                }
                catch(FbException fbex)
                {
                    throw fbex;
                }

            }
            else
            {
                MessageBox.Show("ID Vazio. Por favor, clique no botão PROCURAR e selecione a Armação !");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(txt_id.Text != "" && MessageBox.Show("Deseja mesmo DELETAR PERMANENTEMENTE essa ARMAÇÂO? Os Dados dela serão Excluídos!", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Armacao del_arm = new Armacao();
                Acesso_FB acesso_fb = new Acesso_FB();
                try
                {
                    del_arm.ID = Convert.ToInt32(txt_id.Text);
                    acesso_fb.exe_CRUD($"delete from ARMACOES where ARM_ID = {del_arm.ID}");
                    MessageBox.Show("Dados EXCLUÍDOS com Sucesso !");
                    limparForm();

                }catch(FbException fbex)
                {
                    throw fbex;
                }
            }
            else
            {
                MessageBox.Show("ID Vazio. Por favor, clique no botão PROCURAR e selecione a Armação !");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Select_Armacao frm_slctArm = new Select_Armacao();
            frm_slctArm.ShowDialog();
            this.Close();
        }

        private void Cad_Armacao_Load(object sender, EventArgs e)
        {

        }
    }
}

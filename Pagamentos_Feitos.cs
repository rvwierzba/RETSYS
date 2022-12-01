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
    public partial class Pagamentos_Feitos : Form
    {
        public Pagamentos_Feitos()
        {
            InitializeComponent();
            listarCbxAno();
            view_pgtosFeitos();
        }

        internal void listarCbxAno()
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

        internal void preencherDgv(string Mes, string Ano)
        {
            Acesso_FB acesso_fb = new Acesso_FB();
            try
            {
                lbl_pagosEm.Text = $"Pagamentos Realizados em: {Mes}/{Ano}.";

                DataTable dt = acesso_fb.fb_GetDados("select PAG_PARCELA_NOME AS NOME, PAG_NUM_PARCELAS AS NoPARC, PAG_FORMA_PAGAMENTO as FormaPGTO, PAG_VALOR as VALOR, PAG_DATA_PAGAMENTO as DATA " +
                     $"from PAGAMENTOS where PAG_DATA_PAGAMENTO between '01.{Mes}.{Ano}' and '31.{Mes}.{Ano}' order by PAG_DATA_PAGAMENTO");

                dgv_PagFeitos.DataSource = dt;

                decimal tot_pgtoFeitos_mensal = 0;
                foreach (var row in dgv_PagFeitos.Rows.Cast<DataGridViewRow>())
                {
                    tot_pgtoFeitos_mensal += Convert.ToDecimal(row.Cells["VALOR"].Value);
                }

                if(tot_pgtoFeitos_mensal > 0)
                {
                    lbl_valorTot.Text = $"Total: R$ {tot_pgtoFeitos_mensal}";
                }
               
            }
            catch (FbException fbex)
            {
                throw fbex;
            }
        }

       internal void view_pgtosFeitos()
       {
                                   
                string mes, ano;

            if (cbx_selectedMes.Text == "" || cbx_selectedMes.Text == null)
            {
                mes = DateTime.Now.Month.ToString();
            }
            else
            {
                switch (cbx_selectedMes.Text)
                {
                    case "01 - JANEIRO": 
                        mes = "1";
                       break;

                    case "02 - FEVEREIRO": 
                        mes = "2";
                     break;

                    case "03 - MARCO":
                        mes = "3";
                       break;

                    case "04 - ABRIL":
                        mes = "4";
                        break;

                    case "05 - MAIO":
                        mes ="5";
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

                    default: mes = DateTime.Now.Year.ToString(); break;
                }
                                
            }
               

                if (cbx_ano.Text == "" || cbx_ano.Text == null)
                {
                    ano = DateTime.Now.Year.ToString();
                }
                else
                {
                    ano = cbx_ano.Text;
                }
          
            preencherDgv(mes, ano);
       }

        private void pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void cbx_ano_SelectedIndexChanged(object sender, EventArgs e)
        {
            view_pgtosFeitos();
        }

        private void cbx_selectedMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            view_pgtosFeitos();
        }
    }
}

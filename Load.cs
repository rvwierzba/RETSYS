using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RETSYS
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            tmr_pgBar.Enabled = true;
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process my_web_process = new Process();
            try
            {
                my_web_process.StartInfo.UseShellExecute = true;
                my_web_process.StartInfo.FileName = link_wbt.Text;
                my_web_process.Start();
            }catch(Exception ex)
            {
                throw ex;
            }        
               
                
        }

        private void tmr_pgBar_Tick(object sender, EventArgs e)
        {
            if (load_bar.Value < 100)
            {
                load_bar.Value = load_bar.Value + 5;
            }
            else if (load_bar.Value == 100)
            {
                Login frmLogin = new Login();
                frmLogin.Show();  // abre o form login
                tmr_pgBar.Stop(); // para o relógio
                this.Hide();      //fecha a janela após completar os 100%
            }
        }
    }
}

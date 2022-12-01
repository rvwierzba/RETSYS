namespace RETSYS
{
    partial class Cad_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Usuario));
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_loja = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.chk_mostrarSenha = new System.Windows.Forms.CheckBox();
            this.btn_limparForm = new System.Windows.Forms.Button();
            this.msk_dataCadUsr = new System.Windows.Forms.MaskedTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dgv_vendasMes = new System.Windows.Forms.DataGridView();
            this.lbl_titleDGV = new System.Windows.Forms.Label();
            this.lbl_valorTotVendasMo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.cbx_selectedMes = new System.Windows.Forms.ComboBox();
            this.cbx_ano = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendasMes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(841, 3);
            this.pbx_minimize.Name = "pbx_minimize";
            this.pbx_minimize.Size = new System.Drawing.Size(49, 42);
            this.pbx_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_minimize.TabIndex = 4;
            this.pbx_minimize.TabStop = false;
            this.pbx_minimize.Click += new System.EventHandler(this.pbx_minimize_Click);
            // 
            // pbx_close
            // 
            this.pbx_close.Image = ((System.Drawing.Image)(resources.GetObject("pbx_close.Image")));
            this.pbx_close.Location = new System.Drawing.Point(896, 3);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 5;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(584, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID";
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(445, 309);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(174, 24);
            this.txt_senha.TabIndex = 9;
            // 
            // txt_usuario
            // 
            this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(445, 227);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(261, 24);
            this.txt_usuario.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cadastro USUÁRIO";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(587, 107);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(100, 24);
            this.txt_id.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loja";
            // 
            // cbx_loja
            // 
            this.cbx_loja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_loja.FormattingEnabled = true;
            this.cbx_loja.Items.AddRange(new object[] {
            "MATRIZ",
            "PARQUE",
            "ITALIA"});
            this.cbx_loja.Location = new System.Drawing.Point(443, 384);
            this.cbx_loja.Name = "cbx_loja";
            this.cbx_loja.Size = new System.Drawing.Size(187, 26);
            this.cbx_loja.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(375, 65);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(121, 66);
            this.btn_novo.TabIndex = 17;
            this.btn_novo.Text = "(+) Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(420, 517);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 66);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(722, 517);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(121, 66);
            this.btn_excluir.TabIndex = 18;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(777, 240);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 66);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Pesquisar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // chk_mostrarSenha
            // 
            this.chk_mostrarSenha.AutoSize = true;
            this.chk_mostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_mostrarSenha.Location = new System.Drawing.Point(625, 309);
            this.chk_mostrarSenha.Name = "chk_mostrarSenha";
            this.chk_mostrarSenha.Size = new System.Drawing.Size(113, 20);
            this.chk_mostrarSenha.TabIndex = 19;
            this.chk_mostrarSenha.Text = "Mostrar Senha";
            this.chk_mostrarSenha.UseVisualStyleBackColor = true;
            this.chk_mostrarSenha.CheckedChanged += new System.EventHandler(this.chk_mostrarSenha_CheckedChanged);
            // 
            // btn_limparForm
            // 
            this.btn_limparForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparForm.Location = new System.Drawing.Point(48, 0);
            this.btn_limparForm.Name = "btn_limparForm";
            this.btn_limparForm.Size = new System.Drawing.Size(141, 34);
            this.btn_limparForm.TabIndex = 20;
            this.btn_limparForm.Text = "Limpar Formulário";
            this.btn_limparForm.UseVisualStyleBackColor = true;
            this.btn_limparForm.Click += new System.EventHandler(this.btn_limparForm_Click);
            // 
            // msk_dataCadUsr
            // 
            this.msk_dataCadUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_dataCadUsr.Location = new System.Drawing.Point(714, 107);
            this.msk_dataCadUsr.Mask = "00,00,0000";
            this.msk_dataCadUsr.Name = "msk_dataCadUsr";
            this.msk_dataCadUsr.ReadOnly = true;
            this.msk_dataCadUsr.Size = new System.Drawing.Size(100, 24);
            this.msk_dataCadUsr.TabIndex = 89;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(710, 88);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 16);
            this.label32.TabIndex = 88;
            this.label32.Text = "DATA CAD.";
            // 
            // dgv_vendasMes
            // 
            this.dgv_vendasMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendasMes.Location = new System.Drawing.Point(12, 350);
            this.dgv_vendasMes.Name = "dgv_vendasMes";
            this.dgv_vendasMes.Size = new System.Drawing.Size(326, 203);
            this.dgv_vendasMes.TabIndex = 90;
            // 
            // lbl_titleDGV
            // 
            this.lbl_titleDGV.AutoSize = true;
            this.lbl_titleDGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleDGV.Location = new System.Drawing.Point(45, 331);
            this.lbl_titleDGV.Name = "lbl_titleDGV";
            this.lbl_titleDGV.Size = new System.Drawing.Size(0, 16);
            this.lbl_titleDGV.TabIndex = 91;
            // 
            // lbl_valorTotVendasMo
            // 
            this.lbl_valorTotVendasMo.AutoSize = true;
            this.lbl_valorTotVendasMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorTotVendasMo.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_valorTotVendasMo.Location = new System.Drawing.Point(79, 567);
            this.lbl_valorTotVendasMo.Name = "lbl_valorTotVendasMo";
            this.lbl_valorTotVendasMo.Size = new System.Drawing.Size(83, 16);
            this.lbl_valorTotVendasMo.TabIndex = 92;
            this.lbl_valorTotVendasMo.Text = "TOTAL: R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(254, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 95;
            this.label6.Text = "ANO";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(13, 291);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(39, 16);
            this.lbl.TabIndex = 94;
            this.lbl.Text = "MÊS";
            // 
            // cbx_selectedMes
            // 
            this.cbx_selectedMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_selectedMes.FormattingEnabled = true;
            this.cbx_selectedMes.Items.AddRange(new object[] {
            "01 - JANEIRO",
            "02- FEVEREIRO",
            "03 - MARÇO",
            "04 - ABRIL",
            "05 - MAIO",
            "06 - JUNHO",
            "07 - JULHO",
            "08 - AGOSTO",
            "09 - SETEMBRO",
            "10 - OUTUBRO",
            "11 - NOVEMBRO",
            "12 - DEZEMBRO"});
            this.cbx_selectedMes.Location = new System.Drawing.Point(58, 285);
            this.cbx_selectedMes.Name = "cbx_selectedMes";
            this.cbx_selectedMes.Size = new System.Drawing.Size(175, 26);
            this.cbx_selectedMes.TabIndex = 93;
            this.cbx_selectedMes.SelectedIndexChanged += new System.EventHandler(this.cbx_selectedMes_SelectedIndexChanged);
            // 
            // cbx_ano
            // 
            this.cbx_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ano.FormattingEnabled = true;
            this.cbx_ano.Location = new System.Drawing.Point(299, 286);
            this.cbx_ano.Name = "cbx_ano";
            this.cbx_ano.Size = new System.Drawing.Size(92, 26);
            this.cbx_ano.TabIndex = 96;
            this.cbx_ano.SelectedIndexChanged += new System.EventHandler(this.cbx_ano_SelectedIndexChanged);
            // 
            // Cad_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(947, 595);
            this.Controls.Add(this.cbx_ano);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cbx_selectedMes);
            this.Controls.Add(this.lbl_valorTotVendasMo);
            this.Controls.Add(this.lbl_titleDGV);
            this.Controls.Add(this.dgv_vendasMes);
            this.Controls.Add(this.msk_dataCadUsr);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btn_limparForm);
            this.Controls.Add(this.chk_mostrarSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbx_loja);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cad_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendasMes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_loja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox chk_mostrarSenha;
        private System.Windows.Forms.Button btn_limparForm;
        private System.Windows.Forms.MaskedTextBox msk_dataCadUsr;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dgv_vendasMes;
        private System.Windows.Forms.Label lbl_titleDGV;
        private System.Windows.Forms.Label lbl_valorTotVendasMo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cbx_selectedMes;
        private System.Windows.Forms.ComboBox cbx_ano;
    }
}
namespace RETSYS
{
    partial class Cad_Armacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Armacao));
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_limparForm = new System.Windows.Forms.Button();
            this.txt_tamanho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_fabricante = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_material = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_qtd_estoque = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_valor_final = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(784, 12);
            this.pbx_minimize.Name = "pbx_minimize";
            this.pbx_minimize.Size = new System.Drawing.Size(49, 42);
            this.pbx_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_minimize.TabIndex = 6;
            this.pbx_minimize.TabStop = false;
            this.pbx_minimize.Click += new System.EventHandler(this.pbx_minimize_Click);
            // 
            // pbx_close
            // 
            this.pbx_close.Image = ((System.Drawing.Image)(resources.GetObject("pbx_close.Image")));
            this.pbx_close.Location = new System.Drawing.Point(839, 12);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 7;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cadastro ARMAÇÃO";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(598, 522);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(121, 66);
            this.btn_excluir.TabIndex = 15;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(158, 522);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 66);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(767, 267);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 66);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Pesquisar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(228, 59);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(121, 66);
            this.btn_novo.TabIndex = 22;
            this.btn_novo.Text = "(+) Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(457, 78);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(86, 24);
            this.txt_id.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID";
            // 
            // btn_limparForm
            // 
            this.btn_limparForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparForm.Location = new System.Drawing.Point(89, -3);
            this.btn_limparForm.Name = "btn_limparForm";
            this.btn_limparForm.Size = new System.Drawing.Size(141, 34);
            this.btn_limparForm.TabIndex = 16;
            this.btn_limparForm.Text = "Limpar Formulário";
            this.btn_limparForm.UseVisualStyleBackColor = true;
            this.btn_limparForm.Click += new System.EventHandler(this.btn_limparForm_Click);
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tamanho.Location = new System.Drawing.Point(375, 278);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(128, 24);
            this.txt_tamanho.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tamanho";
            // 
            // txt_cor
            // 
            this.txt_cor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cor.Location = new System.Drawing.Point(581, 278);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(138, 24);
            this.txt_cor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(578, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Cor";
            // 
            // txt_ref
            // 
            this.txt_ref.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ref.Location = new System.Drawing.Point(375, 215);
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(168, 24);
            this.txt_ref.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Referêcia";
            // 
            // txt_cod
            // 
            this.txt_cod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod.Location = new System.Drawing.Point(375, 155);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(153, 24);
            this.txt_cod.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(372, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "COD";
            // 
            // cbx_fabricante
            // 
            this.cbx_fabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fabricante.FormattingEnabled = true;
            this.cbx_fabricante.Items.AddRange(new object[] {
            "SP",
            "JEAN PIERRE",
            "DETROIT",
            "HB",
            "MORMAII",
            "RABIT",
            "RAY-BAN",
            "SPY",
            "OUTRA"});
            this.cbx_fabricante.Location = new System.Drawing.Point(579, 153);
            this.cbx_fabricante.Name = "cbx_fabricante";
            this.cbx_fabricante.Size = new System.Drawing.Size(187, 26);
            this.cbx_fabricante.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(578, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Fabricante";
            // 
            // cbx_material
            // 
            this.cbx_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_material.FormattingEnabled = true;
            this.cbx_material.Items.AddRange(new object[] {
            "ACETATO",
            "METAL FECHADO",
            "FIO DE NYLON",
            "BALGRIFF -  3 PCAS"});
            this.cbx_material.Location = new System.Drawing.Point(581, 354);
            this.cbx_material.Name = "cbx_material";
            this.cbx_material.Size = new System.Drawing.Size(187, 26);
            this.cbx_material.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(580, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Material";
            // 
            // txt_qtd_estoque
            // 
            this.txt_qtd_estoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_qtd_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtd_estoque.Location = new System.Drawing.Point(375, 354);
            this.txt_qtd_estoque.Name = "txt_qtd_estoque";
            this.txt_qtd_estoque.Size = new System.Drawing.Size(77, 24);
            this.txt_qtd_estoque.TabIndex = 6;
            this.txt_qtd_estoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qdt_estoque_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(372, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 41;
            this.label10.Text = "QDT Em Estoque";
            // 
            // txt_modelo
            // 
            this.txt_modelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_modelo.Location = new System.Drawing.Point(581, 215);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(198, 24);
            this.txt_modelo.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(578, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Modelo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(626, 420);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Valor Final de Venda";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(611, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 16);
            this.label16.TabIndex = 52;
            this.label16.Text = "R$";
            // 
            // txt_valor_final
            // 
            this.txt_valor_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_final.Location = new System.Drawing.Point(643, 439);
            this.txt_valor_final.Name = "txt_valor_final";
            this.txt_valor_final.Size = new System.Drawing.Size(136, 24);
            this.txt_valor_final.TabIndex = 9;
            this.txt_valor_final.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "und.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "*Selecione e use o DEL para apagar.";
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "RECEITUARIO",
            "SOLAR",
            "COM ADD"});
            this.cbx_tipo.Location = new System.Drawing.Point(375, 437);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(187, 26);
            this.cbx_tipo.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(374, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 56;
            this.label14.Text = "Tipo";
            // 
            // Cad_Armacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valor_final);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_qtd_estoque);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbx_material);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_fabricante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ref);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tamanho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_limparForm);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cad_Armacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Armacoes";
            this.Load += new System.EventHandler(this.Cad_Armacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_limparForm;
        private System.Windows.Forms.TextBox txt_tamanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_fabricante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbx_material;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_qtd_estoque;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_valor_final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.Label label14;
    }
}
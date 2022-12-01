namespace RETSYS
{
    partial class Cad_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Cliente));
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_limparForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msk_rg = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msk_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_validarCpf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpbox_endereco = new System.Windows.Forms.GroupBox();
            this.btn_buscarEndereco = new System.Windows.Forms.Button();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.msk_whatsapp = new System.Windows.Forms.MaskedTextBox();
            this.msk_dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.rtx_obs = new System.Windows.Forms.RichTextBox();
            this.dgv_oss_client = new System.Windows.Forms.DataGridView();
            this.OS_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_DATA_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.msk_telFixo = new System.Windows.Forms.MaskedTextBox();
            this.btn_conversarWhatsapp = new System.Windows.Forms.Button();
            this.msk_dataCadCli = new System.Windows.Forms.MaskedTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.sem_acentos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbox_endereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oss_client)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cadastro CLIENTE";
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(864, 1);
            this.pbx_minimize.Name = "pbx_minimize";
            this.pbx_minimize.Size = new System.Drawing.Size(49, 42);
            this.pbx_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_minimize.TabIndex = 16;
            this.pbx_minimize.TabStop = false;
            this.pbx_minimize.Click += new System.EventHandler(this.pbx_minimize_Click);
            // 
            // pbx_close
            // 
            this.pbx_close.Image = ((System.Drawing.Image)(resources.GetObject("pbx_close.Image")));
            this.pbx_close.Location = new System.Drawing.Point(919, 1);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 17;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(719, 667);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(121, 55);
            this.btn_excluir.TabIndex = 17;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(189, 667);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 55);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Salvar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(381, 74);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(86, 24);
            this.txt_id.TabIndex = 27;
            // 
            // btn_novo
            // 
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(189, 32);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(121, 66);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "(+) Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(802, 198);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 66);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Pesquisar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_limparForm
            // 
            this.btn_limparForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparForm.Location = new System.Drawing.Point(29, -1);
            this.btn_limparForm.Name = "btn_limparForm";
            this.btn_limparForm.Size = new System.Drawing.Size(141, 34);
            this.btn_limparForm.TabIndex = 29;
            this.btn_limparForm.Text = "Limpar Formulário";
            this.btn_limparForm.UseVisualStyleBackColor = true;
            this.btn_limparForm.Click += new System.EventHandler(this.btn_limparForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(316, 122);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(330, 24);
            this.txt_nome.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "NOME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "ID";
            // 
            // msk_rg
            // 
            this.msk_rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_rg.Location = new System.Drawing.Point(244, 166);
            this.msk_rg.Name = "msk_rg";
            this.msk_rg.Size = new System.Drawing.Size(143, 24);
            this.msk_rg.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(696, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "DATA NASCIMENTO";
            // 
            // msk_cpf
            // 
            this.msk_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cpf.Location = new System.Drawing.Point(397, 167);
            this.msk_cpf.Name = "msk_cpf";
            this.msk_cpf.Size = new System.Drawing.Size(166, 24);
            this.msk_cpf.TabIndex = 4;
            // 
            // btn_validarCpf
            // 
            this.btn_validarCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validarCpf.Location = new System.Drawing.Point(563, 168);
            this.btn_validarCpf.Name = "btn_validarCpf";
            this.btn_validarCpf.Size = new System.Drawing.Size(106, 23);
            this.btn_validarCpf.TabIndex = 29;
            this.btn_validarCpf.Text = "Verificar CPF";
            this.btn_validarCpf.UseVisualStyleBackColor = true;
            this.btn_validarCpf.Click += new System.EventHandler(this.btn_validarCpf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(367, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(696, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "EMAIL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "WHATSAPP";
            // 
            // gpbox_endereco
            // 
            this.gpbox_endereco.BackColor = System.Drawing.Color.Gold;
            this.gpbox_endereco.Controls.Add(this.sem_acentos);
            this.gpbox_endereco.Controls.Add(this.btn_buscarEndereco);
            this.gpbox_endereco.Controls.Add(this.txt_num);
            this.gpbox_endereco.Controls.Add(this.cbx_uf);
            this.gpbox_endereco.Controls.Add(this.msk_cep);
            this.gpbox_endereco.Controls.Add(this.label13);
            this.gpbox_endereco.Controls.Add(this.label17);
            this.gpbox_endereco.Controls.Add(this.label11);
            this.gpbox_endereco.Controls.Add(this.label10);
            this.gpbox_endereco.Controls.Add(this.label9);
            this.gpbox_endereco.Controls.Add(this.txt_rua);
            this.gpbox_endereco.Controls.Add(this.txt_cidade);
            this.gpbox_endereco.Controls.Add(this.txt_bairro);
            this.gpbox_endereco.Controls.Add(this.label3);
            this.gpbox_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbox_endereco.Location = new System.Drawing.Point(381, 279);
            this.gpbox_endereco.Name = "gpbox_endereco";
            this.gpbox_endereco.Size = new System.Drawing.Size(580, 267);
            this.gpbox_endereco.TabIndex = 43;
            this.gpbox_endereco.TabStop = false;
            this.gpbox_endereco.Text = "Endereço";
            // 
            // btn_buscarEndereco
            // 
            this.btn_buscarEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarEndereco.Location = new System.Drawing.Point(279, 35);
            this.btn_buscarEndereco.Name = "btn_buscarEndereco";
            this.btn_buscarEndereco.Size = new System.Drawing.Size(138, 23);
            this.btn_buscarEndereco.TabIndex = 9;
            this.btn_buscarEndereco.Text = "Buscar Endereço";
            this.btn_buscarEndereco.UseVisualStyleBackColor = true;
            this.btn_buscarEndereco.Click += new System.EventHandler(this.btn_buscarEndereco_Click);
            // 
            // txt_num
            // 
            this.txt_num.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num.Location = new System.Drawing.Point(465, 94);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(92, 24);
            this.txt_num.TabIndex = 11;
            // 
            // cbx_uf
            // 
            this.cbx_uf.FormattingEnabled = true;
            this.cbx_uf.ItemHeight = 13;
            this.cbx_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbx_uf.Location = new System.Drawing.Point(456, 237);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(75, 21);
            this.cbx_uf.TabIndex = 14;
            // 
            // msk_cep
            // 
            this.msk_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_cep.Location = new System.Drawing.Point(79, 35);
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(200, 24);
            this.msk_cep.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(459, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "UF";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(77, 216);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 37;
            this.label17.Text = "CIDADE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "BAIRRO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(468, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Nº";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "RUA";
            // 
            // txt_rua
            // 
            this.txt_rua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(79, 98);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(338, 24);
            this.txt_rua.TabIndex = 10;
            // 
            // txt_cidade
            // 
            this.txt_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(79, 235);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(296, 24);
            this.txt_cidade.TabIndex = 13;
            // 
            // txt_bairro
            // 
            this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(79, 165);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(296, 24);
            this.txt_bairro.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(264, 536);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "OBSERVAÇÃO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(401, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "CPF";
            // 
            // txt_email
            // 
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(692, 156);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(265, 24);
            this.txt_email.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(247, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "RG";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(581, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 16);
            this.label16.TabIndex = 37;
            this.label16.Text = "TEL FIXO";
            // 
            // msk_whatsapp
            // 
            this.msk_whatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_whatsapp.Location = new System.Drawing.Point(329, 218);
            this.msk_whatsapp.Name = "msk_whatsapp";
            this.msk_whatsapp.Size = new System.Drawing.Size(174, 24);
            this.msk_whatsapp.TabIndex = 6;
            // 
            // msk_dataNasc
            // 
            this.msk_dataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_dataNasc.Location = new System.Drawing.Point(693, 99);
            this.msk_dataNasc.Mask = "00,00,0000";
            this.msk_dataNasc.Name = "msk_dataNasc";
            this.msk_dataNasc.Size = new System.Drawing.Size(160, 24);
            this.msk_dataNasc.TabIndex = 7;
            // 
            // rtx_obs
            // 
            this.rtx_obs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtx_obs.Location = new System.Drawing.Point(268, 552);
            this.rtx_obs.Name = "rtx_obs";
            this.rtx_obs.Size = new System.Drawing.Size(541, 109);
            this.rtx_obs.TabIndex = 15;
            this.rtx_obs.Text = "";
            this.rtx_obs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtx_obs_KeyPress);
            // 
            // dgv_oss_client
            // 
            this.dgv_oss_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_oss_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OS_OS,
            this.OS_DATA_VENDA,
            this.FK_ID_CLIENTE,
            this.SELECIONAR});
            this.dgv_oss_client.Location = new System.Drawing.Point(-38, 386);
            this.dgv_oss_client.Name = "dgv_oss_client";
            this.dgv_oss_client.Size = new System.Drawing.Size(409, 141);
            this.dgv_oss_client.TabIndex = 44;
            this.dgv_oss_client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_oss_client_CellContentClick);
            // 
            // OS_OS
            // 
            this.OS_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OS_OS.DataPropertyName = "OS_OS";
            this.OS_OS.HeaderText = "OS";
            this.OS_OS.Name = "OS_OS";
            // 
            // OS_DATA_VENDA
            // 
            this.OS_DATA_VENDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OS_DATA_VENDA.DataPropertyName = "OS_DATA_VENDA";
            this.OS_DATA_VENDA.HeaderText = "Data Venda";
            this.OS_DATA_VENDA.Name = "OS_DATA_VENDA";
            // 
            // FK_ID_CLIENTE
            // 
            this.FK_ID_CLIENTE.DataPropertyName = "FK_ID_CLIENTE";
            this.FK_ID_CLIENTE.HeaderText = "FK_ID_CLIENTE";
            this.FK_ID_CLIENTE.Name = "FK_ID_CLIENTE";
            this.FK_ID_CLIENTE.Visible = false;
            // 
            // SELECIONAR
            // 
            this.SELECIONAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SELECIONAR.DataPropertyName = "SELECIONAR";
            this.SELECIONAR.HeaderText = "SELECIONAR AQUI";
            this.SELECIONAR.Name = "SELECIONAR";
            this.SELECIONAR.Text = "SELECIONE";
            this.SELECIONAR.UseColumnTextForButtonValue = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(82, 371);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(117, 16);
            this.label18.TabIndex = 37;
            this.label18.Text = "OS\'s - CLIENTE";
            // 
            // msk_telFixo
            // 
            this.msk_telFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_telFixo.Location = new System.Drawing.Point(579, 232);
            this.msk_telFixo.Name = "msk_telFixo";
            this.msk_telFixo.Size = new System.Drawing.Size(174, 24);
            this.msk_telFixo.TabIndex = 6;
            // 
            // btn_conversarWhatsapp
            // 
            this.btn_conversarWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conversarWhatsapp.Location = new System.Drawing.Point(329, 242);
            this.btn_conversarWhatsapp.Name = "btn_conversarWhatsapp";
            this.btn_conversarWhatsapp.Size = new System.Drawing.Size(174, 23);
            this.btn_conversarWhatsapp.TabIndex = 45;
            this.btn_conversarWhatsapp.Text = "Conversar WhatsApp";
            this.btn_conversarWhatsapp.UseVisualStyleBackColor = true;
            this.btn_conversarWhatsapp.Click += new System.EventHandler(this.btn_conversarWhatsapp_Click);
            // 
            // msk_dataCadCli
            // 
            this.msk_dataCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_dataCadCli.Location = new System.Drawing.Point(527, 74);
            this.msk_dataCadCli.Mask = "00,00,0000";
            this.msk_dataCadCli.Name = "msk_dataCadCli";
            this.msk_dataCadCli.ReadOnly = true;
            this.msk_dataCadCli.Size = new System.Drawing.Size(100, 24);
            this.msk_dataCadCli.TabIndex = 87;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(523, 55);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 16);
            this.label32.TabIndex = 86;
            this.label32.Text = "DATA CAD.";
            // 
            // sem_acentos
            // 
            this.sem_acentos.AutoSize = true;
            this.sem_acentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sem_acentos.Location = new System.Drawing.Point(403, 0);
            this.sem_acentos.Name = "sem_acentos";
            this.sem_acentos.Size = new System.Drawing.Size(173, 16);
            this.sem_acentos.TabIndex = 38;
            this.sem_acentos.Text = "Não usar acentos ou çÇ";
            // 
            // Cad_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(969, 723);
            this.Controls.Add(this.msk_dataCadCli);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.btn_conversarWhatsapp);
            this.Controls.Add(this.dgv_oss_client);
            this.Controls.Add(this.rtx_obs);
            this.Controls.Add(this.msk_dataNasc);
            this.Controls.Add(this.msk_telFixo);
            this.Controls.Add(this.msk_whatsapp);
            this.Controls.Add(this.gpbox_endereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.msk_cpf);
            this.Controls.Add(this.msk_rg);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_validarCpf);
            this.Controls.Add(this.btn_limparForm);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cad_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbox_endereco.ResumeLayout(false);
            this.gpbox_endereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_oss_client)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_limparForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msk_cpf;
        private System.Windows.Forms.Button btn_validarCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpbox_endereco;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_buscarEndereco;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox msk_whatsapp;
        private System.Windows.Forms.MaskedTextBox msk_dataNasc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rtx_obs;
        private System.Windows.Forms.DataGridView dgv_oss_client;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox msk_telFixo;
        private System.Windows.Forms.Button btn_conversarWhatsapp;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_DATA_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_ID_CLIENTE;
        private System.Windows.Forms.DataGridViewButtonColumn SELECIONAR;
        private System.Windows.Forms.MaskedTextBox msk_dataCadCli;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label sem_acentos;
    }
}
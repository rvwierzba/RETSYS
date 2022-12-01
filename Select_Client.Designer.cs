namespace RETSYS
{
    partial class Select_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Client));
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.txt_instrucaoSelect = new System.Windows.Forms.Label();
            this.dgv_clients = new System.Windows.Forms.DataGridView();
            this.CLI_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLI_TELFIXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Selecione o CLIENTE:";
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(563, 3);
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
            this.pbx_close.Location = new System.Drawing.Point(618, 3);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 17;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // txt_instrucaoSelect
            // 
            this.txt_instrucaoSelect.AutoSize = true;
            this.txt_instrucaoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instrucaoSelect.Location = new System.Drawing.Point(123, 49);
            this.txt_instrucaoSelect.Name = "txt_instrucaoSelect";
            this.txt_instrucaoSelect.Size = new System.Drawing.Size(0, 16);
            this.txt_instrucaoSelect.TabIndex = 18;
            // 
            // dgv_clients
            // 
            this.dgv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLI_ID,
            this.CLI_NOME,
            this.CLI_CELULAR,
            this.CLI_TELFIXO,
            this.SELECIONAR});
            this.dgv_clients.Location = new System.Drawing.Point(12, 93);
            this.dgv_clients.Name = "dgv_clients";
            this.dgv_clients.Size = new System.Drawing.Size(643, 240);
            this.dgv_clients.TabIndex = 19;
            this.dgv_clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clients_CellContentClick);
            // 
            // CLI_ID
            // 
            this.CLI_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLI_ID.DataPropertyName = "CLI_ID";
            this.CLI_ID.HeaderText = "ID";
            this.CLI_ID.Name = "CLI_ID";
            // 
            // CLI_NOME
            // 
            this.CLI_NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLI_NOME.DataPropertyName = "CLI_NOME";
            this.CLI_NOME.HeaderText = "Nome";
            this.CLI_NOME.Name = "CLI_NOME";
            // 
            // CLI_CELULAR
            // 
            this.CLI_CELULAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLI_CELULAR.DataPropertyName = "CLI_CELULAR";
            this.CLI_CELULAR.HeaderText = "Whatsapp";
            this.CLI_CELULAR.Name = "CLI_CELULAR";
            // 
            // CLI_TELFIXO
            // 
            this.CLI_TELFIXO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLI_TELFIXO.DataPropertyName = "CLI_TELFIXO";
            this.CLI_TELFIXO.HeaderText = "Tel Fixo";
            this.CLI_TELFIXO.Name = "CLI_TELFIXO";
            // 
            // SELECIONAR
            // 
            this.SELECIONAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SELECIONAR.DataPropertyName = "SELECIONAR";
            this.SELECIONAR.HeaderText = "SELECIONE AQUI";
            this.SELECIONAR.Name = "SELECIONAR";
            this.SELECIONAR.Text = "SELECIONAR";
            this.SELECIONAR.UseColumnTextForButtonValue = true;
            // 
            // Select_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 343);
            this.Controls.Add(this.dgv_clients);
            this.Controls.Add(this.txt_instrucaoSelect);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select_Client";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.Label txt_instrucaoSelect;
        private System.Windows.Forms.DataGridView dgv_clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLI_TELFIXO;
        private System.Windows.Forms.DataGridViewButtonColumn SELECIONAR;
    }
}
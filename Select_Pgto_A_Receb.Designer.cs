namespace RETSYS
{
    partial class Select_Pgto_A_Receb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Pgto_A_Receb));
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.dgv_select_pagtosAreceb = new System.Windows.Forms.DataGridView();
            this.PGAR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGAR_PARCELA_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGAR_DATA_PAGAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGAR_VALOR_PARC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_instrucaoSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select_pagtosAreceb)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(639, 1);
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
            this.pbx_close.Location = new System.Drawing.Point(694, 1);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 7;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // dgv_select_pagtosAreceb
            // 
            this.dgv_select_pagtosAreceb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_select_pagtosAreceb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PGAR_ID,
            this.PGAR_PARCELA_NOME,
            this.PGAR_DATA_PAGAMENTO,
            this.PGAR_VALOR_PARC,
            this.SELECIONAR});
            this.dgv_select_pagtosAreceb.Location = new System.Drawing.Point(10, 90);
            this.dgv_select_pagtosAreceb.Name = "dgv_select_pagtosAreceb";
            this.dgv_select_pagtosAreceb.Size = new System.Drawing.Size(724, 230);
            this.dgv_select_pagtosAreceb.TabIndex = 8;
            this.dgv_select_pagtosAreceb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_select_pagtosAreceb_CellContentClick);
            // 
            // PGAR_ID
            // 
            this.PGAR_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PGAR_ID.DataPropertyName = "PGAR_ID";
            this.PGAR_ID.HeaderText = "ID";
            this.PGAR_ID.Name = "PGAR_ID";
            // 
            // PGAR_PARCELA_NOME
            // 
            this.PGAR_PARCELA_NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PGAR_PARCELA_NOME.DataPropertyName = "PGAR_PARCELA_NOME";
            this.PGAR_PARCELA_NOME.HeaderText = "Nome";
            this.PGAR_PARCELA_NOME.Name = "PGAR_PARCELA_NOME";
            // 
            // PGAR_DATA_PAGAMENTO
            // 
            this.PGAR_DATA_PAGAMENTO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PGAR_DATA_PAGAMENTO.DataPropertyName = "PGAR_DATA_PAGAMENTO";
            this.PGAR_DATA_PAGAMENTO.HeaderText = "Data";
            this.PGAR_DATA_PAGAMENTO.Name = "PGAR_DATA_PAGAMENTO";
            // 
            // PGAR_VALOR_PARC
            // 
            this.PGAR_VALOR_PARC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PGAR_VALOR_PARC.DataPropertyName = "PGAR_VALOR_PARC";
            this.PGAR_VALOR_PARC.HeaderText = "Valor Parcela";
            this.PGAR_VALOR_PARC.Name = "PGAR_VALOR_PARC";
            // 
            // SELECIONAR
            // 
            this.SELECIONAR.HeaderText = "SELECIONAR";
            this.SELECIONAR.Name = "SELECIONAR";
            this.SELECIONAR.Text = "SELECIONAR";
            this.SELECIONAR.ToolTipText = "SELECIONAR";
            this.SELECIONAR.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selecione o PGTO À RECEBER:";
            // 
            // txt_instrucaoSelect
            // 
            this.txt_instrucaoSelect.AutoSize = true;
            this.txt_instrucaoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instrucaoSelect.Location = new System.Drawing.Point(102, 48);
            this.txt_instrucaoSelect.Name = "txt_instrucaoSelect";
            this.txt_instrucaoSelect.Size = new System.Drawing.Size(0, 16);
            this.txt_instrucaoSelect.TabIndex = 24;
            // 
            // Select_Pgto_A_Receb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 323);
            this.Controls.Add(this.txt_instrucaoSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_select_pagtosAreceb);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Pgto_A_Receb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select_Pgto_A_Receb";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_select_pagtosAreceb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.DataGridView dgv_select_pagtosAreceb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_instrucaoSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGAR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGAR_PARCELA_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGAR_DATA_PAGAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PGAR_VALOR_PARC;
        private System.Windows.Forms.DataGridViewButtonColumn SELECIONAR;
    }
}
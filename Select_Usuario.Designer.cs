namespace RETSYS
{
    partial class Select_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Usuario));
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.USR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USR_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USR_LOJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_instrucaoSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USR_ID,
            this.USR_NOME,
            this.USR_LOJA,
            this.SELECIONAR});
            this.dgv_users.Location = new System.Drawing.Point(12, 90);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.Size = new System.Drawing.Size(708, 270);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellContentClick);
            // 
            // USR_ID
            // 
            this.USR_ID.DataPropertyName = "USR_ID";
            this.USR_ID.HeaderText = "ID";
            this.USR_ID.Name = "USR_ID";
            // 
            // USR_NOME
            // 
            this.USR_NOME.DataPropertyName = "USR_NOME";
            this.USR_NOME.HeaderText = "Nome";
            this.USR_NOME.Name = "USR_NOME";
            // 
            // USR_LOJA
            // 
            this.USR_LOJA.DataPropertyName = "USR_LOJA";
            this.USR_LOJA.HeaderText = "Loja";
            this.USR_LOJA.Name = "USR_LOJA";
            // 
            // SELECIONAR
            // 
            this.SELECIONAR.HeaderText = "SELECIONE AQUI";
            this.SELECIONAR.Name = "SELECIONAR";
            this.SELECIONAR.Text = "SELECIONAR";
            this.SELECIONAR.ToolTipText = "Selecionar USUARIO";
            this.SELECIONAR.UseColumnTextForButtonValue = true;
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(616, 12);
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
            this.pbx_close.Location = new System.Drawing.Point(671, 12);
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
            this.label2.Location = new System.Drawing.Point(185, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selecione o USUÁRIO:";
            // 
            // txt_instrucaoSelect
            // 
            this.txt_instrucaoSelect.AutoSize = true;
            this.txt_instrucaoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instrucaoSelect.Location = new System.Drawing.Point(129, 54);
            this.txt_instrucaoSelect.Name = "txt_instrucaoSelect";
            this.txt_instrucaoSelect.Size = new System.Drawing.Size(0, 16);
            this.txt_instrucaoSelect.TabIndex = 13;
            // 
            // Select_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 372);
            this.Controls.Add(this.txt_instrucaoSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.Controls.Add(this.dgv_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_instrucaoSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn USR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USR_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn USR_LOJA;
        private System.Windows.Forms.DataGridViewButtonColumn SELECIONAR;
    }
}
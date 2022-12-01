namespace RETSYS
{
    partial class Select_Armacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Armacao));
            this.label2 = new System.Windows.Forms.Label();
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.dgv_arms = new System.Windows.Forms.DataGridView();
            this.ARM_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARM_FABRICANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARM_MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARM_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARM_COR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txt_instrucaoSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arms)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecione a ARMAÇÃO:";
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(615, 12);
            this.pbx_minimize.Name = "pbx_minimize";
            this.pbx_minimize.Size = new System.Drawing.Size(49, 42);
            this.pbx_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_minimize.TabIndex = 14;
            this.pbx_minimize.TabStop = false;
            this.pbx_minimize.Click += new System.EventHandler(this.pbx_minimize_Click);
            // 
            // pbx_close
            // 
            this.pbx_close.Image = ((System.Drawing.Image)(resources.GetObject("pbx_close.Image")));
            this.pbx_close.Location = new System.Drawing.Point(670, 12);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 15;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // dgv_arms
            // 
            this.dgv_arms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ARM_ID,
            this.ARM_FABRICANTE,
            this.ARM_MODELO,
            this.ARM_TIPO,
            this.ARM_COR,
            this.SELECIONAR});
            this.dgv_arms.Location = new System.Drawing.Point(12, 95);
            this.dgv_arms.Name = "dgv_arms";
            this.dgv_arms.Size = new System.Drawing.Size(707, 244);
            this.dgv_arms.TabIndex = 16;
            this.dgv_arms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_arms_CellContentClick);
            // 
            // ARM_ID
            // 
            this.ARM_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ARM_ID.DataPropertyName = "ARM_ID";
            this.ARM_ID.HeaderText = "ID";
            this.ARM_ID.Name = "ARM_ID";
            // 
            // ARM_FABRICANTE
            // 
            this.ARM_FABRICANTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ARM_FABRICANTE.DataPropertyName = "ARM_FABRICANTE";
            this.ARM_FABRICANTE.HeaderText = "Fabricante";
            this.ARM_FABRICANTE.Name = "ARM_FABRICANTE";
            // 
            // ARM_MODELO
            // 
            this.ARM_MODELO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ARM_MODELO.DataPropertyName = "ARM_MODELO";
            this.ARM_MODELO.HeaderText = "Modelo";
            this.ARM_MODELO.Name = "ARM_MODELO";
            // 
            // ARM_TIPO
            // 
            this.ARM_TIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ARM_TIPO.DataPropertyName = "ARM_TIPO";
            this.ARM_TIPO.HeaderText = "Tipo";
            this.ARM_TIPO.Name = "ARM_TIPO";
            // 
            // ARM_COR
            // 
            this.ARM_COR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ARM_COR.DataPropertyName = "ARM_COR";
            this.ARM_COR.HeaderText = "Cor";
            this.ARM_COR.Name = "ARM_COR";
            // 
            // SELECIONAR
            // 
            this.SELECIONAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SELECIONAR.DataPropertyName = "SELECIONAR";
            this.SELECIONAR.FillWeight = 150F;
            this.SELECIONAR.HeaderText = "SELECIONE AQUI";
            this.SELECIONAR.Name = "SELECIONAR";
            this.SELECIONAR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SELECIONAR.Text = "SELECIONAR";
            this.SELECIONAR.UseColumnTextForButtonValue = true;
            // 
            // txt_instrucaoSelect
            // 
            this.txt_instrucaoSelect.AutoSize = true;
            this.txt_instrucaoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instrucaoSelect.Location = new System.Drawing.Point(123, 58);
            this.txt_instrucaoSelect.Name = "txt_instrucaoSelect";
            this.txt_instrucaoSelect.Size = new System.Drawing.Size(0, 16);
            this.txt_instrucaoSelect.TabIndex = 17;
            // 
            // Select_Armacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 351);
            this.Controls.Add(this.txt_instrucaoSelect);
            this.Controls.Add(this.dgv_arms);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Armacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select_Armacao";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.DataGridView dgv_arms;
        private System.Windows.Forms.Label txt_instrucaoSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARM_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARM_FABRICANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARM_MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARM_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ARM_COR;
        private System.Windows.Forms.DataGridViewButtonColumn SELECIONAR;
    }
}
namespace RETSYS
{
    partial class Select_Os
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Os));
            this.dgv_selectOS = new System.Windows.Forms.DataGridView();
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_instrucaoSelect = new System.Windows.Forms.Label();
            this.OS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_OS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_VENDEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_DATA_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_VALOR_TOTAL_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELECIONAR = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_selectOS
            // 
            this.dgv_selectOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selectOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OS_ID,
            this.OS_OS,
            this.OS_VENDEDOR,
            this.OS_DATA_VENDA,
            this.OS_VALOR_TOTAL_VENDA,
            this.SELECIONAR});
            this.dgv_selectOS.Location = new System.Drawing.Point(12, 74);
            this.dgv_selectOS.Name = "dgv_selectOS";
            this.dgv_selectOS.Size = new System.Drawing.Size(725, 235);
            this.dgv_selectOS.TabIndex = 0;
            this.dgv_selectOS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_selectOS_CellContentClick);
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(645, 2);
            this.pbx_minimize.Name = "pbx_minimize";
            this.pbx_minimize.Size = new System.Drawing.Size(49, 42);
            this.pbx_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_minimize.TabIndex = 20;
            this.pbx_minimize.TabStop = false;
            this.pbx_minimize.Click += new System.EventHandler(this.pbx_minimize_Click);
            // 
            // pbx_close
            // 
            this.pbx_close.Image = ((System.Drawing.Image)(resources.GetObject("pbx_close.Image")));
            this.pbx_close.Location = new System.Drawing.Point(700, 2);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 21;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Selecione a OS:";
            // 
            // txt_instrucaoSelect
            // 
            this.txt_instrucaoSelect.AutoSize = true;
            this.txt_instrucaoSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_instrucaoSelect.Location = new System.Drawing.Point(170, 40);
            this.txt_instrucaoSelect.Name = "txt_instrucaoSelect";
            this.txt_instrucaoSelect.Size = new System.Drawing.Size(0, 16);
            this.txt_instrucaoSelect.TabIndex = 23;
            // 
            // OS_ID
            // 
            this.OS_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OS_ID.DataPropertyName = "OS_ID";
            this.OS_ID.HeaderText = "ID";
            this.OS_ID.Name = "OS_ID";
            // 
            // OS_OS
            // 
            this.OS_OS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OS_OS.DataPropertyName = "OS_OS";
            this.OS_OS.HeaderText = "OS";
            this.OS_OS.Name = "OS_OS";
            // 
            // OS_VENDEDOR
            // 
            this.OS_VENDEDOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OS_VENDEDOR.DataPropertyName = "OS_VENDEDOR";
            this.OS_VENDEDOR.HeaderText = "Vendedor(a)";
            this.OS_VENDEDOR.Name = "OS_VENDEDOR";
            // 
            // OS_DATA_VENDA
            // 
            this.OS_DATA_VENDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OS_DATA_VENDA.DataPropertyName = "OS_DATA_VENDA";
            this.OS_DATA_VENDA.HeaderText = "Data Venda";
            this.OS_DATA_VENDA.Name = "OS_DATA_VENDA";
            // 
            // OS_VALOR_TOTAL_VENDA
            // 
            this.OS_VALOR_TOTAL_VENDA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OS_VALOR_TOTAL_VENDA.DataPropertyName = "OS_VALOR_TOTAL_VENDA";
            this.OS_VALOR_TOTAL_VENDA.HeaderText = "R$";
            this.OS_VALOR_TOTAL_VENDA.Name = "OS_VALOR_TOTAL_VENDA";
            // 
            // SELECIONAR
            // 
            this.SELECIONAR.HeaderText = "SELECIONE AQUI";
            this.SELECIONAR.Name = "SELECIONAR";
            this.SELECIONAR.Text = "SELECIONAR";
            this.SELECIONAR.UseColumnTextForButtonValue = true;
            // 
            // Select_Os
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 321);
            this.Controls.Add(this.txt_instrucaoSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.Controls.Add(this.dgv_selectOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Os";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select_OS";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_selectOS;
        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_instrucaoSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_OS;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_VENDEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_DATA_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_VALOR_TOTAL_VENDA;
        private System.Windows.Forms.DataGridViewButtonColumn SELECIONAR;
    }
}
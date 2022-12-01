namespace RETSYS
{
    partial class Pagamentos_Feitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagamentos_Feitos));
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_PagFeitos = new System.Windows.Forms.DataGridView();
            this.lbl_valorTot = new System.Windows.Forms.Label();
            this.lbl_pagosEm = new System.Windows.Forms.Label();
            this.cbx_selectedMes = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_ano = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PagFeitos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(661, 1);
            this.pbx_minimize.Name = "pbx_minimize";
            this.pbx_minimize.Size = new System.Drawing.Size(49, 42);
            this.pbx_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_minimize.TabIndex = 24;
            this.pbx_minimize.TabStop = false;
            this.pbx_minimize.Click += new System.EventHandler(this.pbx_minimize_Click);
            // 
            // pbx_close
            // 
            this.pbx_close.Image = ((System.Drawing.Image)(resources.GetObject("pbx_close.Image")));
            this.pbx_close.Location = new System.Drawing.Point(716, 1);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 25;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "PAGAMENTOS FEITOS";
            // 
            // dgv_PagFeitos
            // 
            this.dgv_PagFeitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PagFeitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PagFeitos.Location = new System.Drawing.Point(12, 78);
            this.dgv_PagFeitos.Name = "dgv_PagFeitos";
            this.dgv_PagFeitos.Size = new System.Drawing.Size(742, 256);
            this.dgv_PagFeitos.TabIndex = 27;
            // 
            // lbl_valorTot
            // 
            this.lbl_valorTot.AutoSize = true;
            this.lbl_valorTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorTot.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_valorTot.Location = new System.Drawing.Point(478, 337);
            this.lbl_valorTot.Name = "lbl_valorTot";
            this.lbl_valorTot.Size = new System.Drawing.Size(83, 16);
            this.lbl_valorTot.TabIndex = 88;
            this.lbl_valorTot.Text = "TOTAL: R$";
            // 
            // lbl_pagosEm
            // 
            this.lbl_pagosEm.AutoSize = true;
            this.lbl_pagosEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagosEm.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_pagosEm.Location = new System.Drawing.Point(407, 52);
            this.lbl_pagosEm.Name = "lbl_pagosEm";
            this.lbl_pagosEm.Size = new System.Drawing.Size(0, 16);
            this.lbl_pagosEm.TabIndex = 89;
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
            this.cbx_selectedMes.Location = new System.Drawing.Point(54, 46);
            this.cbx_selectedMes.Name = "cbx_selectedMes";
            this.cbx_selectedMes.Size = new System.Drawing.Size(175, 26);
            this.cbx_selectedMes.TabIndex = 90;
            this.cbx_selectedMes.SelectedIndexChanged += new System.EventHandler(this.cbx_selectedMes_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(9, 52);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(39, 16);
            this.lbl.TabIndex = 91;
            this.lbl.Text = "MÊS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(250, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 92;
            this.label3.Text = "ANO";
            // 
            // cbx_ano
            // 
            this.cbx_ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ano.FormattingEnabled = true;
            this.cbx_ano.Location = new System.Drawing.Point(295, 46);
            this.cbx_ano.Name = "cbx_ano";
            this.cbx_ano.Size = new System.Drawing.Size(92, 26);
            this.cbx_ano.TabIndex = 93;
            this.cbx_ano.SelectedIndexChanged += new System.EventHandler(this.cbx_ano_SelectedIndexChanged);
            // 
            // Pagamentos_Feitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(766, 359);
            this.Controls.Add(this.cbx_ano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.cbx_selectedMes);
            this.Controls.Add(this.lbl_pagosEm);
            this.Controls.Add(this.lbl_valorTot);
            this.Controls.Add(this.dgv_PagFeitos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pagamentos_Feitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos_Feitos";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PagFeitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_PagFeitos;
        private System.Windows.Forms.Label lbl_valorTot;
        private System.Windows.Forms.Label lbl_pagosEm;
        private System.Windows.Forms.ComboBox cbx_selectedMes;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_ano;
    }
}
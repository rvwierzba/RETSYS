namespace RETSYS
{
    partial class Select_Qual_Pgto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Qual_Pgto));
            this.pbx_minimize = new System.Windows.Forms.PictureBox();
            this.pbx_close = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_selecione = new System.Windows.Forms.ComboBox();
            this.btn_calc_grauPert = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_minimize
            // 
            this.pbx_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pbx_minimize.Image")));
            this.pbx_minimize.Location = new System.Drawing.Point(578, 1);
            this.pbx_minimize.Name = "pbx_minimize";
            this.pbx_minimize.Size = new System.Drawing.Size(49, 42);
            this.pbx_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_minimize.TabIndex = 22;
            this.pbx_minimize.TabStop = false;
            this.pbx_minimize.Click += new System.EventHandler(this.pbx_minimize_Click);
            // 
            // pbx_close
            // 
            this.pbx_close.Image = ((System.Drawing.Image)(resources.GetObject("pbx_close.Image")));
            this.pbx_close.Location = new System.Drawing.Point(633, 1);
            this.pbx_close.Name = "pbx_close";
            this.pbx_close.Size = new System.Drawing.Size(49, 42);
            this.pbx_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_close.TabIndex = 23;
            this.pbx_close.TabStop = false;
            this.pbx_close.Click += new System.EventHandler(this.pbx_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Seleção PAGAMENTOS ";
            // 
            // cbx_selecione
            // 
            this.cbx_selecione.FormattingEnabled = true;
            this.cbx_selecione.Items.AddRange(new object[] {
            "PAGAMENTOS À RECEBER",
            "PAGAMENTOS FEITOS"});
            this.cbx_selecione.Location = new System.Drawing.Point(129, 153);
            this.cbx_selecione.Name = "cbx_selecione";
            this.cbx_selecione.Size = new System.Drawing.Size(364, 21);
            this.cbx_selecione.TabIndex = 77;
            // 
            // btn_calc_grauPert
            // 
            this.btn_calc_grauPert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calc_grauPert.Location = new System.Drawing.Point(238, 246);
            this.btn_calc_grauPert.Name = "btn_calc_grauPert";
            this.btn_calc_grauPert.Size = new System.Drawing.Size(171, 21);
            this.btn_calc_grauPert.TabIndex = 78;
            this.btn_calc_grauPert.Text = "SELECIONAR";
            this.btn_calc_grauPert.UseVisualStyleBackColor = true;
            this.btn_calc_grauPert.Click += new System.EventHandler(this.btn_calc_grauPert_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(62, 73);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(507, 16);
            this.label31.TabIndex = 79;
            this.label31.Text = "Selecione entre PAGAMENTOS À RECEBER ou PAGAMENTOS FEITOS:";
            // 
            // Select_Qual_Pgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 309);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.btn_calc_grauPert);
            this.Controls.Add(this.cbx_selecione);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbx_minimize);
            this.Controls.Add(this.pbx_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select_Qual_Pgto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select_Qual_Pgto";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_minimize;
        private System.Windows.Forms.PictureBox pbx_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_selecione;
        private System.Windows.Forms.Button btn_calc_grauPert;
        private System.Windows.Forms.Label label31;
    }
}
namespace RETSYS
{
    partial class Load
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.load_bar = new System.Windows.Forms.ProgressBar();
            this.tmr_pgBar = new System.Windows.Forms.Timer(this.components);
            this.link_wbt = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // load_bar
            // 
            this.load_bar.Location = new System.Drawing.Point(12, 284);
            this.load_bar.Name = "load_bar";
            this.load_bar.Size = new System.Drawing.Size(662, 19);
            this.load_bar.TabIndex = 0;
            // 
            // tmr_pgBar
            // 
            this.tmr_pgBar.Tick += new System.EventHandler(this.tmr_pgBar_Tick);
            // 
            // link_wbt
            // 
            this.link_wbt.AutoSize = true;
            this.link_wbt.BackColor = System.Drawing.Color.CornflowerBlue;
            this.link_wbt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.link_wbt.Location = new System.Drawing.Point(442, 244);
            this.link_wbt.Name = "link_wbt";
            this.link_wbt.Size = new System.Drawing.Size(106, 13);
            this.link_wbt.TabIndex = 1;
            this.link_wbt.TabStop = true;
            this.link_wbt.Text = "www.webting.com.br";
            this.link_wbt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RETSYS.Properties.Resources.RETSYS_COMERCIAL_VERSION;
            this.ClientSize = new System.Drawing.Size(686, 332);
            this.Controls.Add(this.link_wbt);
            this.Controls.Add(this.load_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar load_bar;
        private System.Windows.Forms.Timer tmr_pgBar;
        private System.Windows.Forms.LinkLabel link_wbt;
    }
}
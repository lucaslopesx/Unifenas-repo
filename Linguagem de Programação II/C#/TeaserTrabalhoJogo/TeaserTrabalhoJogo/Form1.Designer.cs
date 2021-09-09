
namespace TeaserTrabalhoJogo
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJogar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRanking = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastrar,
            this.mnuJogar,
            this.mnuRanking});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuCadastrar
            // 
            this.mnuCadastrar.Name = "mnuCadastrar";
            this.mnuCadastrar.Size = new System.Drawing.Size(114, 20);
            this.mnuCadastrar.Text = "Cadastrar Jogador";
            this.mnuCadastrar.Click += new System.EventHandler(this.mnuCadastrar_Click);
            // 
            // mnuJogar
            // 
            this.mnuJogar.Name = "mnuJogar";
            this.mnuJogar.Size = new System.Drawing.Size(47, 20);
            this.mnuJogar.Text = "Jogar";
            this.mnuJogar.Click += new System.EventHandler(this.mnuJogar_Click);
            // 
            // mnuRanking
            // 
            this.mnuRanking.Name = "mnuRanking";
            this.mnuRanking.Size = new System.Drawing.Size(62, 20);
            this.mnuRanking.Text = "Ranking";
            this.mnuRanking.Click += new System.EventHandler(this.mnuRanking_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem mnuJogar;
        private System.Windows.Forms.ToolStripMenuItem mnuRanking;
    }
}


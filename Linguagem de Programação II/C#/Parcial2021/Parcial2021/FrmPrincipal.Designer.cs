
namespace Parcial2021
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisaAlunoPorIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularSituaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorSituaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisaAlunoPorIdToolStripMenuItem,
            this.calcularSituaçãoToolStripMenuItem,
            this.pesquisarPorSituaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pesquisaAlunoPorIdToolStripMenuItem
            // 
            this.pesquisaAlunoPorIdToolStripMenuItem.Name = "pesquisaAlunoPorIdToolStripMenuItem";
            this.pesquisaAlunoPorIdToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.pesquisaAlunoPorIdToolStripMenuItem.Text = "Pesquisa Aluno por Id";
            this.pesquisaAlunoPorIdToolStripMenuItem.Click += new System.EventHandler(this.pesquisaAlunoPorIdToolStripMenuItem_Click);
            // 
            // calcularSituaçãoToolStripMenuItem
            // 
            this.calcularSituaçãoToolStripMenuItem.Name = "calcularSituaçãoToolStripMenuItem";
            this.calcularSituaçãoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.calcularSituaçãoToolStripMenuItem.Text = "Calcular Situação";
            this.calcularSituaçãoToolStripMenuItem.Click += new System.EventHandler(this.calcularSituaçãoToolStripMenuItem_Click);
            // 
            // pesquisarPorSituaçãoToolStripMenuItem
            // 
            this.pesquisarPorSituaçãoToolStripMenuItem.Name = "pesquisarPorSituaçãoToolStripMenuItem";
            this.pesquisarPorSituaçãoToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.pesquisarPorSituaçãoToolStripMenuItem.Text = "Pesquisar por Situação";
            this.pesquisarPorSituaçãoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorSituaçãoToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisaAlunoPorIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularSituaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorSituaçãoToolStripMenuItem;
    }
}


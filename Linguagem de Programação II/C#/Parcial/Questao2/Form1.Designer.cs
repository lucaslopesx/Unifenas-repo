
namespace Questao2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmdIncluir = new System.Windows.Forms.Button();
            this.cmdPares = new System.Windows.Forms.Button();
            this.cmdImpares = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(110, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // cmdIncluir
            // 
            this.cmdIncluir.Location = new System.Drawing.Point(247, 40);
            this.cmdIncluir.Name = "cmdIncluir";
            this.cmdIncluir.Size = new System.Drawing.Size(75, 23);
            this.cmdIncluir.TabIndex = 2;
            this.cmdIncluir.Text = "Incluir";
            this.cmdIncluir.UseVisualStyleBackColor = true;
            this.cmdIncluir.Click += new System.EventHandler(this.cmdIncluir_Click);
            // 
            // cmdPares
            // 
            this.cmdPares.Location = new System.Drawing.Point(41, 112);
            this.cmdPares.Name = "cmdPares";
            this.cmdPares.Size = new System.Drawing.Size(75, 23);
            this.cmdPares.TabIndex = 3;
            this.cmdPares.Text = "Pares";
            this.cmdPares.UseVisualStyleBackColor = true;
            this.cmdPares.Click += new System.EventHandler(this.cmdPares_Click);
            // 
            // cmdImpares
            // 
            this.cmdImpares.Location = new System.Drawing.Point(179, 112);
            this.cmdImpares.Name = "cmdImpares";
            this.cmdImpares.Size = new System.Drawing.Size(75, 23);
            this.cmdImpares.TabIndex = 4;
            this.cmdImpares.Text = "Impares";
            this.cmdImpares.UseVisualStyleBackColor = true;
            this.cmdImpares.Click += new System.EventHandler(this.cmdImpares_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(41, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 225);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmdImpares);
            this.Controls.Add(this.cmdPares);
            this.Controls.Add(this.cmdIncluir);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button cmdIncluir;
        private System.Windows.Forms.Button cmdPares;
        private System.Windows.Forms.Button cmdImpares;
        private System.Windows.Forms.Label lblStatus;
    }
}


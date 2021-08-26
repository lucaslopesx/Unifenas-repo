
namespace Projeto04
{
    partial class FrmLista
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.cmdNome = new System.Windows.Forms.Button();
            this.cmdIdade = new System.Windows.Forms.Button();
            this.cmdObjeto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(23, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 409);
            this.listBox1.TabIndex = 0;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(492, 99);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(162, 23);
            this.cmdMostrar.TabIndex = 1;
            this.cmdMostrar.Text = "Mostrar Objetos da Lista";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // cmdNome
            // 
            this.cmdNome.Location = new System.Drawing.Point(471, 138);
            this.cmdNome.Name = "cmdNome";
            this.cmdNome.Size = new System.Drawing.Size(207, 23);
            this.cmdNome.TabIndex = 2;
            this.cmdNome.Text = "Mostra Lista Ordenada por nome";
            this.cmdNome.UseVisualStyleBackColor = true;
            this.cmdNome.Click += new System.EventHandler(this.cmdNome_Click);
            // 
            // cmdIdade
            // 
            this.cmdIdade.Location = new System.Drawing.Point(471, 183);
            this.cmdIdade.Name = "cmdIdade";
            this.cmdIdade.Size = new System.Drawing.Size(207, 23);
            this.cmdIdade.TabIndex = 3;
            this.cmdIdade.Text = "Filtrando a lista: idade >30";
            this.cmdIdade.UseVisualStyleBackColor = true;
            this.cmdIdade.Click += new System.EventHandler(this.cmdIdade_Click);
            // 
            // cmdObjeto
            // 
            this.cmdObjeto.Location = new System.Drawing.Point(471, 312);
            this.cmdObjeto.Name = "cmdObjeto";
            this.cmdObjeto.Size = new System.Drawing.Size(207, 23);
            this.cmdObjeto.TabIndex = 4;
            this.cmdObjeto.Text = "Localizando objetos na lista";
            this.cmdObjeto.UseVisualStyleBackColor = true;
            this.cmdObjeto.Click += new System.EventHandler(this.cmdObjeto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(522, 283);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 6;
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdObjeto);
            this.Controls.Add(this.cmdIdade);
            this.Controls.Add(this.cmdNome);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmLista";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Button cmdNome;
        private System.Windows.Forms.Button cmdIdade;
        private System.Windows.Forms.Button cmdObjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}


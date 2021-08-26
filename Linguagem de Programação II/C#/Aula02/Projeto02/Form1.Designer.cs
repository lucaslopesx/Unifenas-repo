
namespace Projeto02
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.lblSelecionado = new System.Windows.Forms.Label();
            this.cmdIncluir = new System.Windows.Forms.Button();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Ciência da Computação",
            "Odontologia",
            "Administração",
            "Enfermagem"});
            this.listBox1.Location = new System.Drawing.Point(40, 156);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 94);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cursos";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(40, 56);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 23);
            this.txtCurso.TabIndex = 2;
            // 
            // lblSelecionado
            // 
            this.lblSelecionado.AutoSize = true;
            this.lblSelecionado.Location = new System.Drawing.Point(40, 305);
            this.lblSelecionado.Name = "lblSelecionado";
            this.lblSelecionado.Size = new System.Drawing.Size(0, 15);
            this.lblSelecionado.TabIndex = 3;
            // 
            // cmdIncluir
            // 
            this.cmdIncluir.Location = new System.Drawing.Point(260, 56);
            this.cmdIncluir.Name = "cmdIncluir";
            this.cmdIncluir.Size = new System.Drawing.Size(75, 23);
            this.cmdIncluir.TabIndex = 4;
            this.cmdIncluir.Text = "Incluir";
            this.cmdIncluir.UseVisualStyleBackColor = true;
            this.cmdIncluir.Click += new System.EventHandler(this.cmdIncluir_Click);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.Location = new System.Drawing.Point(260, 115);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(75, 23);
            this.cmdExcluir.TabIndex = 5;
            this.cmdExcluir.Text = "Excluir";
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(260, 174);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpar.TabIndex = 6;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.cmdExcluir);
            this.Controls.Add(this.cmdIncluir);
            this.Controls.Add(this.lblSelecionado);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label lblSelecionado;
        private System.Windows.Forms.Button cmdIncluir;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdLimpar;
    }
}


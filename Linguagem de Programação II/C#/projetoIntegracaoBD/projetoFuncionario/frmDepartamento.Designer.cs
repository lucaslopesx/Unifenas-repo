
namespace projetoFuncionario
{
    partial class frmDepartamento
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
            this.lblMaiorSalario = new System.Windows.Forms.Label();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDados = new System.Windows.Forms.Label();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.cmdCadastra = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaiorSalario
            // 
            this.lblMaiorSalario.AutoSize = true;
            this.lblMaiorSalario.Location = new System.Drawing.Point(45, 302);
            this.lblMaiorSalario.Name = "lblMaiorSalario";
            this.lblMaiorSalario.Size = new System.Drawing.Size(0, 15);
            this.lblMaiorSalario.TabIndex = 11;
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(45, 253);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(242, 23);
            this.cmdPesquisar.TabIndex = 10;
            this.cmdPesquisar.Text = "Mostrar departamentos";
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.lblDados);
            this.panel2.Location = new System.Drawing.Point(382, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 382);
            this.panel2.TabIndex = 9;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(18, 19);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(0, 15);
            this.lblDados.TabIndex = 1;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(382, 12);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(136, 23);
            this.cmdMostrar.TabIndex = 8;
            this.cmdMostrar.Text = "Mostrar departamentos";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar departamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdLimpar);
            this.panel1.Controls.Add(this.cmdCadastra);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 139);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(20, 102);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpar.TabIndex = 8;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // cmdCadastra
            // 
            this.cmdCadastra.Location = new System.Drawing.Point(232, 102);
            this.cmdCadastra.Name = "cmdCadastra";
            this.cmdCadastra.Size = new System.Drawing.Size(75, 23);
            this.cmdCadastra.TabIndex = 7;
            this.cmdCadastra.Text = "Cadastrar";
            this.cmdCadastra.UseVisualStyleBackColor = true;
            this.cmdCadastra.Click += new System.EventHandler(this.cmdCadastra_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(53, 73);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(273, 23);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(273, 23);
            this.txtNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cadastro do departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // frmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMaiorSalario);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDepartamento";
            this.Text = "frmDepartamento";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaiorSalario;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button cmdCadastra;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
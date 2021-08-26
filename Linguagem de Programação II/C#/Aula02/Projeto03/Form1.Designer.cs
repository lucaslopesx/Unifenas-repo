
namespace Projeto03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbCatapora = new System.Windows.Forms.CheckBox();
            this.ckbPoliomielite = new System.Windows.Forms.CheckBox();
            this.ckbFebreAmarela = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmdAdicionar = new System.Windows.Forms.Button();
            this.lbPacientes = new System.Windows.Forms.ListBox();
            this.cmdAlfenas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPesquisa2 = new System.Windows.Forms.Label();
            this.cmdCatapora = new System.Windows.Forms.Button();
            this.lblPesquisa1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cidade";
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Machado",
            "Alfenas"});
            this.cmbCidade.Location = new System.Drawing.Point(311, 27);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 23);
            this.cmbCidade.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFeminino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Location = new System.Drawing.Point(35, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(13, 74);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(75, 19);
            this.rbFeminino.TabIndex = 1;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(13, 36);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ckbCatapora);
            this.panel1.Controls.Add(this.ckbPoliomielite);
            this.panel1.Controls.Add(this.ckbFebreAmarela);
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(210, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 93);
            this.panel1.TabIndex = 5;
            // 
            // ckbCatapora
            // 
            this.ckbCatapora.AutoSize = true;
            this.ckbCatapora.Location = new System.Drawing.Point(134, 36);
            this.ckbCatapora.Name = "ckbCatapora";
            this.ckbCatapora.Size = new System.Drawing.Size(74, 19);
            this.ckbCatapora.TabIndex = 3;
            this.ckbCatapora.Text = "Catapora";
            this.ckbCatapora.UseVisualStyleBackColor = true;
            // 
            // ckbPoliomielite
            // 
            this.ckbPoliomielite.AutoSize = true;
            this.ckbPoliomielite.Location = new System.Drawing.Point(18, 61);
            this.ckbPoliomielite.Name = "ckbPoliomielite";
            this.ckbPoliomielite.Size = new System.Drawing.Size(89, 19);
            this.ckbPoliomielite.TabIndex = 2;
            this.ckbPoliomielite.Text = "Poliomielite";
            this.ckbPoliomielite.UseVisualStyleBackColor = true;
            // 
            // ckbFebreAmarela
            // 
            this.ckbFebreAmarela.AutoSize = true;
            this.ckbFebreAmarela.Location = new System.Drawing.Point(18, 36);
            this.ckbFebreAmarela.Name = "ckbFebreAmarela";
            this.ckbFebreAmarela.Size = new System.Drawing.Size(102, 19);
            this.ckbFebreAmarela.TabIndex = 1;
            this.ckbFebreAmarela.Text = "Febre Amarela";
            this.ckbFebreAmarela.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vacinas";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(29, 23);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(140, 23);
            this.txtNome.TabIndex = 7;
            // 
            // cmdAdicionar
            // 
            this.cmdAdicionar.Location = new System.Drawing.Point(35, 273);
            this.cmdAdicionar.Name = "cmdAdicionar";
            this.cmdAdicionar.Size = new System.Drawing.Size(75, 23);
            this.cmdAdicionar.TabIndex = 8;
            this.cmdAdicionar.Text = "Adicionar";
            this.cmdAdicionar.UseVisualStyleBackColor = true;
            this.cmdAdicionar.Click += new System.EventHandler(this.cmdAdicionar_Click);
            // 
            // lbPacientes
            // 
            this.lbPacientes.FormattingEnabled = true;
            this.lbPacientes.ItemHeight = 15;
            this.lbPacientes.Location = new System.Drawing.Point(35, 313);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(397, 124);
            this.lbPacientes.TabIndex = 9;
            // 
            // cmdAlfenas
            // 
            this.cmdAlfenas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAlfenas.Location = new System.Drawing.Point(66, 23);
            this.cmdAlfenas.Name = "cmdAlfenas";
            this.cmdAlfenas.Size = new System.Drawing.Size(150, 23);
            this.cmdAlfenas.TabIndex = 10;
            this.cmdAlfenas.Text = "Pacientes de Alfenas";
            this.cmdAlfenas.UseVisualStyleBackColor = true;
            this.cmdAlfenas.Click += new System.EventHandler(this.cmdAlfenas_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPesquisa2);
            this.panel2.Controls.Add(this.cmdCatapora);
            this.panel2.Controls.Add(this.lblPesquisa1);
            this.panel2.Controls.Add(this.cmdAlfenas);
            this.panel2.Location = new System.Drawing.Point(477, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 347);
            this.panel2.TabIndex = 11;
            // 
            // lblPesquisa2
            // 
            this.lblPesquisa2.AutoSize = true;
            this.lblPesquisa2.Location = new System.Drawing.Point(132, 190);
            this.lblPesquisa2.Name = "lblPesquisa2";
            this.lblPesquisa2.Size = new System.Drawing.Size(0, 15);
            this.lblPesquisa2.TabIndex = 13;
            // 
            // cmdCatapora
            // 
            this.cmdCatapora.Location = new System.Drawing.Point(25, 160);
            this.cmdCatapora.Name = "cmdCatapora";
            this.cmdCatapora.Size = new System.Drawing.Size(242, 23);
            this.cmdCatapora.TabIndex = 12;
            this.cmdCatapora.Text = "Numero de pacientes vacina Catapora";
            this.cmdCatapora.UseVisualStyleBackColor = true;
            this.cmdCatapora.Click += new System.EventHandler(this.cmdCatapora_Click);
            // 
            // lblPesquisa1
            // 
            this.lblPesquisa1.AutoSize = true;
            this.lblPesquisa1.Location = new System.Drawing.Point(132, 49);
            this.lblPesquisa1.Name = "lblPesquisa1";
            this.lblPesquisa1.Size = new System.Drawing.Size(0, 15);
            this.lblPesquisa1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbPacientes);
            this.Controls.Add(this.cmdAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbCatapora;
        private System.Windows.Forms.CheckBox ckbPoliomielite;
        private System.Windows.Forms.CheckBox ckbFebreAmarela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cmdAdicionar;
        private System.Windows.Forms.ListBox lbPacientes;
        private System.Windows.Forms.Button cmdAlfenas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPesquisa2;
        private System.Windows.Forms.Button cmdCatapora;
        private System.Windows.Forms.Label lblPesquisa1;
    }
}


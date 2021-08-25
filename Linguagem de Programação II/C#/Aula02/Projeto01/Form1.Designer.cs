
namespace Projeto01
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.gbPermissao = new System.Windows.Forms.GroupBox();
            this.ckApagar = new System.Windows.Forms.CheckBox();
            this.ckAlterar = new System.Windows.Forms.CheckBox();
            this.ckIncluir = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblApagar = new System.Windows.Forms.Label();
            this.lblAlterar = new System.Windows.Forms.Label();
            this.lblIncluir = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMostra = new System.Windows.Forms.Label();
            this.btnMostra = new System.Windows.Forms.Button();
            this.gbTipo.SuspendLayout();
            this.gbPermissao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 23);
            this.txtNome.TabIndex = 1;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbUser);
            this.gbTipo.Controls.Add(this.rbAdmin);
            this.gbTipo.Location = new System.Drawing.Point(35, 68);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(200, 100);
            this.gbTipo.TabIndex = 2;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Location = new System.Drawing.Point(16, 65);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(65, 19);
            this.rbUser.TabIndex = 4;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "Usuario";
            this.rbUser.UseVisualStyleBackColor = true;
            this.rbUser.CheckedChanged += new System.EventHandler(this.rbUser_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(16, 23);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(61, 19);
            this.rbAdmin.TabIndex = 3;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.CheckedChanged += new System.EventHandler(this.rbAdmin_CheckedChanged);
            // 
            // gbPermissao
            // 
            this.gbPermissao.Controls.Add(this.ckApagar);
            this.gbPermissao.Controls.Add(this.ckAlterar);
            this.gbPermissao.Controls.Add(this.ckIncluir);
            this.gbPermissao.Location = new System.Drawing.Point(256, 68);
            this.gbPermissao.Name = "gbPermissao";
            this.gbPermissao.Size = new System.Drawing.Size(202, 113);
            this.gbPermissao.TabIndex = 3;
            this.gbPermissao.TabStop = false;
            this.gbPermissao.Text = "Permissão";
            // 
            // ckApagar
            // 
            this.ckApagar.AutoSize = true;
            this.ckApagar.Location = new System.Drawing.Point(26, 75);
            this.ckApagar.Name = "ckApagar";
            this.ckApagar.Size = new System.Drawing.Size(64, 19);
            this.ckApagar.TabIndex = 4;
            this.ckApagar.Text = "Apagar";
            this.ckApagar.UseVisualStyleBackColor = true;
            this.ckApagar.CheckedChanged += new System.EventHandler(this.ckApagar_CheckedChanged);
            // 
            // ckAlterar
            // 
            this.ckAlterar.AutoSize = true;
            this.ckAlterar.Location = new System.Drawing.Point(26, 48);
            this.ckAlterar.Name = "ckAlterar";
            this.ckAlterar.Size = new System.Drawing.Size(61, 19);
            this.ckAlterar.TabIndex = 1;
            this.ckAlterar.Text = "Alterar";
            this.ckAlterar.UseVisualStyleBackColor = true;
            this.ckAlterar.CheckedChanged += new System.EventHandler(this.ckAlterar_CheckedChanged);
            // 
            // ckIncluir
            // 
            this.ckIncluir.AutoSize = true;
            this.ckIncluir.Location = new System.Drawing.Point(26, 23);
            this.ckIncluir.Name = "ckIncluir";
            this.ckIncluir.Size = new System.Drawing.Size(59, 19);
            this.ckIncluir.TabIndex = 0;
            this.ckIncluir.Text = "Incluir";
            this.ckIncluir.UseVisualStyleBackColor = true;
            this.ckIncluir.CheckedChanged += new System.EventHandler(this.ckIncluir_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblApagar);
            this.panel1.Controls.Add(this.lblAlterar);
            this.panel1.Controls.Add(this.lblIncluir);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(505, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 225);
            this.panel1.TabIndex = 4;
            // 
            // lblApagar
            // 
            this.lblApagar.AutoSize = true;
            this.lblApagar.Location = new System.Drawing.Point(26, 190);
            this.lblApagar.Name = "lblApagar";
            this.lblApagar.Size = new System.Drawing.Size(0, 15);
            this.lblApagar.TabIndex = 5;
            // 
            // lblAlterar
            // 
            this.lblAlterar.AutoSize = true;
            this.lblAlterar.Location = new System.Drawing.Point(26, 141);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(0, 15);
            this.lblAlterar.TabIndex = 2;
            // 
            // lblIncluir
            // 
            this.lblIncluir.AutoSize = true;
            this.lblIncluir.Location = new System.Drawing.Point(26, 83);
            this.lblIncluir.Name = "lblIncluir";
            this.lblIncluir.Size = new System.Drawing.Size(0, 15);
            this.lblIncluir.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(26, 30);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 15);
            this.lblTipo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMostra);
            this.panel2.Controls.Add(this.btnMostra);
            this.panel2.Location = new System.Drawing.Point(35, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 123);
            this.panel2.TabIndex = 5;
            // 
            // lblMostra
            // 
            this.lblMostra.AutoSize = true;
            this.lblMostra.Location = new System.Drawing.Point(112, 44);
            this.lblMostra.Name = "lblMostra";
            this.lblMostra.Size = new System.Drawing.Size(38, 15);
            this.lblMostra.TabIndex = 1;
            this.lblMostra.Text = "label2";
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(4, 4);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(75, 23);
            this.btnMostra.TabIndex = 0;
            this.btnMostra.Text = "Mostra";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbPermissao);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.gbPermissao.ResumeLayout(false);
            this.gbPermissao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbUser;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.GroupBox gbPermissao;
        private System.Windows.Forms.CheckBox ckApagar;
        private System.Windows.Forms.CheckBox ckAlterar;
        private System.Windows.Forms.CheckBox ckIncluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApagar;
        private System.Windows.Forms.Label lblAlterar;
        private System.Windows.Forms.Label lblIncluir;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMostra;
        private System.Windows.Forms.Button btnMostra;
    }
}


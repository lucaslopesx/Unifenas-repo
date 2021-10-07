
namespace projetoFuncionario
{
    partial class frmFuncionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDados = new System.Windows.Forms.Label();
            this.cmdMaiorSalario = new System.Windows.Forms.Button();
            this.lblMaiorSalario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdLimpar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 164);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(23, 132);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpar.TabIndex = 8;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(53, 103);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(273, 23);
            this.txtSalario.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
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
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cadastro do funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de nascimento:";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar Funcionario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(399, 13);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(136, 23);
            this.cmdMostrar.TabIndex = 2;
            this.cmdMostrar.Text = "Mostrar Funcionarios";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.lblDados);
            this.panel2.Location = new System.Drawing.Point(399, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 382);
            this.panel2.TabIndex = 3;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(4, 19);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(0, 15);
            this.lblDados.TabIndex = 1;
            // 
            // cmdMaiorSalario
            // 
            this.cmdMaiorSalario.Location = new System.Drawing.Point(62, 254);
            this.cmdMaiorSalario.Name = "cmdMaiorSalario";
            this.cmdMaiorSalario.Size = new System.Drawing.Size(242, 23);
            this.cmdMaiorSalario.TabIndex = 4;
            this.cmdMaiorSalario.Text = "Mostrar Funcionario com maior salario";
            this.cmdMaiorSalario.UseVisualStyleBackColor = true;
            this.cmdMaiorSalario.Click += new System.EventHandler(this.cmdMaiorSalario_Click);
            // 
            // lblMaiorSalario
            // 
            this.lblMaiorSalario.AutoSize = true;
            this.lblMaiorSalario.Location = new System.Drawing.Point(62, 303);
            this.lblMaiorSalario.Name = "lblMaiorSalario";
            this.lblMaiorSalario.Size = new System.Drawing.Size(0, 15);
            this.lblMaiorSalario.TabIndex = 5;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.lblMaiorSalario);
            this.Controls.Add(this.cmdMaiorSalario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "frmFuncionario";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button cmdMaiorSalario;
        private System.Windows.Forms.Label lblMaiorSalario;
    }
}


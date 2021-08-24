
namespace Projeto1
{
    partial class frmEscola
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
            this.lblEscola = new System.Windows.Forms.Label();
            this.cmdEscola = new System.Windows.Forms.Button();
            this.cmdMostrarCurso = new System.Windows.Forms.Button();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(98, 168);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(38, 15);
            this.lblEscola.TabIndex = 0;
            this.lblEscola.Text = "label1";
            // 
            // cmdEscola
            // 
            this.cmdEscola.Location = new System.Drawing.Point(252, 74);
            this.cmdEscola.Name = "cmdEscola";
            this.cmdEscola.Size = new System.Drawing.Size(75, 23);
            this.cmdEscola.TabIndex = 1;
            this.cmdEscola.Text = "Escola";
            this.cmdEscola.UseVisualStyleBackColor = true;
            this.cmdEscola.Click += new System.EventHandler(this.cmdEscola_Click);
            // 
            // cmdMostrarCurso
            // 
            this.cmdMostrarCurso.Location = new System.Drawing.Point(181, 232);
            this.cmdMostrarCurso.Name = "cmdMostrarCurso";
            this.cmdMostrarCurso.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrarCurso.TabIndex = 2;
            this.cmdMostrarCurso.Text = "Mostrar Cursos";
            this.cmdMostrarCurso.UseVisualStyleBackColor = true;
            this.cmdMostrarCurso.Click += new System.EventHandler(this.cmdMostrarCurso_Click);
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(79, 75);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(100, 23);
            this.txtEscola.TabIndex = 3;
            // 
            // frmEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 324);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.cmdMostrarCurso);
            this.Controls.Add(this.cmdEscola);
            this.Controls.Add(this.lblEscola);
            this.Name = "frmEscola";
            this.Text = "frmEscola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.Button cmdEscola;
        private System.Windows.Forms.Button cmdMostrarCurso;
        private System.Windows.Forms.TextBox txtEscola;
    }
}
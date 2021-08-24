
namespace Projeto01
{
    partial class frmCurso
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
            this.lblEscola = new System.Windows.Forms.Label();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.cmdEscola = new System.Windows.Forms.Button();
            this.cmdMostraCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEscola
            // 
            this.lblEscola.AutoSize = true;
            this.lblEscola.Location = new System.Drawing.Point(81, 134);
            this.lblEscola.Name = "lblEscola";
            this.lblEscola.Size = new System.Drawing.Size(40, 15);
            this.lblEscola.TabIndex = 0;
            this.lblEscola.Text = "Escola";
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(65, 47);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(158, 23);
            this.txtEscola.TabIndex = 2;
            // 
            // cmdEscola
            // 
            this.cmdEscola.Location = new System.Drawing.Point(288, 47);
            this.cmdEscola.Name = "cmdEscola";
            this.cmdEscola.Size = new System.Drawing.Size(75, 23);
            this.cmdEscola.TabIndex = 3;
            this.cmdEscola.Text = "Escola";
            this.cmdEscola.UseVisualStyleBackColor = true;
            this.cmdEscola.Click += new System.EventHandler(this.cmdEscola_Click);
            // 
            // cmdMostraCurso
            // 
            this.cmdMostraCurso.Location = new System.Drawing.Point(158, 243);
            this.cmdMostraCurso.Name = "cmdMostraCurso";
            this.cmdMostraCurso.Size = new System.Drawing.Size(137, 23);
            this.cmdMostraCurso.TabIndex = 4;
            this.cmdMostraCurso.Text = "Mostrar Cursos";
            this.cmdMostraCurso.UseVisualStyleBackColor = true;
            this.cmdMostraCurso.Click += new System.EventHandler(this.cmdMostraCurso_Click);
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 350);
            this.Controls.Add(this.cmdMostraCurso);
            this.Controls.Add(this.cmdEscola);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.lblEscola);
            this.Name = "frmCurso";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscola;
        private System.Windows.Forms.TextBox txtEscola;
        private System.Windows.Forms.Button cmdEscola;
        private System.Windows.Forms.Button cmdMostraCurso;
    }
}


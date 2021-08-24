
namespace Projeto1
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
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmdCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(87, 132);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(38, 15);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso";
            // 
            // cmdCurso
            // 
            this.cmdCurso.Location = new System.Drawing.Point(67, 48);
            this.cmdCurso.Name = "cmdCurso";
            this.cmdCurso.Size = new System.Drawing.Size(75, 23);
            this.cmdCurso.TabIndex = 1;
            this.cmdCurso.Text = "Curso";
            this.cmdCurso.UseVisualStyleBackColor = true;
            this.cmdCurso.Click += new System.EventHandler(this.cmdCurso_Click);
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(219, 280);
            this.Controls.Add(this.cmdCurso);
            this.Controls.Add(this.lblCurso);
            this.Name = "frmCurso";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button cmdCurso;
    }
}


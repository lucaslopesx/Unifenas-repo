
namespace Projeto03
{
    partial class frmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cmdImagem1 = new System.Windows.Forms.Button();
            this.cmdImagem2 = new System.Windows.Forms.Button();
            this.cmdCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 23);
            this.txtNome.TabIndex = 1;
            // 
            // cmdImagem1
            // 
            this.cmdImagem1.Location = new System.Drawing.Point(104, 196);
            this.cmdImagem1.Name = "cmdImagem1";
            this.cmdImagem1.Size = new System.Drawing.Size(75, 23);
            this.cmdImagem1.TabIndex = 2;
            this.cmdImagem1.Text = "Imagem 1";
            this.cmdImagem1.UseVisualStyleBackColor = true;
            this.cmdImagem1.Click += new System.EventHandler(this.cmdImagem1_Click);
            // 
            // cmdImagem2
            // 
            this.cmdImagem2.Location = new System.Drawing.Point(327, 196);
            this.cmdImagem2.Name = "cmdImagem2";
            this.cmdImagem2.Size = new System.Drawing.Size(75, 23);
            this.cmdImagem2.TabIndex = 3;
            this.cmdImagem2.Text = "Imagem 2";
            this.cmdImagem2.UseVisualStyleBackColor = true;
            this.cmdImagem2.Click += new System.EventHandler(this.cmdImagem2_Click);
            // 
            // cmdCadastrar
            // 
            this.cmdCadastrar.Location = new System.Drawing.Point(213, 237);
            this.cmdCadastrar.Name = "cmdCadastrar";
            this.cmdCadastrar.Size = new System.Drawing.Size(75, 23);
            this.cmdCadastrar.TabIndex = 4;
            this.cmdCadastrar.Text = "Cadastrar";
            this.cmdCadastrar.UseVisualStyleBackColor = true;
            this.cmdCadastrar.Click += new System.EventHandler(this.cmdCadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(283, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 291);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdCadastrar);
            this.Controls.Add(this.cmdImagem2);
            this.Controls.Add(this.cmdImagem1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cmdImagem1;
        private System.Windows.Forms.Button cmdImagem2;
        private System.Windows.Forms.Button cmdCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
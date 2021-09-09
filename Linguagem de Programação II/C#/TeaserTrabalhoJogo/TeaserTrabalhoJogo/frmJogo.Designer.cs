
namespace TeaserTrabalhoJogo
{
    partial class frmJogo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOpcao3 = new System.Windows.Forms.RadioButton();
            this.rbOpcao2 = new System.Windows.Forms.RadioButton();
            this.rbOpcao1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(74, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOpcao3);
            this.panel1.Controls.Add(this.rbOpcao2);
            this.panel1.Controls.Add(this.rbOpcao1);
            this.panel1.Location = new System.Drawing.Point(311, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 80);
            this.panel1.TabIndex = 1;
            // 
            // rbOpcao3
            // 
            this.rbOpcao3.AutoSize = true;
            this.rbOpcao3.Location = new System.Drawing.Point(4, 56);
            this.rbOpcao3.Name = "rbOpcao3";
            this.rbOpcao3.Size = new System.Drawing.Size(94, 19);
            this.rbOpcao3.TabIndex = 2;
            this.rbOpcao3.TabStop = true;
            this.rbOpcao3.Text = "radioButton3";
            this.rbOpcao3.UseVisualStyleBackColor = true;
            // 
            // rbOpcao2
            // 
            this.rbOpcao2.AutoSize = true;
            this.rbOpcao2.Location = new System.Drawing.Point(4, 30);
            this.rbOpcao2.Name = "rbOpcao2";
            this.rbOpcao2.Size = new System.Drawing.Size(94, 19);
            this.rbOpcao2.TabIndex = 1;
            this.rbOpcao2.TabStop = true;
            this.rbOpcao2.Text = "radioButton2";
            this.rbOpcao2.UseVisualStyleBackColor = true;
            // 
            // rbOpcao1
            // 
            this.rbOpcao1.AutoSize = true;
            this.rbOpcao1.Location = new System.Drawing.Point(4, 5);
            this.rbOpcao1.Name = "rbOpcao1";
            this.rbOpcao1.Size = new System.Drawing.Size(94, 19);
            this.rbOpcao1.TabIndex = 0;
            this.rbOpcao1.TabStop = true;
            this.rbOpcao1.Text = "radioButton1";
            this.rbOpcao1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jogador:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Finalizar jogo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 308);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmJogo";
            this.Text = "Jogo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOpcao3;
        private System.Windows.Forms.RadioButton rbOpcao2;
        private System.Windows.Forms.RadioButton rbOpcao1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}
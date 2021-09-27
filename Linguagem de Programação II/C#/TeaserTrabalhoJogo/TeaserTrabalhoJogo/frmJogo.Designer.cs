
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
            this.cmdEnviar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelJogo = new System.Windows.Forms.Panel();
            this.cmdComecar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeaserTrabalhoJogo.Properties.Resources.Captura_de_tela_2021_02_11_114542;
            this.pictureBox1.InitialImage = global::TeaserTrabalhoJogo.Properties.Resources.Captura_de_tela_2021_02_11_114542;
            this.pictureBox1.Location = new System.Drawing.Point(25, 40);
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
            this.panel1.Location = new System.Drawing.Point(254, 40);
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
            this.rbOpcao2.Location = new System.Drawing.Point(4, 31);
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
            // cmdEnviar
            // 
            this.cmdEnviar.Location = new System.Drawing.Point(289, 161);
            this.cmdEnviar.Name = "cmdEnviar";
            this.cmdEnviar.Size = new System.Drawing.Size(75, 23);
            this.cmdEnviar.TabIndex = 2;
            this.cmdEnviar.Text = "Enviar";
            this.cmdEnviar.UseVisualStyleBackColor = true;
            this.cmdEnviar.Click += new System.EventHandler(this.cmdEnviar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // cmdFinalizar
            // 
            this.cmdFinalizar.Location = new System.Drawing.Point(427, 273);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(100, 23);
            this.cmdFinalizar.TabIndex = 5;
            this.cmdFinalizar.Text = "Finalizar jogo";
            this.cmdFinalizar.UseVisualStyleBackColor = true;
            this.cmdFinalizar.Click += new System.EventHandler(this.cmdFinalizar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(81, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(68, 21);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "placeholder";
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // panelJogo
            // 
            this.panelJogo.Controls.Add(this.pictureBox1);
            this.panelJogo.Controls.Add(this.lblTitle);
            this.panelJogo.Controls.Add(this.panel1);
            this.panelJogo.Controls.Add(this.cmdEnviar);
            this.panelJogo.Location = new System.Drawing.Point(37, 63);
            this.panelJogo.Name = "panelJogo";
            this.panelJogo.Size = new System.Drawing.Size(420, 204);
            this.panelJogo.TabIndex = 7;
            this.panelJogo.Visible = false;
            // 
            // cmdComecar
            // 
            this.cmdComecar.Location = new System.Drawing.Point(381, 19);
            this.cmdComecar.Name = "cmdComecar";
            this.cmdComecar.Size = new System.Drawing.Size(75, 23);
            this.cmdComecar.TabIndex = 8;
            this.cmdComecar.Text = "Começar";
            this.cmdComecar.UseVisualStyleBackColor = true;
            this.cmdComecar.Click += new System.EventHandler(this.cmdComecar_Click);
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 308);
            this.Controls.Add(this.cmdComecar);
            this.Controls.Add(this.panelJogo);
            this.Controls.Add(this.cmdFinalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmJogo";
            this.Text = "Jogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelJogo.ResumeLayout(false);
            this.panelJogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOpcao3;
        private System.Windows.Forms.RadioButton rbOpcao2;
        private System.Windows.Forms.RadioButton rbOpcao1;
        private System.Windows.Forms.Button cmdEnviar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFinalizar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelJogo;
        private System.Windows.Forms.Button cmdComecar;
    }
}
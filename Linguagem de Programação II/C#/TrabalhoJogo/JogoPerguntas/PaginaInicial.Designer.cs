
namespace JogoPerguntas
{
    partial class TelaInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuRank = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFechr = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdQuizz = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRank,
            this.mnuRegra,
            this.mnuFechr});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuRank
            // 
            this.mnuRank.Name = "mnuRank";
            this.mnuRank.Size = new System.Drawing.Size(62, 20);
            this.mnuRank.Text = "Ranking";
            this.mnuRank.Click += new System.EventHandler(this.mnuRank_Click);
            // 
            // mnuRegra
            // 
            this.mnuRegra.Name = "mnuRegra";
            this.mnuRegra.Size = new System.Drawing.Size(54, 20);
            this.mnuRegra.Text = "Regras";
            // 
            // mnuFechr
            // 
            this.mnuFechr.Name = "mnuFechr";
            this.mnuFechr.Size = new System.Drawing.Size(48, 20);
            this.mnuFechr.Text = "Close";
            this.mnuFechr.Click += new System.EventHandler(this.mnuFechr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogoPerguntas.Properties.Resources.Jogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(859, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmdQuizz
            // 
            this.cmdQuizz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdQuizz.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdQuizz.Location = new System.Drawing.Point(346, 415);
            this.cmdQuizz.Name = "cmdQuizz";
            this.cmdQuizz.Size = new System.Drawing.Size(154, 28);
            this.cmdQuizz.TabIndex = 2;
            this.cmdQuizz.Text = "Jogar";
            this.cmdQuizz.UseVisualStyleBackColor = false;
            this.cmdQuizz.Click += new System.EventHandler(this.cmdQuizz_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(369, 388);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Digite seu nome";
            this.txtName.Size = new System.Drawing.Size(117, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 490);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmdQuizz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInicial";
            this.Text = "Bora Jogar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuRank;
        private System.Windows.Forms.ToolStripMenuItem mnuRegra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdQuizz;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem mnuFechr;
    }
}


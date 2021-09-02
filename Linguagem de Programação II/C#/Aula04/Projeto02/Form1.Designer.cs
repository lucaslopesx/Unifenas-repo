
namespace Projeto02
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdImage1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmdImage2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdImage1
			// 
			this.cmdImage1.Location = new System.Drawing.Point(12, 212);
			this.cmdImage1.Name = "cmdImage1";
			this.cmdImage1.Size = new System.Drawing.Size(75, 23);
			this.cmdImage1.TabIndex = 1;
			this.cmdImage1.Text = " Imagem 1";
			this.cmdImage1.UseVisualStyleBackColor = true;
			this.cmdImage1.Click += new System.EventHandler(this.cmdImage1_Click_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(347, 194);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// cmdImage2
			// 
			this.cmdImage2.Location = new System.Drawing.Point(284, 212);
			this.cmdImage2.Name = "cmdImage2";
			this.cmdImage2.Size = new System.Drawing.Size(75, 23);
			this.cmdImage2.TabIndex = 2;
			this.cmdImage2.Text = "Imagem 2";
			this.cmdImage2.UseVisualStyleBackColor = true;
			this.cmdImage2.Click += new System.EventHandler(this.cmdImage2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmdImage2);
			this.Controls.Add(this.cmdImage1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button cmdImage1;
		private System.Windows.Forms.Button cmdImage2;
	}
}


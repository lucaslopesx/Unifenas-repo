
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
            this.cmdVetor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVetor = new System.Windows.Forms.DataGridView();
            this.nudColunas = new System.Windows.Forms.NumericUpDown();
            this.cmdOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVetor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdVetor
            // 
            this.cmdVetor.Location = new System.Drawing.Point(140, 12);
            this.cmdVetor.Name = "cmdVetor";
            this.cmdVetor.Size = new System.Drawing.Size(75, 23);
            this.cmdVetor.TabIndex = 13;
            this.cmdVetor.Text = "Criar Vetor";
            this.cmdVetor.UseVisualStyleBackColor = true;
            this.cmdVetor.Click += new System.EventHandler(this.cmdVetor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Colunas:";
            // 
            // dgvVetor
            // 
            this.dgvVetor.AllowUserToAddRows = false;
            this.dgvVetor.AllowUserToDeleteRows = false;
            this.dgvVetor.AllowUserToResizeColumns = false;
            this.dgvVetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVetor.ColumnHeadersVisible = false;
            this.dgvVetor.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvVetor.Location = new System.Drawing.Point(9, 56);
            this.dgvVetor.Name = "dgvVetor";
            this.dgvVetor.RowHeadersVisible = false;
            this.dgvVetor.Size = new System.Drawing.Size(453, 30);
            this.dgvVetor.TabIndex = 10;
            // 
            // nudColunas
            // 
            this.nudColunas.Location = new System.Drawing.Point(54, 15);
            this.nudColunas.Name = "nudColunas";
            this.nudColunas.Size = new System.Drawing.Size(52, 20);
            this.nudColunas.TabIndex = 9;
            // 
            // cmdOrdenar
            // 
            this.cmdOrdenar.Location = new System.Drawing.Point(266, 12);
            this.cmdOrdenar.Name = "cmdOrdenar";
            this.cmdOrdenar.Size = new System.Drawing.Size(75, 23);
            this.cmdOrdenar.TabIndex = 14;
            this.cmdOrdenar.Text = "Ordenar";
            this.cmdOrdenar.UseVisualStyleBackColor = true;
            this.cmdOrdenar.Click += new System.EventHandler(this.cmdOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 263);
            this.Controls.Add(this.cmdOrdenar);
            this.Controls.Add(this.cmdVetor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVetor);
            this.Controls.Add(this.nudColunas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVetor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button cmdVetor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvVetor;
		private System.Windows.Forms.NumericUpDown nudColunas;
		private System.Windows.Forms.Button cmdOrdenar;
	}
}



namespace Projeto01_MatrizForms
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
            this.nudLinhas = new System.Windows.Forms.NumericUpDown();
            this.nudColunas = new System.Windows.Forms.NumericUpDown();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdMatriz = new System.Windows.Forms.Button();
            this.cmdSomar = new System.Windows.Forms.Button();
            this.lblSoma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // nudLinhas
            // 
            this.nudLinhas.Location = new System.Drawing.Point(106, 61);
            this.nudLinhas.Name = "nudLinhas";
            this.nudLinhas.Size = new System.Drawing.Size(52, 20);
            this.nudLinhas.TabIndex = 0;
            this.nudLinhas.ValueChanged += new System.EventHandler(this.nudLinhas_ValueChanged);
            // 
            // nudColunas
            // 
            this.nudColunas.Location = new System.Drawing.Point(106, 110);
            this.nudColunas.Name = "nudColunas";
            this.nudColunas.Size = new System.Drawing.Size(52, 20);
            this.nudColunas.TabIndex = 1;
            this.nudColunas.ValueChanged += new System.EventHandler(this.nudColunas_ValueChanged);
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AllowUserToAddRows = false;
            this.dgvMatriz.AllowUserToDeleteRows = false;
            this.dgvMatriz.AllowUserToResizeColumns = false;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.ColumnHeadersVisible = false;
            this.dgvMatriz.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvMatriz.Location = new System.Drawing.Point(270, 61);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.RowHeadersVisible = false;
            this.dgvMatriz.Size = new System.Drawing.Size(332, 193);
            this.dgvMatriz.TabIndex = 2;
            this.dgvMatriz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriz_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Linhas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Colunas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdMatriz
            // 
            this.cmdMatriz.Location = new System.Drawing.Point(83, 158);
            this.cmdMatriz.Name = "cmdMatriz";
            this.cmdMatriz.Size = new System.Drawing.Size(75, 23);
            this.cmdMatriz.TabIndex = 5;
            this.cmdMatriz.Text = "Matriz";
            this.cmdMatriz.UseVisualStyleBackColor = true;
            this.cmdMatriz.Click += new System.EventHandler(this.cmdMatriz_Click);
            // 
            // cmdSomar
            // 
            this.cmdSomar.Location = new System.Drawing.Point(82, 225);
            this.cmdSomar.Name = "cmdSomar";
            this.cmdSomar.Size = new System.Drawing.Size(75, 23);
            this.cmdSomar.TabIndex = 6;
            this.cmdSomar.Text = "Soma:";
            this.cmdSomar.UseVisualStyleBackColor = true;
            this.cmdSomar.Click += new System.EventHandler(this.cmdSomar_Click);
            // 
            // lblSoma
            // 
            this.lblSoma.AutoSize = true;
            this.lblSoma.Location = new System.Drawing.Point(163, 230);
            this.lblSoma.Name = "lblSoma";
            this.lblSoma.Size = new System.Drawing.Size(0, 13);
            this.lblSoma.TabIndex = 7;
            this.lblSoma.Click += new System.EventHandler(this.lblSoma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSoma);
            this.Controls.Add(this.cmdSomar);
            this.Controls.Add(this.cmdMatriz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatriz);
            this.Controls.Add(this.nudColunas);
            this.Controls.Add(this.nudLinhas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown nudLinhas;
		private System.Windows.Forms.NumericUpDown nudColunas;
		private System.Windows.Forms.DataGridView dgvMatriz;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdMatriz;
		private System.Windows.Forms.Button cmdSomar;
		private System.Windows.Forms.Label lblSoma;
	}
}


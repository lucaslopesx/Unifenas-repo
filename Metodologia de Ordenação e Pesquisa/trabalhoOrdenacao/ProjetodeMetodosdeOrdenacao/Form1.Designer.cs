
namespace ProjetodeMetodosdeOrdenacao
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTroca = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.cmdOrdenar = new System.Windows.Forms.Button();
            this.nudColunas = new System.Windows.Forms.NumericUpDown();
            this.dgvVetor = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvOrdenado = new System.Windows.Forms.DataGridView();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.cmdRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVetor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trocas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comparações:";
            // 
            // lblTroca
            // 
            this.lblTroca.AutoSize = true;
            this.lblTroca.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTroca.Location = new System.Drawing.Point(155, 96);
            this.lblTroca.Name = "lblTroca";
            this.lblTroca.Size = new System.Drawing.Size(0, 25);
            this.lblTroca.TabIndex = 2;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComp.Location = new System.Drawing.Point(155, 121);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(0, 25);
            this.lblComp.TabIndex = 3;
            // 
            // cmdOrdenar
            // 
            this.cmdOrdenar.Enabled = false;
            this.cmdOrdenar.Location = new System.Drawing.Point(499, 13);
            this.cmdOrdenar.Name = "cmdOrdenar";
            this.cmdOrdenar.Size = new System.Drawing.Size(75, 23);
            this.cmdOrdenar.TabIndex = 5;
            this.cmdOrdenar.Text = "Ordenar";
            this.cmdOrdenar.UseVisualStyleBackColor = true;
            this.cmdOrdenar.Click += new System.EventHandler(this.cmdOrdenar_Click);
            // 
            // nudColunas
            // 
            this.nudColunas.Location = new System.Drawing.Point(13, 13);
            this.nudColunas.Name = "nudColunas";
            this.nudColunas.Size = new System.Drawing.Size(55, 23);
            this.nudColunas.TabIndex = 6;
            this.nudColunas.ValueChanged += new System.EventHandler(this.nudColunas_ValueChanged);
            // 
            // dgvVetor
            // 
            this.dgvVetor.AllowUserToAddRows = false;
            this.dgvVetor.AllowUserToDeleteRows = false;
            this.dgvVetor.AllowUserToResizeColumns = false;
            this.dgvVetor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVetor.ColumnHeadersVisible = false;
            this.dgvVetor.Location = new System.Drawing.Point(18, 54);
            this.dgvVetor.Name = "dgvVetor";
            this.dgvVetor.RowHeadersVisible = false;
            this.dgvVetor.RowTemplate.Height = 25;
            this.dgvVetor.Size = new System.Drawing.Size(561, 30);
            this.dgvVetor.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select Sort",
            "Insertion Sort",
            "Bubble Sort",
            "Quick Sort"});
            this.comboBox1.Location = new System.Drawing.Point(372, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvOrdenado
            // 
            this.dgvOrdenado.AllowUserToAddRows = false;
            this.dgvOrdenado.AllowUserToDeleteRows = false;
            this.dgvOrdenado.AllowUserToResizeColumns = false;
            this.dgvOrdenado.AllowUserToResizeRows = false;
            this.dgvOrdenado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenado.ColumnHeadersVisible = false;
            this.dgvOrdenado.Location = new System.Drawing.Point(18, 165);
            this.dgvOrdenado.Name = "dgvOrdenado";
            this.dgvOrdenado.ReadOnly = true;
            this.dgvOrdenado.RowHeadersVisible = false;
            this.dgvOrdenado.RowTemplate.Height = 25;
            this.dgvOrdenado.Size = new System.Drawing.Size(561, 30);
            this.dgvOrdenado.TabIndex = 9;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Location = new System.Drawing.Point(499, 201);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpar.TabIndex = 10;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // cmdRandom
            // 
            this.cmdRandom.Location = new System.Drawing.Point(80, 5);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new System.Drawing.Size(104, 43);
            this.cmdRandom.TabIndex = 11;
            this.cmdRandom.Text = "Gerar números aleatórios";
            this.cmdRandom.UseVisualStyleBackColor = true;
            this.cmdRandom.Click += new System.EventHandler(this.cmdRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 239);
            this.Controls.Add(this.cmdRandom);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.dgvOrdenado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvVetor);
            this.Controls.Add(this.nudColunas);
            this.Controls.Add(this.cmdOrdenar);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.lblTroca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVetor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTroca;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Button cmdOrdenar;
        private System.Windows.Forms.NumericUpDown nudColunas;
        private System.Windows.Forms.DataGridView dgvVetor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvOrdenado;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Button cmdRandom;
    }
}


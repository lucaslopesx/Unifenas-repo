
namespace Parcial2021
{
    partial class FrmPesquisarPorSituacao
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
            this.rbAprovado = new System.Windows.Forms.RadioButton();
            this.rbReprovado = new System.Windows.Forms.RadioButton();
            this.rbFinal = new System.Windows.Forms.RadioButton();
            this.cmdpesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbAprovado
            // 
            this.rbAprovado.AutoSize = true;
            this.rbAprovado.Location = new System.Drawing.Point(51, 49);
            this.rbAprovado.Name = "rbAprovado";
            this.rbAprovado.Size = new System.Drawing.Size(71, 17);
            this.rbAprovado.TabIndex = 0;
            this.rbAprovado.TabStop = true;
            this.rbAprovado.Text = "Aprovado";
            this.rbAprovado.UseVisualStyleBackColor = true;
            // 
            // rbReprovado
            // 
            this.rbReprovado.AutoSize = true;
            this.rbReprovado.Location = new System.Drawing.Point(190, 49);
            this.rbReprovado.Name = "rbReprovado";
            this.rbReprovado.Size = new System.Drawing.Size(78, 17);
            this.rbReprovado.TabIndex = 1;
            this.rbReprovado.TabStop = true;
            this.rbReprovado.Text = "Reprovado";
            this.rbReprovado.UseVisualStyleBackColor = true;
            // 
            // rbFinal
            // 
            this.rbFinal.AutoSize = true;
            this.rbFinal.Location = new System.Drawing.Point(355, 49);
            this.rbFinal.Name = "rbFinal";
            this.rbFinal.Size = new System.Drawing.Size(47, 17);
            this.rbFinal.TabIndex = 2;
            this.rbFinal.TabStop = true;
            this.rbFinal.Text = "Final";
            this.rbFinal.UseVisualStyleBackColor = true;
            // 
            // cmdpesquisar
            // 
            this.cmdpesquisar.Location = new System.Drawing.Point(521, 49);
            this.cmdpesquisar.Name = "cmdpesquisar";
            this.cmdpesquisar.Size = new System.Drawing.Size(75, 23);
            this.cmdpesquisar.TabIndex = 3;
            this.cmdpesquisar.Text = "Pesquisar";
            this.cmdpesquisar.UseVisualStyleBackColor = true;
            this.cmdpesquisar.Click += new System.EventHandler(this.cmdpesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(557, 272);
            this.dataGridView1.TabIndex = 4;
            // 
            // FrmPesquisarPorSituacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 435);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdpesquisar);
            this.Controls.Add(this.rbFinal);
            this.Controls.Add(this.rbReprovado);
            this.Controls.Add(this.rbAprovado);
            this.Name = "FrmPesquisarPorSituacao";
            this.Text = "FrmPesquisarPorSituacao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAprovado;
        private System.Windows.Forms.RadioButton rbReprovado;
        private System.Windows.Forms.RadioButton rbFinal;
        private System.Windows.Forms.Button cmdpesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
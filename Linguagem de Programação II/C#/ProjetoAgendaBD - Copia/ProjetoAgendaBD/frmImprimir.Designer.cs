
namespace ProjetoAgendaBD
{
    partial class frmImprimir
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
            this.cmdVisualizar = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // cmdVisualizar
            // 
            this.cmdVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVisualizar.Location = new System.Drawing.Point(261, 163);
            this.cmdVisualizar.Name = "cmdVisualizar";
            this.cmdVisualizar.Size = new System.Drawing.Size(285, 119);
            this.cmdVisualizar.TabIndex = 0;
            this.cmdVisualizar.Text = "Visualizar Impressão";
            this.cmdVisualizar.UseVisualStyleBackColor = true;
            this.cmdVisualizar.Click += new System.EventHandler(this.cmdVisualizar_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdVisualizar);
            this.Name = "frmImprimir";
            this.Text = "frmImprimir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdVisualizar;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

namespace DesafioAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblMostra = new System.Windows.Forms.Label();
            this.cmdPao_Click = new System.Windows.Forms.Button();
            this.cmdCarne = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listIngredientes = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite sua senha:";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(105, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 23);
            this.textBox1.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSenha.Location = new System.Drawing.Point(105, 87);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 23);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSenha_Validating);
            // 
            // lblMostra
            // 
            this.lblMostra.AutoSize = true;
            this.lblMostra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostra.ForeColor = System.Drawing.Color.Red;
            this.lblMostra.Location = new System.Drawing.Point(65, 243);
            this.lblMostra.Name = "lblMostra";
            this.lblMostra.Size = new System.Drawing.Size(49, 15);
            this.lblMostra.TabIndex = 4;
            this.lblMostra.Text = "Calorias";
            // 
            // cmdPao_Click
            // 
            this.cmdPao_Click.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdPao_Click.BackgroundImage")));
            this.cmdPao_Click.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPao_Click.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdPao_Click.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdPao_Click.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cmdPao_Click.Location = new System.Drawing.Point(12, 125);
            this.cmdPao_Click.Name = "cmdPao_Click";
            this.cmdPao_Click.Size = new System.Drawing.Size(131, 79);
            this.cmdPao_Click.TabIndex = 5;
            this.cmdPao_Click.Text = "Pão";
            this.cmdPao_Click.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdPao_Click.UseVisualStyleBackColor = true;
            this.cmdPao_Click.Click += new System.EventHandler(this.cmdPao_Click_Click);
            // 
            // cmdCarne
            // 
            this.cmdCarne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCarne.BackgroundImage")));
            this.cmdCarne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCarne.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmdCarne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdCarne.Location = new System.Drawing.Point(178, 125);
            this.cmdCarne.Name = "cmdCarne";
            this.cmdCarne.Size = new System.Drawing.Size(131, 79);
            this.cmdCarne.TabIndex = 6;
            this.cmdCarne.Text = "Carne";
            this.cmdCarne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdCarne.UseVisualStyleBackColor = true;
            this.cmdCarne.Click += new System.EventHandler(this.cmdCarne_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(178, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tabela de Calorias";
            // 
            // listIngredientes
            // 
            this.listIngredientes.FormattingEnabled = true;
            this.listIngredientes.ItemHeight = 15;
            this.listIngredientes.Location = new System.Drawing.Point(374, 49);
            this.listIngredientes.Name = "listIngredientes";
            this.listIngredientes.Size = new System.Drawing.Size(120, 64);
            this.listIngredientes.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(471, 157);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular total de Calorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(543, 330);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listIngredientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdCarne);
            this.Controls.Add(this.cmdPao_Click);
            this.Controls.Add(this.lblMostra);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblMostra;
        private System.Windows.Forms.Button cmdPao_Click;
        private System.Windows.Forms.Button cmdCarne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listIngredientes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button1;
    }
}


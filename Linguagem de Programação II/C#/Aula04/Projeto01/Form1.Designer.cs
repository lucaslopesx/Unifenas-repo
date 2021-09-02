
namespace Projeto01
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.lblDTP = new System.Windows.Forms.Label();
			this.lblMC = new System.Windows.Forms.Label();
			this.cmdOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(58, 43);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(58, 75);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 1;
			// 
			// lblDTP
			// 
			this.lblDTP.AutoSize = true;
			this.lblDTP.Location = new System.Drawing.Point(297, 49);
			this.lblDTP.Name = "lblDTP";
			this.lblDTP.Size = new System.Drawing.Size(35, 13);
			this.lblDTP.TabIndex = 2;
			this.lblDTP.Text = "label1";
			// 
			// lblMC
			// 
			this.lblMC.AutoSize = true;
			this.lblMC.Location = new System.Drawing.Point(297, 146);
			this.lblMC.Name = "lblMC";
			this.lblMC.Size = new System.Drawing.Size(35, 13);
			this.lblMC.TabIndex = 3;
			this.lblMC.Text = "label2";
			// 
			// cmdOk
			// 
			this.cmdOk.Location = new System.Drawing.Point(131, 249);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.Size = new System.Drawing.Size(75, 23);
			this.cmdOk.TabIndex = 4;
			this.cmdOk.Text = "OK";
			this.cmdOk.UseVisualStyleBackColor = true;
			this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.lblMC);
			this.Controls.Add(this.lblDTP);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.dateTimePicker1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label lblDTP;
		private System.Windows.Forms.Label lblMC;
		private System.Windows.Forms.Button cmdOk;
	}
}


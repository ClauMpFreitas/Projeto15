/*
 * Criado por SharpDevelop.
 * Usuário: Diogo Freitas
 * Data: 29/03/2023
 * Hora: 09:45
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Projeto15
{
	partial class FrmPratica15
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.MonthCalendar MonCalendario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtDataInicial;
		private System.Windows.Forms.TextBox TxtDataFinal;
		private System.Windows.Forms.TextBox TxtDataHoje;
		private System.Windows.Forms.TextBox TxtNumDias;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.MonCalendario = new System.Windows.Forms.MonthCalendar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtDataInicial = new System.Windows.Forms.TextBox();
			this.TxtDataFinal = new System.Windows.Forms.TextBox();
			this.TxtDataHoje = new System.Windows.Forms.TextBox();
			this.TxtNumDias = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(59, 85);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox1.TabIndex = 0;
			// 
			// MonCalendario
			// 
			this.MonCalendario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MonCalendario.Location = new System.Drawing.Point(0, 0);
			this.MonCalendario.Name = "MonCalendario";
			this.MonCalendario.TabIndex = 1;
			this.MonCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonCalendarioDateChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(253, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Data inicial";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(253, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Data final";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(378, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Data de hoje";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(378, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(235, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "Dias desde o início do período";
			// 
			// TxtDataInicial
			// 
			this.TxtDataInicial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtDataInicial.Location = new System.Drawing.Point(253, 39);
			this.TxtDataInicial.Name = "TxtDataInicial";
			this.TxtDataInicial.Size = new System.Drawing.Size(100, 26);
			this.TxtDataInicial.TabIndex = 6;
			// 
			// TxtDataFinal
			// 
			this.TxtDataFinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtDataFinal.Location = new System.Drawing.Point(253, 98);
			this.TxtDataFinal.Name = "TxtDataFinal";
			this.TxtDataFinal.Size = new System.Drawing.Size(100, 26);
			this.TxtDataFinal.TabIndex = 7;
			// 
			// TxtDataHoje
			// 
			this.TxtDataHoje.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtDataHoje.Location = new System.Drawing.Point(378, 39);
			this.TxtDataHoje.Name = "TxtDataHoje";
			this.TxtDataHoje.Size = new System.Drawing.Size(100, 26);
			this.TxtDataHoje.TabIndex = 8;
			// 
			// TxtNumDias
			// 
			this.TxtNumDias.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNumDias.Location = new System.Drawing.Point(378, 98);
			this.TxtNumDias.Name = "TxtNumDias";
			this.TxtNumDias.Size = new System.Drawing.Size(235, 26);
			this.TxtNumDias.TabIndex = 9;
			// 
			// FrmPratica15
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 159);
			this.Controls.Add(this.TxtNumDias);
			this.Controls.Add(this.TxtDataHoje);
			this.Controls.Add(this.TxtDataFinal);
			this.Controls.Add(this.TxtDataInicial);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MonCalendario);
			this.Controls.Add(this.maskedTextBox1);
			this.Name = "FrmPratica15";
			this.Text = "Pratica 15 – Usando MonthCalendar";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}

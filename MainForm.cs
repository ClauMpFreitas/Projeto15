using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto15
{
	public partial class FrmPratica15 : Form
	{
		public FrmPratica15()
		{
			InitializeComponent();
		}
		void MonCalendarioDateChanged(object sender, DateRangeEventArgs e)
		{
			TxtDataInicial.Text=MonCalendario.SelectionStart.ToShortDateString();
			TxtDataFinal.Text=MonCalendario.SelectionEnd.ToShortDateString();
			TxtDataHoje.Text=MonCalendario.TodayDate.ToShortDateString();
			
			TimeSpan date = Convert.ToDateTime(TxtDataFinal.Text) - Convert.ToDateTime(TxtDataInicial.Text);
			int dias = date.Days;
			TxtNumDias.Text = Convert.ToString(dias);
		}
		
		
	}
}

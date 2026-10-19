using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();

			this.Location = new Point
			(
				Screen.PrimaryScreen.Bounds.Right - this.Width - 50,
				Screen.PrimaryScreen.Bounds.Bottom / 20
			);
        }

		//					Methods:
		void SetVisibility(bool vidible)
		{
			cbShowDate.Visible		= vidible;
			cbShowWeekday.Visible	= vidible;
			bthHideControls.Visible = vidible;
			this.ShowInTaskbar		= vidible;
			this.FormBorderStyle	= vidible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None;
			this.TransparencyKey	= vidible ? Color.Empty : this.BackColor;
		}


        //      Event handlers (Обработчики событий)
		private void timer_Tick(object sender, EventArgs e)
		{
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (cbShowDate.Checked)    labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
            if (cbShowWeekday.Checked) labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
		}

		private void bthHideControls_Click(object sender, EventArgs e) => SetVisibility(false);

		//команда для закрытие часов: taskkill /f /im clock.exe

		private void labelTime_DoubleClick(object sender, EventArgs e) => SetVisibility(true);

		private void tsmiTopmost_Click(object sender, EventArgs e)
		{

		}

		private void backgroundColoeToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void contextMenu_Opening(object sender, CancelEventArgs e)
		{

		}
	}
}

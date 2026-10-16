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
        }

		private void timer_Tick(object sender, EventArgs e)
		{
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (cbShowDate.Checked)    labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
            if (cbShowWeekday.Checked) labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
		}

		private void bthHideControls_Click(object sender, EventArgs e)
		{
            cbShowDate.Visible = false;
            cbShowWeekday.Visible = false;
            bthHideControls.Visible = false;
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = this.BackColor;
		}

		//команда для закрытие часов: taskkill /f /im clock.exe

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}

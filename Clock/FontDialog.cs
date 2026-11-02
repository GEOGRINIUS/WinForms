using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Clock
{
    public partial class FontDialog: Form
    {
        public Font Font { get; set; }
        public string Filename { get; set; }
        public string CounterFontsize { get; set; }
        MainForm parentWindow;
        public FontDialog()
        {
            InitializeComponent();
            //if(parentWindow.tsmiShowConsole.Checked)Console.WriteLine(Directory.GetCurrentDirectory());
            //if(parentWindow.tsmiShowConsole.Checked)Console.WriteLine($"{Application.ExecutablePath}");
            //Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..\\Fonts");
            //if(parentWindow.tsmiShowConsole.Checked)Console.WriteLine(Directory.GetCurrentDirectory());
           
            //LoadFonts("*.ttf");
            //LoadFonts("*.otf");
            //comboBoxFont.SelectedIndex = 0;
        }
        public FontDialog(MainForm parentWindow) : this()
        {
            this.parentWindow = parentWindow;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point
            (
                parentWindow.Location.X - this.Width / 3,
                parentWindow.Location.Y + 128
            );

            if (parentWindow.tsmiShowConsole.Checked)
            try
            {
                    Console.WriteLine(Directory.GetCurrentDirectory());
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            if (parentWindow.tsmiShowConsole.Checked) Console.WriteLine($"{Application.ExecutablePath}");
            Directory.SetCurrentDirectory($"{Application.ExecutablePath}\\..\\..\\..\\Fonts");
            if (parentWindow.tsmiShowConsole.Checked) Console.WriteLine(Directory.GetCurrentDirectory());

            LoadFonts("*.ttf");
            LoadFonts("*.otf");
            comboBoxFont.SelectedIndex = 0;
        }
		private void FontDialog_Load(object sender, EventArgs e)
		{
			this.Location = new Point
			(
				parentWindow.Location.X - this.Width / 3,
				parentWindow.Location.Y + 128
			);
            labelExample.Font = Font;
            comboBoxFont.SelectedItem = Filename;
            counterFontSize.Value = (int)Font.Size;
            if(parentWindow.tsmiShowConsole.Checked)Console.WriteLine(Directory.GetCurrentDirectory());
		}

            void LoadFonts(String pattern)
            {
            string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), pattern);
            for(int i=0; i<files.Length; i++)
            {
                files[i] = files[i].Split('\\').Last();
            }
            comboBoxFont.Items.AddRange(files);
            }

		private void comboBoxFont_SelectionChangeCommitted(object sender, EventArgs e) => ApplyFont();

		private void counterFontSize_ValueChanged(object sender, EventArgs e) => ApplyFont();
        void ApplyFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(comboBoxFont.SelectedItem.ToString());
            labelExample.Font = new Font(pfc.Families[0], (int)counterFontSize.Value);

        }

		private void buttonOK_Click(object sender, EventArgs e)
		{
            this.Font = labelExample.Font;
            this.Filename = comboBoxFont.SelectedItem.ToString();
		}

	}
}

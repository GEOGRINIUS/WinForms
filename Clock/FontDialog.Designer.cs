namespace Clock
{
	partial class FontDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontDialog));
			this.comboBoxFont = new System.Windows.Forms.ComboBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelExample = new System.Windows.Forms.Label();
			this.counterFontSize = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.counterFontSize)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxFont
			// 
			this.comboBoxFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFont.FormattingEnabled = true;
			this.comboBoxFont.Location = new System.Drawing.Point(13, 13);
			this.comboBoxFont.Name = "comboBoxFont";
			this.comboBoxFont.Size = new System.Drawing.Size(561, 24);
			this.comboBoxFont.TabIndex = 0;
			this.comboBoxFont.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFont_SelectionChangeCommitted);
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(440, 232);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(113, 39);
			this.buttonOK.TabIndex = 1;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(559, 232);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(113, 39);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelExample.Location = new System.Drawing.Point(12, 58);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(363, 61);
			this.labelExample.TabIndex = 3;
			this.labelExample.Text = "Example 1234";
			// 
			// counterFontSize
			// 
			this.counterFontSize.Location = new System.Drawing.Point(581, 15);
			this.counterFontSize.Name = "counterFontSize";
			this.counterFontSize.Size = new System.Drawing.Size(91, 22);
			this.counterFontSize.TabIndex = 4;
			this.counterFontSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
			this.counterFontSize.ValueChanged += new System.EventHandler(this.counterFontSize_ValueChanged);
			// 
			// FontDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 283);
			this.Controls.Add(this.counterFontSize);
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.comboBoxFont);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FontDialog";
			this.Text = "FontDialog";
			((System.ComponentModel.ISupportInitialize)(this.counterFontSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxFont;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelExample;
		private System.Windows.Forms.NumericUpDown counterFontSize;
	}
}
namespace laba4_uchebka
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxForCity = new System.Windows.Forms.ComboBox();
			this.comboBoxForHosp = new System.Windows.Forms.ComboBox();
			this.comboBoxForPeople = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// comboBoxForCity
			// 
			this.comboBoxForCity.FormattingEnabled = true;
			this.comboBoxForCity.Location = new System.Drawing.Point(39, 34);
			this.comboBoxForCity.Name = "comboBoxForCity";
			this.comboBoxForCity.Size = new System.Drawing.Size(187, 21);
			this.comboBoxForCity.TabIndex = 0;
			this.comboBoxForCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxForCity_SelectedIndexChanged);
			// 
			// comboBoxForHosp
			// 
			this.comboBoxForHosp.FormattingEnabled = true;
			this.comboBoxForHosp.Location = new System.Drawing.Point(39, 86);
			this.comboBoxForHosp.Name = "comboBoxForHosp";
			this.comboBoxForHosp.Size = new System.Drawing.Size(187, 21);
			this.comboBoxForHosp.TabIndex = 1;
			// 
			// comboBoxForPeople
			// 
			this.comboBoxForPeople.FormattingEnabled = true;
			this.comboBoxForPeople.Location = new System.Drawing.Point(39, 138);
			this.comboBoxForPeople.Name = "comboBoxForPeople";
			this.comboBoxForPeople.Size = new System.Drawing.Size(187, 21);
			this.comboBoxForPeople.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxForPeople);
			this.Controls.Add(this.comboBoxForHosp);
			this.Controls.Add(this.comboBoxForCity);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxForCity;
		private System.Windows.Forms.ComboBox comboBoxForHosp;
		private System.Windows.Forms.ComboBox comboBoxForPeople;
		private System.Windows.Forms.Label label1;
	}
}


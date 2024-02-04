namespace Academy
{
	partial class AddGroup
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
			this.cbDirections = new System.Windows.Forms.ComboBox();
			this.cbLearningForm = new System.Windows.Forms.ComboBox();
			this.cbTime = new System.Windows.Forms.ComboBox();
			this.tbGroupName = new System.Windows.Forms.TextBox();
			this.lcbWeek = new System.Windows.Forms.CheckedListBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbDirections
			// 
			this.cbDirections.FormattingEnabled = true;
			this.cbDirections.Location = new System.Drawing.Point(12, 56);
			this.cbDirections.Name = "cbDirections";
			this.cbDirections.Size = new System.Drawing.Size(539, 21);
			this.cbDirections.TabIndex = 0;
			this.cbDirections.Text = "Направление обучения";
			// 
			// cbLearningForm
			// 
			this.cbLearningForm.FormattingEnabled = true;
			this.cbLearningForm.Location = new System.Drawing.Point(12, 29);
			this.cbLearningForm.Name = "cbLearningForm";
			this.cbLearningForm.Size = new System.Drawing.Size(539, 21);
			this.cbLearningForm.TabIndex = 1;
			this.cbLearningForm.Text = "Форма обучения";
			// 
			// cbTime
			// 
			this.cbTime.FormattingEnabled = true;
			this.cbTime.Location = new System.Drawing.Point(13, 83);
			this.cbTime.Name = "cbTime";
			this.cbTime.Size = new System.Drawing.Size(539, 21);
			this.cbTime.TabIndex = 2;
			this.cbTime.Text = "Время обучения";
			// 
			// tbGroupName
			// 
			this.tbGroupName.Location = new System.Drawing.Point(13, 211);
			this.tbGroupName.Name = "tbGroupName";
			this.tbGroupName.Size = new System.Drawing.Size(539, 20);
			this.tbGroupName.TabIndex = 3;
			this.tbGroupName.Text = "Название группы";
			// 
			// lcbWeek
			// 
			this.lcbWeek.CheckOnClick = true;
			this.lcbWeek.ColumnWidth = 60;
			this.lcbWeek.FormattingEnabled = true;
			this.lcbWeek.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.lcbWeek.Location = new System.Drawing.Point(13, 153);
			this.lcbWeek.MultiColumn = true;
			this.lcbWeek.Name = "lcbWeek";
			this.lcbWeek.Size = new System.Drawing.Size(429, 19);
			this.lcbWeek.TabIndex = 5;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(477, 253);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 6;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// AddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(564, 288);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.lcbWeek);
			this.Controls.Add(this.tbGroupName);
			this.Controls.Add(this.cbTime);
			this.Controls.Add(this.cbLearningForm);
			this.Controls.Add(this.cbDirections);
			this.Name = "AddGroup";
			this.Text = "AddGroup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDirections;
		private System.Windows.Forms.ComboBox cbLearningForm;
		private System.Windows.Forms.ComboBox cbTime;
		private System.Windows.Forms.TextBox tbGroupName;
		private System.Windows.Forms.CheckedListBox lcbWeek;
		private System.Windows.Forms.Button btnGenerate;
	}
}
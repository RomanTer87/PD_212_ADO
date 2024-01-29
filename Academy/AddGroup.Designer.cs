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
			this.tbName = new System.Windows.Forms.TextBox();
			this.groupBoxDaysOfWeek = new System.Windows.Forms.GroupBox();
			this.cbMon = new System.Windows.Forms.CheckBox();
			this.cbTew = new System.Windows.Forms.CheckBox();
			this.groupBoxDaysOfWeek.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbDirections
			// 
			this.cbDirections.FormattingEnabled = true;
			this.cbDirections.Location = new System.Drawing.Point(13, 24);
			this.cbDirections.Name = "cbDirections";
			this.cbDirections.Size = new System.Drawing.Size(539, 21);
			this.cbDirections.TabIndex = 0;
			this.cbDirections.Text = "Направление обучения";
			// 
			// cbLearningForm
			// 
			this.cbLearningForm.FormattingEnabled = true;
			this.cbLearningForm.Location = new System.Drawing.Point(13, 52);
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
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(13, 157);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(539, 20);
			this.tbName.TabIndex = 3;
			this.tbName.Text = "Название группы";
			// 
			// groupBoxDaysOfWeek
			// 
			this.groupBoxDaysOfWeek.Controls.Add(this.cbTew);
			this.groupBoxDaysOfWeek.Controls.Add(this.cbMon);
			this.groupBoxDaysOfWeek.Location = new System.Drawing.Point(13, 111);
			this.groupBoxDaysOfWeek.Name = "groupBoxDaysOfWeek";
			this.groupBoxDaysOfWeek.Size = new System.Drawing.Size(539, 37);
			this.groupBoxDaysOfWeek.TabIndex = 4;
			this.groupBoxDaysOfWeek.TabStop = false;
			this.groupBoxDaysOfWeek.Text = "Дни обучения";
			// 
			// cbMon
			// 
			this.cbMon.AutoSize = true;
			this.cbMon.Location = new System.Drawing.Point(0, 18);
			this.cbMon.Name = "cbMon";
			this.cbMon.Size = new System.Drawing.Size(40, 17);
			this.cbMon.TabIndex = 0;
			this.cbMon.Text = "Пн";
			this.cbMon.UseVisualStyleBackColor = true;
			// 
			// cbTew
			// 
			this.cbTew.AutoSize = true;
			this.cbTew.Location = new System.Drawing.Point(45, 18);
			this.cbTew.Name = "cbTew";
			this.cbTew.Size = new System.Drawing.Size(38, 17);
			this.cbTew.TabIndex = 1;
			this.cbTew.Text = "Вт";
			this.cbTew.UseVisualStyleBackColor = true;
			// 
			// AddGroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 243);
			this.Controls.Add(this.groupBoxDaysOfWeek);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.cbTime);
			this.Controls.Add(this.cbLearningForm);
			this.Controls.Add(this.cbDirections);
			this.Name = "AddGroup";
			this.Text = "AddGroup";
			this.groupBoxDaysOfWeek.ResumeLayout(false);
			this.groupBoxDaysOfWeek.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDirections;
		private System.Windows.Forms.ComboBox cbLearningForm;
		private System.Windows.Forms.ComboBox cbTime;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.GroupBox groupBoxDaysOfWeek;
		private System.Windows.Forms.CheckBox cbTew;
		private System.Windows.Forms.CheckBox cbMon;
	}
}
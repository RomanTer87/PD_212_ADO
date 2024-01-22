namespace Academy
{
	partial class Form1
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.dgwStudents = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblStudCount = new System.Windows.Forms.Label();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.rbGroups = new System.Windows.Forms.RadioButton();
			this.rbStudents = new System.Windows.Forms.RadioButton();
			this.tabControl1.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageStudents);
			this.tabControl1.Controls.Add(this.tabPageTeachers);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1017, 426);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageStudents.Controls.Add(this.rbStudents);
			this.tabPageStudents.Controls.Add(this.rbGroups);
			this.tabPageStudents.Controls.Add(this.cbDirection);
			this.tabPageStudents.Controls.Add(this.lblStudCount);
			this.tabPageStudents.Controls.Add(this.btnAdd);
			this.tabPageStudents.Controls.Add(this.dgwStudents);
			this.tabPageStudents.Controls.Add(this.cbGroup);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(1009, 400);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Студенты";
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(749, 400);
			this.tabPageTeachers.TabIndex = 1;
			this.tabPageTeachers.Text = "Преподаватели";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// cbGroup
			// 
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(7, 8);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(296, 21);
			this.cbGroup.TabIndex = 0;
			this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
			// 
			// dgwStudents
			// 
			this.dgwStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwStudents.Location = new System.Drawing.Point(7, 59);
			this.dgwStudents.Name = "dgwStudents";
			this.dgwStudents.Size = new System.Drawing.Size(996, 335);
			this.dgwStudents.TabIndex = 1;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(928, 8);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblStudCount
			// 
			this.lblStudCount.AutoSize = true;
			this.lblStudCount.Location = new System.Drawing.Point(309, 11);
			this.lblStudCount.Name = "lblStudCount";
			this.lblStudCount.Size = new System.Drawing.Size(122, 13);
			this.lblStudCount.TabIndex = 3;
			this.lblStudCount.Text = "количество студентов:";
			// 
			// cbDirection
			// 
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(7, 35);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(296, 21);
			this.cbDirection.TabIndex = 4;
			this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
			// 
			// rbGroups
			// 
			this.rbGroups.AutoSize = true;
			this.rbGroups.Location = new System.Drawing.Point(310, 36);
			this.rbGroups.Name = "rbGroups";
			this.rbGroups.Size = new System.Drawing.Size(62, 17);
			this.rbGroups.TabIndex = 5;
			this.rbGroups.TabStop = true;
			this.rbGroups.Text = "Группы";
			this.rbGroups.UseVisualStyleBackColor = true;
			this.rbGroups.CheckedChanged += new System.EventHandler(this.rbGroups_CheckedChanged);
			// 
			// rbStudents
			// 
			this.rbStudents.AutoSize = true;
			this.rbStudents.Location = new System.Drawing.Point(395, 36);
			this.rbStudents.Name = "rbStudents";
			this.rbStudents.Size = new System.Drawing.Size(73, 17);
			this.rbStudents.TabIndex = 6;
			this.rbStudents.TabStop = true;
			this.rbStudents.Text = "Студенты";
			this.rbStudents.UseVisualStyleBackColor = true;
			this.rbStudents.CheckedChanged += new System.EventHandler(this.rbStudents_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1041, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dgwStudents;
		private System.Windows.Forms.ComboBox cbGroup;
		private System.Windows.Forms.Label lblStudCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.RadioButton rbStudents;
		private System.Windows.Forms.RadioButton rbGroups;
	}
}


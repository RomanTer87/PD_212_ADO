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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.rbStudents = new System.Windows.Forms.RadioButton();
			this.rbGroups = new System.Windows.Forms.RadioButton();
			this.cbDirection = new System.Windows.Forms.ComboBox();
			this.lblStudCount = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgwStudents = new System.Windows.Forms.DataGridView();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblGroupsCount = new System.Windows.Forms.Label();
			this.cbDirectionOnGroupTab = new System.Windows.Forms.ComboBox();
			this.btnGroupAdd = new System.Windows.Forms.Button();
			this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.tabControl.Location = new System.Drawing.Point(12, 12);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1023, 341);
			this.tabControl.TabIndex = 0;
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
			this.tabPageStudents.Size = new System.Drawing.Size(1015, 315);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Студенты";
			this.tabPageStudents.UseWaitCursor = true;
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
			this.rbStudents.UseWaitCursor = true;
			this.rbStudents.CheckedChanged += new System.EventHandler(this.rbStudents_CheckedChanged);
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
			this.rbGroups.UseWaitCursor = true;
			this.rbGroups.CheckedChanged += new System.EventHandler(this.rbGroups_CheckedChanged);
			// 
			// cbDirection
			// 
			this.cbDirection.FormattingEnabled = true;
			this.cbDirection.Location = new System.Drawing.Point(7, 35);
			this.cbDirection.Name = "cbDirection";
			this.cbDirection.Size = new System.Drawing.Size(296, 21);
			this.cbDirection.TabIndex = 4;
			this.cbDirection.UseWaitCursor = true;
			this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.cbDirection_SelectedIndexChanged);
			// 
			// lblStudCount
			// 
			this.lblStudCount.AutoSize = true;
			this.lblStudCount.Location = new System.Drawing.Point(309, 11);
			this.lblStudCount.Name = "lblStudCount";
			this.lblStudCount.Size = new System.Drawing.Size(122, 13);
			this.lblStudCount.TabIndex = 3;
			this.lblStudCount.Text = "количество студентов:";
			this.lblStudCount.UseWaitCursor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(934, 8);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.UseWaitCursor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgwStudents
			// 
			this.dgwStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwStudents.Location = new System.Drawing.Point(7, 59);
			this.dgwStudents.Name = "dgwStudents";
			this.dgwStudents.Size = new System.Drawing.Size(1002, 250);
			this.dgwStudents.TabIndex = 1;
			this.dgwStudents.UseWaitCursor = true;
			// 
			// cbGroup
			// 
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(7, 8);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(296, 21);
			this.cbGroup.TabIndex = 0;
			this.cbGroup.UseWaitCursor = true;
			this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.BackColor = System.Drawing.SystemColors.Control;
			this.tabPageGroups.Controls.Add(this.btnDelete);
			this.tabPageGroups.Controls.Add(this.lblGroupsCount);
			this.tabPageGroups.Controls.Add(this.cbDirectionOnGroupTab);
			this.tabPageGroups.Controls.Add(this.btnGroupAdd);
			this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(1015, 315);
			this.tabPageGroups.TabIndex = 2;
			this.tabPageGroups.Text = "Группы";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(833, 15);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblGroupsCount
			// 
			this.lblGroupsCount.AutoSize = true;
			this.lblGroupsCount.Location = new System.Drawing.Point(538, 20);
			this.lblGroupsCount.Name = "lblGroupsCount";
			this.lblGroupsCount.Size = new System.Drawing.Size(100, 13);
			this.lblGroupsCount.TabIndex = 3;
			this.lblGroupsCount.Text = "Количество групп:";
			// 
			// cbDirectionOnGroupTab
			// 
			this.cbDirectionOnGroupTab.FormattingEnabled = true;
			this.cbDirectionOnGroupTab.Location = new System.Drawing.Point(7, 17);
			this.cbDirectionOnGroupTab.Name = "cbDirectionOnGroupTab";
			this.cbDirectionOnGroupTab.Size = new System.Drawing.Size(525, 21);
			this.cbDirectionOnGroupTab.TabIndex = 2;
			this.cbDirectionOnGroupTab.SelectedIndexChanged += new System.EventHandler(this.cbDirectionOnGroupTab_SelectedIndexChanged);
			// 
			// btnGroupAdd
			// 
			this.btnGroupAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnGroupAdd.Location = new System.Drawing.Point(928, 15);
			this.btnGroupAdd.Name = "btnGroupAdd";
			this.btnGroupAdd.Size = new System.Drawing.Size(75, 23);
			this.btnGroupAdd.TabIndex = 1;
			this.btnGroupAdd.Text = "Добавить";
			this.btnGroupAdd.UseVisualStyleBackColor = true;
			this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
			// 
			// dataGridViewGroups
			// 
			this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGroups.Location = new System.Drawing.Point(7, 44);
			this.dataGridViewGroups.MultiSelect = false;
			this.dataGridViewGroups.Name = "dataGridViewGroups";
			this.dataGridViewGroups.ReadOnly = true;
			this.dataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewGroups.Size = new System.Drawing.Size(999, 268);
			this.dataGridViewGroups.TabIndex = 0;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(1015, 315);
			this.tabPageTeachers.TabIndex = 1;
			this.tabPageTeachers.Text = "Преподаватели";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			this.tabPageTeachers.UseWaitCursor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1047, 365);
			this.Controls.Add(this.tabControl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dgwStudents;
		private System.Windows.Forms.ComboBox cbGroup;
		private System.Windows.Forms.Label lblStudCount;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ComboBox cbDirection;
		private System.Windows.Forms.RadioButton rbStudents;
		private System.Windows.Forms.RadioButton rbGroups;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.Button btnGroupAdd;
		private System.Windows.Forms.DataGridView dataGridViewGroups;
		private System.Windows.Forms.ComboBox cbDirectionOnGroupTab;
		private System.Windows.Forms.Label lblGroupsCount;
		private System.Windows.Forms.Button btnDelete;
	}
}


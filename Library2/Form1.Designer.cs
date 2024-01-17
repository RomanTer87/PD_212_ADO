namespace Library2
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
			this.btnExecute = new System.Windows.Forms.Button();
			this.dgwResults = new System.Windows.Forms.DataGridView();
			this.rtbQuery = new System.Windows.Forms.RichTextBox();
			this.cbTable = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgwResults)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExecute
			// 
			this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExecute.Location = new System.Drawing.Point(1203, 13);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(104, 37);
			this.btnExecute.TabIndex = 0;
			this.btnExecute.Text = "Execute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// dgwResults
			// 
			this.dgwResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgwResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwResults.Location = new System.Drawing.Point(33, 122);
			this.dgwResults.Name = "dgwResults";
			this.dgwResults.Size = new System.Drawing.Size(1274, 485);
			this.dgwResults.TabIndex = 1;
			// 
			// rtbQuery
			// 
			this.rtbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbQuery.Location = new System.Drawing.Point(33, 13);
			this.rtbQuery.Multiline = false;
			this.rtbQuery.Name = "rtbQuery";
			this.rtbQuery.Size = new System.Drawing.Size(1164, 38);
			this.rtbQuery.TabIndex = 2;
			this.rtbQuery.Text = "";
			// 
			// cbTable
			// 
			this.cbTable.FormattingEnabled = true;
			this.cbTable.Location = new System.Drawing.Point(33, 73);
			this.cbTable.Name = "cbTable";
			this.cbTable.Size = new System.Drawing.Size(1274, 21);
			this.cbTable.TabIndex = 3;
			this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1341, 637);
			this.Controls.Add(this.cbTable);
			this.Controls.Add(this.rtbQuery);
			this.Controls.Add(this.dgwResults);
			this.Controls.Add(this.btnExecute);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgwResults)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.DataGridView dgwResults;
		private System.Windows.Forms.RichTextBox rtbQuery;
		private System.Windows.Forms.ComboBox cbTable;
	}
}


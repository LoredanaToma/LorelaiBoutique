namespace LorelaiBoutique
{
	partial class Update_Categorii
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
			this.bUpdate_Categ = new System.Windows.Forms.Button();
			this.dataGridViewcateg = new System.Windows.Forms.DataGridView();
			this.tcateg = new System.Windows.Forms.TextBox();
			this.tIDcateg = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewcateg)).BeginInit();
			this.SuspendLayout();
			// 
			// bUpdate_Categ
			// 
			this.bUpdate_Categ.Location = new System.Drawing.Point(79, 474);
			this.bUpdate_Categ.Name = "bUpdate_Categ";
			this.bUpdate_Categ.Size = new System.Drawing.Size(102, 46);
			this.bUpdate_Categ.TabIndex = 11;
			this.bUpdate_Categ.Text = "Update";
			this.bUpdate_Categ.UseVisualStyleBackColor = true;
			this.bUpdate_Categ.Click += new System.EventHandler(this.BDone_Categ_Click);
			// 
			// dataGridViewcateg
			// 
			this.dataGridViewcateg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewcateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewcateg.Location = new System.Drawing.Point(255, 56);
			this.dataGridViewcateg.Name = "dataGridViewcateg";
			this.dataGridViewcateg.RowTemplate.Height = 24;
			this.dataGridViewcateg.Size = new System.Drawing.Size(415, 658);
			this.dataGridViewcateg.TabIndex = 10;
			// 
			// tcateg
			// 
			this.tcateg.Location = new System.Drawing.Point(126, 341);
			this.tcateg.Name = "tcateg";
			this.tcateg.Size = new System.Drawing.Size(100, 22);
			this.tcateg.TabIndex = 9;
			// 
			// tIDcateg
			// 
			this.tIDcateg.Location = new System.Drawing.Point(126, 233);
			this.tIDcateg.Name = "tIDcateg";
			this.tIDcateg.Size = new System.Drawing.Size(100, 22);
			this.tIDcateg.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 346);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Categoria";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 238);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "ID";
			// 
			// Update_Categorii
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(722, 768);
			this.Controls.Add(this.bUpdate_Categ);
			this.Controls.Add(this.dataGridViewcateg);
			this.Controls.Add(this.tcateg);
			this.Controls.Add(this.tIDcateg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Update_Categorii";
			this.Text = "Update Categorii";
			this.Load += new System.EventHandler(this.Update_Categorii_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewcateg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bUpdate_Categ;
		private System.Windows.Forms.DataGridView dataGridViewcateg;
		private System.Windows.Forms.TextBox tcateg;
		private System.Windows.Forms.TextBox tIDcateg;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
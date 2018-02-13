namespace LorelaiBoutique
{
	partial class ClearCategorii
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
			this.dataGridClearcateg = new System.Windows.Forms.DataGridView();
			this.bdel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tidcateg = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridClearcateg)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridClearcateg
			// 
			this.dataGridClearcateg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridClearcateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridClearcateg.Location = new System.Drawing.Point(206, 75);
			this.dataGridClearcateg.Name = "dataGridClearcateg";
			this.dataGridClearcateg.RowTemplate.Height = 24;
			this.dataGridClearcateg.Size = new System.Drawing.Size(318, 453);
			this.dataGridClearcateg.TabIndex = 0;
			this.dataGridClearcateg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClearcateg_CellContentClick);
			this.dataGridClearcateg.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridClearcateg_RowHeaderMouseClick);
			// 
			// bdel
			// 
			this.bdel.Location = new System.Drawing.Point(57, 419);
			this.bdel.Name = "bdel";
			this.bdel.Size = new System.Drawing.Size(99, 47);
			this.bdel.TabIndex = 1;
			this.bdel.Text = "Delete";
			this.bdel.UseVisualStyleBackColor = true;
			this.bdel.Click += new System.EventHandler(this.bdel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 227);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "ID ";
			// 
			// tidcateg
			// 
			this.tidcateg.Location = new System.Drawing.Point(86, 227);
			this.tidcateg.Name = "tidcateg";
			this.tidcateg.Size = new System.Drawing.Size(100, 22);
			this.tidcateg.TabIndex = 3;
			// 
			// ClearCategorii
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(561, 593);
			this.Controls.Add(this.tidcateg);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bdel);
			this.Controls.Add(this.dataGridClearcateg);
			this.Name = "ClearCategorii";
			this.Text = "ClearCategorii";
			this.Load += new System.EventHandler(this.ClearCategorii_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridClearcateg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridClearcateg;
		private System.Windows.Forms.Button bdel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tidcateg;
	}
}
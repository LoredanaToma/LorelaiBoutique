namespace LorelaiBoutique
{
	partial class Categorii
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tIDcateg = new System.Windows.Forms.TextBox();
			this.tcateg = new System.Windows.Forms.TextBox();
			this.dataGridViewcateg = new System.Windows.Forms.DataGridView();
			this.bDone_Categ = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewcateg)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 205);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Categoria";
			// 
			// tIDcateg
			// 
			this.tIDcateg.Location = new System.Drawing.Point(139, 127);
			this.tIDcateg.Name = "tIDcateg";
			this.tIDcateg.Size = new System.Drawing.Size(100, 22);
			this.tIDcateg.TabIndex = 2;
			// 
			// tcateg
			// 
			this.tcateg.Location = new System.Drawing.Point(139, 205);
			this.tcateg.Name = "tcateg";
			this.tcateg.Size = new System.Drawing.Size(100, 22);
			this.tcateg.TabIndex = 3;
			this.tcateg.TextChanged += new System.EventHandler(this.tcateg_TextChanged);
			// 
			// dataGridViewcateg
			// 
			this.dataGridViewcateg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewcateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewcateg.Location = new System.Drawing.Point(276, 50);
			this.dataGridViewcateg.Name = "dataGridViewcateg";
			this.dataGridViewcateg.RowTemplate.Height = 24;
			this.dataGridViewcateg.Size = new System.Drawing.Size(438, 544);
			this.dataGridViewcateg.TabIndex = 4;
			// 
			// bDone_Categ
			// 
			this.bDone_Categ.Location = new System.Drawing.Point(88, 385);
			this.bDone_Categ.Name = "bDone_Categ";
			this.bDone_Categ.Size = new System.Drawing.Size(102, 46);
			this.bDone_Categ.TabIndex = 5;
			this.bDone_Categ.Text = "Add";
			this.bDone_Categ.UseVisualStyleBackColor = true;
			this.bDone_Categ.Click += new System.EventHandler(this.BDone_Categ_Click);
			// 
			// Categorii
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(753, 662);
			this.Controls.Add(this.bDone_Categ);
			this.Controls.Add(this.dataGridViewcateg);
			this.Controls.Add(this.tcateg);
			this.Controls.Add(this.tIDcateg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Categorii";
			this.Text = "Add_Categorii";
			this.Load += new System.EventHandler(this.Add_Categorii_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewcateg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tIDcateg;
		private System.Windows.Forms.TextBox tcateg;
		private System.Windows.Forms.DataGridView dataGridViewcateg;
		private System.Windows.Forms.Button bDone_Categ;
	}
}
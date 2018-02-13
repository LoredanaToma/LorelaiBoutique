namespace LorelaiBoutique
{
	partial class ClearProduse
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
			this.bClearProd = new System.Windows.Forms.Button();
			this.dataGridViewClear = new System.Windows.Forms.DataGridView();
			this.tid_produs = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClear)).BeginInit();
			this.SuspendLayout();
			// 
			// bClearProd
			// 
			this.bClearProd.Location = new System.Drawing.Point(91, 414);
			this.bClearProd.Name = "bClearProd";
			this.bClearProd.Size = new System.Drawing.Size(100, 44);
			this.bClearProd.TabIndex = 19;
			this.bClearProd.Text = "Clear";
			this.bClearProd.UseVisualStyleBackColor = true;
			this.bClearProd.Click += new System.EventHandler(this.bClearProd_Click);
			// 
			// dataGridViewClear
			// 
			this.dataGridViewClear.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewClear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClear.Location = new System.Drawing.Point(282, 60);
			this.dataGridViewClear.Name = "dataGridViewClear";
			this.dataGridViewClear.RowTemplate.Height = 24;
			this.dataGridViewClear.Size = new System.Drawing.Size(515, 641);
			this.dataGridViewClear.TabIndex = 18;
			this.dataGridViewClear.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClear_CellContentClick);
			this.dataGridViewClear.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClear_RowHeaderMouseClick);
			// 
			// tid_produs
			// 
			this.tid_produs.Location = new System.Drawing.Point(154, 264);
			this.tid_produs.Name = "tid_produs";
			this.tid_produs.Size = new System.Drawing.Size(100, 22);
			this.tid_produs.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "ID produs";
			// 
			// ClearProduse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(864, 763);
			this.Controls.Add(this.bClearProd);
			this.Controls.Add(this.dataGridViewClear);
			this.Controls.Add(this.tid_produs);
			this.Controls.Add(this.label1);
			this.Name = "ClearProduse";
			this.Text = "Clear Produse";
			this.Load += new System.EventHandler(this.ClearProduse_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bClearProd;
		private System.Windows.Forms.DataGridView dataGridViewClear;
		private System.Windows.Forms.TextBox tid_produs;
		private System.Windows.Forms.Label label1;
	}
}
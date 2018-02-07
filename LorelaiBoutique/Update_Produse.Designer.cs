namespace LorelaiBoutique
{
	partial class Update_Produse
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
			this.bUpdateProd = new System.Windows.Forms.Button();
			this.dataGridViewprod = new System.Windows.Forms.DataGridView();
			this.tPret = new System.Windows.Forms.TextBox();
			this.tNume = new System.Windows.Forms.TextBox();
			this.tid_produs = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tidcateg = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.timagMare = new System.Windows.Forms.TextBox();
			this.timagMic = new System.Windows.Forms.TextBox();
			this.tprez = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewprod)).BeginInit();
			this.SuspendLayout();
			// 
			// bUpdateProd
			// 
			this.bUpdateProd.Location = new System.Drawing.Point(64, 630);
			this.bUpdateProd.Name = "bUpdateProd";
			this.bUpdateProd.Size = new System.Drawing.Size(100, 44);
			this.bUpdateProd.TabIndex = 19;
			this.bUpdateProd.Text = "Update";
			this.bUpdateProd.UseVisualStyleBackColor = true;
			this.bUpdateProd.Click += new System.EventHandler(this.bUpdateProd_Click);
			// 
			// dataGridViewprod
			// 
			this.dataGridViewprod.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewprod.Location = new System.Drawing.Point(302, 62);
			this.dataGridViewprod.Name = "dataGridViewprod";
			this.dataGridViewprod.RowTemplate.Height = 24;
			this.dataGridViewprod.Size = new System.Drawing.Size(564, 612);
			this.dataGridViewprod.TabIndex = 18;
			// 
			// tPret
			// 
			this.tPret.Location = new System.Drawing.Point(161, 506);
			this.tPret.Name = "tPret";
			this.tPret.Size = new System.Drawing.Size(100, 22);
			this.tPret.TabIndex = 17;
			// 
			// tNume
			// 
			this.tNume.Location = new System.Drawing.Point(161, 358);
			this.tNume.Name = "tNume";
			this.tNume.Size = new System.Drawing.Size(100, 22);
			this.tNume.TabIndex = 16;
			// 
			// tid_produs
			// 
			this.tid_produs.Location = new System.Drawing.Point(161, 62);
			this.tid_produs.Name = "tid_produs";
			this.tid_produs.Size = new System.Drawing.Size(100, 22);
			this.tid_produs.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 506);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "Pret";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 358);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Nume_produs";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 284);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 11;
			this.label2.Text = "ID Categorie";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "id_produs";
			// 
			// tidcateg
			// 
			this.tidcateg.Location = new System.Drawing.Point(161, 284);
			this.tidcateg.Name = "tidcateg";
			this.tidcateg.Size = new System.Drawing.Size(100, 22);
			this.tidcateg.TabIndex = 20;
			this.tidcateg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(48, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 17);
			this.label5.TabIndex = 21;
			this.label5.Text = "Imagine mica";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(48, 210);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 17);
			this.label6.TabIndex = 22;
			this.label6.Text = "Imagine mare";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(48, 432);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 17);
			this.label7.TabIndex = 23;
			this.label7.Text = "Prezentare";
			// 
			// timagMare
			// 
			this.timagMare.Location = new System.Drawing.Point(161, 210);
			this.timagMare.Name = "timagMare";
			this.timagMare.Size = new System.Drawing.Size(100, 22);
			this.timagMare.TabIndex = 24;
			// 
			// timagMic
			// 
			this.timagMic.Location = new System.Drawing.Point(161, 136);
			this.timagMic.Name = "timagMic";
			this.timagMic.Size = new System.Drawing.Size(100, 22);
			this.timagMic.TabIndex = 25;
			// 
			// tprez
			// 
			this.tprez.Location = new System.Drawing.Point(161, 432);
			this.tprez.Name = "tprez";
			this.tprez.Size = new System.Drawing.Size(100, 22);
			this.tprez.TabIndex = 26;
			// 
			// Update_Produse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(914, 795);
			this.Controls.Add(this.tprez);
			this.Controls.Add(this.timagMic);
			this.Controls.Add(this.timagMare);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tidcateg);
			this.Controls.Add(this.bUpdateProd);
			this.Controls.Add(this.dataGridViewprod);
			this.Controls.Add(this.tPret);
			this.Controls.Add(this.tNume);
			this.Controls.Add(this.tid_produs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Update_Produse";
			this.Text = "Update Produse";
			this.Load += new System.EventHandler(this.Update_Produse_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewprod)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bUpdateProd;
		private System.Windows.Forms.DataGridView dataGridViewprod;
		private System.Windows.Forms.TextBox tPret;
		private System.Windows.Forms.TextBox tNume;
		private System.Windows.Forms.TextBox tid_produs;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tidcateg;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox timagMare;
		private System.Windows.Forms.TextBox timagMic;
		private System.Windows.Forms.TextBox tprez;
	}
}
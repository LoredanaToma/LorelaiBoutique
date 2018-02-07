namespace LorelaiBoutique
{
	partial class Produse
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tid_produs = new System.Windows.Forms.TextBox();
			this.comboCateg = new System.Windows.Forms.ComboBox();
			this.tNume = new System.Windows.Forms.TextBox();
			this.tPret = new System.Windows.Forms.TextBox();
			this.dataGridViewprod = new System.Windows.Forms.DataGridView();
			this.bdoneProd = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.timagMic = new System.Windows.Forms.TextBox();
			this.timagMare = new System.Windows.Forms.TextBox();
			this.tprez = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewprod)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "id_produs";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 277);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID categorie";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 341);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nume_produs";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 470);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Pret";
			// 
			// tid_produs
			// 
			this.tid_produs.Location = new System.Drawing.Point(170, 104);
			this.tid_produs.Name = "tid_produs";
			this.tid_produs.Size = new System.Drawing.Size(100, 22);
			this.tid_produs.TabIndex = 4;
			// 
			// comboCateg
			// 
			this.comboCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboCateg.FormattingEnabled = true;
			this.comboCateg.Location = new System.Drawing.Point(170, 277);
			this.comboCateg.Name = "comboCateg";
			this.comboCateg.Size = new System.Drawing.Size(121, 24);
			this.comboCateg.TabIndex = 5;
			this.comboCateg.SelectedIndexChanged += new System.EventHandler(this.comboCateg_SelectedIndexChanged);
			// 
			// tNume
			// 
			this.tNume.Location = new System.Drawing.Point(170, 341);
			this.tNume.Name = "tNume";
			this.tNume.Size = new System.Drawing.Size(100, 22);
			this.tNume.TabIndex = 6;
			// 
			// tPret
			// 
			this.tPret.Location = new System.Drawing.Point(170, 470);
			this.tPret.Name = "tPret";
			this.tPret.Size = new System.Drawing.Size(100, 22);
			this.tPret.TabIndex = 7;
			// 
			// dataGridViewprod
			// 
			this.dataGridViewprod.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridViewprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewprod.Location = new System.Drawing.Point(351, 68);
			this.dataGridViewprod.Name = "dataGridViewprod";
			this.dataGridViewprod.RowTemplate.Height = 24;
			this.dataGridViewprod.Size = new System.Drawing.Size(443, 589);
			this.dataGridViewprod.TabIndex = 8;
			// 
			// bdoneProd
			// 
			this.bdoneProd.Location = new System.Drawing.Point(111, 579);
			this.bdoneProd.Name = "bdoneProd";
			this.bdoneProd.Size = new System.Drawing.Size(100, 44);
			this.bdoneProd.TabIndex = 9;
			this.bdoneProd.Text = "Add";
			this.bdoneProd.UseVisualStyleBackColor = true;
			this.bdoneProd.Click += new System.EventHandler(this.bdoneProd_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Imagine mica";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "Imagine mare";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(44, 407);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 17);
			this.label7.TabIndex = 12;
			this.label7.Text = "Prezentare";
			// 
			// timagMic
			// 
			this.timagMic.Location = new System.Drawing.Point(170, 160);
			this.timagMic.Name = "timagMic";
			this.timagMic.Size = new System.Drawing.Size(100, 22);
			this.timagMic.TabIndex = 13;
			// 
			// timagMare
			// 
			this.timagMare.Location = new System.Drawing.Point(170, 217);
			this.timagMare.Name = "timagMare";
			this.timagMare.Size = new System.Drawing.Size(100, 22);
			this.timagMare.TabIndex = 14;
			// 
			// tprez
			// 
			this.tprez.Location = new System.Drawing.Point(170, 407);
			this.tprez.Name = "tprez";
			this.tprez.Size = new System.Drawing.Size(100, 22);
			this.tprez.TabIndex = 15;
			// 
			// Produse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(876, 744);
			this.Controls.Add(this.tprez);
			this.Controls.Add(this.timagMare);
			this.Controls.Add(this.timagMic);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.bdoneProd);
			this.Controls.Add(this.dataGridViewprod);
			this.Controls.Add(this.tPret);
			this.Controls.Add(this.tNume);
			this.Controls.Add(this.comboCateg);
			this.Controls.Add(this.tid_produs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Produse";
			this.Text = "Produse";
			this.Load += new System.EventHandler(this.Produse_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewprod)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tid_produs;
		private System.Windows.Forms.ComboBox comboCateg;
		private System.Windows.Forms.TextBox tNume;
		private System.Windows.Forms.TextBox tPret;
		private System.Windows.Forms.DataGridView dataGridViewprod;
		private System.Windows.Forms.Button bdoneProd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox timagMic;
		private System.Windows.Forms.TextBox timagMare;
		private System.Windows.Forms.TextBox tprez;
	}
}
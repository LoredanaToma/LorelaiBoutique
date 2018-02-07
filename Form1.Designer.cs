namespace LorelaiBoutique
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoriiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.produseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.produseToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.clearCategoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Crimson;
			this.label1.Location = new System.Drawing.Point(552, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "LorelaiBoutique";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(270, 604);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(111, 17);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Lorelai Boutique";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(543, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(127, 85);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.WaitOnLoad = true;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(682, 28);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriiToolStripMenuItem,
            this.produseToolStripMenuItem});
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// categoriiToolStripMenuItem
			// 
			this.categoriiToolStripMenuItem.Name = "categoriiToolStripMenuItem";
			this.categoriiToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.categoriiToolStripMenuItem.Text = "Categorii";
			this.categoriiToolStripMenuItem.Click += new System.EventHandler(this.categoriiToolStripMenuItem_Click);
			// 
			// produseToolStripMenuItem
			// 
			this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
			this.produseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.produseToolStripMenuItem.Text = "Produse";
			this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriiToolStripMenuItem1,
            this.produseToolStripMenuItem1});
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
			this.updateToolStripMenuItem.Text = "Update";
			// 
			// categoriiToolStripMenuItem1
			// 
			this.categoriiToolStripMenuItem1.Name = "categoriiToolStripMenuItem1";
			this.categoriiToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
			this.categoriiToolStripMenuItem1.Text = "Update Categorii";
			this.categoriiToolStripMenuItem1.Click += new System.EventHandler(this.CategoriiToolStripMenuItem1_Click);
			// 
			// produseToolStripMenuItem1
			// 
			this.produseToolStripMenuItem1.Name = "produseToolStripMenuItem1";
			this.produseToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
			this.produseToolStripMenuItem1.Text = "Update Produse";
			this.produseToolStripMenuItem1.Click += new System.EventHandler(this.produseToolStripMenuItem1_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem2,
            this.clearCategoriiToolStripMenuItem});
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
			this.exitToolStripMenuItem.Text = "Clear";
			// 
			// produseToolStripMenuItem2
			// 
			this.produseToolStripMenuItem2.Name = "produseToolStripMenuItem2";
			this.produseToolStripMenuItem2.Size = new System.Drawing.Size(183, 26);
			this.produseToolStripMenuItem2.Text = "Clear Produse";
			this.produseToolStripMenuItem2.Click += new System.EventHandler(this.produseToolStripMenuItem2_Click);
			// 
			// clearCategoriiToolStripMenuItem
			// 
			this.clearCategoriiToolStripMenuItem.Name = "clearCategoriiToolStripMenuItem";
			this.clearCategoriiToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
			this.clearCategoriiToolStripMenuItem.Text = "Clear Categorii";
			this.clearCategoriiToolStripMenuItem.Click += new System.EventHandler(this.clearCategoriiToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(45, 24);
			this.exitToolStripMenuItem1.Text = "Exit";
			this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Enabled = false;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(120, 121);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(413, 480);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(682, 693);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Location = new System.Drawing.Point(0, 5);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "LorelaiBoutique";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem clearCategoriiToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}


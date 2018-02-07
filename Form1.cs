using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace LorelaiBoutique
{
	public partial class Form1 : Form
	{
		

		public Form1()
		{
			InitializeComponent();
		

		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://localhost/LORELAI/");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void CategoriiToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Update_Categorii Upcateg = new Update_Categorii();
			Upcateg.ShowDialog();
		}

		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{


		}
	

		private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void produseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Produse produse = new Produse();
			produse.ShowDialog();
		}

		private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Categorii categ = new Categorii();
			categ.ShowDialog();
		}

		private void produseToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			ClearProduse clearproduse = new ClearProduse();
			clearproduse.ShowDialog();
		}

		private void produseToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Update_Produse Upprod = new Update_Produse();
			Upprod.ShowDialog();
		}

		private void clearCategoriiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ClearCategorii Clearcateg = new ClearCategorii();
			Clearcateg.ShowDialog();
		}
	}
	
}

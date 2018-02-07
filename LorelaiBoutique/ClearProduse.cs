using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LorelaiBoutique
{
	public partial class ClearProduse : Form
	{
		MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=lorelai;username=root;password=");

		public ClearProduse()
		{
			InitializeComponent();
		}
		public void openConnection()
		{
			if (connection.State == ConnectionState.Closed)
			{
				connection.Open();
			}
		}

		public void closeConnection()
		{
			if (connection.State == ConnectionState.Open)
			{
				connection.Close();
			}
		}

		public void ExecuteQuery(String query)
		{
			try
			{
				openConnection();
				MySqlCommand command;
				command = new MySqlCommand(query, connection);
				if (command.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Done!");
				}
				else
				{
					MessageBox.Show("Not Executed!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				closeConnection();
			}
		}
		public void populateDGV()
		{
			string selectQuery = "select * from produse";
			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
			adapter.Fill(table);
			dataGridViewClear.DataSource = table;
		}

			private void label2_Click(object sender, EventArgs e)
		{

		}

		private void comboCateg_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void ClearProduse_Load(object sender, EventArgs e)
		{
			populateDGV();
		}

		private void bClearProd_Click(object sender, EventArgs e)
		{
			string deleteQuery = "DELETE FROM produse WHERE id_produs = " + tid_produs.Text;
			ExecuteQuery(deleteQuery);
			populateDGV();
		}
	}
}

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
	public partial class Update_Categorii : Form
	{
		MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=lorelai;username=root;password=");
		public Update_Categorii()
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
			string selectQuery = "select * from categorii";
			DataTable table = new DataTable();
			MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
			adapter.Fill(table);
			dataGridViewcateg.DataSource = table;
		}

		private void BDone_Categ_Click(object sender, EventArgs e)
		{

			string updateQuery = "UPDATE categorii SET categoria='" + tcateg.Text + "'   WHERE id_categ= '" + tIDcateg.Text +"'";
			

			ExecuteQuery(updateQuery);
			populateDGV();
		}

		private void Update_Categorii_Load(object sender, EventArgs e)
		{
			populateDGV();
		}
	}
}

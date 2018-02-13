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

	public partial class ClearCategorii : Form
	{
		String server = "localhost";
		String database = "lorelai";
		String uid = "root";
		String password = "";
		MySqlConnection connection;

		String connectionString;
		int ID = 0;


		public ClearCategorii()
		{
			InitializeComponent();
			connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
			connection = new MySqlConnection(connectionString);

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
			dataGridClearcateg.DataSource = table;
		}

		private void ClearCategorii_Load(object sender, EventArgs e)
		{
			populateDGV();
		}

		private void bdel_Click(object sender, EventArgs e)
		{
			if (ID != 0)
			{
				// Folosim siruri prelucrate pentru a preveni erori și pentru securitatea codului SQL
				try
				{
					openConnection();

					MySqlCommand command;

					// Nu încadrăm @id în apostrof!
					command = new MySqlCommand("DELETE FROM categorii WHERE id_categ = @id ;", connection);

					// Atribui la @id valoarea ID care va fi înlocuită '<nr>'
					command.Parameters.AddWithValue("@id", ID);

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

			// end if ID != 0
			else
				MessageBox.Show("Câmpurile sunt goale! \nSelectați un rând dând click pe coloana dinaintea cifrei!", "Nu ați selectat vreun rând", MessageBoxButtons.OK, MessageBoxIcon.Warning);


			populateDGV();
			curataDate();
		}
		private void curataDate()
		{
			ID = 0;
			tidcateg.Text = "";

		}
		
		private void dataGridViewcateg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		private void dataGridClearcateg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridClearcateg_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID = Convert.ToInt32(dataGridClearcateg.Rows[e.RowIndex].Cells[0].Value.ToString());
			tidcateg.Text = dataGridClearcateg.Rows[e.RowIndex].Cells[1].Value.ToString();

		}
	}
}



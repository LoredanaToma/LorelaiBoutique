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
		int ID = 0;
		String server = "localhost";
		String database = "lorelai";
		String uid = "root";
		String password = "";
		MySqlConnection connection;

		String connectionString;
		public ClearProduse()
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
		private void curataDate()
		{
			ID = 0;
			tid_produs.Text = "";
		}


		private void ClearProduse_Load(object sender, EventArgs e)
		{
			populateDGV();
		}


		private void bClearProd_Click(object sender, EventArgs e)
		{
			if (ID != 0)
			{
				// Folosim siruri prelucrate pentru a preveni erori și pentru securitatea codului SQL
				try
				{

					openConnection();

					MySqlCommand command;

					command = new MySqlCommand("delete from produse  WHERE id_produs = @id ;", connection);

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

			curataDate();
			populateDGV();
		}

		private void dataGridViewClear_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridViewClear_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID = Convert.ToInt32(dataGridViewClear.Rows[e.RowIndex].Cells[0].Value.ToString());
			tid_produs.Text = dataGridViewClear.Rows[e.RowIndex].Cells[1].Value.ToString();
			
		}
	}
}

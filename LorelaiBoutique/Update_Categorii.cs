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
		String server = "localhost";
		String database = "lorelai";
		String uid = "root";
		String password = "";
		MySqlConnection connection;

		String connectionString;


		int ID = 0;

		
		public Update_Categorii()
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
			if (ID != 0)
			{
				// Folosim siruri prelucrate pentru a preveni erori și pentru securitatea codului SQL
				try
				{

					openConnection();

					MySqlCommand command;


					// Nu încadrăm @id în apostrof!

					command = new MySqlCommand("UPDATE categorii SET categoria= @tcateg WHERE id_categ = @id ;", connection);

					command.Parameters.AddWithValue("@id", ID);
					command.Parameters.AddWithValue("@tcateg", tcateg.Text);

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
		

			}

		
		private void curataDate()
		{
			ID = 0;
			tIDcateg.Text = "";
			tcateg.Text = "";
		}
			
		private void Update_Categorii_Load(object sender, EventArgs e)
		{
			populateDGV();
		}

		private void tIDcateg_TextChanged(object sender, EventArgs e)
		{

		}

		private void tcateg_TextChanged(object sender, EventArgs e)
		{

		}

		private void DataGridViewcateg_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridViewcateg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridViewcateg_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID = Convert.ToInt32(dataGridViewcateg.Rows[e.RowIndex].Cells[0].Value.ToString());
			tcateg.Text = dataGridViewcateg.Rows[e.RowIndex].Cells[1].Value.ToString();
		}
	}
}

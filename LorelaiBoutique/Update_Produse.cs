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
	public partial class Update_Produse : Form
	{
		int ID = 0;
		String server = "localhost";
		String database = "lorelai";
		String uid = "root";
		String password = "";
		MySqlConnection connection;

		String connectionString;

		public Update_Produse()
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
			dataGridViewprod.DataSource = table;
		}

		private void curataDate()
		{
			ID = 0;
			tidcateg.Text = "";
			timagMic.Text = "";
			timagMare.Text = "";
			tNume.Text = "";
			tprez.Text = "";
			tPret.Text = "";
		}

		private void Update_Produse_Load(object sender, EventArgs e)
		{
			populateDGV();
		}

		private void bUpdateProd_Click(object sender, EventArgs e)
		{
			if (ID != 0)
			{
				// Folosim siruri prelucrate pentru a preveni erori și pentru securitatea codului SQL
				try
				{

					openConnection();

					MySqlCommand command;

					command = new MySqlCommand("UPDATE produse SET fisier_imagine= @timagMic , imagine_mare= @timagMare , id_categ= @tidcateg , nume_produs= @tNume , prezentare= @tprez , pret= @tPret WHERE id_produs = @id ;", connection);

					command.Parameters.AddWithValue("@id", ID);
					command.Parameters.AddWithValue("@timagMic", timagMic.Text);
					command.Parameters.AddWithValue("@timagMare", timagMare.Text);
					command.Parameters.AddWithValue("@tidcateg", tidcateg.Text);
					command.Parameters.AddWithValue("@tNume", tNume.Text);
					command.Parameters.AddWithValue("@tprez", tprez.Text);
					command.Parameters.AddWithValue("@tPret", tPret.Text);

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


		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridViewprod_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID = Convert.ToInt32(dataGridViewprod.Rows[e.RowIndex].Cells[0].Value.ToString());
			tidcateg.Text = dataGridViewprod.Rows[e.RowIndex].Cells[1].Value.ToString();
			timagMic.Text = dataGridViewprod.Rows[e.RowIndex].Cells[2].Value.ToString();
			timagMare.Text = dataGridViewprod.Rows[e.RowIndex].Cells[3].Value.ToString();
			tNume.Text = dataGridViewprod.Rows[e.RowIndex].Cells[4].Value.ToString();
			tprez.Text = dataGridViewprod.Rows[e.RowIndex].Cells[5].Value.ToString();
			tPret.Text = dataGridViewprod.Rows[e.RowIndex].Cells[6].Value.ToString();
		
		}

		private void dataGridViewprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
	
}




using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.SqlClient;
using static FinalProjectTravel.autheticate;

namespace FinalProjectTravel
{
    public partial class ActivitiesFilter : Form
    {
        private User authenticatedUser;

        public ActivitiesFilter()
        {
            InitializeComponent();
        }


        // Event handler for when the room type is selected in the ComboBox
        private void weather_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // SQL query to select rooms based on the selected room type
                string query = "select * from ActivitiesFilter where Weather = @Weather";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@Weather", weather.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void terrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string query2 = "select * from ActivitiesFilter where Terrain = @Terrain AND Weather = @Weather";

                SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                cmd2.Parameters.AddWithValue("@Weather", weather.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@Terrain", Terrain.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd2))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void TravelLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establish a connection to the database
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string query3 = "select * from ActivitiesFilter where Terrain = @Terrain AND Weather = @Weather AND TravelLength = @TravelLength";

                SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                cmd3.Parameters.AddWithValue("@Weather", weather.SelectedItem.ToString());
                cmd3.Parameters.AddWithValue("@Terrain", Terrain.SelectedItem.ToString());
                cmd3.Parameters.AddWithValue("@TravelLength", TravelLength.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd3))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
        private void SuitActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection
                string query4 = "select * from ActivitiesFilter where Terrain = @Terrain AND Weather = @Weather AND TravelLength = @TravelLength AND SuitActivity = @SuitActivity";

                SqlCommand cmd4 = new SqlCommand(query4, sqlCon);
                cmd4.Parameters.AddWithValue("@Weather", weather.SelectedItem.ToString());
                cmd4.Parameters.AddWithValue("@Terrain", Terrain.SelectedItem.ToString());
                cmd4.Parameters.AddWithValue("@TravelLength", TravelLength.SelectedItem.ToString());
                cmd4.Parameters.AddWithValue("@SuitActivity", SuitActivity.SelectedItem.ToString());

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd4))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            weather.SelectedIndex = 0;
            Terrain.SelectedIndex = 0;
            TravelLength.SelectedIndex = 0;
            SuitActivity.SelectedIndex = 0;
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            using (PackingList pack = new PackingList())
            {
                // Display the form as a dialog
                pack.ShowDialog();

            }
        }
        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True; TrustServerCertificate=True;"))
            {
                string query = "SELECT * FROM ActivitiesFilter";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    // Check if the DataSet contains any tables
                    if (ds.Tables.Count > 0)
                    {
                        // Set the DataSource of the DataGridView to the DataTable in the DataSet
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // If no data found, set DataSource to null
                        dataGridView1.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving reviews: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
                Menu menu = new Menu();
                menu.Show();
            }
        }
    }

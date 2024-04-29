using System.Data.SqlClient;
using System.Xml.Linq;

namespace FinalProjectTravel
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True;"))
            {
                cn.Open();

                using (cmd = new SqlCommand("INSERT INTO TripPlanning (DestinationName, Country, DateTrip, Activities, Budget)" +
                    " VALUES(@dname, @country, @dtrip, @activ, @budg)", cn))
                {
                    cmd.Parameters.AddWithValue("@dname", city.Text);
                    cmd.Parameters.AddWithValue("@country", Destination.Text);
                    cmd.Parameters.AddWithValue("@dtrip", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@activ", act.Text);
                    cmd.Parameters.AddWithValue("@budg", bud.Text);
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Your Trip is planned. Please make a packing list now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    ActivitiesFilter pack = new ActivitiesFilter();
                    pack.Show();
                }
            }
        }

        private void btnEditTrip_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True;"))
            {
                cn.Open();

                using (cmd = new SqlCommand("UPDATE TripPlanning SET Country = @country, DateTrip = @dtrip, Activities = @activ, Budget = @budg WHERE DestinationName = @dname", cn))
                {
                    cmd.Parameters.AddWithValue("@dname", city.Text);
                    cmd.Parameters.AddWithValue("@country", Destination.Text);
                    cmd.Parameters.AddWithValue("@dtrip", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@activ", act.Text);
                    cmd.Parameters.AddWithValue("@budg", bud.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Trip updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Button click event handler to delete an existing trip
        private void btnDeleteTrip_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True;"))
            {
                cn.Open();

                using (cmd = new SqlCommand("DELETE FROM TripPlanning WHERE DestinationName = @dname", cn))
                {
                    cmd.Parameters.AddWithValue("@dname", city.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trip deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Trip not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
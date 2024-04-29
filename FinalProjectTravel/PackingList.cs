using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectTravel
{
    public partial class PackingList : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;
        public PackingList()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=LAB109PC05\SQLEXPRESS; Initial Catalog=TravelDB; Integrated Security=True;"))
            {
                cn.Open();

                using (cmd = new SqlCommand("INSERT INTO PackList (DestinationName, Weather, TripDuration, ImportantPack)" +
                    " VALUES(@dname, @weather, @dtrip, @packlist)", cn))
                {
                    cmd.Parameters.AddWithValue("@dname", dest.Text);
                    cmd.Parameters.AddWithValue("@weather", weth.Text);
                    cmd.Parameters.AddWithValue("@dtrip", dur.Text);
                    cmd.Parameters.AddWithValue("@packlist", list.Text);
                    cmd.ExecuteNonQuery();



                    MessageBox.Show("Your packing list is created. Please view your planned trips now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    Yourtrips view = new Yourtrips();
                    view.Show();
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

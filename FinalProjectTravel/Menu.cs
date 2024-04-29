using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectTravel
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 trip = new Form1();
            trip.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivitiesFilter itin = new ActivitiesFilter();
            itin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PackingList pack = new PackingList();
            pack.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SignUp login = new SignUp();
            login.Show();
        }
    }
}

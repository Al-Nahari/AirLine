using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class MainFlight : Form
    {
        public MainFlight()
        {
            InitializeComponent();
        }

        private void btnToFlight_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFlight VF = new ViewFlight();
            VF.ShowDialog();
           
        }

        private void btnToPasenger_Click(object sender, EventArgs e)
        {
            ViewPassengercs VP = new ViewPassengercs();
            VP.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnToTickets_Click(object sender, EventArgs e)
        {
            Ticket T = new Ticket();
            T.Show();
            this.Hide();
        }
    }
}

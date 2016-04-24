using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportPortal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passengerAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passengers passengerForm = new passengers();
            passengerForm.MdiParent = this;
            passengerForm.Show();
        }

        private void baggageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baggage bagForm = new Baggage();
            bagForm.MdiParent = this;
            bagForm.Show();
        }

        private void buyTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tickets buyTickets = new tickets();
            buyTickets.MdiParent = this;
            buyTickets.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            planes managePlanes = new planes();
            managePlanes.MdiParent = this;
            managePlanes.Show();
        }

        private void addFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flights mngFlights = new flights();
            mngFlights.MdiParent = this;
            mngFlights.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            peopleCreate createPeople = new peopleCreate();
            createPeople.MdiParent = this;
            createPeople.Show();
        }

    }
}

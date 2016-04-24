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
    public partial class passengers : Form
    {
        public passengers()
        {
            InitializeComponent();
        }

        private void passengers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDatabaseDataSet.peopleAdressesAdapter' table. You can move, or remove it, as needed.
            this.peopleAdressesAdapterTableAdapter.Fill(this.airportDatabaseDataSet.peopleAdressesAdapter);

        }
    }
}

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
    public partial class planes : Form
    {
        public planes()
        {
            InitializeComponent();
        }

        private void planesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDatabaseDataSet);

        }

        private void planes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDatabaseDataSet.Planes' table. You can move, or remove it, as needed.
            this.planesTableAdapter.Fill(this.airportDatabaseDataSet.Planes);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.planesTableAdapter.FillByName(this.airportDatabaseDataSet.Planes,search.Text);
        }

        private void planeResetbtn_Click(object sender, EventArgs e)
        {
            this.planesTableAdapter.Fill(this.airportDatabaseDataSet.Planes);
        }

    }
}

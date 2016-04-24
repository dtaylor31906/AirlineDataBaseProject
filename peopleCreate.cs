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
    public partial class peopleCreate : Form
    {
        public peopleCreate()
        {
            InitializeComponent();
        }

        private void peopleCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airportDatabaseDataSet.peopleAdressesAdapter' table. You can move, or remove it, as needed.
            

        }

        private void idSearch_Click(object sender, EventArgs e)
        {
            this.peopleAdressesAdapterTableAdapter.FillByID(this.airportDatabaseDataSet.peopleAdressesAdapter, (int)numericID.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.peopleAdressesAdapterTableAdapter.UpdateQueryAddresses(street_AddressTextBox.Text, cityTextBox.Text, stateTextBox.Text, zipcodeTextBox.Text);
                this.peopleAdressesAdapterTableAdapter.UpdateQueryPeople(nameTextBox.Text, phoneTextBox.Text, employerTextBox.Text, Int32.Parse(expr1Label1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Failed");
            }
        }
    }
}

namespace AirportPortal
{
    partial class peopleCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(peopleCreate));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label employerLabel;
            System.Windows.Forms.Label addressIDLabel;
            System.Windows.Forms.Label expr1Label;
            System.Windows.Forms.Label street_AddressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipcodeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.peopleAdressesAdapterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.employerTextBox = new System.Windows.Forms.TextBox();
            this.addressIDLabel1 = new System.Windows.Forms.Label();
            this.expr1Label1 = new System.Windows.Forms.Label();
            this.street_AddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.peopleAdressesAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDatabaseDataSet = new AirportPortal.airportDatabaseDataSet();
            this.peopleAdressesAdapterTableAdapter = new AirportPortal.airportDatabaseDataSetTableAdapters.peopleAdressesAdapterTableAdapter();
            this.tableAdapterManager = new AirportPortal.airportDatabaseDataSetTableAdapters.TableAdapterManager();
            this.idSearch = new System.Windows.Forms.Button();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            employerLabel = new System.Windows.Forms.Label();
            addressIDLabel = new System.Windows.Forms.Label();
            expr1Label = new System.Windows.Forms.Label();
            street_AddressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipcodeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peopleAdressesAdapterBindingNavigator)).BeginInit();
            this.peopleAdressesAdapterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleAdressesAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleAdressesAdapterBindingNavigator
            // 
            this.peopleAdressesAdapterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peopleAdressesAdapterBindingNavigator.BindingSource = this.peopleAdressesAdapterBindingSource;
            this.peopleAdressesAdapterBindingNavigator.CountItem = null;
            this.peopleAdressesAdapterBindingNavigator.DeleteItem = null;
            this.peopleAdressesAdapterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem});
            this.peopleAdressesAdapterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peopleAdressesAdapterBindingNavigator.MoveFirstItem = null;
            this.peopleAdressesAdapterBindingNavigator.MoveLastItem = null;
            this.peopleAdressesAdapterBindingNavigator.MoveNextItem = null;
            this.peopleAdressesAdapterBindingNavigator.MovePreviousItem = null;
            this.peopleAdressesAdapterBindingNavigator.Name = "peopleAdressesAdapterBindingNavigator";
            this.peopleAdressesAdapterBindingNavigator.PositionItem = null;
            this.peopleAdressesAdapterBindingNavigator.Size = new System.Drawing.Size(436, 25);
            this.peopleAdressesAdapterBindingNavigator.TabIndex = 0;
            this.peopleAdressesAdapterBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(11, 68);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(96, 68);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(11, 97);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(96, 94);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(11, 123);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 5;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(96, 120);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 6;
            // 
            // employerLabel
            // 
            employerLabel.AutoSize = true;
            employerLabel.Location = new System.Drawing.Point(11, 149);
            employerLabel.Name = "employerLabel";
            employerLabel.Size = new System.Drawing.Size(53, 13);
            employerLabel.TabIndex = 7;
            employerLabel.Text = "Employer:";
            // 
            // employerTextBox
            // 
            this.employerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "Employer", true));
            this.employerTextBox.Location = new System.Drawing.Point(96, 146);
            this.employerTextBox.Name = "employerTextBox";
            this.employerTextBox.Size = new System.Drawing.Size(100, 20);
            this.employerTextBox.TabIndex = 8;
            // 
            // addressIDLabel
            // 
            addressIDLabel.AutoSize = true;
            addressIDLabel.Location = new System.Drawing.Point(11, 169);
            addressIDLabel.Name = "addressIDLabel";
            addressIDLabel.Size = new System.Drawing.Size(62, 13);
            addressIDLabel.TabIndex = 9;
            addressIDLabel.Text = "Address ID:";
            // 
            // addressIDLabel1
            // 
            this.addressIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "AddressID", true));
            this.addressIDLabel1.Location = new System.Drawing.Point(96, 169);
            this.addressIDLabel1.Name = "addressIDLabel1";
            this.addressIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.addressIDLabel1.TabIndex = 10;
            // 
            // expr1Label
            // 
            expr1Label.AutoSize = true;
            expr1Label.Location = new System.Drawing.Point(11, 192);
            expr1Label.Name = "expr1Label";
            expr1Label.Size = new System.Drawing.Size(37, 13);
            expr1Label.TabIndex = 11;
            expr1Label.Text = "Expr1:";
            // 
            // expr1Label1
            // 
            this.expr1Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "Expr1", true));
            this.expr1Label1.Location = new System.Drawing.Point(96, 192);
            this.expr1Label1.Name = "expr1Label1";
            this.expr1Label1.Size = new System.Drawing.Size(100, 23);
            this.expr1Label1.TabIndex = 12;
            // 
            // street_AddressLabel
            // 
            street_AddressLabel.AutoSize = true;
            street_AddressLabel.Location = new System.Drawing.Point(11, 221);
            street_AddressLabel.Name = "street_AddressLabel";
            street_AddressLabel.Size = new System.Drawing.Size(79, 13);
            street_AddressLabel.TabIndex = 13;
            street_AddressLabel.Text = "Street Address:";
            // 
            // street_AddressTextBox
            // 
            this.street_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "Street Address", true));
            this.street_AddressTextBox.Location = new System.Drawing.Point(96, 218);
            this.street_AddressTextBox.Name = "street_AddressTextBox";
            this.street_AddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.street_AddressTextBox.TabIndex = 14;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(11, 247);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 15;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(96, 244);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 16;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(11, 273);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 17;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(96, 270);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 18;
            // 
            // zipcodeLabel
            // 
            zipcodeLabel.AutoSize = true;
            zipcodeLabel.Location = new System.Drawing.Point(11, 299);
            zipcodeLabel.Name = "zipcodeLabel";
            zipcodeLabel.Size = new System.Drawing.Size(49, 13);
            zipcodeLabel.TabIndex = 19;
            zipcodeLabel.Text = "Zipcode:";
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleAdressesAdapterBindingSource, "Zipcode", true));
            this.zipcodeTextBox.Location = new System.Drawing.Point(96, 296);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipcodeTextBox.TabIndex = 20;
            // 
            // peopleAdressesAdapterBindingSource
            // 
            this.peopleAdressesAdapterBindingSource.DataMember = "peopleAdressesAdapter";
            this.peopleAdressesAdapterBindingSource.DataSource = this.airportDatabaseDataSet;
            // 
            // airportDatabaseDataSet
            // 
            this.airportDatabaseDataSet.DataSetName = "airportDatabaseDataSet";
            this.airportDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleAdressesAdapterTableAdapter
            // 
            this.peopleAdressesAdapterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressesTableAdapter = null;
            this.tableAdapterManager.AmenitiesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaggageTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FlightLogTableAdapter = null;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.PlanesTableAdapter = null;
            this.tableAdapterManager.SeatTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirportPortal.airportDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idSearch
            // 
            this.idSearch.Location = new System.Drawing.Point(290, 123);
            this.idSearch.Name = "idSearch";
            this.idSearch.Size = new System.Drawing.Size(75, 23);
            this.idSearch.TabIndex = 21;
            this.idSearch.Text = "Search ID";
            this.idSearch.UseVisualStyleBackColor = true;
            this.idSearch.Click += new System.EventHandler(this.idSearch_Click);
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(276, 90);
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(120, 20);
            this.numericID.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(93, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 13);
            label1.TabIndex = 23;
            label1.Text = "Create Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(278, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 13);
            label2.TabIndex = 24;
            label2.Text = "Search for account";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // peopleCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.numericID);
            this.Controls.Add(this.idSearch);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(employerLabel);
            this.Controls.Add(this.employerTextBox);
            this.Controls.Add(addressIDLabel);
            this.Controls.Add(this.addressIDLabel1);
            this.Controls.Add(expr1Label);
            this.Controls.Add(this.expr1Label1);
            this.Controls.Add(street_AddressLabel);
            this.Controls.Add(this.street_AddressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipcodeLabel);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(this.peopleAdressesAdapterBindingNavigator);
            this.Name = "peopleCreate";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.peopleCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peopleAdressesAdapterBindingNavigator)).EndInit();
            this.peopleAdressesAdapterBindingNavigator.ResumeLayout(false);
            this.peopleAdressesAdapterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleAdressesAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airportDatabaseDataSet airportDatabaseDataSet;
        private System.Windows.Forms.BindingSource peopleAdressesAdapterBindingSource;
        private airportDatabaseDataSetTableAdapters.peopleAdressesAdapterTableAdapter peopleAdressesAdapterTableAdapter;
        private airportDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator peopleAdressesAdapterBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox employerTextBox;
        private System.Windows.Forms.Label addressIDLabel1;
        private System.Windows.Forms.Label expr1Label1;
        private System.Windows.Forms.TextBox street_AddressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.Button idSearch;
        private System.Windows.Forms.NumericUpDown numericID;
        private System.Windows.Forms.Button button1;

    }
}
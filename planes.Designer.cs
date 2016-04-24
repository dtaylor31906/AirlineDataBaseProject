namespace AirportPortal
{
    partial class planes
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label fuelCapicityLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label topSpeedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(planes));
            System.Windows.Forms.Label fuelEconomyLabel;
            this.planesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDatabaseDataSet = new AirportPortal.airportDatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.planesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fuelCapicityTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.topSpeedTextBox = new System.Windows.Forms.TextBox();
            this.planesTableAdapter = new AirportPortal.airportDatabaseDataSetTableAdapters.PlanesTableAdapter();
            this.tableAdapterManager = new AirportPortal.airportDatabaseDataSetTableAdapters.TableAdapterManager();
            this.search = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.planeResetbtn = new System.Windows.Forms.Button();
            this.fuelEconomyTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            fuelCapicityLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            topSpeedLabel = new System.Windows.Forms.Label();
            fuelEconomyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingNavigator)).BeginInit();
            this.planesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(17, 78);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // fuelCapicityLabel
            // 
            fuelCapicityLabel.AutoSize = true;
            fuelCapicityLabel.Location = new System.Drawing.Point(17, 104);
            fuelCapicityLabel.Name = "fuelCapicityLabel";
            fuelCapicityLabel.Size = new System.Drawing.Size(67, 13);
            fuelCapicityLabel.TabIndex = 5;
            fuelCapicityLabel.Text = "fuel Capicity:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(17, 130);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 7;
            weightLabel.Text = "Weight:";
            // 
            // topSpeedLabel
            // 
            topSpeedLabel.AutoSize = true;
            topSpeedLabel.Location = new System.Drawing.Point(17, 156);
            topSpeedLabel.Name = "topSpeedLabel";
            topSpeedLabel.Size = new System.Drawing.Size(59, 13);
            topSpeedLabel.TabIndex = 9;
            topSpeedLabel.Text = "top Speed:";
            // 
            // planesBindingNavigator
            // 
            this.planesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.planesBindingNavigator.BindingSource = this.planesBindingSource;
            this.planesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.planesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.planesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.planesBindingNavigatorSaveItem});
            this.planesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.planesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.planesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.planesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.planesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.planesBindingNavigator.Name = "planesBindingNavigator";
            this.planesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.planesBindingNavigator.Size = new System.Drawing.Size(382, 25);
            this.planesBindingNavigator.TabIndex = 0;
            this.planesBindingNavigator.Text = "bindingNavigator1";
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
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "Planes";
            this.planesBindingSource.DataSource = this.airportDatabaseDataSet;
            // 
            // airportDatabaseDataSet
            // 
            this.airportDatabaseDataSet.DataSetName = "airportDatabaseDataSet";
            this.airportDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // planesBindingNavigatorSaveItem
            // 
            this.planesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.planesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("planesBindingNavigatorSaveItem.Image")));
            this.planesBindingNavigatorSaveItem.Name = "planesBindingNavigatorSaveItem";
            this.planesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.planesBindingNavigatorSaveItem.Text = "Save Data";
            this.planesBindingNavigatorSaveItem.Click += new System.EventHandler(this.planesBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planesBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(90, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // fuelCapicityTextBox
            // 
            this.fuelCapicityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planesBindingSource, "fuelCapicity", true));
            this.fuelCapicityTextBox.Location = new System.Drawing.Point(90, 101);
            this.fuelCapicityTextBox.Name = "fuelCapicityTextBox";
            this.fuelCapicityTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelCapicityTextBox.TabIndex = 6;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planesBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(90, 127);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 8;
            // 
            // topSpeedTextBox
            // 
            this.topSpeedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planesBindingSource, "topSpeed", true));
            this.topSpeedTextBox.Location = new System.Drawing.Point(90, 153);
            this.topSpeedTextBox.Name = "topSpeedTextBox";
            this.topSpeedTextBox.Size = new System.Drawing.Size(100, 20);
            this.topSpeedTextBox.TabIndex = 10;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressesTableAdapter = null;
            this.tableAdapterManager.AmenitiesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaggageTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.FlightLogTableAdapter = null;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.PlanesTableAdapter = this.planesTableAdapter;
            this.tableAdapterManager.SeatTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AirportPortal.airportDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(237, 75);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 11;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(237, 101);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(91, 23);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "Search Name";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plane Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Plane Search";
            // 
            // planeResetbtn
            // 
            this.planeResetbtn.Location = new System.Drawing.Point(243, 130);
            this.planeResetbtn.Name = "planeResetbtn";
            this.planeResetbtn.Size = new System.Drawing.Size(75, 23);
            this.planeResetbtn.TabIndex = 15;
            this.planeResetbtn.Text = "Reset Search";
            this.planeResetbtn.UseVisualStyleBackColor = true;
            this.planeResetbtn.Click += new System.EventHandler(this.planeResetbtn_Click);
            // 
            // fuelEconomyLabel
            // 
            fuelEconomyLabel.AutoSize = true;
            fuelEconomyLabel.Location = new System.Drawing.Point(7, 184);
            fuelEconomyLabel.Name = "fuelEconomyLabel";
            fuelEconomyLabel.Size = new System.Drawing.Size(77, 13);
            fuelEconomyLabel.TabIndex = 16;
            fuelEconomyLabel.Text = "Fuel Economy:";
            // 
            // fuelEconomyTextBox
            // 
            this.fuelEconomyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planesBindingSource, "FuelEconomy", true));
            this.fuelEconomyTextBox.Location = new System.Drawing.Point(90, 181);
            this.fuelEconomyTextBox.Name = "fuelEconomyTextBox";
            this.fuelEconomyTextBox.Size = new System.Drawing.Size(100, 20);
            this.fuelEconomyTextBox.TabIndex = 17;
            // 
            // planes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 262);
            this.Controls.Add(fuelEconomyLabel);
            this.Controls.Add(this.fuelEconomyTextBox);
            this.Controls.Add(this.planeResetbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.search);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(fuelCapicityLabel);
            this.Controls.Add(this.fuelCapicityTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(topSpeedLabel);
            this.Controls.Add(this.topSpeedTextBox);
            this.Controls.Add(this.planesBindingNavigator);
            this.Name = "planes";
            this.Text = "Manage Planes";
            this.Load += new System.EventHandler(this.planes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingNavigator)).EndInit();
            this.planesBindingNavigator.ResumeLayout(false);
            this.planesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private airportDatabaseDataSet airportDatabaseDataSet;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private airportDatabaseDataSetTableAdapters.PlanesTableAdapter planesTableAdapter;
        private airportDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator planesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton planesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox fuelCapicityTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox topSpeedTextBox;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button planeResetbtn;
        private System.Windows.Forms.TextBox fuelEconomyTextBox;
    }
}
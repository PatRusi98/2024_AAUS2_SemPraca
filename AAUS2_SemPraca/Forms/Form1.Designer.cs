namespace AAUS2_SemPraca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Menu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            LoadFromFile = new ToolStripMenuItem();
            SaveToFile = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            parcelToolStripMenuItem = new ToolStripMenuItem();
            InsertParcel = new ToolStripMenuItem();
            SearchParcel = new ToolStripMenuItem();
            FindAllParcels = new ToolStripMenuItem();
            propertyToolStripMenuItem = new ToolStripMenuItem();
            InsertProperty = new ToolStripMenuItem();
            SearchProperty = new ToolStripMenuItem();
            FindAllProperties = new ToolStripMenuItem();
            allObjectsToolStripMenuItem = new ToolStripMenuItem();
            FindObjectByPoint = new ToolStripMenuItem();
            FindAllObjects = new ToolStripMenuItem();
            generatorToolStripMenuItem = new ToolStripMenuItem();
            generateToolStripMenuItem = new ToolStripMenuItem();
            GenerateParcels = new ToolStripMenuItem();
            GenerateProperties = new ToolStripMenuItem();
            GenerateRandomObjects = new ToolStripMenuItem();
            RandomOperations = new ToolStripMenuItem();
            DataGrid = new DataGridView();
            TypeColumn = new DataGridViewTextBoxColumn();
            NumberColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            GPS1Column = new DataGridViewTextBoxColumn();
            GPS2Column = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.ImageScalingSize = new Size(24, 24);
            Menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, parcelToolStripMenuItem, propertyToolStripMenuItem, allObjectsToolStripMenuItem, generatorToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(4, 1, 0, 1);
            Menu.Size = new Size(1578, 24);
            Menu.TabIndex = 0;
            Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LoadFromFile, SaveToFile, Exit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // LoadFromFile
            // 
            LoadFromFile.Name = "LoadFromFile";
            LoadFromFile.Size = new Size(157, 22);
            LoadFromFile.Text = "Load from file...";
            LoadFromFile.Click += LoadFromFile_Click;
            // 
            // SaveToFile
            // 
            SaveToFile.Name = "SaveToFile";
            SaveToFile.Size = new Size(157, 22);
            SaveToFile.Text = "Save to file...";
            SaveToFile.Click += SaveToFile_Click;
            // 
            // Exit
            // 
            Exit.Name = "Exit";
            Exit.Size = new Size(157, 22);
            Exit.Text = "Exit";
            Exit.Click += Exit_Click;
            // 
            // parcelToolStripMenuItem
            // 
            parcelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InsertParcel, SearchParcel, FindAllParcels });
            parcelToolStripMenuItem.Name = "parcelToolStripMenuItem";
            parcelToolStripMenuItem.Size = new Size(51, 22);
            parcelToolStripMenuItem.Text = "Parcel";
            // 
            // InsertParcel
            // 
            InsertParcel.Name = "InsertParcel";
            InsertParcel.Size = new Size(114, 22);
            InsertParcel.Text = "Insert";
            InsertParcel.Click += InsertParcel_Click;
            // 
            // SearchParcel
            // 
            SearchParcel.Name = "SearchParcel";
            SearchParcel.Size = new Size(114, 22);
            SearchParcel.Text = "Search";
            SearchParcel.Click += SearchParcel_Click;
            // 
            // FindAllParcels
            // 
            FindAllParcels.Name = "FindAllParcels";
            FindAllParcels.Size = new Size(114, 22);
            FindAllParcels.Text = "Find All";
            FindAllParcels.Click += FindAllParcels_Click;
            // 
            // propertyToolStripMenuItem
            // 
            propertyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InsertProperty, SearchProperty, FindAllProperties });
            propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            propertyToolStripMenuItem.Size = new Size(64, 22);
            propertyToolStripMenuItem.Text = "Property";
            // 
            // InsertProperty
            // 
            InsertProperty.Name = "InsertProperty";
            InsertProperty.Size = new Size(114, 22);
            InsertProperty.Text = "Insert";
            InsertProperty.Click += InsertProperty_Click;
            // 
            // SearchProperty
            // 
            SearchProperty.Name = "SearchProperty";
            SearchProperty.Size = new Size(114, 22);
            SearchProperty.Text = "Search";
            SearchProperty.Click += SearchProperty_Click;
            // 
            // FindAllProperties
            // 
            FindAllProperties.Name = "FindAllProperties";
            FindAllProperties.Size = new Size(114, 22);
            FindAllProperties.Text = "Find All";
            FindAllProperties.Click += FindAllProperties_Click;
            // 
            // allObjectsToolStripMenuItem
            // 
            allObjectsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FindObjectByPoint, FindAllObjects });
            allObjectsToolStripMenuItem.Name = "allObjectsToolStripMenuItem";
            allObjectsToolStripMenuItem.Size = new Size(76, 22);
            allObjectsToolStripMenuItem.Text = "All Objects";
            // 
            // FindObjectByPoint
            // 
            FindObjectByPoint.AutoSize = false;
            FindObjectByPoint.ImageScaling = ToolStripItemImageScaling.None;
            FindObjectByPoint.Name = "FindObjectByPoint";
            FindObjectByPoint.Size = new Size(180, 22);
            FindObjectByPoint.Text = "Find by point";
            FindObjectByPoint.Click += FindObjectByPoint_Click;
            // 
            // FindAllObjects
            // 
            FindAllObjects.Name = "FindAllObjects";
            FindAllObjects.Size = new Size(180, 22);
            FindAllObjects.Text = "Find all objects";
            FindAllObjects.Click += FindAllObjects_Click;
            // 
            // generatorToolStripMenuItem
            // 
            generatorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateToolStripMenuItem, RandomOperations });
            generatorToolStripMenuItem.Name = "generatorToolStripMenuItem";
            generatorToolStripMenuItem.Size = new Size(71, 22);
            generatorToolStripMenuItem.Text = "Generator";
            // 
            // generateToolStripMenuItem
            // 
            generateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GenerateParcels, GenerateProperties, GenerateRandomObjects });
            generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            generateToolStripMenuItem.Size = new Size(178, 22);
            generateToolStripMenuItem.Text = "Generate...";
            // 
            // GenerateParcels
            // 
            GenerateParcels.Name = "GenerateParcels";
            GenerateParcels.Size = new Size(160, 22);
            GenerateParcels.Text = "Parcels";
            GenerateParcels.Click += GenerateParcels_Click;
            // 
            // GenerateProperties
            // 
            GenerateProperties.Name = "GenerateProperties";
            GenerateProperties.Size = new Size(160, 22);
            GenerateProperties.Text = "Properties";
            GenerateProperties.Click += GenerateProperties_Click;
            // 
            // GenerateRandomObjects
            // 
            GenerateRandomObjects.Name = "GenerateRandomObjects";
            GenerateRandomObjects.Size = new Size(160, 22);
            GenerateRandomObjects.Text = "Random objects";
            GenerateRandomObjects.Click += GenerateRandomObjects_Click;
            // 
            // RandomOperations
            // 
            RandomOperations.Name = "RandomOperations";
            RandomOperations.Size = new Size(178, 22);
            RandomOperations.Text = "Random operations";
            RandomOperations.Click += RandomOperations_Click;
            // 
            // DataGrid
            // 
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { TypeColumn, NumberColumn, DescriptionColumn, GPS1Column, GPS2Column, Details });
            DataGrid.Location = new Point(8, 22);
            DataGrid.Margin = new Padding(2);
            DataGrid.MaximumSize = new Size(1565, 828);
            DataGrid.MinimumSize = new Size(1565, 828);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 62;
            DataGrid.Size = new Size(1565, 828);
            DataGrid.TabIndex = 1;
            DataGrid.CellContentClick += DataGrid_CellContentClick;
            // 
            // TypeColumn
            // 
            TypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TypeColumn.FillWeight = 85.9090958F;
            TypeColumn.HeaderText = "Type";
            TypeColumn.MinimumWidth = 150;
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            TypeColumn.Width = 150;
            // 
            // NumberColumn
            // 
            NumberColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NumberColumn.FillWeight = 85.9090958F;
            NumberColumn.HeaderText = "Number";
            NumberColumn.MinimumWidth = 150;
            NumberColumn.Name = "NumberColumn";
            NumberColumn.ReadOnly = true;
            NumberColumn.Width = 150;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.FillWeight = 85.9090958F;
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.MinimumWidth = 8;
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.ReadOnly = true;
            // 
            // GPS1Column
            // 
            GPS1Column.FillWeight = 85.9090958F;
            GPS1Column.HeaderText = "GPS LL";
            GPS1Column.MinimumWidth = 8;
            GPS1Column.Name = "GPS1Column";
            GPS1Column.ReadOnly = true;
            // 
            // GPS2Column
            // 
            GPS2Column.FillWeight = 85.9090958F;
            GPS2Column.HeaderText = "GPS UR";
            GPS2Column.MinimumWidth = 8;
            GPS2Column.Name = "GPS2Column";
            GPS2Column.ReadOnly = true;
            // 
            // Details
            // 
            Details.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Details.FillWeight = 170.454544F;
            Details.HeaderText = "Details";
            Details.MinimumWidth = 100;
            Details.Name = "Details";
            Details.Text = "Details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 867);
            Controls.Add(DataGrid);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Margin = new Padding(2);
            MaximumSize = new Size(1598, 906);
            MinimumSize = new Size(1347, 634);
            Name = "Form1";
            Text = "AAUS2 SemPraca";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGrid;
        private MenuStrip Menu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem parcelToolStripMenuItem;
        private ToolStripMenuItem propertyToolStripMenuItem;
        private ToolStripMenuItem LoadFromFile;
        private ToolStripMenuItem SaveToFile;
        private ToolStripMenuItem Exit;
        private ToolStripMenuItem InsertParcel;
        private ToolStripMenuItem SearchParcel;
        private ToolStripMenuItem InsertProperty;
        private ToolStripMenuItem SearchProperty;
        private ToolStripMenuItem allObjectsToolStripMenuItem;
        private ToolStripMenuItem FindObjectByPoint;
        private ToolStripMenuItem FindAllObjects;
        private ToolStripMenuItem generatorToolStripMenuItem;
        private ToolStripMenuItem generateToolStripMenuItem;
        private ToolStripMenuItem GenerateParcels;
        private ToolStripMenuItem GenerateProperties;
        private ToolStripMenuItem GenerateRandomObjects;
        private ToolStripMenuItem RandomOperations;
        private ToolStripMenuItem FindAllParcels;
        private ToolStripMenuItem FindAllProperties;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private DataGridViewTextBoxColumn GPS1Column;
        private DataGridViewTextBoxColumn GPS2Column;
        private DataGridViewButtonColumn Details;
    }
}

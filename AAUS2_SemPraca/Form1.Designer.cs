﻿namespace AAUS2_SemPraca
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
            NewProject = new ToolStripMenuItem();
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
            allObjectsToolStripMenuItem1 = new ToolStripMenuItem();
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
            ActionsColumn = new DataGridViewComboBoxColumn();
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
            Menu.Size = new Size(1584, 24);
            Menu.TabIndex = 0;
            Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewProject, LoadFromFile, SaveToFile, Exit });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 22);
            fileToolStripMenuItem.Text = "File";
            // 
            // NewProject
            // 
            NewProject.Name = "NewProject";
            NewProject.Size = new Size(157, 22);
            NewProject.Text = "New project";
            NewProject.Click += NewProject_Click;
            // 
            // LoadFromFile
            // 
            LoadFromFile.Name = "LoadFromFile";
            LoadFromFile.Size = new Size(157, 22);
            LoadFromFile.Text = "Load from file...";
            // 
            // SaveToFile
            // 
            SaveToFile.Name = "SaveToFile";
            SaveToFile.Size = new Size(157, 22);
            SaveToFile.Text = "Save to file...";
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
            // 
            // SearchParcel
            // 
            SearchParcel.Name = "SearchParcel";
            SearchParcel.Size = new Size(114, 22);
            SearchParcel.Text = "Search";
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
            propertyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InsertProperty, SearchProperty, FindAllProperties, allObjectsToolStripMenuItem1 });
            propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            propertyToolStripMenuItem.Size = new Size(64, 22);
            propertyToolStripMenuItem.Text = "Property";
            // 
            // InsertProperty
            // 
            InsertProperty.Name = "InsertProperty";
            InsertProperty.Size = new Size(131, 22);
            InsertProperty.Text = "Insert";
            // 
            // SearchProperty
            // 
            SearchProperty.Name = "SearchProperty";
            SearchProperty.Size = new Size(131, 22);
            SearchProperty.Text = "Search";
            // 
            // FindAllProperties
            // 
            FindAllProperties.Name = "FindAllProperties";
            FindAllProperties.Size = new Size(131, 22);
            FindAllProperties.Text = "Find All";
            FindAllProperties.Click += FindAllProperties_Click;
            // 
            // allObjectsToolStripMenuItem1
            // 
            allObjectsToolStripMenuItem1.Name = "allObjectsToolStripMenuItem1";
            allObjectsToolStripMenuItem1.Size = new Size(180, 22);
            allObjectsToolStripMenuItem1.Text = "All Objects";
            allObjectsToolStripMenuItem1.Click += allObjectsToolStripMenuItem1_Click;
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
            FindAllObjects.Size = new Size(153, 22);
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
            // 
            // GenerateProperties
            // 
            GenerateProperties.Name = "GenerateProperties";
            GenerateProperties.Size = new Size(160, 22);
            GenerateProperties.Text = "Properties";
            // 
            // GenerateRandomObjects
            // 
            GenerateRandomObjects.Name = "GenerateRandomObjects";
            GenerateRandomObjects.Size = new Size(160, 22);
            GenerateRandomObjects.Text = "Random objects";
            // 
            // RandomOperations
            // 
            RandomOperations.Name = "RandomOperations";
            RandomOperations.Size = new Size(178, 22);
            RandomOperations.Text = "Random operations";
            // 
            // DataGrid
            // 
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { TypeColumn, NumberColumn, DescriptionColumn, GPS1Column, GPS2Column, ActionsColumn });
            DataGrid.Location = new Point(8, 22);
            DataGrid.Margin = new Padding(2);
            DataGrid.MaximumSize = new Size(1565, 828);
            DataGrid.MinimumSize = new Size(1565, 828);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 62;
            DataGrid.Size = new Size(1565, 828);
            DataGrid.TabIndex = 1;
            // 
            // TypeColumn
            // 
            TypeColumn.HeaderText = "Type";
            TypeColumn.Name = "TypeColumn";
            TypeColumn.ReadOnly = true;
            // 
            // NumberColumn
            // 
            NumberColumn.HeaderText = "Number";
            NumberColumn.Name = "NumberColumn";
            NumberColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.ReadOnly = true;
            // 
            // GPS1Column
            // 
            GPS1Column.HeaderText = "GPS LL";
            GPS1Column.Name = "GPS1Column";
            GPS1Column.ReadOnly = true;
            // 
            // GPS2Column
            // 
            GPS2Column.HeaderText = "GPS UR";
            GPS2Column.Name = "GPS2Column";
            GPS2Column.ReadOnly = true;
            // 
            // ActionsColumn
            // 
            ActionsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ActionsColumn.HeaderText = "Actions";
            ActionsColumn.Name = "ActionsColumn";
            ActionsColumn.Width = 53;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1584, 861);
            Controls.Add(DataGrid);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Margin = new Padding(2);
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1600, 900);
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
        private ToolStripMenuItem NewProject;
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
        private ToolStripMenuItem allObjectsToolStripMenuItem1;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewTextBoxColumn NumberColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private DataGridViewTextBoxColumn GPS1Column;
        private DataGridViewTextBoxColumn GPS2Column;
        private DataGridViewComboBoxColumn ActionsColumn;
    }
}

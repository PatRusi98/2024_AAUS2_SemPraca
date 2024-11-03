using AAUS2_SemPraca.Forms;
using AAUS2_SemPraca.Objects;
using AAUS2_SemPraca.Utils;

namespace AAUS2_SemPraca
{
    public partial class Form1 : Form
    {
        private readonly SemProject _project;

        public Form1()
        {
            InitializeComponent();
            _project = SemProject.Instance;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FindAllObjects_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            var dataSource = _project.GetAllEntities();
            foreach (var entity in dataSource)
            {
                if (entity != null)
                {
                    int rowIndex = DataGrid.Rows.Add(entity.Type, entity.Number, entity.Description, entity.Point1, entity.Point2, entity);
                    DataGrid.Rows[rowIndex].Tag = entity;
                    DataGrid.Rows[rowIndex].Cells["Details"].Value = "Action";
                }
            }
        }

        private void FindObjectByPoint_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            using (var searchForm = new SearchForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    var lat = searchForm.Latitude;
                    var lon = searchForm.Longitude;
                    var latCoord = searchForm.LatCoord.GetDescription().First();
                    var lonCoord = searchForm.LongCoord.GetDescription().First();

                    var dataSource = _project.SearchAllObjectsOnLocation(lat, latCoord, lon, lonCoord);
                    foreach (var entity in dataSource)
                    {
                        if (entity != null)
                        {
                            int rowIndex = DataGrid.Rows.Add(entity.Type, entity.Number, entity.Description, entity.Point1, entity.Point2, entity);
                            DataGrid.Rows[rowIndex].Tag = entity;
                            DataGrid.Rows[rowIndex].Cells["Details"].Value = "Action";
                        }
                    }
                }
            }
        }

        private void FindAllProperties_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            var dataSource = _project.GetAllProperties();
            foreach (var entity in dataSource)
            {
                if (entity != null)
                {
                    int rowIndex = DataGrid.Rows.Add(entity.Type, entity.Number, entity.Description, entity.Point1, entity.Point2, entity);
                    DataGrid.Rows[rowIndex].Tag = entity;
                    DataGrid.Rows[rowIndex].Cells["Details"].Value = "Action";
                }
            }
        }

        private void FindAllParcels_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            var dataSource = _project.GetAllParcels();
            foreach (var entity in dataSource)
            {
                if (entity != null)
                {
                    int rowIndex = DataGrid.Rows.Add(entity.Type, entity.Number, entity.Description, entity.Point1, entity.Point2, entity);
                    DataGrid.Rows[rowIndex].Tag = entity;
                    DataGrid.Rows[rowIndex].Cells["Details"].Value = "Action";
                }
            }
        }

        private void RandomOperations_Click(object sender, EventArgs e)
        {
            using (var testerForm = new TesterForm())
            {
                if (testerForm.ShowDialog() == DialogResult.OK)
                {
                    var numberOfOperations = testerForm.NumberOfOperations;
                    var insertProb = testerForm.InsertProbability;
                    var searchProb = testerForm.SearchProbability;
                    var deleteProb = testerForm.DeleteProbability;

                    _project.Test(numberOfOperations, insertProb, searchProb, deleteProb);
                }
            }
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save file";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        _project.SaveToFile(filePath);
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                openFileDialog.Title = "Load CSV file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        _project.LoadFromFile(filePath);
                        MessageBox.Show("CSV file loaded succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void InsertParcel_Click(object sender, EventArgs e)
        {
            using (var insertForm = new InsertForm())
            {
                if (insertForm.ShowDialog() == DialogResult.OK)
                {
                    var number = insertForm.Number;
                    var desc = insertForm.Description;
                    var lat1 = insertForm.Latitude1;
                    var lat2 = insertForm.Latitude2;
                    var latCoord1 = insertForm.LatCoord1.GetDescription().First();
                    var latCoord2 = insertForm.LatCoord2.GetDescription().First();
                    var long1 = insertForm.Longitude1;
                    var long2 = insertForm.Longitude2;
                    var longCoord1 = insertForm.LongCoord1.GetDescription().First();
                    var longCoord2 = insertForm.LongCoord2.GetDescription().First();

                    _project.AddParcel(number, desc, lat1, latCoord1, long1, longCoord1, lat2, latCoord2, long2, longCoord2);
                }
            }
        }

        private void GenerateParcels_Click(object sender, EventArgs e)
        {
            using (var generatorForm = new GeneratorForm())
            {
                if (generatorForm.ShowDialog() == DialogResult.OK)
                {
                    var numberOfObjects = generatorForm.NumberOfObjects;
                    _project.GenerateRandomParcels(numberOfObjects);
                }
            }
        }

        private void GenerateProperties_Click(object sender, EventArgs e)
        {
            using (var generatorForm = new GeneratorForm())
            {
                if (generatorForm.ShowDialog() == DialogResult.OK)
                {
                    var numberOfObjects = generatorForm.NumberOfObjects;
                    _project.GenerateRandomProperties(numberOfObjects);
                }
            }
        }

        private void GenerateRandomObjects_Click(object sender, EventArgs e)
        {
            using (var generatorForm = new GeneratorForm())
            {
                if (generatorForm.ShowDialog() == DialogResult.OK)
                {
                    var numberOfObjects = generatorForm.NumberOfObjects;
                    var intersection = generatorForm.IntersectionProbability;
                    _project.GenerateRandomEntities(numberOfObjects, intersection);
                }
            }
        }

        private void InsertProperty_Click(object sender, EventArgs e)
        {
            using (var insertForm = new InsertForm())
            {
                if (insertForm.ShowDialog() == DialogResult.OK)
                {
                    var number = insertForm.Number;
                    var desc = insertForm.Description;
                    var lat1 = insertForm.Latitude1;
                    var lat2 = insertForm.Latitude2;
                    var latCoord1 = insertForm.LatCoord1.GetDescription().First();
                    var latCoord2 = insertForm.LatCoord2.GetDescription().First();
                    var long1 = insertForm.Longitude1;
                    var long2 = insertForm.Longitude2;
                    var longCoord1 = insertForm.LongCoord1.GetDescription().First();
                    var longCoord2 = insertForm.LongCoord2.GetDescription().First();

                    _project.AddProperty(number, desc, lat1, latCoord1, long1, longCoord1, lat2, latCoord2, long2, longCoord2);
                }
            }
        }

        private void SearchProperty_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            using (var searchForm = new SearchForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    var lat = searchForm.Latitude;
                    var lon = searchForm.Longitude;
                    var latCoord = searchForm.LatCoord.GetDescription().First();
                    var lonCoord = searchForm.LongCoord.GetDescription().First();

                    var dataSource = _project.SearchAllPropertiesOnLocation(lat, latCoord, lon, lonCoord);
                    foreach (var entity in dataSource)
                    {
                        if (entity != null)
                        {
                            int rowIndex = DataGrid.Rows.Add(entity.Type, entity.Number, entity.Description, entity.Point1, entity.Point2, entity);
                            DataGrid.Rows[rowIndex].Tag = entity;
                            DataGrid.Rows[rowIndex].Cells["Details"].Value = "Action";
                        }
                    }
                }
            }
        }

        private void SearchParcel_Click(object sender, EventArgs e)
        {
            DataGrid.Rows.Clear();
            using (var searchForm = new SearchForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    var lat = searchForm.Latitude;
                    var lon = searchForm.Longitude;
                    var latCoord = searchForm.LatCoord.GetDescription().First();
                    var lonCoord = searchForm.LongCoord.GetDescription().First();

                    var dataSource = _project.SearchAllParcelsOnLocation(lat, latCoord, lon, lonCoord);
                    foreach (var entity in dataSource)
                    {
                        if (entity != null)
                        {
                            int rowIndex = DataGrid.Rows.Add(entity.Type, entity.Number, entity.Description, entity.Point1, entity.Point2, entity);
                            DataGrid.Rows[rowIndex].Tag = entity;
                            DataGrid.Rows[rowIndex].Cells["Details"].Value = "Action";
                        }
                    }
                }
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGrid.Columns["Details"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DataGrid.Rows[e.RowIndex];
                GeoEntity geoEntity = selectedRow.Tag as GeoEntity;

                if (selectedRow.Cells["TypeColumn"].Value == null)
                   return;

                if (selectedRow.Cells["TypeColumn"].Value.ToString() == "Parcel")
                    geoEntity = (Parcel)geoEntity;
                else if (selectedRow.Cells["TypeColumn"].Value.ToString() == "Property")
                    geoEntity = (Property)geoEntity;

                using (var detailsForm = new DetailsForm(selectedRow, geoEntity))
                {
                    if (detailsForm.ShowDialog() == DialogResult.OK)
                    {
                        var number = detailsForm.Number;
                        var desc = detailsForm.Description;
                        var lat1 = detailsForm.Latitude1;
                        var lat2 = detailsForm.Latitude2;
                        var latCoord1 = detailsForm.Lat1Coord.GetDescription().First();
                        var latCoord2 = detailsForm.Lat2Coord.GetDescription().First();
                        var long1 = detailsForm.Longitude1;
                        var long2 = detailsForm.Longitude2;
                        var longCoord1 = detailsForm.Long1Coord.GetDescription().First();
                        var longCoord2 = detailsForm.Long2Coord.GetDescription().First();

                        selectedRow.Cells["NumberColumn"].Value = number;
                        selectedRow.Cells["DescriptionColumn"].Value = desc;
                        selectedRow.Cells["GPS1Column"].Value = lat1 + "~" + detailsForm.Lat1Coord.GetDescription() + "~" + long1 + "~" + detailsForm.Long1Coord.GetDescription();
                        selectedRow.Cells["GPS2Column"].Value = lat2 + "~" + detailsForm.Lat2Coord.GetDescription() + "~" + long2 + "~" + detailsForm.Long2Coord.GetDescription();

                        if (geoEntity is Parcel parcel)
                        {
                            _project.DeleteParcel(parcel);
                            _project.AddParcel(number, desc, lat1, latCoord1, long1, longCoord1, lat2, latCoord2, long2, longCoord2);
                        }
                        else if (geoEntity is Property property)
                        {
                            _project.DeleteProperty(property);
                            _project.AddProperty(number, desc, lat1, latCoord1, long1, longCoord1, lat2, latCoord2, long2, longCoord2);
                        }
                    }
                }
            }
        }
    }
}

using AAUS2_SemPraca.Forms;

namespace AAUS2_SemPraca
{
    public partial class Form1 : Form
    {
        private readonly SemProject _project;

        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FindAllObjects_Click(object sender, EventArgs e)
        {
            var dataSource = _project.GetAllEntities();
        }

        private void FindObjectByPoint_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: implement
                }
            }
        }

        private void FindAllProperties_Click(object sender, EventArgs e)
        {
            var dataSource = _project.GetAllProperties();
        }

        private void FindAllParcels_Click(object sender, EventArgs e)
        {
            var dataSource = _project.GetAllParcels();
        }

        private void RandomOperations_Click(object sender, EventArgs e)
        {
            using (var testerForm = new TesterForm())
            {
                if (testerForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: implement
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
                    //TODO: implement
                }
            }
        }

        private void GenerateParcels_Click(object sender, EventArgs e)
        {
            using (var generatorForm = new GeneratorForm())
            {
                if (generatorForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: implement
                }
            }
        }

        private void GenerateProperties_Click(object sender, EventArgs e)
        {
            using (var generatorForm = new GeneratorForm())
            {
                if (generatorForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: implement
                }
            }
        }

        private void GenerateRandomObjects_Click(object sender, EventArgs e)
        {
            using (var generatorForm = new GeneratorForm())
            {
                if (generatorForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: implement
                }
            }
        }

        private void InsertProperty_Click(object sender, EventArgs e)
        {
            using (var insertForm = new InsertForm())
            {
                if (insertForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: implement
                }
            }
        }

        private void SearchProperty_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: implement
                }
            }
        }

        private void SearchParcel_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    //TODO: implement
                }
            }
        }
    }
}

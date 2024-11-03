using AAUS2_SemPraca.Objects;
using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca
{
    public partial class DetailsForm : Form
    {
        public int Number { get; private set; }
        public string Description { get; private set; }
        public double Latitude1 { get; private set; }
        public Coordinate Lat1Coord { get; private set; }
        public double Longitude1 { get; private set; }
        public Coordinate Long1Coord { get; private set; }
        public double Latitude2 { get; private set; }
        public Coordinate Lat2Coord { get; private set; }
        public double Longitude2 { get; private set; }
        public Coordinate Long2Coord { get; private set; }
        private bool EditMode { get; set; }
        private GeoEntity SelectedEntity { get; set; }
        private readonly SemProject _project;

        public DetailsForm(DataGridViewRow selectedRow, GeoEntity selected)
        {
            InitializeComponent();
            _project = SemProject.Instance;

            NumberInput.Controls[0].Hide();
            Latitude1Input.Controls[0].Hide();
            Longitude1Input.Controls[0].Hide();
            Latitude2Input.Controls[0].Hide();
            Longitude2Input.Controls[0].Hide();
            EditButton.Enabled = false;
            Lat1CoordInput.Enabled = false;
            Long1CoordInput.Enabled = false;
            Lat2CoordInput.Enabled = false;
            Long2CoordInput.Enabled = false;
            Lat1CoordInput.Items.AddRange([Coordinate.North, Coordinate.South]);
            Long1CoordInput.Items.AddRange([Coordinate.East, Coordinate.West]);
            Lat2CoordInput.Items.AddRange([Coordinate.North, Coordinate.South]);
            Long2CoordInput.Items.AddRange([Coordinate.East, Coordinate.West]);

            SelectedEntity = selected;

            Number = (int)selectedRow.Cells["NumberColumn"].Value;
            Description = (string)selectedRow.Cells["DescriptionColumn"].Value;

            var point1 = selectedRow.Cells["GPS1Column"].Value.ToString().Split('~');
            var point2 = selectedRow.Cells["GPS2Column"].Value.ToString().Split('~');

            listBox1.DataSource = selected.SubAreas;

            Latitude1 = Double.Parse(point1[0]);
            Lat1Coord = (Coordinate)Enum.Parse(typeof(Coordinate), point1[1]);
            Longitude1 = Double.Parse(point1[2]);
            Long1Coord = (Coordinate)Enum.Parse(typeof(Coordinate), point1[3]);

            Latitude2 = Double.Parse(point2[0]);
            Lat2Coord = (Coordinate)Enum.Parse(typeof(Coordinate), point2[1]);
            Longitude2 = Double.Parse(point2[2]);
            Long2Coord = (Coordinate)Enum.Parse(typeof(Coordinate), point2[3]);

            NumberInput.Value = Number;
            DescriptionInput.Text = Description;
            Latitude1Input.Value = (decimal)Latitude1;
            Lat1CoordInput.SelectedItem = Lat1Coord;
            Longitude1Input.Value = (decimal)Longitude1;
            Long1CoordInput.SelectedItem = Long1Coord;
            Latitude2Input.Value = (decimal)Latitude2;
            Lat2CoordInput.SelectedItem = Lat2Coord;
            Longitude2Input.Value = (decimal)Longitude2;
            Long2CoordInput.SelectedItem = Long2Coord;
        }

        private bool ValidateInputs()
        {
            if (NumberInput.Value < NumberInput.Minimum || NumberInput.Value > NumberInput.Maximum)
            {
                MessageBox.Show($"Enter number between {NumberInput.Minimum} and {NumberInput.Maximum}.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NumberInput.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(DescriptionInput.Text))
            {
                MessageBox.Show("Please, enter valid text.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DescriptionInput.Focus();
                return false;
            }

            if (Latitude1Input.Value < Latitude1Input.Minimum || Latitude1Input.Value > Latitude1Input.Maximum)
            {
                MessageBox.Show($"Enter number between {Latitude1Input.Minimum} and {Latitude1Input.Maximum}.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Latitude1Input.Focus();
                return false;
            }

            if (Lat1CoordInput.SelectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte kategóriu.", "Neplatný vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Lat1CoordInput.Focus();
                return false;
            }

            if (Longitude1Input.Value < Longitude1Input.Minimum || Longitude1Input.Value > Longitude1Input.Maximum)
            {
                MessageBox.Show($"Enter number between {Longitude1Input.Minimum} and {Longitude1Input.Maximum}.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Longitude1Input.Focus();
                return false;
            }

            if (Long1CoordInput.SelectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte kategóriu.", "Neplatný vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Long1CoordInput.Focus();
                return false;
            }

            if (Latitude2Input.Value < Latitude2Input.Minimum || Latitude2Input.Value > Latitude2Input.Maximum)
            {
                MessageBox.Show($"Enter number between {Latitude2Input.Minimum} and {Latitude2Input.Maximum}.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Latitude2Input.Focus();
                return false;
            }

            if (Lat2CoordInput.SelectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte kategóriu.", "Neplatný vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Lat2CoordInput.Focus();
                return false;
            }

            if (Longitude2Input.Value < Longitude2Input.Minimum || Longitude2Input.Value > Longitude2Input.Maximum)
            {
                MessageBox.Show($"Enter number between {Longitude2Input.Minimum} and {Longitude2Input.Maximum}.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Longitude2Input.Focus();
                return false;
            }

            if (Long2CoordInput.SelectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte kategóriu.", "Neplatný vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Long2CoordInput.Focus();
                return false;
            }

            return true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() && EditMode)
            {
                Number = (int)NumberInput.Value;
                Description = DescriptionInput.Text;
                Latitude1 = (double)Latitude1Input.Value;
                Lat1Coord = (Coordinate)Lat1CoordInput.SelectedItem;
                Longitude1 = (double)Longitude1Input.Value;
                Long1Coord = (Coordinate)Long1CoordInput.SelectedItem;
                Latitude2 = (double)Latitude2Input.Value;
                Lat2Coord = (Coordinate)Lat2CoordInput.SelectedItem;
                Longitude2 = (double)Longitude2Input.Value;
                Long2Coord = (Coordinate)Long2CoordInput.SelectedItem;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
         {
            if (SelectedEntity is Parcel parcel)
                _project.DeleteParcel(parcel);
            else if (SelectedEntity is Property property)
                _project.DeleteProperty(property);
        }

        private void EditCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            EditMode = EditCheckBox.Checked;

            if (EditMode)
            {
                NumberInput.Controls[0].Show();
                Latitude1Input.Controls[0].Show();
                Longitude1Input.Controls[0].Show();
                Latitude2Input.Controls[0].Show();
                Longitude2Input.Controls[0].Show();
            }
            else
            {
                NumberInput.Controls[0].Hide();
                Latitude1Input.Controls[0].Hide();
                Longitude1Input.Controls[0].Hide();
                Latitude2Input.Controls[0].Hide();
                Longitude2Input.Controls[0].Hide();
            }

            NumberInput.ReadOnly = !EditMode;
            DescriptionInput.ReadOnly = !EditMode;
            Latitude1Input.ReadOnly = !EditMode;
            Lat1CoordInput.Enabled = EditMode;
            Longitude1Input.ReadOnly = !EditMode;
            Long1CoordInput.Enabled = EditMode;
            Latitude2Input.ReadOnly = !EditMode;
            Lat2CoordInput.Enabled = EditMode;
            Longitude2Input.ReadOnly = !EditMode;
            Long2CoordInput.Enabled = EditMode;
            EditButton.Enabled = EditMode;
        }
    }
}

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

        public DetailsForm()
        {
            InitializeComponent();

            Lat1CoordInput.Items.AddRange([Coordinate.North, Coordinate.South]);
            Long1CoordInput.Items.AddRange([Coordinate.East, Coordinate.West]);
            Lat2CoordInput.Items.AddRange([Coordinate.North, Coordinate.South]);
            Long2CoordInput.Items.AddRange([Coordinate.East, Coordinate.West]);
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
            if (ValidateInputs())
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
    }
}

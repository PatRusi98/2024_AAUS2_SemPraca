using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca
{
    public partial class InsertForm : Form
    {
        public int Number { get; private set; }
        public string Description { get; private set; }
        public double Latitude1 { get; private set; }
        public Coordinate LatCoord1 { get; private set; }
        public double Longitude1 { get; private set; }
        public Coordinate LongCoord1 { get; private set; }
        public double Latitude2 { get; private set; }
        public Coordinate LatCoord2 { get; private set; }
        public double Longitude2 { get; private set; }
        public Coordinate LongCoord2 { get; private set; }

        public InsertForm()
        {
            InitializeComponent();

            Lat1CoordInput.Items.AddRange([Coordinate.North, Coordinate.South]);
            Lat1CoordInput.SelectedIndex = 0;
            Long1CoordInput.Items.AddRange([Coordinate.East, Coordinate.West]);
            Long1CoordInput.SelectedIndex = 0;
            Lat2CoordInput.Items.AddRange([Coordinate.North, Coordinate.South]);
            Lat2CoordInput.SelectedIndex = 0;
            Long2CoordInput.Items.AddRange([Coordinate.East, Coordinate.West]);
            Long2CoordInput.SelectedIndex = 0;
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void latitude1_Click(object sender, EventArgs e)
        {

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

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            { 
                Number = (int)NumberInput.Value;
                Description = DescriptionInput.Text;
                Latitude1 = (double)Latitude1Input.Value;
                LatCoord1 = (Coordinate)Lat1CoordInput.SelectedItem;
                Longitude1 = (double)Longitude1Input.Value;
                LongCoord1 = (Coordinate)Long1CoordInput.SelectedItem;
                Latitude2 = (double)Latitude2Input.Value;
                LatCoord2 = (Coordinate)Lat2CoordInput.SelectedItem;
                Longitude2 = (double)Longitude2Input.Value;
                LongCoord2 = (Coordinate)Long2CoordInput.SelectedItem;

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

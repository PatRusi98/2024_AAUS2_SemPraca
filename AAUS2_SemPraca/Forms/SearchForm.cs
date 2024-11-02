using static AAUS2_SemPraca.Utils.Enums;

namespace AAUS2_SemPraca.Forms
{
    public partial class SearchForm : Form
    {
        public double Latitude { get; private set; }
        public Coordinate LatCoord { get; private set; }
        public double Longitude { get; private set; }
        public Coordinate LongCoord { get; private set; }

        public SearchForm()
        {
            InitializeComponent();

            LatCoordInput.Items.AddRange([Coordinate.North, Coordinate.South]);
            LatCoordInput.SelectedIndex = 0;
            LongCoordInput.Items.AddRange([Coordinate.East, Coordinate.West]);
            LongCoordInput.SelectedIndex = 0;
        }

        private bool ValidateInputs()
        {
            if (LatitudeInput.Value < LatitudeInput.Minimum || LatitudeInput.Value > LatitudeInput.Maximum)
            {
                MessageBox.Show($"Enter number between {LatitudeInput.Minimum} and {LatitudeInput.Maximum}.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LatitudeInput.Focus();
                return false;
            }

            if (LatCoordInput.SelectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte kategóriu.", "Neplatný vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LatCoordInput.Focus();
                return false;
            }

            if (LongitudeInput.Value < LongitudeInput.Minimum || LongitudeInput.Value > LongitudeInput.Maximum)
            {
                MessageBox.Show($"Enter number between {LongitudeInput.Minimum} and {LongitudeInput.Maximum}.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LongitudeInput.Focus();
                return false;
            }

            if (LongCoordInput.SelectedItem == null)
            {
                MessageBox.Show("Prosím, vyberte kategóriu.", "Neplatný vstup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LongCoordInput.Focus();
                return false;
            }

            return true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Latitude = (double)LatitudeInput.Value;
                LatCoord = (Coordinate)LatCoordInput.SelectedItem;
                Longitude = (double)LongitudeInput.Value;
                LongCoord = (Coordinate)LongCoordInput.SelectedItem;

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}

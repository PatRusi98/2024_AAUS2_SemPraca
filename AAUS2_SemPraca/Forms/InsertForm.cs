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
    }
}

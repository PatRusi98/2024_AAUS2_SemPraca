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
        }
    }
}

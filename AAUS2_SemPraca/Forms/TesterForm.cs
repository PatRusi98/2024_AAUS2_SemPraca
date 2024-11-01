namespace AAUS2_SemPraca.Forms
{
    public partial class TesterForm : Form
    {
        public int NumberOfOperations { get; private set; }
        public double InsertProbability { get; private set; }
        public double SearchProbability { get; private set; }
        public double DeleteProbability { get; private set; }

        public TesterForm()
        {
            InitializeComponent();
        }
    }
}

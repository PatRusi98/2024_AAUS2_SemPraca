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

        private void NewProject_Click(object sender, EventArgs e)
        {

        }

        private void FindAllObjects_Click(object sender, EventArgs e)
        {
            var dataSource = _project.GetAllEntities();
        }

        private void FindObjectByPoint_Click(object sender, EventArgs e)
        {
            //var dataSource = _project.SearchAllObjectsOnLocation();
        }

        private void FindAllProperties_Click(object sender, EventArgs e)
        {
            var dataSource = _project.GetAllProperties();
        }

        private void FindAllParcels_Click(object sender, EventArgs e)
        {
            var dataSource = _project.GetAllParcels();
        }

        private void allObjectsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

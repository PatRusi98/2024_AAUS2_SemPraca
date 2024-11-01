using AAUS2_SemPraca.Tester;

namespace AAUS2_SemPraca
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // GUI
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            // test entit pre semestralku
            //SemProject project = SemProject.Instance;
            //project.GenerateRandomParcels(100);
            //project.GenerateRandomProperties(100);
            //project.GenerateRandomEntities(100);
            //var allEntities = project.GetAllEntities();

            //project.AddParcel(51, "random desc parcel", 123.1234, 'N', 12.3456, 'E', 123.6789, 'N', 12.6789, 'E');
            //project.AddProperty(51, "random desc property", 123.1234, 'S', 12.3456, 'W', 123.6789, 'S', 12.6789, 'W');

            // tester
            //StructTester tester = StructTester.Instance;
            //var success = tester.CreateTestCase(100000, 70.00, 30.00, 0.00);
            //StructTester4Dim tester = StructTester4Dim.Instance;
            //var success = tester.CreateTestCase(10000, 100.00, 0.00, 0.00);
            //List<double[]> valuesToAdd = new List<double[]>();
            //valuesToAdd.Add(new double[] { 4.0, 1.0 });
            //valuesToAdd.Add(new double[] { 7.0, 5.0 });
            //valuesToAdd.Add(new double[] { 7.0, 2.0 });
            //valuesToAdd.Add(new double[] { 7.0, 9.0 });
            //valuesToAdd.Add(new double[] { 7.0, 6.0 });
            //valuesToAdd.Add(new double[] { 8.0, 7.0 });

            //var success = tester.CreateTestCase(100000, 70.0, 10.0, 20.0);

            //Console.WriteLine("hod mi sem brejkac prosim");
        }
    }
}
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            // test entit pre semestralku
            //SemProject project = SemProject.Instance;
            //project.GenerateRandomParcels(100);
            //project.GenerateRandomProperties(100);
            //project.GenerateRandomEntities(100);

            //project.AddParcel(51, "random desc parcel", 123.1234, 'N', 12.3456, 'E', 123.6789, 'N', 12.6789, 'E');
            //project.AddProperty(51, "random desc property", 123.1234, 'S', 12.3456, 'W', 123.6789, 'S', 12.6789, 'W');

            // tester
            StructTester tester = StructTester.Instance;
            //var inserted = tester.TestInsert(100000);
            //var search = tester.TestSearch(inserted);
            var success = tester.CreateTestCase(100000, 70, 30, 0);

            Console.WriteLine("success");
        }
    }
}
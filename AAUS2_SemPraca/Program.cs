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

            // tester
            //while (true)
            //{
            //    StructFinalTester tester = new();
            //    tester.CreateTestCase(100000, 20000, 70.00, 0.00, 30.00);
            //}
        }
    }
}
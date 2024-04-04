using System;
using System.Windows.Forms;

namespace week6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            // Start the Windows Form application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Define a 2x2 matrix for testing
            int[,] myMatrix = { { 1, 2 }, { 3, 4 } };

            // Create an instance of Matrix2D with the test matrix
            Form1.Matrix2D matrix = new Form1.Matrix2D(myMatrix);

            // Display the matrix in the console for testing purposes
            Console.WriteLine("Displaying 2x2 Matrix:");
            matrix.DisplayMatrix();

            // Wait for input to continue (so you can see the output before the form opens)
            Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
        }
    }
}

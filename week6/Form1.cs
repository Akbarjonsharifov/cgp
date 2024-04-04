using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week6
{
    public partial class Form1 : Form
    {
        public class Matrix2D
        {
            private int[,] matrix;

            public Matrix2D(int[,] initialMatrix)
            {
                if (initialMatrix.GetLength(0) == 2 && initialMatrix.GetLength(1) == 2)
                {
                    matrix = initialMatrix;
                }
                else
                {
                    throw new ArgumentException("The Matrix must be 2*2");
                }

            }

            public void DisplayMatrix() //displaying matrix 
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

        }
    }

}
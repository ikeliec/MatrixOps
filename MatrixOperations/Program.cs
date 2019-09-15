using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2 }, { 3, 4 } }; //Test matrix 1 values
            int[,] b = { { 5, 6 }, { 7, 8 } }; //Test matrix 2
            Matrix m = new Matrix();

            Console.WriteLine("");
            Console.WriteLine("---- MATRIX A ----");
            m.InitMatrix(a);

            Console.WriteLine("");
            Console.WriteLine("---- MATRIX B ----");
            m.InitMatrix(b);

            Console.WriteLine("");
            Console.WriteLine("-- MATRIX A + B --");
            m.MatrixSum(a, b);

            Console.WriteLine("");
            Console.WriteLine("-- MATRIX A + B --");
            m.MatrixDiff(a, b);

            Console.WriteLine("");
            Console.WriteLine("-- TRANSPOSE A --");
            m.MatrixTrans(a);

            Console.WriteLine("");
            Console.WriteLine("-- TRANSPOSE B --");
            m.MatrixTrans(b);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    class Matrix
    {
        public void InitMatrix(int[,] arr)
        {
            if (arr.Length > 0)
            {              
                for(int i = 0; i < 2; i++)
                {
                    int[] newArr = new int[2];
                    for (int j = 0; j < 2; j++)
                    {
                        newArr[j] = arr[i,j];
                    }
                    Console.WriteLine(string.Join(", ", newArr));
                }
            }
        }

        public void MatrixSum(int[,] a, int[,] b)
        {
            if (a.Length > 0 && b.Length > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    int[] newArr = new int[2];
                    for (int j = 0; j < 2; j++)
                    {
                        newArr[j] = a[i,j] + b[i,j];
                    }
                    Console.WriteLine(string.Join(", ", newArr));
                }
            }
        }

        public void MatrixDiff(int[,] a, int[,] b)
        {
            if (a.Length > 0 && b.Length > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    int[] newArr = new int[2];
                    for (int j = 0; j < 2; j++)
                    {
                        newArr[j] = a[i,j] - b[i,j];
                    }
                    Console.WriteLine(string.Join(", ", newArr));
                }
            }
        }

        public void MatrixTrans(int[,] arr)
        {
            if (arr.Length > 0)
            {
                var row = arr.GetLength(0);
                var column = arr.GetLength(1);

                int[,] newArr = new int[row, column];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        newArr[j, i] = arr[i, j];
                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    int[] newArr2 = new int[2];
                    for (int j = 0; j < 2; j++)
                    {
                        newArr2[j] = newArr[i,j];
                    }
                    Console.WriteLine(string.Join(", ", newArr2));
                }

                //Console.WriteLine(arr[0][0].ToString());
            }
        }
    }
}

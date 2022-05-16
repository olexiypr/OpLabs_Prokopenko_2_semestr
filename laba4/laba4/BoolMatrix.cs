using System;
using System.Security.AccessControl;


namespace laba4
{
    public class BoolMatrix
    {
        private int sizeX;
        private int sizeY;
        private bool [,] matrix;
        
        public BoolMatrix(int sizeY, int sizeX, Random random)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            matrix = new bool[sizeY,sizeX];
            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    if (random.Next(0,2) == 1)
                    {
                        matrix[i, j] = false;
                    }
                    else
                    {
                        matrix[i, j] = true;
                    }
                }
            }
        }
        public BoolMatrix(int size, Random random)
        {
            sizeX = size;
            sizeY = size;
            matrix = new bool[sizeY,sizeX];
            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    if (random.Next(0,2) == 1)
                    {
                        matrix[i, j] = false;
                    }
                    else
                    {
                        matrix[i, j] = true;
                    }
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    if (matrix[i, j] == true)
                    {
                        Console.Write(" 1 ");
                    }
                    else
                    {
                        Console.Write(" 0 ");
                    }
                }
                Console.Write("\n");
            }
        }

        public int CountTrueValue()
        {
            int count = 0;
            for (int i = 0; i < sizeY; i++)
            {
                for (int j = 0; j < sizeX; j++)
                {
                    if (matrix[i, j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static BoolMatrix operator | (BoolMatrix matrix1, BoolMatrix matrix2)
        {
            for (int i = 0; i < matrix1.sizeY; i++)
            {
                for (int j = 0; j < matrix1.sizeX; j++)
                {
                    if (matrix1.matrix[i,j] != matrix2.matrix[i,j])
                    {
                        matrix1.matrix[i,j] = true;
                    }
                }
            }
            
            return matrix1;
        }

        public static BoolMatrix operator ~ (BoolMatrix matrix)
        {
            for (int i = 0; i < matrix.sizeY; i++)
            {
                for (int j = 0; j < matrix.sizeX; j++)
                {
                    matrix.matrix[i, j] = !matrix.matrix[i, j];
                }
            }

            return matrix;
        }
    }
}
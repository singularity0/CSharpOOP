using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_11.GenericListAndOperations
{
    public class MatrixGeneric<T>  where T : IComparable
    {
        private T[,] myList;
        private int rows;
        private int cols;

        public MatrixGeneric(int size)
        {
            myList = new T[size, size];
        }

        public MatrixGeneric(int rowsInput, int colsInput)
        {
            this.rows = rowsInput;
            this.cols = colsInput;
            myList = new T[rows, cols];
        }

        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (value > 0 && value < int.MaxValue)
                    this.rows = value;
                else
                {
                    throw new ArgumentException("Rows cant be negative or more than int.MaxValue!");
                }
            }
        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value > 0 && value < int.MaxValue)
                    cols = value;
                else
                {
                    throw new ArgumentException("Cols cant be negative or more than int.MaxValue!");
                }
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return myList[row, col];
            }
            set
            {
                if (row >= 0 && row <= int.MaxValue && col >= 0 && col <= int.MaxValue)
                {
                    myList[row, col] = value;
                }
                myList[row, col] = value;
            }
        }

        public static MatrixGeneric<T> operator +(MatrixGeneric<T> matrixFirst, MatrixGeneric<T> matrixSecond)   
        {
            if (matrixFirst.Rows != matrixSecond.Rows || matrixFirst.Cols != matrixSecond.Cols)
            {
                throw new ArgumentException("Matrices must be with the same length ot rows and cols!");
            }
            int currentRows = matrixFirst.Rows;
            int currentCols = matrixSecond.Cols;
            MatrixGeneric<T> current = new MatrixGeneric<T>(currentRows, currentCols);
            for (int i = 0; i < current.Rows; i++)
            {
                for (int j = 0; j < current.Cols; j++)
                {
                    dynamic m1CurrentVal = matrixFirst[i, j];
                    dynamic m2CurrentVal = matrixSecond[i, j];
                    current[i, j] = m1CurrentVal + m2CurrentVal;
                }
            }
            return current;
        }

        public static bool operator true(MatrixGeneric<T> m1)
        {
            bool doesContainZeroElements = false;
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    if (m1[i, j].Equals(default(T)))
                    {
                        doesContainZeroElements = true;
                        break;
                    }
                }
            }
            return doesContainZeroElements;
        }

        public static bool operator false(MatrixGeneric<T> m1)
        {
            bool doesContainZeroElements = true;
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Cols; j++)
                {
                    if (m1[i, j].Equals(default(T)))
                    {
                        doesContainZeroElements = false;
                    }
                    else
                    {
                        doesContainZeroElements = true;
                    }
                }
            }
            return doesContainZeroElements;
        }

        public override string ToString()
        {
            return this.ToString();
        }


    }
}

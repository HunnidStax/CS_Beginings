using System;
using System.Collections.Generic;
using System.Text;

namespace L6
{
    class MyArraySizeExeption : Exception
    {
        public MyArraySizeExeption()
        {

        }
    }
    class MyArrayDataException : Exception
    {
        public int row, column;

        public MyArrayDataException(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}

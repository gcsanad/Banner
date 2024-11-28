using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner.Models
{
    public abstract class ABanner
    {
        const int MAX_ROW_NUM = 50;
        const int MAX_COLUMN_NUM = 1000;
        const int MIN_ROW_NUM = 8;
        const int MIN_COLUMN_NUM = 20;

        const String MSG_ERROR_ARG = "Nem megengedett argumentum!";

        private Color[,] pixel;
        private Color backgroundColor;

        public ABanner(int rowNum, int columnNum)
        {
            if (IsOutOfBounds(rowNum, columnNum))
                throw new ArgumentException(MSG_ERROR_ARG + $"[ABanner: {rowNum}]");

            pixel = new Color[rowNum, columnNum];


            for (int rowIndex = 0; rowIndex < pixel.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < pixel.GetLength(1); columnIndex++)
                {
                    pixel[rowIndex, columnIndex] = backgroundColor;
                }
            }
        }

        private static bool IsOutOfBounds(int rowNum, int columnNum)
        {
            return rowNum < MIN_ROW_NUM || rowNum > MAX_ROW_NUM
                            || columnNum > MAX_COLUMN_NUM || columnNum < MIN_COLUMN_NUM;
        }

        public ABanner() : this(MIN_ROW_NUM, MIN_COLUMN_NUM)
        {
        }

        public int RowNum => pixel.GetLength(0);
        public int ColumnNum => pixel.GetLength(1);

        public Color BackgroundColor { get => backgroundColor; set => backgroundColor = value; }

        //public Color[,] Pixel => pixel;  //Property használatával

        public Color this[int rowIndex, int colIndex]
        {
            get
            {
                if (IsOutOfBounds(rowIndex, colIndex))
                    throw new ArgumentException("Nem megengedett argumentum!");
                return pixel[rowIndex, colIndex];
            }
            set
            {
                if (IsOutOfBounds(rowIndex, colIndex))
                    throw new ArgumentException("Nem megengedett argumentum!");
                pixel[rowIndex, colIndex] = value;
            }

        }

    }
}

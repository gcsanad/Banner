using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner.Models
{
    internal class UserBanner : ABanner, IBannerOperations
    {
        public void Clear()
        {
            Fill(BackgroundColor);
        }

        public void DrawLine(int lineIndex, Color drawingColor, IBannerOperations.Orientation lineOrientation)
        {
            if (lineOrientation == IBannerOperations.Orientation.Horizontally && lineIndex <= RowNum && lineIndex >= 0)
            {
                
                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    this[lineIndex, columnIndex] = drawingColor;
                }
            }
            else if(lineOrientation == IBannerOperations.Orientation.Vertically && lineIndex <= ColumnNum && lineIndex >= 0)
            {
                for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
                {
                    this[rowIndex, lineIndex] = drawingColor;
                }
            }
        }

        public void Fill(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex] = fillColor;
                    
                }
            }
        }

        public void ReplaceColor(Color oldColor, Color newColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    if (this[rowIndex, columnIndex] == oldColor)
                    {
                        this[rowIndex, columnIndex] = newColor;
                    }
                }
            }
        }

        public void RotateToLeft()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color tempColor = this[rowIndex, ColumnNum + 1];
                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex] = this[rowIndex, columnIndex + 1];
                }
                this[rowIndex, 0] = tempColor;
            }
        }

        public void RotateToRight()
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color tempColor = this[rowIndex, ColumnNum - 1];
                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    this[rowIndex, columnIndex] = this[rowIndex,columnIndex-1];
                }
                this[rowIndex, 0]= tempColor;
            }
        }

        public void ShiftToLeft(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color tempColor = this[rowIndex, ColumnNum + 1];
                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    if (columnIndex == ColumnNum)
                    {
                        this[rowIndex, columnIndex] = fillColor;
                    }
                    else
                    {
                        this[rowIndex, columnIndex] = this[rowIndex, columnIndex + 1];

                    }
                }
                this[rowIndex, 0] = tempColor;
            }
        }

        public void ShiftToRight(Color fillColor)
        {
            for (int rowIndex = 0; rowIndex < RowNum; rowIndex++)
            {
                Color tempColor = this[rowIndex, ColumnNum - 1];
                for (int columnIndex = 0; columnIndex < ColumnNum; columnIndex++)
                {
                    if (columnIndex == 0)
                    {
                        this[rowIndex, columnIndex] = fillColor;
                    }
                    else
                    {
                        this[rowIndex, columnIndex] = this[rowIndex, columnIndex + 1];

                    }
                }
                this[rowIndex, 0] = tempColor;
            }
        }
    }
}

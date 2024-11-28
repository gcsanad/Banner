using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banner.Models
{
    internal interface IBannerOperations
    {
        
        enum Orientation { Horizontally, Vertically }


        /// <summary>
        /// A BackgroundColor színnel festi át a teljes kijelzőt.
        /// </summary>
        public void Clear();

        public void Fill(Color fillColor);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldColor">Az előző szin</param>
        /// <param name="newColor"></param>
        public void ReplaceColor(Color oldColor, Color newColor);

        /// <summary>
        /// Egy pixellel balra forgatja a képet
        /// </summary>
        public void RotateToLeft();

        public void RotateToRight();


        /// <summary>
        /// Egy pixellel balra tolja a képet
        /// </summary>
        public void ShiftToLeft(Color fillColor);

        public void ShiftToRight(Color fillColor);


        public void DrawLine(int lineIndex, Color drawingColor, Orientation lineOrientation);

        //kijelzo.DrawLine(4,Color.Red, true)
        //kijelzo.DrawLine(4,Color.Red, Orientation.Horizontally)
    }
}

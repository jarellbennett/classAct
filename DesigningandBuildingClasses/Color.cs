using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesigningandBuildingClasses
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        //constructor that takes all instance variables
        Color(int red, int green, int blue, int alpha)
        {

        }

        //Constructor that defaults alpha to opaque
        Color(int red, int green, int blue)
        {
            alpha = 255;
        }

        public int Red                          //red method with properties
        {
            get { return red; }
            set
            {
                red = value;
                if (value < 0)
                    red = 0;
            }
        }

        public int Green
        {
            get { return green; }
            set
            {
                red = value;
                if (value < 0)
                    green = 0;
            }

        }

        public int Blue
        {
            get { return blue; }
            set
            {
                blue = value;
                if (value < 0)
                    blue = 0;
            }
        }

        public int Alpha
        {
            get { return alpha; }
            set
            {
                alpha = value;
                if (value < 0)
                    alpha = 0;
            }
        }

    }
}
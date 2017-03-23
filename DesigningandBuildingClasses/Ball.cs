using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesigningandBuildingClasses
{
    class Ball
    {
        private int throws;
        private int size;
        private int red;
        private int green;
        private int blue;
        private int alpha;


        public Ball(int size, int red, int green, int blue, int alpha)           //constructure that takes ball size and color
        {
            this.size = size;
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Ball(int size, int red, int green, int blue)
        {
            this.size = size;
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public void Pop()                 //method that pops ball changes size to 0
        {
            size = 0;
        }

        public void Throw()
        {
            Random random = new Random();         //random class number random number generator for throws

            if (size == 0)
            {
                throws = 0;
            }
            else
            {
                throws = random.Next(1, 25);         //throws equal random number between 1-25
            }
        }

        public void ballThrows()        //method that returns number of times ball was thrown
        {
            Console.WriteLine("The ball has been thrown " + throws + " times.");
        }
    }
}

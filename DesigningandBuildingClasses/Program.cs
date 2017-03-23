using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesigningandBuildingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball kickball = new Ball(25, 255, 255, 0);               //new Ball object kickball
            kickball.Throw();
            kickball.ballThrows();
            kickball.Pop();
            kickball.ballThrows();

            Ball soccer = new Ball(30, 255, 255, 255);              //new Ball object soccer
            soccer.Throw();
            soccer.Pop();
            soccer.ballThrows();

            Ball bball = new Ball(35, 255, 165, 0);                 //new Ball object, bball
            bball.Throw();
            bball.ballThrows();








            
            Console.ReadKey();

        }
    }
}

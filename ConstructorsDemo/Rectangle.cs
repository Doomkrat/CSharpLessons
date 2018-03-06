using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    class Rectangle
    {
        private int length;
        private int width;

        
        public Rectangle(int sideA, int sideB)
        {
            Console.WriteLine("we are in the rectangle's which takes two values");
            length = sideA;
            width = sideB;
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}

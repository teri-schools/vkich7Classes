using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

#nullable enable

namespace Class
{
    class Rectangle{
        private double sideA, sideB;

        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }

        public Rectangle(double a)
        {
            sideA = a;
            sideB = 5;
        }

        public Rectangle()
        {
            sideA = 4;
            sideB = 3;
        }
        
        public double GetSideA()
        {
            return sideA;
        }

        public double GetSideB()
        {
            return sideB;
        }

        public double Area()
        {
            return sideA * sideB;
        }

        public double Perimeter()
        {
            return (sideA + sideB) * 2;
        }

        public bool IsSquare()
        {
            return sideA == sideB;
        }

        public void ReplaceSides()
        {
            (sideA, sideB) = (sideB, sideA);
        }

    }

    class ArrayRectangles
    {
        private List<Rectangle> rectangle_array = new List<Rectangle>();

        public ArrayRectangles(int n = 0)
        {

        }

        public ArrayRectangles(IEnumerable<Rectangle> array)
        {
            rectangle_array.Except(array);
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            rectangle_array.Add(rectangle);
            return true;
        }

        public double NumberMaxArea()
        {
            if (rectangle_array.Count == 0)
                return 0;
            return rectangle_array.Max(
                (Rectangle rectangle) => 
                { 
                    return rectangle.Area();
                }
            );
        }

        public double NumberMinPerimeter()
        {
            if (rectangle_array.Count == 0)
                return 0;
            return rectangle_array.Min(
                (Rectangle rectangle) => 
                { 
                    return rectangle.Perimeter();
                }
            );
        }

        public int NumberSquare()
        {
            return rectangle_array.Count;
        }
    }
}

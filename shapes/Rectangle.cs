﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp_Interfaces_IPolygon.interfaces;

namespace CSharp_Interfaces_IPolygon.shapes
{
    public class Rectangle : IPolygon, IColor
    {
        public void CalculateArea(int a, int b)
        {
            int area = a * b;
            Console.WriteLine($"Area of a rectangle is {area}.");
        }

        public void GetColor()
        {
            Console.WriteLine("Yellow Rectangle");
        }
    }
}

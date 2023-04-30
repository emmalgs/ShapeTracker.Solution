using System;
using ShapeTracker.Models;
using System.Collections.Generic;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      List<Triangle> allTriangles = Triangle.GetAll();
      Triangle testTriangle = new Triangle(3,4,5);
      Triangle secondTriangle = new Triangle(32,74,75);
      if (allTriangles.Count == 0)
      {
        Console.WriteLine("There are no triangles!");
      }
      else
      {
        Console.WriteLine("-----------------------------");
        foreach (Triangle tri in allTriangles)
        {
          Console.WriteLine($"Side one of the triangle: {testTriangle.GetSide1()}");
          Console.WriteLine($"Side two of the triangle: {testTriangle.GetSide2()}");
          Console.WriteLine($"Side three of the triangle: {testTriangle.GetSide3()}");
          Console.WriteLine("-----------------------------");
        }
      }
    }
  }
}

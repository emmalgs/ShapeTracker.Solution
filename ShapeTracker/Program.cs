using System;
using ShapeTracker.Models;

namespace ShapeTracker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("We'll caclulate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
      Console.WriteLine("Please enter a number:");
      string stringNumber1 = Console.ReadLine();
      Console.WriteLine("Enter another number:");
      string stringNumber2 = Console.ReadLine();
      Console.WriteLine("Enter a third number:");
      string stringNumber3 = Console.ReadLine();
      int length1 = int.Parse(stringNumber1);
      int length2 = int.Parse(stringNumber2);
      int length3 = int.Parse(stringNumber3);
      Triangle tri = new Triangle(length1, length2, length3);
    }
  }
}

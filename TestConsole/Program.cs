// See https://aka.ms/new-console-template for more information

using GeometryLibrary;
using GeometryLibrary.Models;

var t = new Triangle(1, 2, 2);
var x = Geometry.CreateTriangle(1, 2, 2).Perimeter;
var z = Geometry.GetPerimeter(t);

Console.WriteLine(x);
Console.WriteLine(z);
Console.WriteLine(t.IsRectangular);
Console.WriteLine(Geometry.CreateTriangle(3, 4, 5).IsRectangular);
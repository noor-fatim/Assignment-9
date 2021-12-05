using System;
namespace Assignment_9
{
    public class circle
    {
 public float radius;
    public float GetRadius(float x )
    {
      radius = x;
      return radius;
    }
    public void Area()
    {
        float pi = 3.14f;
        float a = pi*radius*radius;
        Console.WriteLine("Area = " + a);

    }
    public void Circumference()
    {
        float pi = 3.14f;
        float C = 2*pi*radius;
        Console.WriteLine("Circumference = " + C);
    }
}
}
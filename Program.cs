using System;

namespace Assignment_9
{
    class Program
    {
        static void Main(string[] args)
        {
           var obj = new circle();
           float g= obj.GetRadius(3);
           obj.Area();
           obj.circumference();

        }
    }
}

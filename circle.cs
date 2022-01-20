using System;

namespace Assignment_9
{
    public class circle
    {
    public float radius;
        public float GetRadius(float x){
         radius = x;
         return radius;

        }
        public void Area(){
         float pi = 3.14f;
         float a= pi*radius*radius;
         Console.WriteLine("Area of circle is =" + a); 

        }
        public void circumference(){
         float pi= 3.14f;
         float c= 2*pi*radius;
         Console.WriteLine("Circumference of circle is= " + c); 
        }


    }
}
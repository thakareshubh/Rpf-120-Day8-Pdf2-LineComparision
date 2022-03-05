using System;

namespace LenghtOfLineBetweenPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value of two cartetian point");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());
            int x2=Convert.ToInt32(Console.ReadLine());
            int y2=Convert.ToInt32(Console.ReadLine());
            computeLenght p1=new computeLenght();
            p1.Find(x1,y1,x2,y2);
        }
    }
    public class computeLenght
    {
        
        public void Find(int x1,int y1,int x2,int y2)
        {
            double length;
            int temp;
           
            temp= (x2 - x1) ^ 2 + (y2 - y1) ^ 2 ;
            
            length = Math.Sqrt(temp);

            Console.WriteLine("The lenghth between two line is " + length);
            
        }
    }
}

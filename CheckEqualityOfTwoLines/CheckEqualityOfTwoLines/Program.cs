using System;

namespace CheckEqualityOfTwoLines
{
    
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter a value of four cartetian point");
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());
                int x3 = Convert.ToInt32(Console.ReadLine());
                int y3 = Convert.ToInt32(Console.ReadLine());
                int x4 = Convert.ToInt32(Console.ReadLine());
                int y4 = Convert.ToInt32(Console.ReadLine());
            computeLenght p1 = new computeLenght();
                p1.Find(x1, y1, x2, y2,x3,y3,x4,y4);
            }
        }
        public class computeLenght
        {

            public void Find(int x1, int y1, int x2, int y2,int x3,int y3,int x4,int y4)
            {
                double length1;
                int temp1;
                double lenght2;
                int temp2;

                temp1 = (x2 - x1) ^ 2 + (y2 - y1) ^ 2;
                length1 = Math.Sqrt(temp1);

                temp2 = (x4 - x3) ^ 2 + (y4 - y3) ^ 2;
                lenght2 = Math.Sqrt(temp2);
                
                if(lenght2 ==length1)
            {
                Console.WriteLine("leghth of two line are equal");
            }
                else
            {
                Console.WriteLine("lenght of two line are not equal");
            }
            



        }
        }
    
}

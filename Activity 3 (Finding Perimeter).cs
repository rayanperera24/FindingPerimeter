using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class square
        {
            private int length;

            public void setlength()
            {
                Console.WriteLine("enter the length");
                length = Convert.ToInt32(Console.ReadLine());
            }   

            public void displaylength()
            {
                Console.WriteLine("Length is : " + length);
            }

            public void calperimeter()
            {
                Console.WriteLine("Perimeter is : " + length * 4);
            }


        }
        static void Main(string[] args)
        {
            square sq1=new square();
            sq1.setlength();
            sq1.displaylength();
            sq1.calperimeter();
            
            Console.ReadKey();




        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace cSharpLoopsAndSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("What number you want to power? ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which power do you want? ");
            Console.WriteLine("Squared? Press 1");
            Console.WriteLine("Cubed? Press 2");
            Console.WriteLine("power of four? Press 3");
            Console.WriteLine("To exit press 0");
            int choice = Convert.ToInt32(Console.ReadLine());
            int total = GetPower(choice , number);

            Console.WriteLine("Your total is " + total);

            Console.ReadLine();

        }

        static int GetPower(int power , int num)
        {
            int total = 0;

            switch (power)

            {
                case 0:
                    break;
                    
                case 1://squared
                    total = num * num;
                    break;
                
                case 2://cubed
                    total = num * num * num;
                    break;

                case 3:// to 4th power
                    total = num * num * num * num;
                    break;
               
                default:
                    break;
            }   
            
           return total;
        }

    }
}

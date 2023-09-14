using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.The_Return_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("The cube of the Number you entered is ");
            Console.WriteLine (Cube(userInput));



            Console.ReadLine();
       
        
        }
    // making of cube method
    static int Cube(int x)
        {
            return x*x*x;

        }
    
    
    }





}

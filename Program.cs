using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhandling_try
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inPut;
            do {
                
                try
                {
                    Console.Write("Input A Number: ");
                    int a = Int32.Parse(Console.ReadLine());

                    Console.Write("Input Another Number: ");
                    int b = Int32.Parse(Console.ReadLine());

                    int c = a + b;

                    Console.WriteLine("Answer: {0}+{1}={2}", a, b, c);
                    
                    Console.WriteLine("Press any key to exit");
                    break;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Only input a number");
                    inPut = false;

                }

                catch (Exception) 
                {
                    Console.Write("Error occurred! Please try again.");
                    inPut = false;
                }

                //finally
                //{

                //    Console.WriteLine("Finish");
                //}
            }
            while (inPut == false);
            

            Console.ReadKey();
        }
    }
}

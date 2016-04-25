using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Calculator 
    {
        Operation ops;


        public Calculator()
        {
            ops = new Operation();
         
            int choice;
            bool isRunning = true;

            while (isRunning == true)
            {
                Console.Clear();
                Console.WriteLine("\n *************************");
                Console.WriteLine("\n   DEVCODE CALCULATOR.");
                Console.WriteLine("\n *************************");
                Console.WriteLine("\n 1-----> ADDITION");
                Console.WriteLine("\n 2-----> SUBTRACTION");
                Console.WriteLine("\n 3-----> MULTIPLICATION");
                Console.WriteLine("\n 4-----> DIVISION");
                Console.WriteLine("\n 5-----> EXPONENTIAL");
                Console.WriteLine("\n 6-----> EXIT");
                Console.WriteLine("\n *************************");
                Console.Write("\n\n Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ops.read1();
                        ops.read2();
                        ops.Add(ops.aValue, ops.bValue);
                        break;
                    case 2:
                        ops.read1();
                        ops.read2();
                        ops.Subtract(ops.aValue, ops.bValue);
                        break;
                    case 3:
                        ops.read1();
                        ops.read2();
                        ops.Multiply(ops.aValue, ops.bValue);
                        break;
                    case 4:
                        ops.read1();
                        ops.read2();
                        ops.Divide(ops.aValue, ops.bValue);
                        break;
                    case 5:
                        ops.read1();
                        ops.read2();
                        ops.Power(ops.aValue, ops.bValue);
                        break;
                    case 6:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine(" Sorry !!! Wrong  choice.");
                        break;
                }
                Console.Write("\n Press ENTER to Continue. ");
                Console.ReadLine();
            }
            Console.WriteLine("\n Cannot continue... Bye");
        }
    }
}


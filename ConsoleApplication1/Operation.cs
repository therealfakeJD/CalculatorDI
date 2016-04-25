using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Operation : IOperation
    {
        public List<double> numbers = new List<double>();
        public double aValue;
        public double bValue;
        public Operation()
        {
            
        }
        public double read1()
        {
            Console.WriteLine("\n Enter first Number:");
            Console.Write("\n Number1 : ");
            aValue = double.Parse(Console.ReadLine());
            numbers.Add(aValue);
            return aValue;
        }
        public double read2()
        {
            Console.WriteLine("\n Enter second Number:");
            Console.Write("\n Number2 : ");
            bValue = double.Parse(Console.ReadLine());
            numbers.Add(bValue);
            return bValue;
        }
        public double Add(double aValue, double bValue)
        {
            double result = aValue + bValue;
            Console.WriteLine("\nResult: {0} + {1} = {2}", aValue, bValue, result);
            return result;
        }

        public double Subtract(double aValue, double bValue)
        {
            double result = aValue - bValue;
            Console.WriteLine("\nResult: {0} - {1} = {2}", aValue, bValue, result);
            return result;
        }
        public double Multiply(double aValue, double bValue)
        {
            double result = aValue * bValue;
            Console.WriteLine("\nResult: {0} * {1} = {2}", aValue, bValue, result);
            return result;
        }

        public double Divide(double aValue, double bValue)
        {
            double result = aValue / bValue;
            Console.WriteLine("\nResult: {0} / {1} = {2}", aValue, bValue, result);
            return result;
        }

        public double Power(double aValue, double bValue)
        {
            double result = Math.Pow(aValue, bValue);
            Console.WriteLine("\nResult: {0} to the {1}th power = {2}", aValue, bValue, result);
            return result;
        }
    }
       
}

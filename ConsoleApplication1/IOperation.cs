using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface IOperation
    {
        double Add(double aValue, double bValue);
        double Subtract(double aValue, double bValue);
        double Multiply(double aValue, double bValue);
        double Divide(double aValue, double bValue);

    }
}

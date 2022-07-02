using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal interface IMathFunctions
    {
        public double Add(double a, double b);
        public double Subtraction(double a, double b);
        public double Multiplication(double a, double b);
        public double Divide(double a, double b);
        public bool EvenNumber(int a);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class CalculatorBase
    {
        public CalculatorBase()
        {

        }
        public abstract string Operation(decimal x, decimal y);
    }
    public class Addition : CalculatorBase
    {
        public Addition()
        {

        }

        public override string Operation(decimal x, decimal y)
        {
            string result = Convert.ToString(x + y);
            return result;

        }
    }

    public class Subtraction : CalculatorBase
    {
        public Subtraction()
        {

        }
        public override string Operation(decimal x, decimal y)
        {
            string result = Convert.ToString(x - y);
            return result;
        }
    }

    public class Multiplication : CalculatorBase
    {
        public Multiplication()
        {

        }
        public override string Operation(decimal x, decimal y)
        {
            string result = Convert.ToString(x * y);
            return result;
        }
    }

    public class Division : CalculatorBase
    {
        public Division()
        {

        }
        public override string Operation(decimal x, decimal y)
        {
            string result = Convert.ToString(x / y);
            return result;
        }
    }

    public class Power : CalculatorBase
    {
        public Power()
        {

        }

        public override string Operation(decimal x, decimal y)
        {
            string result = Convert.ToString(Math.Pow( (double)x , (double)y) );
            return result;
        }
    }

    public class SquareRoot : CalculatorBase
    {
        public SquareRoot()
        {

        }

        public virtual string Operation(decimal x)
        {
            string result = Convert.ToString(Math.Sqrt( (double)x ));
            return result;
        }

        public override string Operation(decimal x, decimal y)
        {
            string result = Convert.ToString(Math.Sqrt((double)x));
            return result;
        }
    }
}

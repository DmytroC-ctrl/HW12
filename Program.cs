using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ExpressionParser parser = new ExpressionParser();
            string simpleExp = "5";
            int result = parser.Parse(simpleExp);
            Console.WriteLine(result);

        }
    }
}

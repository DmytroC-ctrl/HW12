using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    public class ExpressionParser
    {
        private string expression;
        private int currentPosition;


        public int Parse(string exp)
        {
            currentPosition = 0;
            expression = exp;
            int result;
            if (ParseExpression(out result))
            {
                return result;
            }
            return 0;
        }

        private bool ParseDigit(out int digit)
        {
            digit = 0;
            if (currentPosition >= expression.Length)
            {
                return false;
            }
            if (expression[currentPosition] - '0' < 0 || expression[currentPosition] - '0' > 9)
            {
                return false;
            }
            digit = expression[currentPosition] - '0';
            ++currentPosition;
            return true;
        }

        private bool ParseNumber(out int number)
        {
            number = 0;
            if (currentPosition >= expression.Length)
            {
                return false;
            }
            int digit;
            if (!ParseDigit(out digit))
            {
                return false;
            }
            number = digit;
            while (ParseDigit(out digit))
            {
                number = number * 10 + digit;
            }
            return true;
        }

        private bool ParseOperation(out char operation)
        {
            operation = '0';
            if (currentPosition >= expression.Length)
            {
                return false;
            }
            if (expression[currentPosition] != '+' && expression[currentPosition] != '-')
            {
                return false;
            }
            operation = expression[currentPosition];
            ++currentPosition;
            return true;
        }

        private bool ParseExpression(out int result)
        {
            result = 0;
            int numberFirst;
            if (!ParseNumber(out numberFirst))
            {
                return false;
            }
            char operation;
            if (!ParseOperation(out operation))
            {
                result = numberFirst;
                return true;
            }
            else
            {
                int resultNext;
                if (!ParseExpression(out resultNext))
                {
                    return false;
                }
                switch (operation)
                {
                    case '+':

                        result = numberFirst + resultNext;
                        break;

                    case '-':

                        result = numberFirst - resultNext;
                        break;

                    default:
                        return false;

                }
                return true;

            }

        }
    }
}
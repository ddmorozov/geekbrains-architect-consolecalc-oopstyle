using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalcOOP
{
    class Operators
    {
        public static bool IsOperator(char ch)
        {
            if (
                ch == '(' || ch == ')' ||
                ch == '+' || ch == '-' ||
                ch == '*' || ch == '/' ||
                ch == '^'
            )
                return true;
            else
                return false;
        }

        public static int GetPriority(char op)
        {
            if (op == '(' || op == ')')
                return 0;
            if (op == '+' || op == '-')
                return 1;
            if (op == '*' || op == '/')
                return 2;
            if (op == '^')
                return 3;
            return 4;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalcOOP
{
    class PostfixConverter
    {
        public string Result { get; set; }
        private Stack<char> OperStack { get; set; }

        public PostfixConverter(string input)
        {
            Result = "";
            OperStack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == ' ')
                    continue;
                if (Operators.IsOperator(ch))
                {
                    if (ch != '(' && ch != ')')
                    {
                        if (OperStack.Count > 0 && Operators.GetPriority(OperStack.Peek()) >= Operators.GetPriority(ch))
                        {
                            Result += OperStack.Pop();
                        }
                        OperStack.Push(ch);
                    }
                    if (ch == '(')
                    {
                        OperStack.Push(ch);
                    }
                    if (ch == ')')
                    {
                        Result += OperStack.Pop();
                        OperStack.Pop();
                    }
                }
                else
                {
                    Result += ch;
                }
            }
            AddOperatorsToPostfixOut();
        }

        private void AddOperatorsToPostfixOut()
        {
            while (OperStack.Count > 0)
            {
                Result += OperStack.Pop();
            }
        }
    }
}

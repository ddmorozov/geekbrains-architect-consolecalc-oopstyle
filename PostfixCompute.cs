using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalcOOP
{
    class PostfixCompute
    {
        public decimal Result { get; set; }

        public PostfixCompute(string postfixString)
        {
            Stack<string> stack = new Stack<string>();
            Queue<char> queue = new Queue<char>(postfixString.ToCharArray());
            char str = queue.Dequeue();
            while (queue.Count >= 0)
            {
                if (!Operators.IsOperator(str))
                {
                    stack.Push(str.ToString());
                    str = queue.Dequeue();
                }
                else
                {
                    decimal summ = 0;
                    try
                    {
                        if (str == '+')
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = a + b;
                        }
                        if (str == '-')
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = b - a;
                        }
                        if (str == '*')
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = b * a;
                        }
                        if (str == '/')
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = b / a;
                        }
                        if (str == '^')
                        {
                            decimal a = Convert.ToDecimal(stack.Pop());
                            decimal b = Convert.ToDecimal(stack.Pop());
                            summ = Convert.ToDecimal(Math.Pow(Convert.ToDouble(b), Convert.ToDouble(a)));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                    }
                    stack.Push(summ.ToString());
                    if (queue.Count > 0)
                        str = queue.Dequeue();
                    else
                        break;
                }

            }
            Result = Convert.ToDecimal(stack.Pop());
        }
    }
}

using System;
using System.Collections.Generic;

public class ValidExpression
{
    public static bool IsValidExpression(string expression)
    {
        char[] characters = expression.ToCharArray();

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < characters.Length; i++)
        {
            stack.Push(characters[i]);
        }

        int countParenthesis = 0;
        int lengthStack = stack.Count;

        for (int i = 0; i < lengthStack; i++)
        {
            if (stack.Peek() == '(')
            {
                countParenthesis++;
                stack.Pop();
            }
            else if (stack.Peek() == ')')
            {
                countParenthesis--;
                stack.Pop();
            }
        }
        if (countParenthesis == 0) return true;
        return false;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsValidExpression(new string('(',5) + new string(')',6)));
        Console.WriteLine(IsValidExpression(new string('(', 10000) + new string(')', 10000)));
        Console.ReadLine();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lol = Console.ReadLine();
            if (Check(lol))
            {
                Console.WriteLine("Yes");
            }
            else
                Console.WriteLine("NO");
            
        }

        public static bool Check(string checkString)
        {
            var braceStack = new Stack();

            foreach (var chr in checkString)
            {
                if (chr == '(' || chr == '{' || chr == '[')
                {
                    braceStack.Push(chr);
                    continue;
                }

                if (chr != ')' && chr != '}' && chr != ']')
                    continue;

                char brace;

                if (braceStack.Count > 0)
                    brace = (Char)braceStack.Pop();
                else
                    return false;

                switch (brace)
                {
                    case '(':
                        if (chr != ')') return false;
                        break;
                    case '{':
                        if (chr != '}') return false;
                        break;
                    case '[':
                        if (chr != ']') return false;
                        break;
                }
            }

            return braceStack.Count == 0;
        }


    }

}

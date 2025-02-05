using System.Collections;

namespace C_AdvAss002
{
    internal class Program
    {
        #region 1- Given a Queue, implement a function to reverse the elements of a queue using a stack.
        public static void ReverseQueue<T>(Queue<T> queue)
        {

            if (queue == null) return;

            else if (queue.Count == 0) return;

            Stack<T> stack = new Stack<T>();



            do { stack.Push(queue.Dequeue()); }
            while (queue.Count > 0);


            do { queue.Enqueue(stack.Pop()); }
            while (stack.Count > 0);




        }
        #endregion

        #region 2- Given a Stack, implement a function to check if a string of parentheses is balanced using a stack

        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char openBracket = stack.Pop();
                    if (!IsMatchingPair(openBracket, ch))
                        return false;
                }
            }

            return stack.Count == 0;
        }

        static bool IsMatchingPair(char openBracket, char closeBracket)
        {
            return (openBracket == '(' && closeBracket == ')') ||
                   (openBracket == '{' && closeBracket == '}') ||
                   (openBracket == '[' && closeBracket == ']');
        }


        #endregion
        static void Main(string[] args)
        {

            #region 1- Given a Queue, implement a function to reverse the elements of a queue using a stack.



            //Queue<int> s = new Queue<int> ();

            //s.Enqueue (1);
            //s.Enqueue (2);
            //s.Enqueue (3);

            //ReverseQueue<int>(s);

            //foreach (var item in s) Console.WriteLine(item);


            #endregion


            #region 2- Given a Stack, implement a function to check if a string of parentheses is balanced using a stack

            //string s = "[()]{}";

            //IsBalanced(s);



            #endregion

        }
    }
}

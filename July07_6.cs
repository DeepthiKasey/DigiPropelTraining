using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;


namespace July07_6
{
       interface IStack
        {
            void push(int n);
            int pop();
            int length { get; }
        }
        class StackFullException : Exception
        {
            public StackFullException() : base("Stack Full")
            {

            }
        }
        class StackEmptyException : Exception
        {
            public StackEmptyException() : base("Stack Empty")
            {

            }
        }
        class Stack : IStack
        {
            private int[] a = new int[10];
            public int top = 0;
            public void push(int n)
            {
                if (top == 10)
                    throw new StackFullException();
                a[top] = n;
                top++;
            }
            public int pop()
            {
                if (top == 0)
                    throw new StackEmptyException();
                top--;
                return a[top];
            }
            public int length
            {
                get
                {
                    return top;
                }
            }

        }
        public class StackOperation
        {
            public static void Main()
            {
                try
                {
                    Stack st = new Stack();
                    st.push(10);
                    Console.WriteLine(st.pop());
                    Console.WriteLine(st.length);
                    Console.WriteLine(st.pop());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Read();
            }

        }

    
    
}

/*output:
    10
    0
    Stack Empty   */


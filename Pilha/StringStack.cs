using System;

namespace MeuProjeto
{
    public class StringStack
    {
        private const int MAX = 1000;
        private int top = -1;
        private string[] stack = new string[MAX];

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(string data)
        {
            if (top >= MAX - 1)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1;
            stack[top] = data;
            return true;
        }

        public string Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return null;
            }

            string value = stack[top];
            top--;

            return value;
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é: {stack[top]}");
        }

        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da pilha:");
            for (int i = top; i >= 0; i--)
            {
                string text = $"Stack[{stack[i]}]";
                Console.WriteLine(text);
            }
        }
    }
}

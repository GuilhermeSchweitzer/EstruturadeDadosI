using System;
using System.Collections.Generic;

namespace QueueClass
{
    public class CustomQueue<T>
    {
        private Queue<T> queue = new Queue<T>();

        public void Enqueue(T data)
        {
            queue.Enqueue(data);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return default; 
            }

            return queue.Dequeue();
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return default; 
            }

            return queue.Peek();
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila Vazia");
                return;
            }

            Console.WriteLine("Nomes na fila:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<string> fila = new CustomQueue<string>();

            fila.Enqueue("Anderson");
            fila.Enqueue("Renato");
            fila.Enqueue("Charles");
            fila.Enqueue("Emily");

            fila.PrintQueue();

            Console.WriteLine("Primeiro nome: " + fila.Peek());

            Console.WriteLine("Removendo o primeiro nome: " + fila.Dequeue());

            fila.PrintQueue();
        }
    }
}

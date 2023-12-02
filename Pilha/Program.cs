using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main()
        {
            // Criando uma instância da pilha de strings
            StringStack pilha = new StringStack();

            // Adicionando valores à pilha
            pilha.Push("3");
            pilha.Push("14");
            pilha.Push("-2");
            pilha.Push("0");

            // Exibindo a pilha
            pilha.PrintStack();

            // Exibindo o topo da pilha
            pilha.Peek();

            // Removendo um item da pilha e exibindo
            string itemRemovido = pilha.Pop();
            Console.WriteLine($"Item removido: {itemRemovido}");

            // Exibindo a pilha após a remoção
            pilha.PrintStack();
        }
    }
}

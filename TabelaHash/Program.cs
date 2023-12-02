using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var tabelaHash = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("\n1 - Inserir par de Chave e Valor");
            Console.WriteLine("2 - Exibir todos os dados");
            Console.WriteLine("3 - Sair");

            if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > 3)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            switch (escolha)
            {
                case 1:
                    InserirDados(tabelaHash);
                    break;
                case 2:
                    ExibirDados(tabelaHash);
                    break;
                case 3:
                    Console.WriteLine("Encerrando o programa.");
                    return;
            }
        }
    }

    static void InserirDados(Dictionary<string, string> tabelaHash)
    {
        Console.Write("\nDigite o CPF: ");
        string cpf = Console.ReadLine();

        if (tabelaHash.ContainsKey(cpf))
        {
            Console.WriteLine("Chave já inserida anteriormente. Não é permitido duplicação de chaves.");
            return;
        }

        Console.Write("Digite o Nome: ");
        string nome = Console.ReadLine();

        tabelaHash[cpf] = nome;

        Console.WriteLine("Par de Chave e Valor inserido com sucesso.");
    }

    static void ExibirDados(Dictionary<string, string> tabelaHash)
    {
        Console.WriteLine(tabelaHash.Count == 0
            ? "Tabela hash vazia. Nenhum dado para exibir."
            : "\nDados na Tabela Hash:\n" + string.Join("\n", tabelaHash.Select(par => $"CPF: {par.Key}, Nome: {par.Value}")));
    }
}

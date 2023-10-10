// C# program for implementation of Insertion Sort
using System;
 
class InsertionSort {
     static void PrintarArray(int[] data)
    {
        int arrMax = data.Length; // Tamanho do escopo da array
        for (int i = 0; i < arrMax; ++i) // Enquanto i for menor que o tamanho do escopo da array
        {
            if (i < arrMax-1) // se i for menor que o tamanho do escopo da array - 1
            { 
                Console.Write(data[i] + ","); // adiciona a data com vírgula após
            }
            else // se não
            {
                Console.Write(data[i]); // adiciona a data sem vírgula após
            }
        }
            
 
        Console.Write("\n"); // pula uma linha
    }
 
    static void Ordenar(int[] data)
    {
        int arrMax = data.Length;
        for (int i = 1; i < arrMax; ++i) // enquanto i for menor que arrMax
        {
            int chave = data[i]; // define a variável chave como o valor atual da chave i
            int chaveanterior = i - 1; // define a variável chaveanterior como o valor atual da chave i - 1

            while (chaveanterior >= 0 && data[chaveanterior] > chave) // enquanto a chave anterior for maior ou igual a 0 e a chaveanterior for maior que a chave (dentro do while... senão linha 37)
            {
                data[chaveanterior + 1] = data[chaveanterior]; // a chave anterior + 1 se torna igual a chave anterior
                chaveanterior -= 1; // diminui o valor da chaveanterior para os próximos loops
            }
            data[chaveanterior + 1] = chave; // caso fora do while, define chaveanterior +1 como chave
        }
    }

     public static void Main()
    {
        int[] arr = { 12, 11, 13, 5, 6 }; // Cria uma array nova com valores pré-definidos, fora de ordem
        InsertionSort ObjetoInsertion = new InsertionSort(); // Cria uma instância chamada Objetoinsertion com a classe acima
        Ordenar(arr); // Ordena a array de acordo com a função criada na classe do InsertionSort
        PrintarArray(arr); // Printa a array
    }
}

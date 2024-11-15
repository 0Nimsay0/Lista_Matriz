using System;
using Biblioteca_Matriz;
    class exercicio10
    {
    public static void mostra(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"Regiao {i + 1}:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{mat[i, j],3} |");
            } // fim for j

            Console.WriteLine();

        }
    }
    static void Main()
    {
        Console.WriteLine("Quantas regioes?");
        int linha = int.Parse(Console.ReadLine());
        Console.WriteLine("Quantas cidades por região?");
        int coluna = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linha, coluna];
        Biblioteca_Matriz.Matriz.gerar(matriz);
        mostra(matriz);
        int[] regiao = new int[linha];
        for (int i = 0; i < linha; i++)
        {
            int soma = 0;
            for (int j = 0; j < coluna; j++)
            {
                soma += matriz[i, j];
            }
            regiao[i] = soma;
        }
        Console.WriteLine("\nForça Total das regioões");
        for (int i = 0; i < linha; i++)
        {
            Console.WriteLine($"regiao {i + 1}: {regiao[i]} tropas");
        }
   


    }
    }




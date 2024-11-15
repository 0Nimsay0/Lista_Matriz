using System;
using Biblioteca_Matriz;

class exercicio4
{
    static void diagonalPrincipal(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (i == j)
                {
                    Console.Write($"{matriz[i, j]} || ");
                }
            }
        }
    }
    static void Main()
    {

        int linha, coluna, resul;

        Console.WriteLine("Digite quantas linhas e colunas vai ter na matriz:");
        linha = int.Parse(Console.ReadLine());
        coluna = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linha, coluna];
        Matriz.gerar(matriz);
        Matriz.mostra(matriz);
        Console.WriteLine();

        diagonalPrincipal(matriz);

        Console.WriteLine("\n");
        Console.ReadKey();

    }
}
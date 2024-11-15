using System;
using Biblioteca_Matriz;

class exercicio5
{
    static void diagonalSecundaria(int[,] matriz)
    {
        int colunas = matriz.GetLength(0);
        for (int i = 0; i < colunas; i++)
        {
            Console.Write($"{matriz[i, colunas - 1 - i]} || ");
        }
    }
    static void Main()
    {

        int linha, coluna;
        Console.WriteLine("Digite quantas linhas e colunas vai ter na matriz:");
        linha = int.Parse(Console.ReadLine());
        coluna = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linha, coluna];
        Matriz.gerar(matriz);
        Matriz.mostra(matriz);
        Console.WriteLine();

        diagonalSecundaria(matriz);

        Console.WriteLine("\n");
        Console.ReadKey();

    }
}
using Biblioteca_Matriz;
using System;


class exercicio11
{
    static int diagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (i == j)
                {
                    // Console.Write($"{matriz[i, j]} || ");
                    soma += matriz[i, j];
                }
            }
        }
        return soma;
    }

    static int diagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        int colunas = matriz.GetLength(0);
        for (int i = 0; i < colunas; i++)
        {
            // Console.Write($"{matriz[i, colunas - 1 - i]} || ");
            soma += matriz[i, colunas - 1 - i];
        }
        return soma;
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

        Console.WriteLine($"Soma diagonal Principal = {diagonalPrincipal(matriz)}");
        Console.WriteLine($"Soma diagonal Secundaria = {diagonalSecundaria(matriz)}");

        if (diagonalSecundaria(matriz) > diagonalPrincipal(matriz))
        {
            Console.WriteLine("O maior tesouro esta na diagonal secundaria, vamos la");
        }
        else
            Console.WriteLine("O maior tesouro esta na diagonal principal, vamos la");
    }
}


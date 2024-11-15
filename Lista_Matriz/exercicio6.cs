using System;
using Biblioteca_Matriz;

class exercicio6
{
    static int[,] somaMatriz(int linha, int coluna, int[,] matriz1, int[,] matriz2)
    {
        int resul;
        int[,] matriz3 = new int[linha, coluna];
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                matriz3[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }
        Matriz.mostra(matriz3);
        return matriz3;

    }
    static void Main()
    {
        int linha1, linha2, coluna1, coluna2;

        Console.WriteLine("Digite quantas linhas e colunas vai ter na primeira matriz:");
        linha1 = int.Parse(Console.ReadLine());
        coluna1 = int.Parse(Console.ReadLine());

        int[,] matriz1 = new int[linha1, coluna1];
        Matriz.gerar(matriz1);
        Matriz.mostra(matriz1);
        Console.WriteLine();

        Console.WriteLine("Digite quantas linhas e colunas vai ter na segunda matriz:");
        linha2 = int.Parse(Console.ReadLine());
        coluna2 = int.Parse(Console.ReadLine());

        int[,] matriz2 = new int[linha2, coluna2];
        Matriz.gerar(matriz2);
        Matriz.mostra(matriz2);
        Console.WriteLine();

        if (linha1 == linha2)
        {
            if (coluna1 == coluna2)
            {
                Console.WriteLine("A soma das matrizes:");
                int[,] resul = new int[linha1, coluna1];
                resul = somaMatriz(linha1, coluna1, matriz1, matriz2);
            }
        }
        else
            Console.WriteLine("As matrizes nao sao de mesma ordem para realizar a soma");


    }
}
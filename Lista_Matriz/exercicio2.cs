using System;
using Biblioteca_Matriz;


class exercicio2
{
    static int menorValor(int linha, int coluna, int[,] Matriz)
    {
        int menor = Matriz[0, 0];
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                if (Matriz[i, j] <= menor)
                {
                    menor = Matriz[i, j];
                }
            }
        }
        return menor;
    }
    static void Main()
    {
        {
            int linha, coluna, resul;
            Console.WriteLine("Digite quantas linhas e colunas deseja na Matriz:");
            linha = int.Parse(Console.ReadLine());
            coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];
            Matriz.leia(matriz);
            resul = menorValor(linha, coluna, matriz);
            Console.WriteLine();
            Matriz.mostra(matriz);
            Console.WriteLine();
            Console.WriteLine($"Menor valor localizado na Matriz: {resul}");
        }
    }
}

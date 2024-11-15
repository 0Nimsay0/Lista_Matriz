using System;
using Biblioteca_Matriz;

class exercicio1
{
    static int maiorValor(int linha, int coluna, int[,] Matriz)
    {
        int maior = 0;
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                if (Matriz[i, j] >= maior)
                {
                    maior = Matriz[i, j];
                }
            }
        }
        return maior;
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
            resul = maiorValor(linha, coluna, matriz);
            Console.WriteLine();
            Matriz.mostra(matriz);
            Console.WriteLine();
            Console.WriteLine($"Maior Valor localizado na Matriz: {resul}");
        }
    }
}

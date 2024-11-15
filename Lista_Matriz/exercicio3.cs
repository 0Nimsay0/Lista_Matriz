using System;
using Biblioteca_Matriz;

class exercicio3
{
    static int comparaNum(int num, int[,] matriz)
    {
        int qtd = 0;
        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1); 
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                if (matriz[i, j] == num)
                {
                    qtd++;
                }
            }
        }
        return qtd;
    }
    static void Main()
    {
        int linha, coluna, resul, num;

        Console.WriteLine("Digite quantas linhas e colunas vai ter na matriz:");
        linha = int.Parse(Console.ReadLine());
        coluna = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual numero quer procurar na matriz?");
        num = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linha, coluna];
        Matriz.gerar(matriz);
        Matriz.mostra(matriz);

        resul = comparaNum(num, matriz);

        Console.WriteLine($"\nO num {num} aparece {resul}x na matriz");
    }
}
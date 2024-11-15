using System;
using Biblioteca_Matriz;
class exercicio7
{
    static int[,] somaMatriz(int[,] matriz1, int[,] matriz2)
    {
        int linha = matriz1.GetLength(0);
        int coluna = matriz1.GetLength(1);
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
    static int[,] subMatriz(int[,] matriz1, int[,] matriz2)
    {
        int linha = matriz1.GetLength(0);
        int coluna = matriz1.GetLength(1);
        int[,] matriz3 = new int[linha, coluna];
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                matriz3[i, j] = matriz1[i, j] - matriz2[i, j];
            }
        }
        Matriz.mostra(matriz3);
        return matriz3;

    }
    static void constante(int constante, int[,] matriz1, int[,] matriz2)
    {
        int linha = matriz1.GetLength(0);
        int coluna = matriz1.GetLength(1);

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                matriz1[i, j] = matriz1[i, j] + constante;
            }
        }
        Matriz.mostra(matriz1);

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                matriz2[i, j] = matriz2[i, j] + constante;
            }
        }
        Console.WriteLine();
        Matriz.mostra(matriz2);


    }
    static void Main()
    {
        int ordem;
        Console.WriteLine("Qual a ordem da matriz?");
        ordem = int.Parse(Console.ReadLine());
        int[,] matriz1 = new int[ordem, ordem];
        int[,] matriz2 = new int[ordem, ordem];

        Biblioteca_Matriz.Matriz.gerar(matriz1);
        Biblioteca_Matriz.Matriz.gerar(matriz2);
        Console.WriteLine();
        Biblioteca_Matriz.Matriz.mostra(matriz1);
        Console.WriteLine();
        Biblioteca_Matriz.Matriz.mostra(matriz2);
        Console.WriteLine();
        Console.WriteLine("** Informe qual operação deseja realizar **");
        Console.WriteLine("1) Soma das Matrizes");
        Console.WriteLine("2) Subtração das Matrizes");
        Console.WriteLine("3) Adicionar uma constante na matriz");
        int res = int.Parse(Console.ReadLine());

        switch (res)
        {
            case 1:
                Console.WriteLine("\nSoma das Matrizes");
                somaMatriz(matriz1, matriz2);
                break;

            case 2:
                Console.WriteLine("\nSubtração das matrizes");
                subMatriz(matriz1, matriz2);
                break;

            case 3:
                Console.WriteLine("\n Informe o valor da constante");
                int cons = int.Parse(Console.ReadLine());
                constante(cons, matriz1, matriz2);
                break;

        }

        
        Console.WriteLine();
        

    }
}
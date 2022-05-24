//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// ??????????????
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк o: ");
int o = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов p: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
int[,] array1 = new int[o, p];

FillArray(array);
PrintArray(array);
Console.WriteLine();
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
int[,] outputMatrix = ProductMatrix(array, array1);
PrintArray(outputMatrix);

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($" {matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1, 11);
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
    {
        return matrix1;
    }

    int[,] outputMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {
                outputMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return outputMatrix;
}
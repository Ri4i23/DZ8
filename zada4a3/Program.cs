//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int n1, n2;
int[,] Array;

Console.Write("Введите количество строк в матрице: ");
n1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
n2 = int.Parse(Console.ReadLine());
Array = new int[n1, n2];
Random rnd = new Random();

for (int i = 0; i < n1; i++)
    for (int j = 0; j < n2; j++)
        Array[i, j] = rnd.Next(-0, 10 + 1);

for (int i = 0; i < n1; i++, Console.WriteLine())
    for (int j = 0; j < n2; j++)
        Console.Write(Array[i, j] + "\t");
int minRowSum = int.MaxValue, indexMinRow = 0;

for (int i = 0; i < n1; i++)
{
    int rowSum = 0;
    for (int j = 0; j < n2; j++)
        rowSum += Array[i, j];

    if (rowSum < minRowSum)
    {
        minRowSum = rowSum;
        indexMinRow = i;
    }
}
Console.WriteLine("Строка с минимальной суммой элементов");
for (int j = 0; j < n2; j++)
    Console.Write(Array[indexMinRow, j] + "\t");
/*Заполните спирально массив 4 на 4.

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/

int s = 4;
int[,] snakeArray = new int[s, s];
int tempNumber = 1;
int i = 0;
int j = 0;

while (tempNumber <= s * s)
{
    snakeArray[i, j] = tempNumber;
    tempNumber++;
    if (i <= j + 1 && i + j < s - 1)
    {
        j++;
    }
    else if (i < j && i + j >= s - 1)
    {
        i++;
    }
    else if (i >= j && i + j > s - 1)
    {
        j--;
    }
    else
    {
        i--;
    }
}
PrintArray(snakeArray);

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

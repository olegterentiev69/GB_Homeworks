//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int[,] matrix = new int[5, 6];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-5, 11);
        }
    }
}
// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}

int minSum = 1;
int sum = SumLine(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    if (sum > SumLine(matrix, i))
    {
        sum = SumLine(matrix, i);
        minSum = i + 1;
    }
}
Console.WriteLine("-------------------------------------------");
Console.WriteLine($"Строка c наименьшей суммой элементов: № {minSum}");
Console.WriteLine("-------------------------------------------");
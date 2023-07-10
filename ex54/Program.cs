//Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int[,] matrix = new int[5, 6];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("-------------------------------------------");
PrintArray(matrix);
Console.WriteLine("-------------------------------------------");
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
            matr[i, j] = new Random().Next(-5, 11);//[1; 10)
        }
    }
}
//
void uporyadok(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
{
    if (array[i, k] < array[i, k + 1])
    {
        int temp = array[i, k + 1];
        array[i, k + 1] = array[i, k];
        array[i, k] = temp;
    }
}
        }
        }
        }
uporyadok(matrix);
Console.WriteLine("Отсортированный массив: ->");
Console.WriteLine("-------------------------------------------");
PrintArray(matrix);
Console.WriteLine("-------------------------------------------");

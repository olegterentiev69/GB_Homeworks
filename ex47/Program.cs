//Задача 47: Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.


Console.Write("Введите количество строк -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---------------------------");
double[,] numbers = new double[m, n];
ArrayRandomNumbers(numbers);
PrintArray(numbers);


void ArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    
        Console.WriteLine("");
    }
}
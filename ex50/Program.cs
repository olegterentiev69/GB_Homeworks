//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("---------------------------");
int[,] numbers = new int[10, 10];
ArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine("---------------------------");

if (m < 1 || n < 1)
{ Console.WriteLine("Позиции строк или столбцов не могут быть меньше 1! "); }
else
if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {m} строки и {n} столбца равно -> {numbers[m - 1, n - 1]}");
}

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintArray(int[,] array)
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

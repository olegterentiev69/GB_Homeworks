//Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите натуральное число больше 1: -> ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-------------------------------------------");
GetNum(number);
void GetNum(int number)
{
    if (number <= 0) return;
    Console.Write("{0,3}", number);
    GetNum(number - 1);
}


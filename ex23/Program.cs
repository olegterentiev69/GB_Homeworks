// Программа на вход получает число и выдаёт таблицу кубов чисел от 1 до этого числа.

Console.Clear();
Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine());
int b = 0;

Console.Write($"{a} -->");
while(b != a-1)
{
    b++;
Console.Write($" {b*b*b}, ");
}
b++;
Console.Write($" {b*b*b}. ");

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное значение массива: ", "Ошибка ввода!");

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

int sumNotEven(int[] array)
{
int sum = 0;
int i = 1;
while (i < array.Length)
{
sum = sum + array[i];
i = i + 2;
}
return sum;
}

Console.Write($"Cумма элементов, стоящих на нечётных позициях в массиве равна:-> {sumNotEven(array)}");

// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
//

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
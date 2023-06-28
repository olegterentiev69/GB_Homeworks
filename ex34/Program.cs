Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");

int[] array = GetArray(size, 100, 999);
Console.WriteLine(String.Join(" ", array));

int quantity(int[] array)
{
int quantity = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
quantity = quantity + 1;
}
return quantity;
}

Console.Write($"Количество чётных чисел в массиве: {quantity(array)}");


//////////////////////////////////////////////////////////////////////////////////
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




Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int minValue = GetNumberFromUser("Введите минимальное значение массива: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное значение массива: ", "Ошибка ввода!");

double[] array = new double[a];

void mas(int a)
{
    Random rand = new Random();

    for (int i = 0; i < a; i++)
    {
        array[i] = (maxValue-1) - rand.Next(minValue) + rand.NextDouble(); 
        //rand.NextDouble(); цифры после запятой
        Console.Write($"{array[i]:f2}; ");
    }

}

double diff(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
        i = i + 1;
    }
    return max - min;
}
mas(a);

Console.Write($"Разница между максимальным и минимальным элементов массива: -> {diff(array):f2}");

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
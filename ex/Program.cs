// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь. Задача №41


Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[m];

void mas(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int kol(int[] Array)
{
    int i = 0;
    int sum = 0;
    while (i < Array.Length)
    {
        if (Array[i] > 0)
            sum = sum + 1;
        i = i + 1;
    }
    return sum;
}
mas(m);
Console.Write($" Чисел больше нуля: {kol(Array)}");








//Console.Clear();

//int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");

//int GetNumberFromUser(string message, string errorMessage)
//{
// while (true)
//{
//  Console.Write(message);
// bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
// if (isCorrect)
//   return userNumber;
// Console.WriteLine(errorMessage);
//  }
//}
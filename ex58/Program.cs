//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
Console.Clear();
Console.WriteLine("Введите разиерность матриц и диапазон их значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон чисел матриц: от 1 до ");
Console.WriteLine("-------------------------------------------");
int[,] firstMartrix = new int[m, n];
FillArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);
Console.WriteLine("-------------------------------------------");
int[,] secomdMartrix = new int[n, p];
FillArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);
Console.WriteLine("-------------------------------------------");
int[,] resultMatrix = new int[m,p];

CompositionMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);
Console.WriteLine("-------------------------------------------");

void CompositionMatrix
(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
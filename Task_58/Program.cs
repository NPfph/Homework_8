// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine($"Найдите произведение двух матриц");
int m = InputNumbs("Введите число строк 1-й матрицы: ");
int n = InputNumbs("Введите число столбцов 1-й матрицы и строк 2-й: ");
int p = InputNumbs("Введите число столбцов 2-й матрицы: ");
int range = InputNumbs("Введите диапазон случайных чисел в матрицах от 1 до N: ");

int[,] firstMat = new int[m, n];
CreateArray(firstMat);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMat);

int[,] secondMat = new int[n, p];
CreateArray(secondMat);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secondMat);

int[,] resultMat = new int[m,p];

MultiplyMat(firstMat, secondMat, resultMat);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMat);

int InputNumbs(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMat(int[,] firstMat, int[,] secondMat, int[,] resultMat)
{
  for (int i = 0; i < resultMat.GetLength(0); i++)
  {
    for (int j = 0; j < resultMat.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMat.GetLength(1); k++)
      {
        sum += firstMat[i,k] * secondMat[k,j];
      }
      resultMat[i,j] = sum;
    }
  }
}


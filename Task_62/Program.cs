// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int n = 4;
int[,] sqareM = new int[n, n];

int t = InputNumbs("Введите число для заполнения массива: ");

int i = 0;
int j = 0;

int InputNumbs(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

while (t <= sqareM.GetLength(0) * sqareM.GetLength(1))
{
    sqareM[i, j] = t;
        t++;
    if (i <= j + 1 && i + j < sqareM.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareM.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareM.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(sqareM);

void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
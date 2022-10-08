//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                matrix[i, j] = new Random().Next(1, 11);
              
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}
void FindAverage(int[,] matrix)
     {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            double result = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                result += matrix[j, i];  
            }
        average = result/matrix.GetLength(0); 
        Console.WriteLine($"Среднее арифметическое столбца {i+1} равно: {average}");
        }
    }

Console.Write("Введите кол-во строк исходного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов исходного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
FindAverage(matrix);


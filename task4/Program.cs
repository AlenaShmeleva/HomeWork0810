// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.
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

void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0)/2; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i,j];
            matrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
            matrix[matrix.GetLength(0) - i - 1, j] = temp;
        }
    } 
}

Console.Write("Введите кол-во строк исходного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов исходного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
Console.WriteLine($"Исходная матрица: ");
PrintMatrix(matrix);
ReleaseMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Транспортированная матрица: ");
PrintMatrix(matrix);

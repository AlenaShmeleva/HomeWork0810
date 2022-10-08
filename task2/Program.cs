// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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
string FindElement(int[,] matrix, int a, int b)
     {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == a - 1 && j == b - 1)
                return Convert.ToString(matrix[i, j]);
                  
            }
        }
    return "не существует";
    }

Console.Write("Введите кол-во строк исходного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов исходного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки элемента, который требуется найти: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента, который требуется найти: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine($"Искомый элемент массива: {FindElement(matrix, a, b)}");

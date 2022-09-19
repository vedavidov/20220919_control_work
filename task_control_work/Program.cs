// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

int[,] matrix = new int[3, 3];

FillArray(matrix);
Console.WriteLine("Исходный массив: ");
PrintArray(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] < matrix[i, k + 1])
            {
                int number = 0;
                number = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = number;
            }
        }
    }
}
Console.WriteLine("Новый массив: ");
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 1000); // [1, 10)
        }
    }
}
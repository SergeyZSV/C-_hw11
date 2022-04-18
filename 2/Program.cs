// Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10. Найдите количество элементов, значение которых больше 5, и их сумму.

Random rnd = new Random();
int rows = rnd.Next(2, 10);
int cols = rnd.Next(2, 10);
int[,] matrix = new int[rows, cols];

Console.WriteLine();
FillMatrix();
Console.WriteLine($"Дан массив {rows} на {cols}: ");
PrintMatrix();
Console.WriteLine();
AmountAndSum();
Console.WriteLine();

void FillMatrix()
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
}

void PrintMatrix()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

void AmountAndSum()
{
    int amount = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] > 5)
            {
                sum += matrix[i,j];
                amount += 1;
            }
        }
    }
    Console.WriteLine($"Количество элементов, значение которых больше 5: {amount}.");
    Console.WriteLine($"Сумма элементов, значение которых больше 5: {sum}.");
}
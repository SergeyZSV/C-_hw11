// Задача 1. На вход подаются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].

int n = 1;
int m = 10;
int[] array = new int[m - n];

FillArray();

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

void FillArray()
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(n, m + 1);
    }
}
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int collumns = int.Parse(Console.ReadLine());

double[,] array = new double[rows, collumns];
FillArrayRandom(rows, collumns);
Console.WriteLine("Массив со случайными вещественными числами:");
PrintArray(array);

// Заполнение массива случайными вещественными числами
double[,] FillArrayRandom(double rows, double collumns)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(100)) / 10;
        }
    }
    return array;
}

// Вывод массива в консоль
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

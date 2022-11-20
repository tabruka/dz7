// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[3, 5];

FillArrayRandom(array);
Console.WriteLine("Массив:");
PrintArray(array);

Console.WriteLine(ArevageArrayCollumns(array));

// Поиск среднего арефметического
string ArevageArrayCollumns(int[,] array)
{
    string rezult = "Среднее арифметическое столбцов: ";
    double averageCollumns = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            averageCollumns = averageCollumns + array[j, i];
        }
        averageCollumns = averageCollumns / array.GetLength(0);
        rezult = rezult + Convert.ToString(averageCollumns) + " ";
        averageCollumns = 0;
    }
    return rezult;
}

// Заполнение массива случайными числами
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

// Вывод массива в консоль
void PrintArray(int[,] array)
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
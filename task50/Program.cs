// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите номер строки");
int rowsPos = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int collumnsPos = int.Parse(Console.ReadLine());
int[,] array = new int[3, 4];

FillArrayRandom(array);
Console.WriteLine("Массив со случайными числами:");
PrintArray(array);

// Условаие для поиска позиции элемента
if (rowsPos > array.GetLength(0) || collumnsPos > array.GetLength(1))
{
    Console.WriteLine("Элемент с этими позициями отсутствует");
}
else
{
    Console.WriteLine($"Элемент на позиции {rowsPos} строки и {collumnsPos} столбца имеет значение: {array[rowsPos-1,collumnsPos-1]}");
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

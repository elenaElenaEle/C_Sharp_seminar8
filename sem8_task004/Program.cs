// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // 0 - строка ГЕНЕРАЦИЯ
    {
        for (int j = 0; j < arr.GetLength(1); j++) // 1 - столбец
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)  // ПЕЧАТЬ
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write(arr1[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 4, n = 5;
int[,] mass = new int[m, n];
FillArray(mass);
Console.WriteLine("Исходный массив: ");
Print(mass);
Console.WriteLine();

int min = mass[0, 0];
int iMin = 0;
int jMin = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        if (mass[i, j] < min)
        {
            min = mass[i, j];
            iMin = i;
            jMin = j;
        }
    }
}
Console.WriteLine("Минимальный элемент: " + min);
Console.Write($"Индексы минимального значения: i = {iMin} и j = {jMin}");

int[,] newMass = new int[mass.GetLength(0) - 1, mass.GetLength(1) - 1];


for (int i = 0, i1 = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0, j1 = 0; j < mass.GetLength(1); j++)
    {
        if (i != iMin && j != jMin)
        {
            newMass[i1, j1] = mass[i, j];
            j1++;
        }
    }
    if (i != iMin)
    {
        i1++;
    }
}
Console.WriteLine();
Print(newMass);
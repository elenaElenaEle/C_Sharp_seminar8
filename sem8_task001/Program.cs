// 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void FillArray(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++) // 0 - столбцы ГЕНЕРАЦИЯ
    {
        for (int j = 0; j < arr2.GetLength(1); j++) // 1 - строки
        {
            arr2[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)  // ПЕЧАТЬ
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 4, n = 6; // m - сторка, n - столбец

int[,] mass = new int[m, n];
FillArray(mass);
Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        int temp = mass[i, j];
        mass[i, j] = mass[mass.GetLength(0) - 1, j];
        mass[mass.GetLength(0) - 1, j] = temp;
    }
    break;
}

Print(mass);


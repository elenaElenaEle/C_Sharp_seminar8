// 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void Sort(int[,] arr2)
{
    int temp;

    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1) - 1; j++)
        {
            int maxPosJ = j;
            for (int k = j + 1; k < arr2.GetLength(1); k++)
            {
                if (arr2[i, k] > arr2[i, maxPosJ])
                {
                    maxPosJ = k;
                }
            }
            temp = arr2[i, j];
            arr2[i, j] = arr2[i, maxPosJ];
            arr2[i, maxPosJ] = temp;
        }
    }
}

int m = 4, n = 5;
int[,] mass = new int[m, n];
FillArray(mass);
Console.WriteLine("Несортированный массив: ");
Print(mass);
Console.WriteLine();
Sort(mass);
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными по убыванию элементами в каждой строке: ");
Print(mass);



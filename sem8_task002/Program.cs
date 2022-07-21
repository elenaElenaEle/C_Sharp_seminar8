// 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void FillArray(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++) // 0 - строка ГЕНЕРАЦИЯ
    {
        for (int j = 0; j < arr2.GetLength(1); j++) // 1 - столбец
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

int m = 4, n = 4; // m - сторка, n - столбец

int[,] mass = new int[m, n];
FillArray(mass);
//mass[0,4] = 99;
Print(mass);
Console.WriteLine();

if (m != n)
{
    Console.Write("Для данного масива невозможно поменять местами строки и столбцы ");
}
else
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = i; j < mass.GetLength(1); j++)
        {
            int temp = mass[i, j];
            mass[i, j] = mass[j, i];
            mass[j, i] = temp;
        }
    }
}

Print(mass);
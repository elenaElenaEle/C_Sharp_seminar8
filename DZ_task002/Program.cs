//56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void FindRowSum(int[,] arr2, int[] sumRow)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            sumRow[i] += arr2[i, j];
        }
        Console.WriteLine("Сумма элементов строки " + i + " = " + sumRow[i]);
    }
}
void FindMin(int[] arr3)
{
    int idx = 0; //индекс минимального элемента
    int min = arr3[idx];
    for (int i = 0; i < arr3.Length; i++)
    {
        if (arr3[i] < min)
        {
            min = arr3[i];
            idx = i;
        }
    }
    Console.Write("Наименьшая сумма элементов: " + min + " в строке № " + idx);
}

int m = 4, n = 5;
int[,] mass = new int[m, n];
int[] array = new int[mass.GetLength(0)];
FillArray(mass);
Print(mass);
FindRowSum(mass, array);
FindMin(array);
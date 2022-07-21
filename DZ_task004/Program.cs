// 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void FillArray(int[,,] arr2)
{
    int count = 1;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr2.GetLength(2); k++)
            {
                arr2[i, j, k] = 10 + count;
                count++;
            }
        }
    }
}

void Print(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)  
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"({i},{j},{k})= " + arr[i, j, k] + " ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] mass = new int[4, 4, 4];

FillArray(mass);
Print(mass);
Console.WriteLine();
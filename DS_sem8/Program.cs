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

********************************************************************************************************************************************

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

******************************************************************************************************************************************

// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

void Proizv(int[,] arrA, int[,] arrB, int[,] arrC)
{
    for (int iA = 0; iA < arrA.GetLength(0); iA++)
    {
        for (int jB = 0; jB < arrB.GetLength(1); jB++)
        {
            int temp = 0;
            for (int jA = 0; jA < arrA.GetLength(1); jA++)
            //int iB = jA;
            //int jC = jB;
            //int iC = iA;
            {
                temp += arrA[iA, jA] * arrB[jA, jB];
            }
            arrC[iA, jB] = temp;
            Console.Write(arrC[iA, jB] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
int k = 4, l = 5;
int[,] matrA = new int[m, n];
int[,] matrB = new int[k, l];
int[,] matrC = new int[m, l];

FillArray(matrA);
Console.WriteLine("Матрица А: ");
Print(matrA);
Console.WriteLine();

FillArray(matrB);
Console.WriteLine("Матрица B: ");
Print(matrB);
Console.WriteLine();
Console.WriteLine("Матрица C: ");
if (n != k)
{
    Console.WriteLine("Произведение матриц невозможно");
}
else
{
    Proizv(matrA, matrB, matrC);
}

***************************************************************************************************************************************

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

************************************************************************************************************************************

// 62: Заполните спирально массив 4 на 4.
// 1   2   3   4 
// 12  13  14  5
// 11  16  15  6
// 10  9   8   7

void Print(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)  // ПЕЧАТЬ
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int i = 4, j = 4;
int[,] mass = new int[i, j];
int m=0,k=0;
//mass[0,0] = 1;
            int count = 1;
for (i = 0; i < mass.GetLength(0); i++)
{
    for (j = 0; j < mass.GetLength(1); j++)
    {
    
        mass[i, j] = count;
        mass[j, i] = count;
        
        switch (k){
            case 1:
            break;
            case 2:
            break;
            case 3:
        }
        
        /*if (i > 0) mass[i, mass.GetLength(1) - 1] = mass[i - 1, mass.GetLength(1) - 1] + 1;
        if (i == mass.GetLength(0) - 1)
        {
            mass[mass.GetLength(0) - 1, mass.GetLength(1) - 1 - count] = mass[mass.GetLength(0) - 1, mass.GetLength(1) - 1] + 1;
            count++;
        }*/
        count++;
    }
    m=mass.GetLength(1)
}

Print(mass);

***************************************************************************************************************************************

// 62: Заполните спирально массив 4 на 4.
// 1   2   3   4 
// 12  13  14  5
// 11  16  15  6
// 10  9   8   7

void Print(int[,] arr)

{
    for (int i = 0; i < arr.GetLength(0); i++)  // ПЕЧАТЬ
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

int i = 4, j = 4;
int[,] mass = new int[i, j];
mass[0,0] = 1;
int count = 1;
for (i = 0; i < mass.GetLength(0); i++)
{
    for (j = 1; j < mass.GetLength(1); j++)
    {
        mass[i, j] = mass[i, j-1] + 1;
    }
    if (i > 0) mass[i, mass.GetLength(1) - 1] = mass[i - 1, mass.GetLength(1) - 1] + 1;
    if (i == mass.GetLength(0) - 1)
    {
        mass[mass.GetLength(0) - 1, mass.GetLength(1) - 1 - count] = mass[mass.GetLength(0) - 1, mass.GetLength(1) - 1] + 1;
        count++;
    }
    //count++;
}
 ????????????????????????????????????????????????
Print(mass);
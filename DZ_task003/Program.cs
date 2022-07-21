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

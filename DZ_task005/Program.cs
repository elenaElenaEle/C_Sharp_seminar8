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

Print(mass);

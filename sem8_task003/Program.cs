// 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных. 
// Набор данных                          Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }           0 встречается 2 раза
//                                      1 встречается 1 раз
//                                      2 встречается 1 раз
//                                      8 встречается 1 раз
//                                      9 встречается 3 раза
// ---------------------------------------------------------
// 1, 2, 3                              1 встречается 3 раза
// 4, 6, 1                              2 встречается 2 раз
// 2, 1, 6                              3 встречается 1 раз
//                                      4 встречается 1 раз
//                                      6 встречается 2 раза

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

void SerchElement(int[,] arr2, int element)
{
    int count = 0;
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            if (arr2[i, j] == element) 
            {
                count++;
            }
        }
    }
    Console.Write(element + " встречается " + count + " раз.");
    Console.WriteLine();
}

bool ChekArray(int[,] arr3, int idx, int elem)  // для проверки уникальности элемента (т.е. его значение еще не обрабатывали) 
{
    int counter = 0;
    for (int i = 0; i < arr3.GetLength(0); i++)
    {
        for (int j = 0; j < arr3.GetLength(1); j++)
        {
            if (counter == idx) return true;// определяем, новый ли это элемент, или уже встречался. Если мы дошли по порядковому номеру до него самого
                                            // то он не встречался- возвращаем TRUE
            if (arr3[i, j] == elem) return false;    // если нашли такое же значение, то возвращаем False - т.е. мы уже работали с этим значением 
                                                    // и выводили его на экран. Предыдущий IF исключает попадание на самого себя
            counter++;
        } 
    }
    return true;
}

int m = 3, n = 4; 
int[,] mass = new int[m, n];
FillArray(mass);
Print(mass);
Console.WriteLine();

int elemNum = 0;

foreach (int element in mass)
{
    if (ChekArray(mass, elemNum, element)) 
    {
        SerchElement(mass, element);
    }
    elemNum ++;
}

/*Как вариант решения можно использовать сортировку - по трудоемкости не особо отличается от этого*/
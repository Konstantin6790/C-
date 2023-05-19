// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine($"Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");


int m = 3;
int n = 3;
int [,] arr = new int[m, n];
Console.Write("Введите значение: ");
int number = Convert.ToInt32 (Console.ReadLine());
FillArray (arr);
FindElementArray (arr, number);

void FillArray (int [,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(0, 10);
            Console.Write(arr [i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindElementArray (int [,] findElement, int userNumber)
{
    bool find = false;  
    for (int i = 0; i < findElement.GetLength(0); i++)
    {
        for (int j = 0; j < findElement.GetLength(1); j++)
        {
            if (findElement [i, j] == userNumber)
            Console.WriteLine("Ваше число находится по координатам" + i + " " + j);
            find = true;
        }
    }
    if (!find)
    Console.WriteLine("Такого значения нет");
    
}

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.WriteLine($"\n\nЗадача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

int m = 3;
int n = 4;
int [,] array = new int[m, n];

FillArray (array);
PrintArray (array);
Average (array);

void FillArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(1, 9);
        }
    }
}


void PrintArray (int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($"{ar[i, j],1} ");
        }
        Console.WriteLine("");
    }
}
void Average(int[,] ar)
{
    
    for (int i = 0; i < ar.GetLength(1); i++)
    {
        double summ = 0;
        for (int j = 0; j < ar.GetLength(0); j++)
        {
            summ += ar [j, i];
        }
        System.Console.WriteLine($"Среднее арифметическое столбца №{i+1} = {summ / ar.GetLength(0)}");
    }
}
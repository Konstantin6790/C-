void FillArray(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
    numbers[i] = rnd.Next(1, 10);
    }
}
//распечать массив
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
}
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
void Task0()
{
    int size = 10;
    int [] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
}

Task0();
    
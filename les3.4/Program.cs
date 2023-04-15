// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
void Kvadrat(int n)
{
  for (int i = 1; i <= n; i++)
  {
    System.Console.Write(" "+Math.Pow(i, 2));
  }
}
Kvadrat(n);

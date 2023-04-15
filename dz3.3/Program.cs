//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число:");
int n = int.Parse(Console.ReadLine());
void Kub(int n)
{
  for (int i = 1; i <= n; i++)
  {
    System.Console.Write(" " + Math.Pow(i, 3));
  }
}
Kub(n);
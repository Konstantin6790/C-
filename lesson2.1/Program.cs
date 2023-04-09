// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int Length = number.ToString().Length;

if (Length == 3) {
		int result = (number / 10) % 10;
		Console.WriteLine($"Вторая цифра это {result}");
} 
else 
{
		Console.WriteLine("Введено не трехзначное число!!!");
}

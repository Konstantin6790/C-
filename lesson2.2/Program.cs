// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int Length = number.ToString().Length;
if (Length >= 3) {
	while (number > 999)
	{
		number = number / 10;
	}
	int result = number % 10;
	Console.WriteLine("Третья цифра числа " + result);
} else {
	Console.WriteLine("В введенном числе нет третьей цифры");
}
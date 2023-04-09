// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели ввиде числа от 1 до 7:");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) {
	if (Day >= 6) {
		Console.WriteLine("ДА, это выходной:)");
	} else {
		Console.WriteLine("НЕТ, это рабочий день:(");
	}
} else {
	Console.WriteLine("Такого дня недели нет.Дней недели лишь 7!!!");
}
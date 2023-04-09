Console.WriteLine("Input number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max) max = number2;

Console.WriteLine($"максимальное значение = {max}");
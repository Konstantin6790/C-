//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Укажите x1:");
double x1 = double.Parse (Console.ReadLine());
Console.Write("Укажите y1:");
double y1 = double.Parse (Console.ReadLine());
Console.Write("Укажите z1:");
double z1 = double.Parse (Console.ReadLine());
Console.Write("Укажите x2:");
double x2 = double.Parse (Console.ReadLine());
Console.Write("Укажите y2:");
double y2 = double.Parse (Console.ReadLine());
Console.Write("Укажите z2:");
double z2 = double.Parse (Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Результат:"+Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2)));
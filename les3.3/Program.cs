//апишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Console.WriteLine("Укажите x1:");
double x1 = double.Parse (Console.ReadLine());
Console.WriteLine("Укажите y1:");
double y1 = double.Parse (Console.ReadLine());

Console.WriteLine("Укажите x2:");
double x2 = double.Parse (Console.ReadLine());
Console.WriteLine("Укажите y2:");
double y2 = double.Parse (Console.ReadLine());

System.Console.WriteLine();
Console.WriteLine("Результат:"+Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2)));
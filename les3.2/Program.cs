// По номеру четверти возвращает какие координаты будут
Console.WriteLine("Укажите четверть:");
int x = int.Parse (Console.ReadLine());

void Chetvert(int a)
{
    switch (a)
    {
	case 1: System.Console.WriteLine("x > 0, y > 0"); break;
    case 2: System.Console.WriteLine("x < 0, y > 0"); break;
    case 3: System.Console.WriteLine("x < 0, y < 0"); break;
    case 4: System.Console.WriteLine("x < 0, y > 0"); break;
    default: System.Console.WriteLine("x = 0 и/или y = 0"); break;
    }
}
Chetvert(x);
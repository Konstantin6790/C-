﻿Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
 void palindrom()
{
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;
    int nul = number / 10000;
        
        if (nul < 1 || nul > 9){
        Console.WriteLine("Введено не пятизначное число");
        }
        else if  (num1 == rev2 && num2 == rev1){
        Console.WriteLine(number + "-> да");
        }
        else{
        Console.WriteLine(number + "-> нет");
        }
}
palindrom();
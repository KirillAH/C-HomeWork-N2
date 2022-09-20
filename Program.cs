//Задача 10 .Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5, 782 -> 8, 918 -> 1
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
num = num / 10 % 10;
Console.WriteLine($"Вторая цифра вашего числа {num}");



//Задача 13. Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает,что третьей цифры нет. 
//645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numStr = Convert.ToString(num);
int num3 = numStr.Length;
if (num3 > 2) 
{
    Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
}
else
 {
    Console.WriteLine("третьей цифры нет");
 }
 
 
// Задача 15. Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 | num <= 7)
    {
    if (num == 6 | num == 7) Console.WriteLine("Сегодня выходной");
else Console.WriteLine("Сегодня рабочий день");
    }   
else 
{
    Console.WriteLine("Не верное число");
}
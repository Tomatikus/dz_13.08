/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}


/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
System.Console.Write("Введите координаты А: ");
double A = Convert.ToInt32(Console.ReadLine ());
double A1 = Convert.ToInt32(Console.ReadLine ());
double A2 = Convert.ToInt32(Console.ReadLine ());
System.Console.Write("Введите координаты B: ");
double B = Convert.ToInt32(Console.ReadLine ());
double B1 = Convert.ToInt32(Console.ReadLine ());
double B2 = Convert.ToInt32(Console.ReadLine ());

double result = Math.Sqrt((Math.Pow((B-A),2))+(Math.Pow((B1-A1),2))+(Math.Pow((B2-A2),2)));
Console.WriteLine($"Расстояние -> {Math.Round(result,2)}");
*/


/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
Console.WriteLine("Введите число: ");
double N = Convert.ToInt32(Console.ReadLine());
int cube = 1;
while (cube <= N)
{
    System.Console.WriteLine($"Кубы чисел от 1 до {N} - {Math.Pow(cube,3)} ");
    qube++;
}
*/
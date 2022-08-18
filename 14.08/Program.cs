/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

/*
Console.WriteLine("Введите число и степень в которю надо возвести: ");
double A = Convert.ToInt32(Console.ReadLine());
double B = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(A, B);

Console.WriteLine($"Число {A} в степени {B} будет равно - {result}");
*/


/*
Задача 27: Напишите программу, которая принимает на вход число и
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (N > 0)
{
    sum = sum + N %10;
    N /= 10;
}
Console.WriteLine($"Сумма всех чисел = {sum}");


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

/*
int [] GetArray(int size)
{
    int [] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result [i] = new Random().Next(9);
    }
    return result;
}

int [] array = GetArray(8);
Console.WriteLine($"Результат: [{string.Join(", ", array)} ]");
*/
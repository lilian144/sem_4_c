//  Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

int Result(int number, int degree)
{
    int res = number;
    for(int i = 1; i < degree; i++)
    {
        res = res * number;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа: ");
int degree = Convert.ToInt32(Console.ReadLine());

int res = Result(number, degree);
Console.WriteLine(res);
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum(int number)
{
    int count = Convert.ToString(number).Length;
    int res = 0;
    int advance = 0;
    for(int i = 0; i <= count; i++)
    {
        advance = number - number % 10;
        res = res + (number - advance);
        number = number / 10;
    }
    return res;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int res = SumNum(number);
Console.WriteLine(res);

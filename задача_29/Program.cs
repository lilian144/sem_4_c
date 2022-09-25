//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//  Данные вводятся с консоли пользователем

int[] mas = new int[8];

Console.WriteLine("Введите массив чисел:");
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write("Введите значение массива [" + i + "]: ");
        int numbermas = int.Parse(Console.ReadLine());
        mas[i] = numbermas;
    }
    Console.Write("Массив: ");
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write(mas[i] + "; ");
    }

    
// Console.Write("Заполните массив через пробел: ");
// int[] arrayFilling = Console.ReadLine().Split().Select(int.Parse).ToArray();
//     for (int i = 0; i < arrayFilling.Length ; i++)
//     {
//         Console.Write( $"{arrayFilling[i] + " "}");
//     }


// void Main(string[] args)
// {
//     int[] array = new int[8];

//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write("Введите массив чисел:");
//         array[i] = int.Parse(Console.ReadLine());
//     }

//     Console.WriteLine("[");

//     for(i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine(array[i]);
//     }
//     Console.WriteLine("]");
// }
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int gcd = FindGCD(number1, number2);

        // Виведення результату
        Console.WriteLine($"Наибольший общий делитель для чисел {number1} и {number2}: {gcd}");
    }

    // Метод для знаходження НСД за алгоритмом Евкліда
    static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
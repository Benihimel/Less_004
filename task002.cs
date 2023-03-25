// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
        num = number % 10;
        sum = sum + num;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine($"Sum digit of {number} is {SumNum(number)}");


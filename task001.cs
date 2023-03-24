// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int DegreeNumA(int A)
{
    int NumA = 1;
    for (int i = 1; i <= B; i++)
    {
        NumA = NumA * A;
    }
    return NumA;
}
Console.WriteLine($"The number {A} to the power of {B} is: {DegreeNumA(A)}");
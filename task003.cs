// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int N = 8;
int[] Array(int x)
{
    int[] arr = new int[x];
    Random rand = new Random();
    for (int i = 0; i < x; i++)
    {
        arr[i] = rand.Next(-1000,1000);
    }
    return arr;
}

void PrintArray(int[] list)
{
    // int[]PrintList = Array();
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]} ");
    }
}
PrintArray(Array(N));
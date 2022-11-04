// I. Реализовать следующие функции для работы с массивами:
// 5. Поиск индекса заданного элемента в массиве, если такого элемента в массиве нет то возвращать -1
Console.Clear();
void FillArray(int[] arr, int min, int max)    
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(min, max);
}


void PrintArray(int[] arr)                     
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}
Console.WriteLine("Введите количество элементов массива:");

int NumFind(int[] arr, int n)                   
{
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == n)
            return i;

    return -1;
}
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[size];
Console.WriteLine("Введите искомое число: ");
int n = int.Parse(Console.ReadLine() ?? "0");

FillArray(arr, 1, 5);
PrintArray(arr);
int x = NumFind(arr, n);
if (x == -1)
    Console.WriteLine($"Искомый элемент не найден; {x} ");
else
{
    Console.Write($"Искомый элемент находится на позиции: {x + 1} ");
}

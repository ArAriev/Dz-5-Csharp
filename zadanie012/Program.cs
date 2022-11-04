// I. Реализовать следующие функции для работы с массивами:
// 12. Подсчёт количества положительных элементов в массиве
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
int NegativeCount(int[] arr)                   
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[size];
FillArray(arr, -20, 20);
PrintArray(arr);
int x = NegativeCount(arr);
Console.WriteLine($"Количество положительных элементов в массиве равно: {x} ");

